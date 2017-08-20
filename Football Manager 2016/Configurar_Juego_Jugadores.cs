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
    public partial class Configurar_Juego_Jugadores : Form
    {
        public Configurar_Juego_Jugadores()
        {
            InitializeComponent();
        }
        ListaUsuario Lista = new ListaUsuario();
        Usuario Usu = new Usuario();
        Jugador Jug = new Jugador();
        Jugadores Jdores = new Jugadores();
        public void CargarArchivosJugadores()
        {
            string LeerDatos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosJugadores.json";

            using (StreamReader Entrada = new StreamReader(LeerDatos))
            {
                string contenido = Entrada.ReadToEnd();

                Jdores.ListaJugadores = JsonConvert.DeserializeObject<List<Jugador>>(contenido);
            }
        }
        public void GuardarArchivosJugadores()
        {
            string ArchivosJugadores = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosJugadores.json";

            using (StreamWriter file = new StreamWriter(ArchivosJugadores, false))
            {
                string Salida = JsonConvert.SerializeObject(Jdores.ListaJugadores);
                file.Write(Salida);
            }
        }
        private void btnConfigCargarJugador_Click(object sender, EventArgs e)
        {
            if (cbxConfigPosicion.SelectedIndex > -1 && txtConfigNombre.Text != "" && ntxtConfigSalario.Text != "" && ntxtConfigValor.Text != "" && cbxConfigFuerza.SelectedIndex > -1 && cbxConfigEdad.SelectedIndex > -1 && cbxConfigPie.SelectedIndex > -1 && cbxConfigClub.SelectedIndex > -1)
            {
                DateTime FechaContrato = new DateTime(2017,02,26);
             
                Jugador Jug = new Jugador();
                Jug.Condicion = Convert.ToInt32(100);
                Jug.Edad = Convert.ToInt32(cbxConfigEdad.SelectedItem);
                Jug.EquipoActual = cbxConfigClub.Text;
                Jug.Fuerza = Convert.ToInt32(cbxConfigFuerza.Text);
                Jug.GolesConvertidos = Convert.ToInt32(0);
                Jug.Nombre = txtConfigNombre.Text;
                Jug.Pie = cbxConfigPie.Text;
                Jug.Posicion = cbxConfigPosicion.Text;
                Jug.Salario = Convert.ToDouble(ntxtConfigSalario.Text);
                Jug.Valor = Convert.ToDouble(ntxtConfigValor.Text);
                Jug.FinalizacionContrato = FechaContrato;
                Jug.PartidosJugados = 0;
                Jug.GolesConvertidos = 0;
                Jug.Amarillas = 0;
                Jug.Rojas = 0;

                Jdores.ListaJugadores.Add(Jug);

                GuardarArchivosJugadores();
                MessageBox.Show("¡Jugador cargado exitosamente!", "Cargar Jugador", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            else
            {
                MessageBox.Show("¡Rellene todos los campos para continuar!", "Cargar Jugador", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
        }
        private void CargarGrillaJugadores()
        {
            GrillaJugadores.Rows.Clear();
            GrillaJugadores.RowHeadersVisible = false;
            int F = 0;
            foreach (var item in Jdores.ListaJugadores)
            {
                F = GrillaJugadores.Rows.Add();

                GrillaJugadores.Rows[F].Cells[0].Value = item.EquipoActual;
                GrillaJugadores.Rows[F].Cells[1].Value = item.Nombre;
                GrillaJugadores.Rows[F].Cells[2].Value = item.Posicion;
                GrillaJugadores.Rows[F].Cells[3].Value = item.Fuerza;
                GrillaJugadores.Rows[F].Cells[4].Value = item.Salario;
                GrillaJugadores.Rows[F].Cells[5].Value = item.Valor;
                GrillaJugadores.Rows[F].Cells[6].Value = item.Edad;
                GrillaJugadores.Rows[F].Cells[7].Value = item.Pie;
            }
        }
        private void Configurar_Juego_Jugadores_Load(object sender, EventArgs e)
        {
            CargarArchivosJugadores();
            CargarGrillaJugadores();         
        }

        private void btnEditarJugador_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Configurar_Juego_Jugadores_Editar))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                string Club = GrillaJugadores.CurrentRow.Cells[0].Value.ToString();
                string Nom = GrillaJugadores.CurrentRow.Cells[1].Value.ToString();
                string Pos = GrillaJugadores.CurrentRow.Cells[2].Value.ToString();
                int Fue = Convert.ToInt32(GrillaJugadores.CurrentRow.Cells[3].Value);
                double Sal = Convert.ToDouble(GrillaJugadores.CurrentRow.Cells[4].Value);
                double Val = Convert.ToDouble(GrillaJugadores.CurrentRow.Cells[5].Value);            
                int Eda = Convert.ToInt32(GrillaJugadores.CurrentRow.Cells[6].Value);
                string Pie = GrillaJugadores.CurrentRow.Cells[7].Value.ToString();
                Configurar_Juego_Jugadores_Editar Config = new Configurar_Juego_Jugadores_Editar( Club,  Nom,  Pos,  Fue,  Sal,  Val,  Eda,  Pie);
                Config.Show();
            }
        }

        private void btnActualizarGrilla_Click(object sender, EventArgs e)
        {
            CargarGrillaJugadores();
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            string JugadorEquipoEliminar = GrillaJugadores.CurrentRow.Cells[0].Value.ToString();
            string NombreEliminar = GrillaJugadores.CurrentRow.Cells[1].Value.ToString();
            foreach (var item in Jdores.ListaJugadores)
            {
                if (NombreEliminar == item.Nombre && JugadorEquipoEliminar == item.EquipoActual)
                {
                    Jdores.ListaJugadores.Remove(item);
                    break;
                }
            }
            GuardarArchivosJugadores();
            CargarGrillaJugadores();
        }
    }
}
