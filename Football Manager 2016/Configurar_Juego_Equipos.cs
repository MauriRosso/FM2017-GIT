using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Football_Manager_2016
{
    public partial class Configurar_Juego_Equipos : Form
    {
        public Configurar_Juego_Equipos()
        {
            InitializeComponent();
        }
        public void GuardarArchivosEquipos()
        {
            string ArchivoEquipos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosEquipos.json";

            using (StreamWriter file = new StreamWriter(ArchivoEquipos, false))
            {
                string Salida = JsonConvert.SerializeObject(Equ.ListaEquipos);
                file.Write(Salida);
            }
        }
        public void CargarArchivosEquipos()
        {
            string LeerEquipos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosEquipos.json";

            using (StreamReader Entrada = new StreamReader(LeerEquipos))
            {
                string contenido = Entrada.ReadToEnd();

                Equ.ListaEquipos = JsonConvert.DeserializeObject<List<PropiedadesEquipos>>(contenido);
            }
        }
        Equipos Equ = new Equipos();

        private void btnCfgCargarEquipo_Click(object sender, EventArgs e)
        {
            PropiedadesEquipos Pro = new PropiedadesEquipos();
            if (cbxCfgSeleccionEquipo.SelectedIndex > -1 && cbxCfgDivisionEquipo.SelectedIndex > -1 && txtCfgNombreEstadio.Text != "" && ntxtCfgCapacidadEstadio.Text != "" && ntxtCfgPresupuesto.Text != "")
            {
                int Enc = 0;
                foreach (var item in Equ.ListaEquipos)
                {
                    if (cbxCfgSeleccionEquipo.SelectedItem.ToString() == item.Nombre)
                    {
                        MessageBox.Show("El equipo que desea cargar ya se encuentra cargado.", "Cargar equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enc = 1;
                        break;
                    }
                }
                if (Enc == 0) //Si el equipo no esta cargado..
                {
                    Pro.Nombre = cbxCfgSeleccionEquipo.Text;
                    Pro.Division = cbxCfgDivisionEquipo.Text;
                    Pro.NombreEstadio = txtCfgNombreEstadio.Text;
                    Pro.CapacidadEstadio = Convert.ToInt32(ntxtCfgCapacidadEstadio.Text);
                    Pro.Presupuesto = Convert.ToInt32(ntxtCfgPresupuesto.Text);
                    Pro.ConfianzaDirigentes = 100;
                    Pro.ConfianzaHinchada = 100;
                    Equ.ListaEquipos.Add(Pro);
                    GuardarArchivosEquipos();
                    MessageBox.Show("¡Equipo cargado exitosamente!", "Cargar equipo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxCfgSeleccionEquipo.Text = "";
                    cbxCfgDivisionEquipo.Text = "";
                    txtCfgNombreEstadio.Text = "";
                    ntxtCfgCapacidadEstadio.Text = "";
                    ntxtCfgPresupuesto.Text = "";
                    CargarGrillaEquipos();
                }
            }
            else
            {
                MessageBox.Show("¡Campos incompletos!", "Cargar equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Configurar_Juego_Equipos_Load(object sender, EventArgs e)
        {
            CargarArchivosEquipos();
            CargarGrillaEquipos();           
        }

        private void CargarGrillaEquipos()
        {
            GrillaEquipos.Rows.Clear();
            GrillaEquipos.RowHeadersVisible = false;
            int F = 0;
            foreach (var item in Equ.ListaEquipos)
            {
                F = GrillaEquipos.Rows.Add();

                GrillaEquipos.Rows[F].Cells[0].Value = item.Nombre;
                GrillaEquipos.Rows[F].Cells[1].Value = item.Division;
                GrillaEquipos.Rows[F].Cells[2].Value = item.NombreEstadio;
                GrillaEquipos.Rows[F].Cells[3].Value = item.CapacidadEstadio;
                GrillaEquipos.Rows[F].Cells[4].Value = item.Presupuesto;          
            }
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Configurar_Juego_Equipos_Editar))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                string Team = GrillaEquipos.CurrentRow.Cells[0].Value.ToString();
                string Estadio = GrillaEquipos.CurrentRow.Cells[2].Value.ToString();
                string Capacidad = GrillaEquipos.CurrentRow.Cells[3].Value.ToString();
                string Presupuesto = GrillaEquipos.CurrentRow.Cells[4].Value.ToString();
                Configurar_Juego_Equipos_Editar Config = new Configurar_Juego_Equipos_Editar(Team,Estadio,Capacidad,Presupuesto);
                Config.Show();
            }
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            string EquipoAEliminar = GrillaEquipos.CurrentRow.Cells[0].Value.ToString();
            foreach (var item in Equ.ListaEquipos)
            {
                if (EquipoAEliminar == item.Nombre)
                {
                    Equ.ListaEquipos.Remove(item);
                    break;
                }     
            }
            GuardarArchivosEquipos();
            ActualizarTabla();
        }
        private void ActualizarTabla()
        {
            GrillaEquipos.Rows.Clear();
            CargarArchivosEquipos();
            int F = 0;
            foreach (var item in Equ.ListaEquipos)
            {
                F = GrillaEquipos.Rows.Add();

                GrillaEquipos.Rows[F].Cells[0].Value = item.Nombre;
                GrillaEquipos.Rows[F].Cells[1].Value = item.Division;
                GrillaEquipos.Rows[F].Cells[2].Value = item.NombreEstadio;
                GrillaEquipos.Rows[F].Cells[3].Value = item.CapacidadEstadio;
                GrillaEquipos.Rows[F].Cells[4].Value = item.Presupuesto;
            }
        }
        private void btnActualizarGrilla_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
