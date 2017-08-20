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
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            CargarUsuario();
            ptbCalendario.TodayDate = Usu.FechaCalendario;
            CargarFechasEspeciales();
            lblFechaActual.Text = Usu.FechaCalendario.ToLongDateString();
            lblVS.BackColor = Color.Transparent;
            lblVS.Visible = false;
            ptbEscudoLocal.BackColor = Color.Transparent;
            ptbEscudoVisitante.BackColor = Color.Transparent;
        }

        Usuario Usu = new Usuario();
        PantallaPrincipal Pan = new PantallaPrincipal();

        public void CargarUsuario()
        {
            string LeerTemp = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamReader Entrada = new StreamReader(LeerTemp))
            {
                string contenido = Entrada.ReadToEnd();

                Usu = JsonConvert.DeserializeObject<Usuario>(contenido);
            }
        }
        private void CargarFechasEspeciales()
        {
            foreach (var item in Usu.ListaPartidosCalendario)
            {
                if (item.EquipoLocal == Usu.Equipo || item.EquipoVisitante == Usu.Equipo)
                {
                    ptbCalendario.AddBoldedDate(item.FechaPartido);
                }
            }
        }
        bool HayPartido = false;
        private void ptbCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {         
            lblFechaActual.Text = ptbCalendario.SelectionRange.Start.ToLongDateString();
            //Cargo Partidos del calendario segun la fecha que se seleccione
            foreach (var item in Usu.ListaPartidosCalendario)
            {
                if (item.EquipoLocal == Usu.Equipo || item.EquipoVisitante == Usu.Equipo)
                {
                    if (ptbCalendario.SelectionStart == item.FechaPartido)
                    {
                        CargarEscudos(item);
                        CargarPlaca(item);
                        HayPartido = true;
                        break;
                    }
                }               
            }
            if (HayPartido == false)
            {
                lblVS.Visible = false;
                this.BackgroundImage = null;
                ptbEscudoLocal.Visible = false;
                ptbEscudoVisitante.Visible = false;
            }
            else
            {
                lblVS.Visible = true;
                ptbEscudoLocal.Visible = true;
                ptbEscudoVisitante.Visible = true;
            }
            HayPartido = false;
        }
        private void CargarPlaca(Partido item)
        {
            if (item.Competencia == "Primera División")
            {
                this.BackgroundImage = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\BannerPrimeraDivision.JPG");
            }
            if (item.Competencia == "B Nacional")
            {
                this.BackgroundImage = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\BannerPrimeraB.PNG");
            }
            if (item.Competencia == "Copa Libertadores")
            {
                this.BackgroundImage = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\BannerCopaLibertadores.JPG");
            }
            if (item.Competencia == "Copa Sudamericana")
            {
                this.BackgroundImage = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\BannerCopaSudamericana.PNG");
            }
            if (item.Competencia == "Copa Argentina")
            {
                this.BackgroundImage = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\BannerCopaArgentina.PNG");
            }
        }
        private void CargarEscudos(Partido item)
        {
            if (item.EquipoLocal == "Argentinos Juniors")
            {
                ptbEscudoLocal.Image = Image.FromFile("ArgentinosJuniors.png");
            }
            if (item.EquipoLocal == "Arsenal")
            {
                ptbEscudoLocal.Image = Image.FromFile("Arsenal.png");
            }
            if (item.EquipoLocal == "Atlético Tucumán")
            {
                ptbEscudoLocal.Image = Image.FromFile("AtleticoTucuman.png");
            }
            if (item.EquipoLocal == "Banfield")
            {
                ptbEscudoLocal.Image = Image.FromFile("Banfield.png");
            }
            if (item.EquipoLocal == "Belgrano")
            {
                ptbEscudoLocal.Image = Image.FromFile("Belgrano.png");
            }
            if (item.EquipoLocal == "Boca Juniors")
            {
                ptbEscudoLocal.Image = Image.FromFile("BocaJuniors.png");
            }
            if (item.EquipoLocal == "Colón")
            {
                ptbEscudoLocal.Image = Image.FromFile("Colon.png");
            }
            if (item.EquipoLocal == "Chacarita Juniors")
            {
                ptbEscudoLocal.Image = Image.FromFile("Chacarita.png");
            }
            if (item.EquipoLocal == "Defensa y Justicia")
            {
                ptbEscudoLocal.Image = Image.FromFile("DefensaYjusticia.png");
            }
            if (item.EquipoLocal == "Estudiantes (LP)")
            {
                ptbEscudoLocal.Image = Image.FromFile("Estudiantes.png");
            }
            if (item.EquipoLocal == "Gimnasia (LP)")
            {
                ptbEscudoLocal.Image = Image.FromFile("Gimnasia.png");
            }
            if (item.EquipoLocal == "Godoy Cruz")
            {
                ptbEscudoLocal.Image = Image.FromFile("GodoyCruz.png");
            }
            if (item.EquipoLocal == "Huracán")
            {
                ptbEscudoLocal.Image = Image.FromFile("Huracan.png");
            }
            if (item.EquipoLocal == "Independiente")
            {
                ptbEscudoLocal.Image = Image.FromFile("Independiente.png");
            }
            if (item.EquipoLocal == "Lanus")
            {
                ptbEscudoLocal.Image = Image.FromFile("Lanus.png");
            }
            if (item.EquipoLocal == "Newell's")
            {
                ptbEscudoLocal.Image = Image.FromFile("Newells.png");
            }
            if (item.EquipoLocal == "Olimpo")
            {
                ptbEscudoLocal.Image = Image.FromFile("Olimpo.png");
            }
            if (item.EquipoLocal == "Patronato")
            {
                ptbEscudoLocal.Image = Image.FromFile("Patronato.png");
            }
            if (item.EquipoLocal == "Racing Club")
            {
                ptbEscudoLocal.Image = Image.FromFile("RacingClub.png");
            }
            if (item.EquipoLocal == "River Plate")
            {
                ptbEscudoLocal.Image = Image.FromFile("RiverPlate.png");
            }
            if (item.EquipoLocal == "Rosario Central")
            {
                ptbEscudoLocal.Image = Image.FromFile("RosarioCentral.png");
            }
            if (item.EquipoLocal == "San Lorenzo")
            {
                ptbEscudoLocal.Image = Image.FromFile("SanLorenzo.png");
            }
            if (item.EquipoLocal == "San Martín (SJ)")
            {
                ptbEscudoLocal.Image = Image.FromFile("SanMartinSJ.png");
            }

            if (item.EquipoLocal == "Talleres")
            {
                ptbEscudoLocal.Image = Image.FromFile("Talleres.png");
            }
            if (item.EquipoLocal == "Temperley")
            {
                ptbEscudoLocal.Image = Image.FromFile("Temperley.png");
            }
            if (item.EquipoLocal == "Tigre")
            {
                ptbEscudoLocal.Image = Image.FromFile("Tigre.png");
            }
            if (item.EquipoLocal == "Unión")
            {
                ptbEscudoLocal.Image = Image.FromFile("Union.png");
            }
            if (item.EquipoLocal == "Velez Sarfield")
            {
                ptbEscudoLocal.Image = Image.FromFile("VelezSarfield.png");
            }
            if (item.EquipoLocal == "Agropecuario")
            {
                ptbEscudoLocal.Image = Image.FromFile("Agropecuario.png");
            }
            if (item.EquipoLocal == "All Boys")
            {
                ptbEscudoLocal.Image = Image.FromFile("AllBoys.png");
            }
            if (item.EquipoLocal == "Almagro")
            {
                ptbEscudoLocal.Image = Image.FromFile("Almagro.png");
            }
            if (item.EquipoLocal == "Aldosivi")
            {
                ptbEscudoLocal.Image = Image.FromFile("Aldosivi.png");
            }
            if (item.EquipoLocal == "Atlético Rafaela")
            {
                ptbEscudoLocal.Image = Image.FromFile("AtleticoRafaela.png");
            }
            if (item.EquipoLocal == "Boca Unidos")
            {
                ptbEscudoLocal.Image = Image.FromFile("BocaUnidos.png");
            }
            if (item.EquipoLocal == "Brown de Adrogué")
            {
                ptbEscudoLocal.Image = Image.FromFile("Brown.png");
            }
            if (item.EquipoLocal == "Sarmiento de Junín")
            {
                ptbEscudoLocal.Image = Image.FromFile("SarmientoDeJunin.png");
            }
            if (item.EquipoLocal == "Deportivo Morón")
            {
                ptbEscudoLocal.Image = Image.FromFile("Moron.png");
            }
            if (item.EquipoLocal == "Deportivo Riestra")
            {
                ptbEscudoLocal.Image = Image.FromFile("DeportivoRiestra.png");
            }
            if (item.EquipoLocal == "Ferro Carril Oeste")
            {
                ptbEscudoLocal.Image = Image.FromFile("FerroCarrilOeste.png");
            }
            if (item.EquipoLocal == "Flandria")
            {
                ptbEscudoLocal.Image = Image.FromFile("Flandria.png");
            }
            if (item.EquipoLocal == "Gimnasia de Jujuy")
            {
                ptbEscudoLocal.Image = Image.FromFile("GimnasiaJujuy.png");
            }
            if (item.EquipoLocal == "Guillermo Brown")
            {
                ptbEscudoLocal.Image = Image.FromFile("GuillermoBrown.png");
            }
            if (item.EquipoLocal == "Independiente Rivadavia")
            {
                ptbEscudoLocal.Image = Image.FromFile("IndependienteRivadavia.png");
            }
            if (item.EquipoLocal == "Instituto")
            {
                ptbEscudoLocal.Image = Image.FromFile("Instituto.png");
            }
            if (item.EquipoLocal == "Juventud Unida")
            {
                ptbEscudoLocal.Image = Image.FromFile("JuventudUnida.png");
            }
            if (item.EquipoLocal == "Los Andes")
            {
                ptbEscudoLocal.Image = Image.FromFile("LosAndes.png");
            }
            if (item.EquipoLocal == "Mitre")
            {
                ptbEscudoLocal.Image = Image.FromFile("Mitre.png");
            }
            if (item.EquipoLocal == "Nueva Chicago")
            {
                ptbEscudoLocal.Image = Image.FromFile("NuevaChicago.png");
            }
            if (item.EquipoLocal == "Quilmes")
            {
                ptbEscudoLocal.Image = Image.FromFile("Quilmes.png");
            }
            if (item.EquipoLocal == "Santamarina de Tandil")
            {
                ptbEscudoLocal.Image = Image.FromFile("SantamarinaDeTandil.png");
            }
            if (item.EquipoLocal == "San Martín de Tucumán")
            {
                ptbEscudoLocal.Image = Image.FromFile("SanMartinTucuman.png");
            }
            if (item.EquipoLocal == "Estudiantes (SL)")
            {
                ptbEscudoLocal.Image = Image.FromFile("EstudiantesSL.png");
            }
            if (item.EquipoLocal == "Villa Dálmine")
            {
                ptbEscudoLocal.Image = Image.FromFile("VillaDalmine.png");
            }

            ////ESCUDO VISITANTE

            if (item.EquipoVisitante == "Argentinos Juniors")
            {
                ptbEscudoVisitante.Image = Image.FromFile("ArgentinosJuniors.png");
            }
            if (item.EquipoVisitante == "Arsenal")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Arsenal.png");
            }
            if (item.EquipoVisitante == "Atlético Tucumán")
            {
                ptbEscudoVisitante.Image = Image.FromFile("AtleticoTucuman.png");
            }
            if (item.EquipoVisitante == "Banfield")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Banfield.png");
            }
            if (item.EquipoVisitante == "Belgrano")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Belgrano.png");
            }
            if (item.EquipoVisitante == "Boca Juniors")
            {
                ptbEscudoVisitante.Image = Image.FromFile("BocaJuniors.png");
            }
            if (item.EquipoVisitante == "Colón")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Colon.png");
            }
            if (item.EquipoVisitante == "Chacarita Juniors")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Chacarita.png");
            }
            if (item.EquipoVisitante == "Defensa y Justicia")
            {
                ptbEscudoVisitante.Image = Image.FromFile("DefensaYjusticia.png");
            }
            if (item.EquipoVisitante == "Estudiantes (LP)")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Estudiantes.png");
            }
            if (item.EquipoVisitante == "Gimnasia (LP)")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Gimnasia.png");
            }
            if (item.EquipoVisitante == "Godoy Cruz")
            {
                ptbEscudoVisitante.Image = Image.FromFile("GodoyCruz.png");
            }
            if (item.EquipoVisitante == "Huracán")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Huracan.png");
            }
            if (item.EquipoVisitante == "Independiente")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Independiente.png");
            }
            if (item.EquipoVisitante == "Lanus")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Lanus.png");
            }
            if (item.EquipoVisitante == "Newell's")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Newells.png");
            }
            if (item.EquipoVisitante == "Olimpo")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Olimpo.png");
            }
            if (item.EquipoVisitante == "Patronato")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Patronato.png");
            }
            if (item.EquipoVisitante == "Racing Club")
            {
                ptbEscudoVisitante.Image = Image.FromFile("RacingClub.png");
            }
            if (item.EquipoVisitante == "River Plate")
            {
                ptbEscudoVisitante.Image = Image.FromFile("RiverPlate.png");
            }
            if (item.EquipoVisitante == "Rosario Central")
            {
                ptbEscudoVisitante.Image = Image.FromFile("RosarioCentral.png");
            }
            if (item.EquipoVisitante == "San Lorenzo")
            {
                ptbEscudoVisitante.Image = Image.FromFile("SanLorenzo.png");
            }
            if (item.EquipoVisitante == "San Martín (SJ)")
            {
                ptbEscudoVisitante.Image = Image.FromFile("SanMartinSJ.png");
            }

            if (item.EquipoVisitante == "Talleres")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Talleres.png");
            }
            if (item.EquipoVisitante == "Temperley")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Temperley.png");
            }
            if (item.EquipoVisitante == "Tigre")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Tigre.png");
            }
            if (item.EquipoVisitante == "Unión")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Union.png");
            }
            if (item.EquipoVisitante == "Velez Sarfield")
            {
                ptbEscudoVisitante.Image = Image.FromFile("VelezSarfield.png");
            }
            if (item.EquipoVisitante == "Agropecuario")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Agropecuario.png");
            }
            if (item.EquipoVisitante == "All Boys")
            {
                ptbEscudoVisitante.Image = Image.FromFile("AllBoys.png");
            }
            if (item.EquipoVisitante == "Almagro")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Almagro.png");
            }
            if (item.EquipoVisitante == "Aldosivi")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Aldosivi.png");
            }
            if (item.EquipoVisitante == "Atlético Rafaela")
            {
                ptbEscudoVisitante.Image = Image.FromFile("AtleticoRafaela.png");
            }
            if (item.EquipoVisitante == "Boca Unidos")
            {
                ptbEscudoVisitante.Image = Image.FromFile("BocaUnidos.png");
            }
            if (item.EquipoVisitante == "Brown de Adrogué")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Brown.png");
            }
            if (item.EquipoVisitante == "Sarmiento de Junín")
            {
                ptbEscudoVisitante.Image = Image.FromFile("SarmientoDeJunin.png");
            }
            if (item.EquipoVisitante == "Deportivo Morón")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Moron.png");
            }
            if (item.EquipoVisitante == "Deportivo Riestra")
            {
                ptbEscudoVisitante.Image = Image.FromFile("DeportivoRiestra.png");
            }
            if (item.EquipoVisitante == "Ferro Carril Oeste")
            {
                ptbEscudoVisitante.Image = Image.FromFile("FerroCarrilOeste.png");
            }
            if (item.EquipoVisitante == "Flandria")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Flandria.png");
            }
            if (item.EquipoVisitante == "Gimnasia de Jujuy")
            {
                ptbEscudoVisitante.Image = Image.FromFile("GimnasiaJujuy.png");
            }
            if (item.EquipoVisitante == "Guillermo Brown")
            {
                ptbEscudoVisitante.Image = Image.FromFile("GuillermoBrown.png");
            }
            if (item.EquipoVisitante == "Independiente Rivadavia")
            {
                ptbEscudoVisitante.Image = Image.FromFile("IndependienteRivadavia.png");
            }
            if (item.EquipoVisitante == "Instituto")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Instituto.png");
            }
            if (item.EquipoVisitante == "Juventud Unida")
            {
                ptbEscudoVisitante.Image = Image.FromFile("JuventudUnida.png");
            }
            if (item.EquipoVisitante == "Los Andes")
            {
                ptbEscudoVisitante.Image = Image.FromFile("LosAndes.png");
            }
            if (item.EquipoVisitante == "Mitre")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Mitre.png");
            }
            if (item.EquipoVisitante == "Nueva Chicago")
            {
                ptbEscudoVisitante.Image = Image.FromFile("NuevaChicago.png");
            }
            if (item.EquipoVisitante == "Quilmes")
            {
                ptbEscudoVisitante.Image = Image.FromFile("Quilmes.png");
            }
            if (item.EquipoVisitante == "Santamarina de Tandil")
            {
                ptbEscudoVisitante.Image = Image.FromFile("SantamarinaDeTandil.png");
            }
            if (item.EquipoVisitante == "San Martín de Tucumán")
            {
                ptbEscudoVisitante.Image = Image.FromFile("SanMartinTucuman.png");
            }
            if (item.EquipoVisitante == "Estudiantes (SL)")
            {
                ptbEscudoVisitante.Image = Image.FromFile("EstudiantesSL.png");
            }
            if (item.EquipoVisitante == "Villa Dálmine")
            {
                ptbEscudoVisitante.Image = Image.FromFile("VillaDalmine.png");
            }
        }
    }
}
