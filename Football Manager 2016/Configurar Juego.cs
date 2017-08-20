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
    public partial class Configurar_Juego : Form
    {
        public Configurar_Juego()
        {
            InitializeComponent();
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
        private void btnConfigurarFixture_Click(object sender, EventArgs e)
        {
            Configurar_Juego_Fixture Confixture = new Configurar_Juego_Fixture();
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Configurar_Juego_Fixture))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                if (Equ.ListaEquipos.Count < 30)
                {
                    MessageBox.Show("Cargue todos los equipos en la seccion 'Configurar Equipos' del apartado de configuraciones para continuar", "Equipos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Confixture.Show();
                }
            }
        }
        
        private void btnConfigEquipos_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Configurar_Juego_Equipos))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Configurar_Juego_Equipos ConEquipos = new Configurar_Juego_Equipos();
                ConEquipos.Show();
            }

        }

        private void Configurar_Juego_Load(object sender, EventArgs e)
        {
            CargarArchivosEquipos();
        }

        private void btnConfigJugadores_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Configurar_Juego_Jugadores))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Configurar_Juego_Jugadores Jug = new Configurar_Juego_Jugadores();
                Jug.Show();
            }
        }
    }
}
