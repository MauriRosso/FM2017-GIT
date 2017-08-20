using Newtonsoft.Json;
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

namespace Football_Manager_2016
{
    public partial class Partidas : Form
    {
        public Partidas()
        {
            InitializeComponent();
        }

        private void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            SeleccionIngresoEquipo Sel = new SeleccionIngresoEquipo();
            this.Hide();
            Sel.Show();
        }
        ListaUsuario Lista = new ListaUsuario ();
       
        public void CargarArchivos()
        {
            string LeerDatos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosUsuarios.json";

            using (StreamReader Entrada = new StreamReader(LeerDatos))
            {
                string contenido = Entrada.ReadToEnd();

                Lista.LU = JsonConvert.DeserializeObject<List<Usuario>>(contenido);
            }
        }
        public void CargarGrilla()
        {
            int F; 
            foreach (var item in Lista.LU)
	        {
		        F = GrillaPartidas.Rows.Add();
                GrillaPartidas.Rows[F].Cells[0].Value = item.NombreEntrenador;
                GrillaPartidas.Rows[F].Cells[1].Value = item.Equipo;
                GrillaPartidas.Rows[F].Cells[2].Value = item.FechaCreacion;
	        }            
        }
        private void Partidas_Load(object sender, EventArgs e)
        {
            CargarArchivos();
            CargarGrilla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea borrar TODAS las partidas?", "Borrar todas las partidas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Lista.LU.Clear();
                GuardarArchivo();
                GrillaPartidas.Rows.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           if (MessageBox.Show("¿Desea borrar la partida seleccionada?","Borrar partida",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
           {
               string Nombre_A_Eliminar = Convert.ToString(GrillaPartidas.CurrentRow.Cells[0].Value);
               Lista.LU.Remove(Lista.LU.Find(x => x.NombreEntrenador == Nombre_A_Eliminar));
               GuardarArchivo();
               GrillaPartidas.Rows.Remove(GrillaPartidas.CurrentRow);
               MessageBox.Show("Partida borrada exitosamente", "Borrar partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
        }

        Usuario Usu = new Usuario();
        public void GuardarArchivo()
        {
            string DatosArchivo = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosUsuarios.json";

            using (StreamWriter file = new StreamWriter(DatosArchivo, false))
            {
                string Salida = JsonConvert.SerializeObject(Lista.LU);
                file.Write(Salida);
            }
        }
        public void GuardarArchivoTemp()
        {
            string ArchivoTemp = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamWriter file = new StreamWriter(ArchivoTemp, false))
            {
                string Salida = JsonConvert.SerializeObject(Usu);
                file.Write(Salida);
            }
        }
        private void btnCargarPartida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cargar la partida seleccionada?", "Cargar partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                Usu.NombreEntrenador = Convert.ToString(GrillaPartidas.CurrentRow.Cells[0].Value);
                Usu.Equipo = Convert.ToString(GrillaPartidas.CurrentRow.Cells[1].Value);
                Usu.FechaCreacion = Convert.ToDateTime(GrillaPartidas.CurrentRow.Cells[2].Value);

                foreach (var item in Lista.LU)
                {
                    if (Usu.NombreEntrenador == item.NombreEntrenador)
                    {
                        Usu = item;                       
                    }  
                }

                GuardarArchivoTemp();
                this.Hide();
                PantallaPrincipal Pan = new PantallaPrincipal();
                Pan.Show();
            }
        }

        private void btnVolverAlPrincipio_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 F1 = new Form1();
            F1.Show();
        }
    }
}

//Usu.ListaPartidosUsuario = item.ListaPartidosUsuario;
//Usu.ListaPartidosTodos = item.ListaPartidosTodos;
//Usu.ListaTablaUsuario = item.ListaTablaUsuario;
//Usu.ListaJugadorUsuario = item.ListaJugadorUsuario;
//Usu.ListaPartidosCalendario = item.ListaPartidosCalendario;
//Usu.ConfianzaDirigentes = item.ConfianzaDirigentes;
//Usu.ConfianzaHinchada = item.ConfianzaHinchada;
//Usu.PrecioPalcos = item.PrecioPalcos;
//Usu.PrecioPlateas = item.PrecioPlateas;
//Usu.PrecioPopulares = item.PrecioPopulares;
//Usu.Presupuesto = item.Presupuesto;
//Usu.Reputacion = item.Reputacion;
//Usu.Sponsor = item.Sponsor;
//Usu.AyudanteCampo = item.AyudanteCampo;
//Usu.ListaMensajes = item.ListaMensajes;
//Usu.FechaCalendario = item.FechaCalendario;
//Usu.TorneoInternacional = item.TorneoInternacional;
//Usu.TorneoLocal = item.TorneoLocal;
