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
    public partial class Fixture : Form
    {
        public Fixture()
        {
            InitializeComponent();
        }
        Usuario Usu = new Usuario();
        Equipos Equ = new Equipos();
        Partidos Partidos = new Partidos();
        ListaUsuario ListaUsuario = new ListaUsuario();
        public void CargaArchivos()
        {
            string LeerListaPartidos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosUsuarios.json";

            using (StreamReader Entrada = new StreamReader(LeerListaPartidos))
            {
                string contenido = Entrada.ReadToEnd();

                ListaUsuario.LU = JsonConvert.DeserializeObject<List<Usuario>>(contenido);
            }
            string LeerTemp = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamReader Entrada = new StreamReader(LeerTemp))
            {
                string contenido = Entrada.ReadToEnd();

                Usu = JsonConvert.DeserializeObject<Usuario>(contenido);
            }
            string LeerListaEquipos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosEquipos.json";

            using (StreamReader Entrada = new StreamReader(LeerListaEquipos))
            {
                string contenido = Entrada.ReadToEnd();

                Equ.ListaEquipos = JsonConvert.DeserializeObject<List<PropiedadesEquipos>>(contenido);
            }
            
        }
        public void CargarEscudo()
        {
            if (Usu.Equipo == "Aldosivi")
            {
                ptbEscudoFixture.Image = Image.FromFile("aldosivi_arg.jpg");

            }
            if (Usu.Equipo == "Arsenal")
            {
                ptbEscudoFixture.Image = Image.FromFile("arsenal_arg.jpg");

            }
            if (Usu.Equipo == "Atlético Rafaela")
            {
                ptbEscudoFixture.Image = Image.FromFile("atlrafaela_arg.jpg");
            }
            if (Usu.Equipo == "Atlético Tucumán")
            {
                ptbEscudoFixture.Image = Image.FromFile("atl_tucuman_arg.jpg");
            }
            if (Usu.Equipo == "Banfield")
            {
                ptbEscudoFixture.Image = Image.FromFile("banfield_arg.jpg");
            }
            if (Usu.Equipo == "Belgrano")
            {
                ptbEscudoFixture.Image = Image.FromFile("belgrano_arg.jpg");
            }
            if (Usu.Equipo == "Boca Juniors")
            {
                ptbEscudoFixture.Image = Image.FromFile("bocajuniors_arg.jpg");
            }
            if (Usu.Equipo == "Colón")
            {
                ptbEscudoFixture.Image = Image.FromFile("colon_arg.jpg");
            }
            if (Usu.Equipo == "Defensa y Justicia")
            {
                ptbEscudoFixture.Image = Image.FromFile("defensayjusticia_arg.jpg");
            }
            if (Usu.Equipo == "Estudiantes (LP)")
            {
                ptbEscudoFixture.Image = Image.FromFile("estudiantes_arg.jpg");
            }
            if (Usu.Equipo == "Gimnasia (LP)")
            {
                ptbEscudoFixture.Image = Image.FromFile("gimnasia_arg.jpg");
            }
            if (Usu.Equipo == "Godoy Cruz")
            {
                ptbEscudoFixture.Image = Image.FromFile("godoy_cruz_arg.jpg");
            }
            if (Usu.Equipo == "Huracán")
            {
                ptbEscudoFixture.Image = Image.FromFile("huracan_arg.jpg");
            }
            if (Usu.Equipo == "Independiente")
            {
                ptbEscudoFixture.Image = Image.FromFile("independiente_arg.jpg");
            }
            if (Usu.Equipo == "Lanus")
            {
                ptbEscudoFixture.Image = Image.FromFile("lanus_arg.jpg");
            }
            if (Usu.Equipo == "Newell's")
            {
                ptbEscudoFixture.Image = Image.FromFile("newells_arg.jpg");
            }
            if (Usu.Equipo == "Olimpo")
            {
                ptbEscudoFixture.Image = Image.FromFile("olimpo_arg.jpg");
            }
            if (Usu.Equipo == "Patronato")
            {
                ptbEscudoFixture.Image = Image.FromFile("patronato_arg.jpg");
            }
            if (Usu.Equipo == "Quilmes")
            {
                ptbEscudoFixture.Image = Image.FromFile("quilmes_arg.jpg");
            }
            if (Usu.Equipo == "Racing Club")
            {
                ptbEscudoFixture.Image = Image.FromFile("racing_arg.jpg");
            }
            if (Usu.Equipo == "River Plate")
            {
                ptbEscudoFixture.Image = Image.FromFile("riverplate_arg.jpg");
            }
            if (Usu.Equipo == "Rosario Central")
            {
                ptbEscudoFixture.Image = Image.FromFile("rosariocentral_arg.jpg");
            }
            if (Usu.Equipo == "San Lorenzo")
            {
                ptbEscudoFixture.Image = Image.FromFile("sanlorenzo_arg.jpg");
            }
            if (Usu.Equipo == "San Martín (SJ)")
            {
                ptbEscudoFixture.Image = Image.FromFile("sanmartin_sanjuan_arg.jpg");
            }
            if (Usu.Equipo == "Sarmiento de Junín")
            {
                ptbEscudoFixture.Image = Image.FromFile("sarmiento_arg.jpg");
            }
            if (Usu.Equipo == "Talleres")
            {
                ptbEscudoFixture.Image = Image.FromFile("talleres_arg.jpg");
            }
            if (Usu.Equipo == "Temperley")
            {
                ptbEscudoFixture.Image = Image.FromFile("temperley_arg.jpg");
            }
            if (Usu.Equipo == "Tigre")
            {
                ptbEscudoFixture.Image = Image.FromFile("tigre_arg.jpg");
            }
            if (Usu.Equipo == "Unión")
            {
                ptbEscudoFixture.Image = Image.FromFile("union_arg.jpg");
            }
            if (Usu.Equipo == "Velez Sarfield")
            {
                ptbEscudoFixture.Image = Image.FromFile("velezsarfield.jpg");
            }
        }
        public void FixtureYnombre()
        {
            lblEquipoFixture.Text = Usu.Equipo;
            foreach (var item in Usu.ListaPartidosCalendario)
            {
                if (Usu.Equipo == item.EquipoLocal || Usu.Equipo == item.EquipoVisitante) //encontre el equipo
                {
                    if (item.Resultado == null) //pregunto si se jugo esa fecha (porque si no se jugo el resultado es NULL)
                    {                        
                        ListViewItem ListaFixture = new ListViewItem(Convert.ToString(item.FechaPartido.ToShortDateString()));
                        ListaFixture.SubItems.Add("-");
                        ListaFixture.SubItems.Add(item.EquipoLocal);
                        ListaFixture.SubItems.Add("");
                        ListaFixture.SubItems.Add("x");
                        ListaFixture.SubItems.Add("");
                        ListaFixture.SubItems.Add(item.EquipoVisitante);
                        ListaFixture.SubItems.Add(item.Estadio);
                        ListaFixture.SubItems.Add("");
                        ListaFixture.SubItems.Add("");
                        ListaFixture.SubItems.Add(item.Jornada.ToString());
                        listViewFixture.Items.Add(ListaFixture);
                    }
                    else
                    {
                        ListViewItem ListaFixture = new ListViewItem(Convert.ToString(item.FechaPartido.ToShortDateString()));
                        ListaFixture.SubItems.Add(item.Resultado);
                        ListaFixture.SubItems.Add(item.EquipoLocal);
                        ListaFixture.SubItems.Add(Convert.ToString(item.GolesLocal));
                        ListaFixture.SubItems.Add("x");
                        ListaFixture.SubItems.Add(Convert.ToString(item.GolesVisitante));
                        ListaFixture.SubItems.Add(item.EquipoVisitante);
                        ListaFixture.SubItems.Add(item.Estadio);
                        ListaFixture.SubItems.Add(item.GananciaEntradas.ToString());
                        ListaFixture.SubItems.Add(item.CantidadEspectadores.ToString());
                        ListaFixture.SubItems.Add(item.Jornada.ToString());
                        listViewFixture.Items.Add(ListaFixture);
                    }
                }
            }
        }
        public void Transparencias()
        {
            ptbEscudoFixture.Parent = ptbFondoFixture;
            ptbEscudoFixture.BackColor = Color.Transparent;
            lblEquipoFixture.Parent = ptbFondoFixture;
            lblEquipoFixture.BackColor = Color.Transparent;
            lblFixture.Parent = ptbFondoFixture;
            lblFixture.BackColor = Color.Transparent;
        }
        private void Fixture_Load(object sender, EventArgs e)
        {
            CargaArchivos();
            CargarEscudo();
            FixtureYnombre();
            Transparencias();
        }

        private void btnVerFixtureCompleto_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(FixtureCompleto))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                FixtureCompleto FixCom = new FixtureCompleto();
                FixCom.Show();
            }
        }
    }
}
