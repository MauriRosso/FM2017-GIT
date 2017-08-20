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
    public partial class Configurar_Juego_Fixture : Form
    {
        Equipos Equ = new Equipos();
        Partidos Partidos = new Partidos();
        public void CargarArchivosEquipos()
        {
            string LeerListaEquipos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosEquipos.json";

            using (StreamReader Entrada = new StreamReader(LeerListaEquipos))
            {
                string contenido = Entrada.ReadToEnd();

                Equ.ListaEquipos = JsonConvert.DeserializeObject<List<PropiedadesEquipos>>(contenido);
            }
        }
        public void CargarArchivosPartidos()
        {
            string LeerListaPartidos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosPartidos.json";

            using (StreamReader Entrada = new StreamReader(LeerListaPartidos))
            {
                string contenido = Entrada.ReadToEnd();

                Partidos.ListaPartidos = JsonConvert.DeserializeObject<List<Partido>>(contenido);
            }
        }
        public void GuardarArchivosPartidos()
        {
            string ArchivosPartidos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosPartidos.json";

            using (StreamWriter file = new StreamWriter(ArchivosPartidos, false))
            {
                string Salida = JsonConvert.SerializeObject(Partidos.ListaPartidos);
                file.Write(Salida);
            } 
        }
        public Configurar_Juego_Fixture()
        {
            InitializeComponent();
        }

        private void btnCfgCargarPartido_Click(object sender, EventArgs e)
        {
            
            if (cbxCfgSeleccionEquipoLocal.SelectedIndex > -1 && cbxCfgSeleccionEquipoVisitante.SelectedIndex > -1 && cbxCfgJornada.SelectedIndex >-1 && cbxCfgCompetencia.SelectedIndex >-1)
            {
                int enc = 0;
                foreach (var item in Partidos.ListaPartidos)
                {
                    if (cbxCfgSeleccionEquipoLocal.SelectedItem.ToString() == item.EquipoLocal && cbxCfgSeleccionEquipoVisitante.SelectedItem.ToString() == item.EquipoVisitante && Convert.ToDateTime(dtpCfgFechaPartido.Text) == item.FechaPartido)
                    {
                        MessageBox.Show("¡Partido ya cargado!", "Cargar partidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        enc = 1;
                        break;
                    }
                }
                if (enc == 0)
                {
                    Partido Par = new Partido();
                    Par.FechaPartido = Convert.ToDateTime(dtpCfgFechaPartido.Text);
                    Par.EquipoLocal = Convert.ToString(cbxCfgSeleccionEquipoLocal.Text);
                    Par.EquipoVisitante = Convert.ToString(cbxCfgSeleccionEquipoVisitante.Text);
                    Par.Estadio = txtCfgEstadio.Text;
                    Par.Jornada = Convert.ToInt32(cbxCfgJornada.Text);
                    Par.Competencia = cbxCfgCompetencia.Text;
                    Par.Resultado = null;
                    Par.GolesLocal = 0;
                    Par.GolesVisitante = 0;
                    Par.CantidadEspectadores = 0;
                    Par.GananciaEntradas = 0;

                    Partidos.ListaPartidos.Add(Par);
                    Partidos.ListaPartidos = Partidos.ListaPartidos.OrderBy(x => x.FechaPartido).ToList();
                    GuardarArchivosPartidos();
                    MessageBox.Show("¡Partido cargado exitosamente!", "Cargar partidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaPartidos();
                }
            }
        }

        private void Configurar_Juego_Fixture_Load(object sender, EventArgs e)
        {
            CargarArchivosEquipos();
            CargarArchivosPartidos();
            CargarGrillaPartidos();
        }

        private void CargarGrillaPartidos()
        {
            GrillaPartidos.Rows.Clear();
            GrillaPartidos.RowHeadersVisible = false;
            CargarArchivosEquipos();
            CargarArchivosPartidos();
            int F = 0;
            foreach (var item in Partidos.ListaPartidos)
            {
                F = GrillaPartidos.Rows.Add();

                GrillaPartidos.Rows[F].Cells[0].Value = item.FechaPartido.ToShortDateString();
                GrillaPartidos.Rows[F].Cells[1].Value = item.Competencia;
                GrillaPartidos.Rows[F].Cells[2].Value = item.EquipoLocal;
                GrillaPartidos.Rows[F].Cells[3].Value = item.EquipoVisitante;
                GrillaPartidos.Rows[F].Cells[4].Value = item.Estadio;
                GrillaPartidos.Rows[F].Cells[5].Value = item.Jornada;
            }
        }
        private void cbxCfgSeleccionEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (var item in Equ.ListaEquipos)
            {
                if (cbxCfgSeleccionEquipoLocal.Text.ToString() == item.Nombre)
                {
                    txtCfgEstadio.Text = item.NombreEstadio;
                }
            }
        }

        private void btnEditarPartido_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Configurar_Juego_Fixture_Editar))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                DateTime Fecha = Convert.ToDateTime(GrillaPartidos.CurrentRow.Cells[0].Value);
                string EquipoLocal = GrillaPartidos.CurrentRow.Cells[2].Value.ToString();
                string EquipoVisitante = GrillaPartidos.CurrentRow.Cells[3].Value.ToString();

                Configurar_Juego_Fixture_Editar Config = new Configurar_Juego_Fixture_Editar(Fecha,EquipoLocal,EquipoVisitante);
                Config.Show();
            }
        }

        private void btnActualizarGrilla_Click(object sender, EventArgs e)
        {
            CargarGrillaPartidos();
            GuardarArchivosPartidos();
        }

        private void btnEliminarPartido_Click(object sender, EventArgs e)
        {
            DateTime FechaAEliminar = Convert.ToDateTime(GrillaPartidos.CurrentRow.Cells[0].Value);
            string EquipoLocal = GrillaPartidos.CurrentRow.Cells[2].Value.ToString();
            string EquipoVisitante = GrillaPartidos.CurrentRow.Cells[3].Value.ToString();
            foreach (var item in Partidos.ListaPartidos)
            {
                if (FechaAEliminar == item.FechaPartido && EquipoLocal == item.EquipoLocal && EquipoVisitante == item.EquipoVisitante)
                {
                    Partidos.ListaPartidos.Remove(item);
                    break;
                }
            }
            GuardarArchivosPartidos();
            CargarGrillaPartidos();
        }
    }
}
