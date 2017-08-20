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
    public partial class Formacion : Form
    {
        public Formacion()
        {
            InitializeComponent();
        }
       
        public void Transparencias()
        {
            ptbCamiseta1.Parent = ptbCanchaFormacion;
            ptbCamiseta1.BackColor = Color.Transparent;
            ptbCamiseta5.Parent = ptbCanchaFormacion;
            ptbCamiseta5.BackColor = Color.Transparent;
            ptbCamiseta3.Parent = ptbCanchaFormacion;
            ptbCamiseta3.BackColor = Color.Transparent;
            ptbCamiseta6.Parent = ptbCanchaFormacion;
            ptbCamiseta6.BackColor = Color.Transparent;
            ptbCamiseta2.Parent = ptbCanchaFormacion;
            ptbCamiseta2.BackColor = Color.Transparent;
            ptbCamiseta8.Parent = ptbCanchaFormacion;
            ptbCamiseta8.BackColor = Color.Transparent;
            ptbCamiseta4.Parent = ptbCanchaFormacion;
            ptbCamiseta4.BackColor = Color.Transparent;
            ptbCamiseta7.Parent = ptbCanchaFormacion;
            ptbCamiseta7.BackColor = Color.Transparent;
            ptbCamiseta10.Parent = ptbCanchaFormacion;
            ptbCamiseta10.BackColor = Color.Transparent;
            ptbCamiseta9.Parent = ptbCanchaFormacion;
            ptbCamiseta9.BackColor = Color.Transparent;
            ptbCamiseta11.Parent = ptbCanchaFormacion;
            ptbCamiseta11.BackColor = Color.Transparent;
            btnCerrarFormacion.Parent = ptbCanchaFormacion;
            btnCerrarFormacion.BackColor = Color.Transparent;
            lblNombreJ1.Parent = ptbCanchaFormacion;
            lblNombreJ1.BackColor = Color.Transparent;
            lblNombreJ2.Parent = ptbCanchaFormacion;
            lblNombreJ2.BackColor = Color.Transparent;
            lblNombreJ3.Parent = ptbCanchaFormacion;
            lblNombreJ3.BackColor = Color.Transparent;
            lblNombreJ4.Parent = ptbCanchaFormacion;
            lblNombreJ4.BackColor = Color.Transparent;
            lblNombreJ5.Parent = ptbCanchaFormacion;
            lblNombreJ5.BackColor = Color.Transparent;
            lblNombreJ6.Parent = ptbCanchaFormacion;
            lblNombreJ6.BackColor = Color.Transparent;
            lblNombreJ7.Parent = ptbCanchaFormacion;
            lblNombreJ7.BackColor = Color.Transparent;
            lblNombreJ8.Parent = ptbCanchaFormacion;
            lblNombreJ8.BackColor = Color.Transparent;
            lblNombreJ9.Parent = ptbCanchaFormacion;
            lblNombreJ9.BackColor = Color.Transparent;
            lblNombreJ10.Parent = ptbCanchaFormacion;
            lblNombreJ10.BackColor = Color.Transparent;
            lblNombreJ11.Parent = ptbCanchaFormacion;
            lblNombreJ11.BackColor = Color.Transparent;
            

            lblPosJ1.Parent = ptbCanchaFormacion;
            lblPosJ1.BackColor = Color.Transparent;
            lblPosJ2.Parent = ptbCanchaFormacion;
            lblPosJ2.BackColor = Color.Transparent;
            lblPosJ3.Parent = ptbCanchaFormacion;
            lblPosJ3.BackColor = Color.Transparent;
            lblPosJ4.Parent = ptbCanchaFormacion;
            lblPosJ4.BackColor = Color.Transparent;
            lblPosJ5.Parent = ptbCanchaFormacion;
            lblPosJ5.BackColor = Color.Transparent;
            lblPosJ6.Parent = ptbCanchaFormacion;
            lblPosJ6.BackColor = Color.Transparent;
            lblPosJ7.Parent = ptbCanchaFormacion;
            lblPosJ7.BackColor = Color.Transparent;
            lblPosJ8.Parent = ptbCanchaFormacion;
            lblPosJ8.BackColor = Color.Transparent;
            lblPosJ9.Parent = ptbCanchaFormacion;
            lblPosJ9.BackColor = Color.Transparent;
            lblPosJ10.Parent = ptbCanchaFormacion;
            lblPosJ10.BackColor = Color.Transparent;
            lblPosJ11.Parent = ptbCanchaFormacion;
            lblPosJ11.BackColor = Color.Transparent;
            
            lblPosJ21.BackColor = Color.Transparent;
            lblConJ1.Parent = ptbCanchaFormacion;
            lblConJ1.BackColor = Color.Transparent;
            lblConJ2.Parent = ptbCanchaFormacion;
            lblConJ2.BackColor = Color.Transparent;
            lblConJ3.Parent = ptbCanchaFormacion;
            lblConJ3.BackColor = Color.Transparent;
            lblConJ4.Parent = ptbCanchaFormacion;
            lblConJ4.BackColor = Color.Transparent;
            lblConJ5.Parent = ptbCanchaFormacion;
            lblConJ5.BackColor = Color.Transparent;
            lblConJ6.Parent = ptbCanchaFormacion;
            lblConJ6.BackColor = Color.Transparent;
            lblConJ7.Parent = ptbCanchaFormacion;
            lblConJ7.BackColor = Color.Transparent;
            lblConJ8.Parent = ptbCanchaFormacion;
            lblConJ8.BackColor = Color.Transparent;
            lblConJ9.Parent = ptbCanchaFormacion;
            lblConJ9.BackColor = Color.Transparent;
            lblConJ10.Parent = ptbCanchaFormacion;
            lblConJ10.BackColor = Color.Transparent;
            lblConJ11.Parent = ptbCanchaFormacion;
            lblConJ11.BackColor = Color.Transparent;

            rbtnJugador1.Parent = ptbCanchaFormacion;
            rbtnJugador1.BackColor = Color.Transparent;
            rbtnJugador2.Parent = ptbCanchaFormacion;
            rbtnJugador2.BackColor = Color.Transparent;
            rbtnJugador3.Parent = ptbCanchaFormacion;
            rbtnJugador3.BackColor = Color.Transparent;
            rbtnJugador4.Parent = ptbCanchaFormacion;
            rbtnJugador4.BackColor = Color.Transparent;
            rbtnJugador5.Parent = ptbCanchaFormacion;
            rbtnJugador5.BackColor = Color.Transparent;
            rbtnJugador6.Parent = ptbCanchaFormacion;
            rbtnJugador6.BackColor = Color.Transparent;
            rbtnJugador7.Parent = ptbCanchaFormacion;
            rbtnJugador7.BackColor = Color.Transparent;
            rbtnJugador8.Parent = ptbCanchaFormacion;
            rbtnJugador8.BackColor = Color.Transparent;
            rbtnJugador9.Parent = ptbCanchaFormacion;
            rbtnJugador9.BackColor = Color.Transparent;
            rbtnJugador10.Parent = ptbCanchaFormacion;
            rbtnJugador10.BackColor = Color.Transparent;
            rbtnJugador11.Parent = ptbCanchaFormacion;
            rbtnJugador11.BackColor = Color.Transparent;

        }
        public void CargarDatosFormacion()
        {
            string LeerForm = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosFormacion.json";

            using (StreamReader Entrada = new StreamReader(LeerForm))
            {
                string contenido = Entrada.ReadToEnd();

                TipoFor = JsonConvert.DeserializeObject<TipoFormacion>(contenido);
            }
        }
        
        private void Formacion_Load(object sender, EventArgs e)
        {
            CargarProcedencia();
            if (Proc.Procedencia == "PantallaPrincipal")
            {
                CargarUsuario();
                cbxCamiseta.SelectedIndex = 0;
                Transparencias();
                cbxTactica.SelectedItem = "5-4-1";
                CargoCapitan();
                CargoLanzadorFaltas();
            }
            else
            {
                LocalYvisitante();
                CargarDatosFormacion();

                CargarUsuario();
                Transparencias();
                CargoCapitan();
                CargoLanzadorFaltas();
                if (Usu.Equipo == TeamLocal)
                {
                    cbxCamiseta.SelectedItem = TipoFor.TipoCamisetaLocal;
                    cbxTactica.SelectedItem = TipoFor.TacticaLocal;
                    cbxTipoPresion.SelectedItem = TipoFor.TipoPresionLocal;
                    cbxActitudEquipo.SelectedItem = TipoFor.ActitudEquipoLocal;
                    cbxTipoAtaque.SelectedItem = TipoFor.TipoAtaqueLocal;
                    cbxCapitan.SelectedItem = TipoFor.NombreCapitanLocal;
                    cbxLanzadorFaltas.SelectedItem = TipoFor.NombreLanzadorFaltasLocal;
                }
                else
                {
                    cbxCamiseta.SelectedItem = TipoFor.TipoCamisetaVisitante;
                    cbxTactica.SelectedItem = TipoFor.TacticaVisitante;
                    cbxTipoPresion.SelectedItem = TipoFor.TipoPresionVisitante;
                    cbxActitudEquipo.SelectedItem = TipoFor.ActitudEquipoVisitante;
                    cbxTipoAtaque.SelectedItem = TipoFor.TipoAtaqueVisitante;
                    cbxCapitan.SelectedItem = TipoFor.NombreCapitanVisitante;
                    cbxLanzadorFaltas.SelectedItem = TipoFor.NombreLanzadorFaltasVisitante;
                }
            }
            if (Usu.Sponsor == "")
            {
                ptbSponsorFormacion1.Visible = false;
                ptbSponsorFormacion2.Visible = false;
                ptbSponsorFormacion3.Visible = false;
                ptbSponsorFormacion4.Visible = false;
            }
            else
            {
                //tengo que cargar el sponsor aca//
                ptbSponsorFormacion1.Visible = true;
                ptbSponsorFormacion2.Visible = true;
                ptbSponsorFormacion3.Visible = true;
                ptbSponsorFormacion4.Visible = true;
            }
        }
        public void CargoCapitan()
        {
            foreach (var item in Usu.ListaJugadorUsuario)
            {
                if (Usu.Equipo == item.EquipoActual)
                {
                    cbxCapitan.Items.Add(item.Nombre);
                }
            }
        }
        public void CargoLanzadorFaltas()
        {
            foreach (var item in Usu.ListaJugadorUsuario)
            {
                if (Usu.Equipo == item.EquipoActual)
                {
                    cbxLanzadorFaltas.Items.Add(item.Nombre);
                }
            }
        }
        Usuario Usu = new Usuario ();
        public void CargarUsuario()
        {
            string LeerTemp = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamReader Entrada = new StreamReader(LeerTemp))
            {
                string contenido = Entrada.ReadToEnd();

                Usu = JsonConvert.DeserializeObject<Usuario>(contenido);
            }
        }
        private void cbxCamiseta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCamiseta.SelectedItem.ToString() == "Suplente")
            {
                if (Usu.Equipo == "Aldosivi")
                {

                }
                if (Usu.Equipo == "Arsenal")
                {

                }
                if (Usu.Equipo == "Atlético Rafaela")
                {
                    ptbEscudoFormacion.Image = Image.FromFile("atlrafaela_arg.jpg");
                    ptbCamiseta1.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta2.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta3.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta4.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta5.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta6.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta7.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta8.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta9.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta10.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta11.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta12.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta13.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta14.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta15.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta16.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta17.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta18.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta19.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta20.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");
                    ptbCamiseta21.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_2.png");

                }
                if (Usu.Equipo == "Atlético Tucumán")
                {

                }
                if (Usu.Equipo == "Banfield")
                {
                }
                if (Usu.Equipo == "Belgrano")
                {
                }
                if (Usu.Equipo == "Boca Juniors")
                {
                }
                if (Usu.Equipo == "Colón")
                {
                }
                if (Usu.Equipo == "Defensa y Justicia")
                {
                }
                if (Usu.Equipo == "Estudiantes (LP)")
                {
                }
                if (Usu.Equipo == "Gimnasia (LP)")
                {
                }
                if (Usu.Equipo == "Godoy Cruz")
                {
                }
                if (Usu.Equipo == "Huracán")
                {
                }
                if (Usu.Equipo == "Independiente")
                {
                }
                if (Usu.Equipo == "Lanus")
                {
                }
                if (Usu.Equipo == "Newell's")
                {
                }
                if (Usu.Equipo == "Olimpo")
                {
                }
                if (Usu.Equipo == "Patronato")
                {
                }
                if (Usu.Equipo == "Quilmes")
                {
                }
                if (Usu.Equipo == "Racing Club")
                {
                }
                if (Usu.Equipo == "River Plate")
                {
                }
                if (Usu.Equipo == "Rosario Central")
                {
                }
                if (Usu.Equipo == "San Lorenzo")
                {
                }
                if (Usu.Equipo == "San Martín (SJ)")
                {
                }
                if (Usu.Equipo == "Sarmiento de Junín")
                {
                }
                if (Usu.Equipo == "Talleres")
                {
                }
                if (Usu.Equipo == "Temperley")
                {
                }
                if (Usu.Equipo == "Tigre")
                {
                }
                if (Usu.Equipo == "Unión")
                {
                }
                if (Usu.Equipo == "Velez Sarfield")
                {
                }
            }
            else
            {
                if (cbxCamiseta.SelectedItem.ToString() == "Titular")
                {
                    if (Usu.Equipo == "Aldosivi")
                    {

                    }
                    if (Usu.Equipo == "Arsenal")
                    {

                    }
                    if (Usu.Equipo == "Atlético Rafaela")
                    {
                        ptbEscudoFormacion.Image = Image.FromFile("atlrafaela_arg.jpg");
                        ptbCamiseta1.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta2.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta3.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta4.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta5.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta6.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta7.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta8.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta9.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta10.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta11.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta12.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta13.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta14.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta15.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta16.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta17.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta18.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta19.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta20.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");
                        ptbCamiseta21.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\atletico_rafaela_1.png");              
     
                    }
                    if (Usu.Equipo == "Atlético Tucumán")
                    {

                    }
                    if (Usu.Equipo == "Banfield")
                    {
                    }
                    if (Usu.Equipo == "Belgrano")
                    {
                    }
                    if (Usu.Equipo == "Boca Juniors")
                    {
                    }
                    if (Usu.Equipo == "Colón")
                    {
                    }
                    if (Usu.Equipo == "Defensa y Justicia")
                    {
                    }
                    if (Usu.Equipo == "Estudiantes (LP)")
                    {
                    }
                    if (Usu.Equipo == "Gimnasia (LP)")
                    {
                    }
                    if (Usu.Equipo == "Godoy Cruz")
                    {
                    }
                    if (Usu.Equipo == "Huracán")
                    {
                    }
                    if (Usu.Equipo == "Independiente")
                    {
                    }
                    if (Usu.Equipo == "Lanus")
                    {
                    }
                    if (Usu.Equipo == "Newell's")
                    {
                    }
                    if (Usu.Equipo == "Olimpo")
                    {
                    }
                    if (Usu.Equipo == "Patronato")
                    {
                    }
                    if (Usu.Equipo == "Quilmes")
                    {
                    }
                    if (Usu.Equipo == "Racing Club")
                    {
                    }
                    if (Usu.Equipo == "River Plate")
                    {
                    }
                    if (Usu.Equipo == "Rosario Central")
                    {
                    }
                    if (Usu.Equipo == "San Lorenzo")
                    {
                    }
                    if (Usu.Equipo == "San Martín (SJ)")
                    {
                    }
                    if (Usu.Equipo == "Sarmiento de Junín")
                    {
                    }
                    if (Usu.Equipo == "Talleres")
                    {
                    }
                    if (Usu.Equipo == "Temperley")
                    {
                    }
                    if (Usu.Equipo == "Tigre")
                    {
                    }
                    if (Usu.Equipo == "Unión")
                    {
                    }
                    if (Usu.Equipo == "Velez Sarfield")
                    {
                    }
                }               
            }
        }

        private void btnCerrarFormacion_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaPrincipal Pan = new PantallaPrincipal();
            Pan.Show();
        }
        public void GuardarArchivos()
        {
            string Archivo = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosFormacion.json";

            using (StreamWriter file = new StreamWriter(Archivo, false))
            {
                string Salida = JsonConvert.SerializeObject(TipoFor);
                file.Write(Salida);
            }
        
        }
        string TeamLocal;
        string TeamVisitante;
        public void LocalYvisitante()
        {           
            foreach (var item in Usu.ListaPartidosCalendario)
            {
                if (Usu.Equipo == item.EquipoLocal || Usu.Equipo == item.EquipoVisitante)
                {
                    if (item.Resultado == null)
                    {
                        TeamLocal = item.EquipoLocal;
                        TeamVisitante = item.EquipoVisitante;
                        break;
                    }
                }
            }
        }
        ProcedenciasFormacion Proc = new ProcedenciasFormacion();
        public void CargarProcedencia()
        {
            string path = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\ProcedenciaFormacion.json";

            using (StreamReader Entrada = new StreamReader(path))
            {
                string contenido = Entrada.ReadToEnd();

                Proc = JsonConvert.DeserializeObject<ProcedenciasFormacion>(contenido);
            }
        }
        TipoFormacion TipoFor = new TipoFormacion();
        private void btnJugarPartido_Click(object sender, EventArgs e)
        {
            if (Proc.Procedencia == "JugarPartido")
            {
                CargarDatosFormacion();
            }
            
            if (cbxCamiseta.SelectedIndex > -1 && cbxTactica.SelectedIndex > -1 && cbxTipoPresion.SelectedIndex > -1 && cbxActitudEquipo.SelectedIndex > -1 && cbxTipoAtaque.SelectedIndex > -1 && cbxCapitan.SelectedIndex > -1 && cbxLanzadorFaltas.SelectedIndex > -1)
            {
                Random Rdm = new Random();
                LocalYvisitante();

                if (Usu.Equipo == TeamLocal)
                {
                    TipoFor.EquipoLocal = Usu.Equipo;
                    TipoFor.TipoCamisetaLocal = cbxCamiseta.SelectedItem.ToString();
                    TipoFor.TacticaLocal = cbxTactica.SelectedItem.ToString();
                    TipoFor.TipoPresionLocal = cbxTipoPresion.SelectedItem.ToString();
                    TipoFor.ActitudEquipoLocal = cbxActitudEquipo.SelectedItem.ToString();
                    TipoFor.TipoAtaqueLocal = cbxTipoAtaque.SelectedItem.ToString();
                    TipoFor.NombreCapitanLocal = cbxCapitan.SelectedItem.ToString();
                    TipoFor.NombreLanzadorFaltasLocal = cbxLanzadorFaltas.SelectedItem.ToString();

                    TipoFor.EquipoVisitante = TeamVisitante;
                    TipoFor.TipoCamisetaVisitante = cbxCamiseta.Items[Rdm.Next(0, 1)].ToString();
                    TipoFor.TacticaVisitante = cbxTactica.Items[Rdm.Next(0, 8)].ToString();
                    TipoFor.TipoPresionVisitante = cbxTipoPresion.Items[Rdm.Next(0, 4)].ToString();
                    TipoFor.ActitudEquipoVisitante = cbxActitudEquipo.Items[Rdm.Next(0, 4)].ToString();
                    TipoFor.TipoAtaqueVisitante = cbxTipoAtaque.Items[Rdm.Next(0, 2)].ToString();
                    string NombreCapVis = ""; string NombreLanzVis = "";
                    int EdadCapVis = 0; int FuerzaLanzVis = 0;
                    int Cj = 0;
                    foreach (var item in Usu.ListaJugadorUsuario)
                    {
                        if (TeamVisitante == item.EquipoActual)
                        {
                            Cj += 1;
                            if (item.Edad > EdadCapVis)
                            {
                                NombreCapVis = item.Nombre;
                                EdadCapVis = item.Edad;
                            }
                            if (item.Fuerza > FuerzaLanzVis)
                            {
                                NombreLanzVis = item.Nombre;
                                FuerzaLanzVis = item.Fuerza;
                            }
                        }
                        if (Cj == 21)
                        {
                            break;
                        }
                    }
                    TipoFor.NombreCapitanVisitante = NombreCapVis;
                    TipoFor.NombreLanzadorFaltasVisitante = NombreLanzVis;
                }
                else
                {
                    TipoFor.EquipoLocal = TeamLocal;
                    TipoFor.TipoCamisetaLocal = cbxCamiseta.Items[Rdm.Next(0, 1)].ToString();
                    TipoFor.TacticaLocal = cbxTactica.Items[Rdm.Next(0, 8)].ToString();
                    TipoFor.TipoPresionLocal = cbxTipoPresion.Items[Rdm.Next(0, 4)].ToString();
                    TipoFor.ActitudEquipoLocal = cbxActitudEquipo.Items[Rdm.Next(0, 4)].ToString();
                    TipoFor.TipoAtaqueLocal = cbxTipoAtaque.Items[Rdm.Next(0, 2)].ToString();
                    string NombreCapLoc = ""; string NombreLanzLoc = "";
                    int EdadCapLoc = 0; int FuerzaLanzLoc = 0;
                    int Cj = 0;
                    foreach (var item in Usu.ListaJugadorUsuario)
                    {
                        if (TeamLocal == item.EquipoActual)
                        {
                            Cj += 1;
                            if (item.Edad > EdadCapLoc)
                            {
                                NombreCapLoc = item.Nombre;
                                EdadCapLoc = item.Edad;
                            }
                            if (item.Fuerza > FuerzaLanzLoc)
                            {
                                NombreLanzLoc = item.Nombre;
                                FuerzaLanzLoc = item.Fuerza;
                            }
                        }
                        if (Cj == 21)
                        {
                            break;
                        }
                    }
                    TipoFor.NombreCapitanLocal = NombreCapLoc;
                    TipoFor.NombreLanzadorFaltasLocal = NombreLanzLoc;

                    TipoFor.EquipoVisitante = Usu.Equipo;
                    TipoFor.TipoCamisetaVisitante = cbxCamiseta.SelectedItem.ToString();
                    TipoFor.TacticaVisitante = cbxTactica.SelectedItem.ToString();
                    TipoFor.TipoPresionVisitante = cbxTipoPresion.SelectedItem.ToString();
                    TipoFor.ActitudEquipoVisitante = cbxActitudEquipo.SelectedItem.ToString();
                    TipoFor.TipoAtaqueVisitante = cbxTipoAtaque.SelectedItem.ToString();
                    TipoFor.NombreCapitanVisitante = cbxCapitan.SelectedItem.ToString();
                    TipoFor.NombreLanzadorFaltasVisitante = cbxLanzadorFaltas.SelectedItem.ToString();
                }
                
                GuardarArchivos();

                Jugar_Partido Jugar = new Jugar_Partido();

                this.Close();
                CargarProcedencia();
                if (Proc.Procedencia == "PantallaPrincipal")
                {
                    Jugar.Show();
                }     
            }
            else
            {
                MessageBox.Show("¡Campos incompletos!", "Jugar partido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxTactica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTactica.SelectedItem == "5-4-1")
            {
                int VezA = 0;
                foreach (var item in Usu.ListaJugadorUsuario)
                {
                    if (item.EquipoActual == Usu.Equipo)
                    {
                        lblNombreDT.Text = Usu.NombreEntrenador;
                        if (item.Posicion == "ARQ")
                        {
                            if (VezA == 0)
                            {
                                VezA = 1;
                                lblNombreJ1.Text = item.Nombre;
                                lblPosJ1.Text = "ARQ";
                                lblConJ1.Text = Convert.ToString(item.Condicion);
                            }
                            else
                            {
                                lblNombreJ12.Text = item.Nombre;
                                lblPosJ12.Text = "ARQ";
                                lblConJ12.Text = Convert.ToString(item.Condicion);
                            }
                        }                 
                    }
                }
                int VezDF = 0;
                foreach (var item in Usu.ListaJugadorUsuario)
                {
                    if (item.EquipoActual == Usu.Equipo)
                    {
                        if (item.Posicion == "DEF")
                        {
                            if (VezDF == 0)
                            {
                                VezDF = 1;
                                lblNombreJ2.Text = item.Nombre;
                                lblPosJ2.Text = "DEF";
                                lblConJ2.Text = Convert.ToString(item.Condicion);
                            }
                            else
                            {
                                if (VezDF == 1)
                                {
                                    VezDF = 2;
                                    lblNombreJ3.Text = item.Nombre;
                                    lblPosJ3.Text = "DEF";
                                    lblConJ3.Text = Convert.ToString(item.Condicion); 
                                }
                                else
                                {
                                    if (VezDF == 2)
                                    {
                                        VezDF = 3;
                                        lblNombreJ4.Text = item.Nombre;
                                        lblPosJ4.Text = "DEF";
                                        lblConJ4.Text = Convert.ToString(item.Condicion);
                                    }
                                    else
                                    {
                                        if (VezDF == 3)
                                        {
                                            VezDF = 4;
                                            lblNombreJ5.Text = item.Nombre;
                                            lblPosJ5.Text = "DEF";
                                            lblConJ5.Text = Convert.ToString(item.Condicion);
                                        }
                                        else
                                        {
                                            if (VezDF == 4)
                                            {
                                                VezDF = 5;
                                                lblNombreJ6.Text = item.Nombre;
                                                lblPosJ6.Text = "DEF";
                                                lblConJ6.Text = Convert.ToString(item.Condicion);
                                            }
                                            else
                                            {
                                                 lblNombreJ13.Text = item.Nombre;
                                                 lblPosJ13.Text = "DEF";
                                                 lblConJ13.Text = Convert.ToString(item.Condicion);
                                                 break;              
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                int VezM = 0;
                foreach (var item in Usu.ListaJugadorUsuario)
                {
                    if (item.EquipoActual == Usu.Equipo)
                    {
                        lblNombreDT.Text = Usu.NombreEntrenador;
                        if (item.Posicion == "MED")
                        {
                            if (VezM == 0)
                            {
                                VezM = 1;
                                lblNombreJ7.Text = item.Nombre;
                                lblPosJ7.Text = "MED";
                                lblConJ7.Text = Convert.ToString(item.Condicion);
                            }
                            else
                            {
                                if (VezM == 1)
                                {
                                    VezM = 2;
                                    lblNombreJ8.Text = item.Nombre;
                                    lblPosJ8.Text = "MED";
                                    lblConJ8.Text = Convert.ToString(item.Condicion);
                                }
                                else
                                {
                                    if (VezM == 2)
                                    {
                                        VezM = 3;
                                        lblNombreJ14.Text = item.Nombre;
                                        lblPosJ14.Text = "MED";
                                        lblConJ14.Text = Convert.ToString(item.Condicion);      
                                    }
                                    else
                                    {
                                        if (VezM == 3)
                                        {
                                            VezM = 4;
                                            lblNombreJ15.Text = item.Nombre;
                                            lblPosJ15.Text = "MED";
                                            lblConJ15.Text = Convert.ToString(item.Condicion);
                                        }
                                        else
                                        {
                                            if (VezM == 4)
                                            {
                                                VezM = 5;
                                                lblNombreJ16.Text = item.Nombre;
                                                lblPosJ16.Text = "MED";
                                                lblConJ16.Text = Convert.ToString(item.Condicion);
                                            }
                                            else
                                            {
                                                VezM = 6;
                                                lblNombreJ17.Text = item.Nombre;
                                                lblPosJ17.Text = "MED";
                                                lblConJ17.Text = Convert.ToString(item.Condicion);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                int VezVol = 0;
                foreach (var item in Usu.ListaJugadorUsuario)
                {
                    if (item.EquipoActual == Usu.Equipo)
                    {
                        lblNombreDT.Text = Usu.NombreEntrenador;
                        if (item.Posicion == "VOL")
                        {
                            if (VezVol == 0)
                            {
                                VezVol = 1;
                                lblNombreJ9.Text = item.Nombre;
                                lblPosJ9.Text = "VOL";
                                lblConJ9.Text = Convert.ToString(item.Condicion);
                            }
                            else
                            {
                                if (VezVol == 1)
                                {
                                    VezVol = 2;
                                    lblNombreJ10.Text = item.Nombre;
                                    lblPosJ10.Text = "VOL";
                                    lblConJ10.Text = Convert.ToString(item.Condicion);
                                }
                                else
                                {
                                    VezVol = 3;
                                    lblNombreJ18.Text = item.Nombre;
                                    lblPosJ18.Text = "VOL";
                                    lblConJ18.Text = Convert.ToString(item.Condicion);
                                    break;
                                }
                            }
                        }
                    }
                }
                int VezDel = 0;
                foreach (var item in Usu.ListaJugadorUsuario)
                {
                    if (item.EquipoActual == Usu.Equipo)
                    {
                        lblNombreDT.Text = Usu.NombreEntrenador;
                        if (item.Posicion == "DEL")
                        {
                            if (VezDel == 0)
                            {
                                VezDel = 1;
                                lblNombreJ11.Text = item.Nombre;
                                lblPosJ11.Text = "DEL";
                                lblConJ11.Text = Convert.ToString(item.Condicion);
                            }
                            else
                            {
                                if (VezDel == 1)
                                {
                                    VezDel = 2;
                                    lblNombreJ19.Text = item.Nombre;
                                    lblPosJ19.Text = "DEL";
                                    lblConJ19.Text = Convert.ToString(item.Condicion);
                                }
                                else
                                {
                                    if (VezDel == 2)
                                    {
                                        VezDel = 3;
                                        lblNombreJ20.Text = item.Nombre;
                                        lblPosJ20.Text = "DEL";
                                        lblConJ20.Text = Convert.ToString(item.Condicion);
                                    }
                                    else
                                    {
                                        if (VezDel == 3)
                                        {
                                            VezDel = 4;
                                            lblNombreJ21.Text = item.Nombre;
                                            lblPosJ21.Text = "DEL";
                                            lblConJ21.Text = Convert.ToString(item.Condicion);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                ptbCamiseta1.Location = new Point(136, 226);
                ptbCamiseta2.Location = new Point(407, 53);
                ptbCamiseta3.Location = new Point(322,110);
                ptbCamiseta4.Location = new Point(322,226);
                ptbCamiseta5.Location = new Point(322,348);
                ptbCamiseta6.Location = new Point(407,402);
                ptbCamiseta7.Location = new Point(525,143);
                ptbCamiseta8.Location = new Point(525,314);
                ptbCamiseta9.Location = new Point(635,40);
                ptbCamiseta10.Location = new Point(635,407);
                ptbCamiseta11.Location = new Point(845,226);
                lblNombreJ1.Location = new Point(141,296);
                lblNombreJ2.Location = new Point(406, 123);
                lblNombreJ3.Location = new Point(320, 180);
                lblNombreJ4.Location = new Point(320, 296);
                lblNombreJ5.Location = new Point(320, 418);
                lblNombreJ6.Location = new Point(407, 472);
                lblNombreJ7.Location = new Point(525, 213);
                lblNombreJ8.Location = new Point(527, 384);
                lblNombreJ9.Location = new Point(636, 110);
                lblNombreJ10.Location = new Point(636, 477);
                lblNombreJ11.Location = new Point(845, 296);
                lblPosJ1.Location = new Point(152, 311);
                lblPosJ2.Location = new Point(416, 138);
                lblPosJ3.Location = new Point(329, 196);
                lblPosJ4.Location = new Point(329, 311);
                lblPosJ5.Location = new Point(329, 433);
                lblPosJ6.Location = new Point(417, 487);
                lblPosJ7.Location = new Point(536, 228);
                lblPosJ8.Location = new Point(536, 399);
                lblPosJ9.Location = new Point(648, 125);
                lblPosJ10.Location = new Point(648, 492);
                lblPosJ11.Location = new Point(856, 311);
                lblConJ1.Location = new Point(152, 326);
                lblConJ2.Location = new Point(415, 153);
                lblConJ3.Location = new Point(329, 210);
                lblConJ4.Location = new Point(329, 326);
                lblConJ5.Location = new Point(329, 448);
                lblConJ6.Location = new Point(416, 503);
                lblConJ7.Location = new Point(536, 243);
                lblConJ8.Location = new Point(536, 414);
                lblConJ9.Location = new Point(648, 140);
                lblConJ10.Location = new Point(647, 507);
                lblConJ11.Location = new Point(856, 326);
            }
        }

        private void btnRealizarCambio_Click(object sender, EventArgs e)
        {
            if (rbtnJugador1.Checked||rbtnJugador2.Checked||rbtnJugador3.Checked||rbtnJugador4.Checked||rbtnJugador5.Checked||rbtnJugador6.Checked||rbtnJugador7.Checked||rbtnJugador8.Checked||rbtnJugador9.Checked||rbtnJugador10.Checked||rbtnJugador11.Checked)
            {
                if (rbtnJugador12.Checked||rbtnJugador13.Checked||rbtnJugador14.Checked||rbtnJugador15.Checked||rbtnJugador16.Checked||rbtnJugador17.Checked||rbtnJugador18.Checked||rbtnJugador19.Checked||rbtnJugador20.Checked||rbtnJugador21.Checked)
                {
                    if (cbxTactica.SelectedItem.ToString() == "5-4-1")
                    {
                        if (rbtnJugador1.Checked && rbtnJugador12.Checked)
                        {
                            MessageBox.Show("¡Cambio Realizado!", "Realizar Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Solo se pueden sustituír jugadores de una misma posición", "Realizar Cambio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (rbtnJugador2.Checked || rbtnJugador3.Checked || rbtnJugador4.Checked || rbtnJugador5.Checked || rbtnJugador6.Checked)
                        {
                            if (rbtnJugador13.Checked)
                            {
                                MessageBox.Show("¡Cambio Realizado!", "Realizar Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);                               
                            }
                            else
                            {
                                MessageBox.Show("Solo se pueden sustituír jugadores de una misma posición", "Realizar Cambio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }  
            }
        }

        private void ptbCanchaFormacion_Click(object sender, EventArgs e)
        {

        }
    }
    class TipoFormacion
    {
        public string EquipoLocal { get; set; }
        public string TacticaLocal { get; set; }
        public string TipoCamisetaLocal { get; set; }
        public string TipoPresionLocal { get; set; }
        public string ActitudEquipoLocal { get; set; }
        public string TipoAtaqueLocal { get; set; }
        public string NombreCapitanLocal { get; set; }
        public string NombreLanzadorFaltasLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public string TacticaVisitante { get; set; }
        public string TipoCamisetaVisitante { get; set; }
        public string TipoPresionVisitante { get; set; }
        public string ActitudEquipoVisitante { get; set; }
        public string TipoAtaqueVisitante { get; set; }
        public string NombreCapitanVisitante { get; set; }
        public string NombreLanzadorFaltasVisitante { get; set; }
    }
}
