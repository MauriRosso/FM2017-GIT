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
    public partial class Configurar_Juego_Jugadores_Editar : Form
    {
        public string ClubAntiguo { get; set; }
        public string NombreAntiguo { get; set; }

        public Configurar_Juego_Jugadores_Editar()
        {
            InitializeComponent();
        }
        public Configurar_Juego_Jugadores_Editar(string ClubC,string NomC,string PosC,int FueC,double SalC,double ValC,int EdaC,string PieC)
        {
            InitializeComponent();
            lblJugador.Text = NomC;
            cbxConfigPosicion.SelectedItem = PosC;
            txtConfigNombre.Text = NomC;
            ntxtConfigSalario.Text = SalC.ToString();
            ntxtConfigValor.Text = ValC.ToString();
            cbxConfigClub.SelectedItem = ClubC;
            cbxConfigFuerza.SelectedItem = FueC.ToString();
            cbxConfigPie.SelectedItem = PieC;
            cbxConfigEdad.SelectedItem = EdaC.ToString();
            ClubAntiguo = ClubC;
            NombreAntiguo = NomC;
        }
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
        private void Configurar_Juego_Jugadores_Editar_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarJug_Click(object sender, EventArgs e)
        {
            CargarArchivosJugadores();
            foreach (var item in Jdores.ListaJugadores)
            {
                if (NombreAntiguo == item.Nombre && ClubAntiguo == item.EquipoActual)
                {
                    item.EquipoActual = cbxConfigClub.Text;
                    item.Nombre = txtConfigNombre.Text;
                    item.Posicion = cbxConfigPosicion.Text;
                    item.Fuerza = Convert.ToInt32(cbxConfigFuerza.Text);
                    item.Salario = Convert.ToInt32(ntxtConfigSalario.Text);
                    item.Valor = Convert.ToInt32(ntxtConfigValor.Text);
                    item.Edad = Convert.ToInt32(cbxConfigEdad.Text);
                    item.Pie = cbxConfigPie.Text;
                    break;
                }
            }
            GuardarArchivosJugadores();
            this.Close();
        }
    }
}
