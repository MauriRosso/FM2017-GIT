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
using System.Media;

namespace Football_Manager_2016
{
    public partial class Jugar_Partido : Form
    {
        public Jugar_Partido()
        {
            InitializeComponent();
        }
        public void BotonesActivos()
        {
            btnComenzarPartido.Enabled = true;
            btnRealizarCambios.Enabled = false;
            btnAbandonarPartido.Enabled = false;

        }
        public void InicializoLeyenda()
        {
            int F;
            F = GrillaLeyendasPartido.Rows.Add();
            GrillaLeyendasPartido.Rows[F].Cells[0].Value = "-";
            GrillaLeyendasPartido.Rows[F].Cells[1].Value = "El partido está por comenzar..";
        }
        int TS;
        int TM;
        TipoFormacion TipFor = new TipoFormacion();
        public void CargarArchivoFormacion()
        {
            string LeerDatos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosFormacion.json";

            using (StreamReader Entrada = new StreamReader(LeerDatos))
            {
                string contenido = Entrada.ReadToEnd();

                TipFor = JsonConvert.DeserializeObject<TipoFormacion>(contenido);
            }
        }
        private void Jugar_Partido_Load(object sender, EventArgs e)
        {
            TS = 0;
            TM = 0;
            lblJugarMilisegundos.Text = "0" + TM.ToString();
            lblJugarSegundos.Text = "0" + TS.ToString();
            CargarArchivosUsuario();
            CargarUsuario();
            CargarDatosEquipos();
            CargarMarcador();
            CargarEquiposMarcador();
            Transparencias();
            BotonesActivos();
            InicializoLeyenda();
            CargarAyudanteCampo();
        }
        public void CargarAyudanteCampo()
        {
            if (Usu.AyudanteCampo == null)
            {
                GrillaAyudante.Visible = false;
            }
            else
            {
                ptbNoContratado.Visible = false;
                lblNoContratado.Visible = false;
            }
        }
        public void Transparencias()
        {
            lblJugarEquipoLocal.Parent = ptbFondoJugar;
            lblJugarEquipoLocal.BackColor = Color.Transparent;
            lblJugarEquipoVisitante.Parent = ptbFondoJugar;
            lblJugarEquipoVisitante.BackColor = Color.Transparent;
            lblJugarGolesLocal.Parent = ptbFondoJugar;
            lblJugarGolesLocal.BackColor = Color.Transparent;
            lblJugarGolesVisitante.Parent = ptbFondoJugar;
            lblJugarGolesVisitante.BackColor = Color.Transparent;
            lblJugarSegundos.Parent = ptbFondoJugar;
            lblJugarSegundos.BackColor = Color.Transparent;
            lblJugarMilisegundos.Parent = ptbFondoJugar;
            lblJugarMilisegundos.BackColor = Color.Transparent;
            lblJugarParte.Parent = ptbFondoJugar;
            lblJugarParte.BackColor = Color.Transparent;
            ptbEscudoTopLocal.Parent = ptbFondoJugar;
            ptbEscudoTopLocal.BackColor = Color.Transparent;
            ptbEscudoTopVisitante.Parent = ptbFondoJugar;
            ptbEscudoTopVisitante.BackColor = Color.Transparent;
            lblTituloEquipoLocal.Parent = ptbFondoJugar;
            lblTituloEquipoLocal.BackColor = Color.Transparent;
            lblTituloEquipoVisitante.Parent = ptbFondoJugar;
            lblTituloEquipoVisitante.BackColor = Color.Transparent;
            lblJornadaJugarPartido.Parent = ptbFondoJugar;
            lblJornadaJugarPartido.BackColor = Color.Transparent;
            lblDivisionJugarPartido.Parent = ptbFondoJugar;
            lblDivisionJugarPartido.BackColor = Color.Transparent;
            lblFechaJornada.Parent = ptbFondoJugar;
            lblFechaJornada.BackColor = Color.Transparent;
        }
        ListaUsuario Lista = new ListaUsuario();
        Usuario Usu = new Usuario();
        Equipos Equ = new Equipos();
        public void CargarArchivosUsuario()
        {
            string LeerDatos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosUsuarios.json";

            using (StreamReader Entrada = new StreamReader(LeerDatos))
            {
                string contenido = Entrada.ReadToEnd();

                Lista.LU = JsonConvert.DeserializeObject<List<Usuario>>(contenido);
            }
        }
        public void CargarDatosEquipos()
        {
            string LeerDatos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosEquipos.json";

            using (StreamReader Entrada = new StreamReader(LeerDatos))
            {
                string contenido = Entrada.ReadToEnd();

                Equ.ListaEquipos = JsonConvert.DeserializeObject<List<PropiedadesEquipos>>(contenido);
            }
        }
        public void CargarUsuario()
        {
            string LeerTemp = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamReader Entrada = new StreamReader(LeerTemp))
            {
                string contenido = Entrada.ReadToEnd();

                Usu = JsonConvert.DeserializeObject<Usuario>(contenido);
            }
        }

        public void CargarMarcador()
        {
            foreach (var item in Usu.ListaPartidosCalendario)
            {
                if (Usu.Equipo == item.EquipoLocal || Usu.Equipo == item.EquipoVisitante)
                {
                    if (item.Resultado == null)
                    {
                        lblJugarEquipoLocal.Text = item.EquipoLocal;
                        TeamLocal = item.EquipoLocal;
                        TeamVisitante = item.EquipoVisitante;
                        lblJugarEquipoVisitante.Text = item.EquipoVisitante;
                        lblJugarGolesLocal.Text = Convert.ToString(0);
                        lblJugarGolesVisitante.Text = Convert.ToString(0);
                        lblJugarParte.Text = "PT";
                        lblDivisionJugarPartido.Text = "Primera División";
                        lblJornadaJugarPartido.Text = Convert.ToString(item.Jornada);
                        lblTituloEquipoLocal.Text = item.EquipoLocal;
                        lblTituloEquipoVisitante.Text = item.EquipoVisitante;
                        break;
                    }
                }
            }
        }
        string TeamLocal = "";
        string TeamVisitante = "";
        public void CargarEquiposMarcador()
        {

            if (lblJugarEquipoLocal.Text == "Aldosivi")
            {

            }
            if (lblJugarEquipoLocal.Text == "Arsenal")
            {

            }
            if (lblJugarEquipoLocal.Text == "Atlético Rafaela")
            {
                ptbColorLocal.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\ColoresMarcador\atletico_rafaela1.PNG");
                lblJugarEquipoLocal.Text = "RAF";
                ptbEscudoTopLocal.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\Atletico_Rafaela.png");

            }
            else
            {
                if (lblJugarEquipoVisitante.Text == "Atlético Rafaela")
                {
                    ptbColorVisitante.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\ColoresMarcador\atletico_rafaela1.PNG");
                    lblJugarEquipoVisitante.Text = "RAF";
                    ptbEscudoTopVisitante.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Rafaela\Atletico_Rafaela.png");
                }
            }
            if (lblJugarEquipoLocal.Text == "Atlético Tucumán")
            {
                ptbColorLocal.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\ColoresMarcador\atletico_tucuman1.PNG");
                lblJugarEquipoLocal.Text = "ATU";
                ptbEscudoTopLocal.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Tucuman\Atletico_Tucuman.png");
            }
            else
            {
                if (lblJugarEquipoVisitante.Text == "Atlético Tucumán")
                {
                    ptbColorVisitante.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\ColoresMarcador\atletico_tucuman2.PNG");
                    lblJugarEquipoVisitante.Text = "ATU";
                    ptbEscudoTopVisitante.Image = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Casacas FM2016\Atletico Tucuman\Atletico_Tucuman.png");
                }
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
        public double CalcularFuerzaLocal()
        {
            double FuerzaLocal;
            int SumaL = 0;
            int CantL = 0;
            foreach (var item in Usu.ListaJugadorUsuario)
            {
                if (TeamLocal == item.EquipoActual)
                {
                    SumaL += item.Fuerza;
                    CantL += 1;
                }
                if (CantL == 21)
                {
                    break;
                }
            }
            FuerzaLocal = SumaL / 21;
            return FuerzaLocal;
        }
        public double CalcularFuerzaVisitante()
        {
            double FuerzaVisitante;
            int SumaV = 0;
            int CantV = 0;

            foreach (var item in Usu.ListaJugadorUsuario)
            {
                if (TeamVisitante == item.EquipoActual)
                {
                    SumaV += item.Fuerza;
                    CantV += 1;
                }
                if (CantV == 21)
                {
                    break;
                }
            }
            FuerzaVisitante = SumaV / 21;
            return FuerzaVisitante;
        }
        SoundPlayer GolLocal = new SoundPlayer(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Sonidos\GolLocal.wav");
        public int GolAleatorioFuerza(int Fi)
        {
            Random Ran = new Random();
            int GolesLocal = 0;
            int GolesVisitante = 0;
            int RandomLocal = 0;
            int RandomVisitante = 0;
            int RandomGeneral = 0;
            double FzaLocal = CalcularFuerzaLocal();
            double FzaVisitante = CalcularFuerzaVisitante();

            if (FzaVisitante >= 70)
            {
                RandomVisitante = Ran.Next(0, 10);
            }
            else
            {
                if (FzaVisitante > 67 && FzaVisitante <= 70)
                {
                    RandomVisitante = Ran.Next(0, 20);
                }
                else
                {
                    if (FzaVisitante > 65 && FzaVisitante <= 67)
                    {
                        RandomVisitante = Ran.Next(0, 30);
                    }
                    else
                    {
                        if (FzaVisitante > 63 && FzaVisitante <= 65)
                        {
                            RandomVisitante = Ran.Next(0, 40);
                        }
                        else
                        {
                            if (FzaVisitante > 60 && FzaVisitante <= 63)
                            {
                                RandomVisitante = Ran.Next(0, 50);
                            }
                            else
                            {
                                if (FzaVisitante > 57 && FzaVisitante <= 60)
                                {
                                    RandomVisitante = Ran.Next(0, 60);
                                }
                                else
                                {
                                    if (FzaVisitante <= 57)
                                    {
                                        RandomVisitante = Ran.Next(0, 70);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (FzaLocal >= 70)
            {
                RandomLocal = Ran.Next(0, 10);
            }
            else
            {
                if (FzaLocal > 67 && FzaLocal <= 70)
                {
                    RandomLocal = Ran.Next(0, 20);
                }
                else
                {
                    if (FzaLocal > 65 && FzaLocal <= 67)
                    {
                        RandomLocal = Ran.Next(0, 30);
                    }
                    else
                    {
                        if (FzaLocal > 63 && FzaLocal <= 65)
                        {
                            RandomLocal = Ran.Next(0, 40);
                        }
                        else
                        {
                            if (FzaLocal > 60 && FzaLocal <= 63)
                            {
                                RandomLocal = Ran.Next(0, 50);
                            }
                            else
                            {
                                if (FzaLocal > 57 && FzaLocal <= 60)
                                {
                                    RandomLocal = Ran.Next(0, 60);
                                }
                                else
                                {
                                    if (FzaLocal <= 57)
                                    {
                                        RandomLocal = Ran.Next(0, 70);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            RandomGeneral = Ran.Next(10);
            if (RandomGeneral == RandomVisitante)
            {

                GolesVisitante += Convert.ToInt32(lblJugarGolesVisitante.Text) + 1;
                lblJugarGolesVisitante.Text = GolesVisitante.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamVisitante + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }
            //este parrafo de abajo desmarque, estaba en comentarios
            if (RandomGeneral == RandomLocal)
            {
                GolesLocal += Convert.ToInt32(lblJugarGolesLocal.Text) + 1;
                lblJugarGolesLocal.Text = GolesLocal.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamLocal + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }

            return Fi;
        }
        public int GolAleatorioTactica(int Fi)
        {
            int GolesVisitante = 0;
            int GolesLocal = 0;
            Random Ran = new Random();

            int RdmLocalFavor; int RdmVisitanteFavor;
            int RdmLocalContra; int RdmVisitanteContra;

            if (TipFor.TacticaVisitante == "5-4-1")
            {
                RdmVisitanteFavor = Ran.Next(0, 15);
                RdmVisitanteContra = Ran.Next(0, 15);
            }
            else
            {
                if (TipFor.TacticaVisitante == "5-3-2")
                {
                    RdmVisitanteFavor = Ran.Next(0, 12);
                    RdmVisitanteContra = Ran.Next(0, 12);
                }
                else
                {
                    if (TipFor.TacticaVisitante == "4-5-1")
                    {
                        RdmVisitanteFavor = Ran.Next(0, 13);
                        RdmVisitanteContra = Ran.Next(0, 13);
                    }
                    else
                    {
                        if (TipFor.TacticaVisitante == "4-4-2(A)")
                        {
                            RdmVisitanteFavor = Ran.Next(0, 10);
                            RdmVisitanteContra = Ran.Next(0, 10);
                        }
                        else
                        {
                            if (TipFor.TacticaVisitante == "4-4-2(B)")
                            {
                                RdmVisitanteFavor = Ran.Next(0, 8);
                                RdmVisitanteContra = Ran.Next(0, 8);
                            }
                            else
                            {
                                if (TipFor.TacticaVisitante == "4-3-3(A)")
                                {
                                    RdmVisitanteFavor = Ran.Next(0, 11);
                                    RdmVisitanteContra = Ran.Next(0, 11);
                                }
                                else
                                {
                                    if (TipFor.TacticaVisitante == "4-3-3(B)")
                                    {
                                        RdmVisitanteFavor = Ran.Next(0, 7);
                                        RdmVisitanteContra = Ran.Next(0, 7);
                                    }
                                    else
                                    {
                                        if (TipFor.TacticaVisitante == "3-5-2")
                                        {
                                            RdmVisitanteFavor = Ran.Next(0, 9);
                                            RdmVisitanteContra = Ran.Next(0, 9);
                                        }
                                        else //3-4-3
                                        {
                                            RdmVisitanteFavor = Ran.Next(0, 7);
                                            RdmVisitanteContra = Ran.Next(0, 7);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (TipFor.TacticaLocal == "5-4-1")
            {
                RdmLocalFavor = Ran.Next(0, 15);
                RdmLocalContra = Ran.Next(0, 15);
            }
            else
            {
                if (TipFor.TacticaLocal == "5-3-2")
                {
                    RdmLocalFavor = Ran.Next(0, 12);
                    RdmLocalContra = Ran.Next(0, 12);
                }
                else
                {
                    if (TipFor.TacticaLocal == "4-5-1")
                    {
                        RdmLocalFavor = Ran.Next(0, 13);
                        RdmLocalContra = Ran.Next(0, 13);
                    }
                    else
                    {
                        if (TipFor.TacticaLocal == "4-4-2(A)")
                        {
                            RdmLocalFavor = Ran.Next(0, 10);
                            RdmLocalContra = Ran.Next(0, 10);
                        }
                        else
                        {
                            if (TipFor.TacticaLocal == "4-4-2(B)")
                            {
                                RdmLocalFavor = Ran.Next(0, 8);
                                RdmLocalContra = Ran.Next(0, 8);
                            }
                            else
                            {
                                if (TipFor.TacticaLocal == "4-3-3(A)")
                                {
                                    RdmLocalFavor = Ran.Next(0, 11);
                                    RdmLocalContra = Ran.Next(0, 11);
                                }
                                else
                                {
                                    if (TipFor.TacticaLocal == "4-3-3(B)")
                                    {
                                        RdmLocalFavor = Ran.Next(0, 7);
                                        RdmLocalContra = Ran.Next(0, 7);
                                    }
                                    else
                                    {
                                        if (TipFor.TacticaLocal == "3-5-2")
                                        {
                                            RdmLocalFavor = Ran.Next(0, 9);
                                            RdmLocalContra = Ran.Next(0, 9);
                                        }
                                        else //3-4-3
                                        {
                                            RdmLocalFavor = Ran.Next(0, 7);
                                            RdmLocalContra = Ran.Next(0, 7);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            int RandomGeneral = Ran.Next(7);
            if (RandomGeneral == RdmVisitanteFavor)
            {
                GolesVisitante += Convert.ToInt32(lblJugarGolesVisitante.Text) + 1;
                lblJugarGolesVisitante.Text = GolesVisitante.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamVisitante + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }
            if (RandomGeneral == RdmVisitanteContra)
            {
                GolesLocal += Convert.ToInt32(lblJugarGolesLocal.Text) + 1;
                lblJugarGolesLocal.Text = GolesLocal.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamLocal + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
                //SonidoGOlLocal
                GolLocal.Play();

            }
            //este parrafo de abajo desmarque, estaba en comentarios

            if (RandomGeneral == RdmLocalFavor)
            {
                GolesLocal += Convert.ToInt32(lblJugarGolesLocal.Text) + 1;
                lblJugarGolesLocal.Text = GolesLocal.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamLocal + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }
            if (RandomGeneral == RdmLocalContra)
            {
                GolesVisitante += Convert.ToInt32(lblJugarGolesVisitante.Text) + 1;
                lblJugarGolesVisitante.Text = GolesVisitante.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamVisitante + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }
            return Fi;
        }
        public int GolAleatorioPresion(int Fi)
        {
            int GolesVisitante = 0;
            int GolesLocal = 0;
            Random Ran = new Random();
            int RdmLocalFavor; int RdmVisitanteFavor;
            int RdmLocalContra; int RdmVisitanteContra;

            if (TipFor.TipoPresionVisitante == "Muy suave")
            {
                RdmVisitanteFavor = Ran.Next(15);
                RdmVisitanteContra = Ran.Next(15);
            }
            else
            {
                if (TipFor.TipoPresionVisitante == "Suave")
                {
                    RdmVisitanteFavor = Ran.Next(12);
                    RdmVisitanteContra = Ran.Next(12);
                }
                else
                {
                    if (TipFor.TipoPresionVisitante == "Equilibrada")
                    {
                        RdmVisitanteFavor = Ran.Next(10);
                        RdmVisitanteContra = Ran.Next(10);
                    }
                    else
                    {
                        if (TipFor.TipoPresionVisitante == "Fuerte")
                        {
                            RdmVisitanteFavor = Ran.Next(8);
                            RdmVisitanteContra = Ran.Next(8);
                        }
                        else //Muy fuerte
                        {
                            RdmVisitanteFavor = Ran.Next(5);
                            RdmVisitanteContra = Ran.Next(5);
                        }
                    }
                }
            }
            if (TipFor.TipoPresionLocal == "Muy suave")
            {
                RdmLocalFavor = Ran.Next(15);
                RdmLocalContra = Ran.Next(15);
            }
            else
            {
                if (TipFor.TipoPresionLocal == "Suave")
                {
                    RdmLocalFavor = Ran.Next(12);
                    RdmLocalContra = Ran.Next(12);
                }
                else
                {
                    if (TipFor.TipoPresionLocal == "Equilibrada")
                    {
                        RdmLocalFavor = Ran.Next(10);
                        RdmLocalContra = Ran.Next(10);
                    }
                    else
                    {
                        if (TipFor.TipoPresionLocal == "Fuerte")
                        {
                            RdmLocalFavor = Ran.Next(8);
                            RdmLocalContra = Ran.Next(8);
                        }
                        else //Muy fuerte
                        {
                            RdmLocalFavor = Ran.Next(5);
                            RdmLocalContra = Ran.Next(5);
                        }
                    }
                }
            }
            int RandomGeneral = Ran.Next(5);
            if (RandomGeneral == RdmVisitanteFavor)
            {
                GolesVisitante += Convert.ToInt32(lblJugarGolesVisitante.Text) + 1;
                lblJugarGolesVisitante.Text = GolesVisitante.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamVisitante + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }
            if (RandomGeneral == RdmVisitanteContra)
            {
                GolesLocal += Convert.ToInt32(lblJugarGolesLocal.Text) + 1;
                lblJugarGolesLocal.Text = GolesLocal.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamLocal + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;

                GolLocal.Play();
            }
            //este parrafo de abajo desmarque, estaba en comentarios

            if (RandomGeneral == RdmLocalFavor)
            {
                GolesLocal += Convert.ToInt32(lblJugarGolesLocal.Text) + 1;
                lblJugarGolesLocal.Text = GolesLocal.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamLocal + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }
            if (RandomGeneral == RdmLocalContra)
            {
                GolesVisitante += Convert.ToInt32(lblJugarGolesVisitante.Text) + 1;
                lblJugarGolesVisitante.Text = GolesVisitante.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamVisitante + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }
            return Fi;
        }
        public int GolAleatorioActitud(int Fi)
        {
            int GolesVisitante = 0;
            int GolesLocal = 0;
            Random Ran = new Random();
            int RdmLocalFavor; int RdmVisitanteFavor;
            int RdmLocalContra; int RdmVisitanteContra;

            if (TipFor.ActitudEquipoVisitante == "Muy defensiva")
            {
                RdmVisitanteFavor = Ran.Next(15);
                RdmVisitanteContra = Ran.Next(15);
            }
            else
            {
                if (TipFor.ActitudEquipoVisitante == "Defensiva")
                {
                    RdmVisitanteFavor = Ran.Next(12);
                    RdmVisitanteContra = Ran.Next(12);
                }
                else
                {
                    if (TipFor.ActitudEquipoVisitante == "Equilibrada")
                    {
                        RdmVisitanteFavor = Ran.Next(10);
                        RdmVisitanteContra = Ran.Next(10);
                    }
                    else
                    {
                        if (TipFor.ActitudEquipoVisitante == "Ofensiva")
                        {
                            RdmVisitanteFavor = Ran.Next(8);
                            RdmVisitanteContra = Ran.Next(8);
                        }
                        else //Muy ofensiva
                        {
                            RdmVisitanteFavor = Ran.Next(5);
                            RdmVisitanteContra = Ran.Next(5);
                        }
                    }
                }
            }
            if (TipFor.ActitudEquipoLocal == "Muy defensiva")
            {
                RdmLocalFavor = Ran.Next(15);
                RdmLocalContra = Ran.Next(15);
            }
            else
            {
                if (TipFor.ActitudEquipoLocal == "Defensiva")
                {
                    RdmLocalFavor = Ran.Next(12);
                    RdmLocalContra = Ran.Next(12);
                }
                else
                {
                    if (TipFor.ActitudEquipoLocal == "Equilibrada")
                    {
                        RdmLocalFavor = Ran.Next(10);
                        RdmLocalContra = Ran.Next(10);
                    }
                    else
                    {
                        if (TipFor.ActitudEquipoLocal == "Ofensiva")
                        {
                            RdmLocalFavor = Ran.Next(8);
                            RdmLocalContra = Ran.Next(8);
                        }
                        else //Muy ofensiva
                        {
                            RdmLocalFavor = Ran.Next(5);
                            RdmLocalContra = Ran.Next(5);
                        }
                    }
                }
            }
            int RandomGeneral = Ran.Next(5);
            if (RandomGeneral == RdmVisitanteFavor)
            {
                GolesVisitante += Convert.ToInt32(lblJugarGolesVisitante.Text) + 1;
                lblJugarGolesVisitante.Text = GolesVisitante.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamVisitante + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }
            if (RandomGeneral == RdmVisitanteContra)
            {
                GolesLocal += Convert.ToInt32(lblJugarGolesLocal.Text) + 1;
                lblJugarGolesLocal.Text = GolesLocal.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamLocal + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;

                GolLocal.Play();
            }
            //este parrafo de abajo desmarque, estaba en comentarios

            if (RandomGeneral == RdmLocalFavor)
            {
                GolesLocal += Convert.ToInt32(lblJugarGolesLocal.Text) + 1;
                lblJugarGolesLocal.Text = GolesLocal.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamLocal + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }
            if (RandomGeneral == RdmLocalContra)
            {
                GolesVisitante += Convert.ToInt32(lblJugarGolesVisitante.Text) + 1;
                lblJugarGolesVisitante.Text = GolesVisitante.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamVisitante + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }
            return Fi;
        }
        public int GolAleatorioAtaque(int Fi)
        {
            int GolesVisitante = 0;
            int GolesLocal = 0;
            Random Ran = new Random();
            int RdmLocalFavor; int RdmVisitanteFavor;

            if (TipFor.TipoAtaqueVisitante != TipFor.TipoAtaqueLocal)
            {
                RdmVisitanteFavor = Ran.Next(8);
                RdmLocalFavor = Ran.Next(8);
            }
            else
            {
                RdmVisitanteFavor = Ran.Next(15);
                RdmLocalFavor = Ran.Next(15);
            }
            int RandomGeneral = Ran.Next(8);
            if (RandomGeneral == RdmVisitanteFavor)
            {
                GolesVisitante += Convert.ToInt32(lblJugarGolesVisitante.Text) + 1;
                lblJugarGolesVisitante.Text = GolesVisitante.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamVisitante + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }
            //este parrafo de abajo desmarque, estaba en comentarios

            if (RandomGeneral == RdmLocalFavor)
            {
                GolesLocal += Convert.ToInt32(lblJugarGolesLocal.Text) + 1;
                lblJugarGolesLocal.Text = GolesLocal.ToString();

                Fi = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[Fi].Cells[0].Value = TS.ToString() + "'";
                GrillaLeyendasPartido.Rows[Fi].Cells[1].Value = "¡Gol de " + TeamLocal + "!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }
            return Fi;
        }
        private void btnComenzarPartido_Click(object sender, EventArgs e)
        {
            TiempoMarcador.Enabled = true;
            btnRealizarCambios.Enabled = true;
            btnAbandonarPartido.Enabled = true;
            CargarArchivoFormacion();
        }
        ProcedenciasFormacion Proc = new ProcedenciasFormacion();
        public void GuardarProcedencia()
        {
            string path = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\ProcedenciaFormacion.json";

            using (StreamWriter file = new StreamWriter(path, false))
            {
                string Salida = JsonConvert.SerializeObject(Proc);
                file.Write(Salida);
            }
        }
        private void btnRealizarCambios_Click(object sender, EventArgs e)
        {
            TiempoMarcador.Stop();
            btnComenzarPartido.Text = "Reanudar Partido";
            if (TM <= 9)
            {
                lblJugarMilisegundos.Text = "0" + TM.ToString();
            }
            else
            {
                lblJugarMilisegundos.Text = TM.ToString();
            }
            if (TS <= 9)
            {
                lblJugarSegundos.Text = "0" + TS.ToString();
            }
            else
            {
                lblJugarSegundos.Text = TS.ToString();
            }
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Formacion))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Formacion Forma = new Formacion();
                Proc.Procedencia = "JugarPartido";
                GuardarProcedencia();
                Forma.Show();
            }

        }
        int F;
        int MaxGoles;
        int PriGol;
        int SegGol;
        int TerGol;
        int CuaGol;
        int Temporal;
        int Ban;
        Registros Reg = new Registros();
        public void GuardarRegistroPartido()
        {
            string path = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\RegistroPartido.json";

            using (StreamWriter file = new StreamWriter(path, false))
            {
                string Salida = JsonConvert.SerializeObject(Reg);
                file.Write(Salida);
            }
        }
        public void GuardarDatosUsuario()
        {
            string path = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamWriter file = new StreamWriter(path, false))
            {
                string Salida = JsonConvert.SerializeObject(Usu);
                file.Write(Salida);
            }
        }
        string EquipoLocal;
        string EquipoVisitante;
        string EquipoRival;
        public void ActualizarFixture()
        {
            foreach (var item in Usu.ListaPartidosCalendario)
            {
                if (Usu.Equipo == item.EquipoLocal || Usu.Equipo == item.EquipoVisitante)
                {
                    if (item.Resultado == null)
                    {
                        if (Usu.Equipo == item.EquipoLocal)
                        {
                            EquipoRival = item.EquipoVisitante;
                        }
                        else
                        {
                            EquipoRival = item.EquipoLocal;
                        }
                        EquipoLocal = item.EquipoLocal;
                        EquipoVisitante = item.EquipoVisitante;
                        item.GolesLocal = Convert.ToInt32(lblJugarGolesLocal.Text);
                        item.GolesVisitante = Convert.ToInt32(lblJugarGolesVisitante.Text);
                        if (Usu.Equipo == item.EquipoLocal) //El usuario es el local
                        {
                            if (Convert.ToInt32(item.GolesLocal) > item.GolesVisitante)
                            {
                                item.Resultado = "Victoria";
                            }
                            else
                            {
                                if (Convert.ToInt32(item.GolesLocal) == item.GolesVisitante)
                                {
                                    item.Resultado = "Empate";
                                }
                                else
                                {
                                    item.Resultado = "Derrota";
                                }
                            }
                        }
                        else //El usuario es el visitante
                        {
                            if (item.GolesVisitante > Convert.ToInt32(item.GolesLocal))
                            {
                                item.Resultado = "Victoria";
                            }
                            else
                            {
                                if (item.GolesVisitante == Convert.ToInt32(item.GolesLocal))
                                {
                                    item.Resultado = "Empate";
                                }
                                else
                                {
                                    item.Resultado = "Derrota";
                                }
                            }
                        }
                        if (item.EquipoLocal == Usu.Equipo)
                        {
                            item.CantidadEspectadores = Espectadores();
                            item.GananciaEntradas = Entradas();
                        }
                        break;
                    }
                }
            }
        }
        public int Entradas()
        {
            int Ganancia = 0;
            int Espec = Espectadores();
            int SumaEntradas = Usu.PrecioPalcos + Usu.PrecioPlateas + Usu.PrecioPopulares;

            Ganancia = (Espec * SumaEntradas) / 3;
            return Ganancia;
        }
        public int Espectadores()
        {
            int TotalEspec = 0;
            foreach (var L in Lista.LU)
            {
                if (L.NombreEntrenador == Usu.NombreEntrenador)
                {
                    foreach (var item in Equ.ListaEquipos)
                    {
                        if (Usu.Equipo == item.Nombre)
                        {
                            //hay que definir un valor medida para cada caracteristica en la cual voy a comparar.
                            //----------------------------------------------------------------------------------//
                            //Por posicion en la tabla del equipo
                            //> Por precio de las entradas   (popular = 50 ; platea = 150 ; palco = 300)
                            //>Por Confianza hinchada
                            //>Por reputacion
                            //------------------------------------------------------------------------------------//

                            //por precio de entradas
                            int Sector1 = 0;
                            int Sector2 = 0;
                            int Sector3 = 0;
                            if (Usu.PrecioPopulares <= 50)
                            {
                                Sector1 = 1;
                            }
                            if (Usu.PrecioPlateas <= 150)
                            {
                                Sector2 = 1;
                            }
                            if (Usu.PrecioPalcos <= 300)
                            {
                                Sector3 = 1;
                            }
                            int SumSectores = Sector1 + Sector2 + Sector3;
                            if (SumSectores == 3)
                            {
                                TotalEspec = item.CapacidadEstadio;
                            }
                            else
                            {
                                if (SumSectores == 2)
                                {
                                    int UnSexto = item.CapacidadEstadio / 6;
                                    TotalEspec = item.CapacidadEstadio - UnSexto;
                                }
                                else
                                {
                                    if (SumSectores == 1)
                                    {
                                        int UnTercio = item.CapacidadEstadio / 3;
                                        TotalEspec = item.CapacidadEstadio - UnTercio;
                                    }
                                    else
                                    {
                                        if (SumSectores == 0)
                                        {
                                            int UnMedio = item.CapacidadEstadio / 2;
                                            TotalEspec = item.CapacidadEstadio - UnMedio;
                                        }
                                    }
                                }
                            }
                            //Por confianza hinchada
                            if (Usu.ConfianzaHinchada == 100)
                            {
                                TotalEspec = item.CapacidadEstadio;
                            }
                            else
                            {
                                if (Usu.ConfianzaHinchada >= 80)
                                {
                                    int Agregado = TotalEspec / 8;
                                    TotalEspec += Agregado;
                                }
                                else
                                {
                                    if (Usu.ConfianzaHinchada >= 60)
                                    {
                                        int Agregado = TotalEspec / 9;
                                        TotalEspec += Agregado;
                                    }
                                    else
                                    {
                                        if (Usu.ConfianzaHinchada >= 50)
                                        {
                                            int Agregado = TotalEspec / 10;
                                            TotalEspec += Agregado;
                                        }
                                        else
                                        {
                                            if (Usu.ConfianzaHinchada > 40)
                                            {
                                                int Restado = TotalEspec / 10;
                                                TotalEspec -= Restado;
                                            }
                                            else
                                            {
                                                if (Usu.ConfianzaHinchada > 20)
                                                {
                                                    int Restado = TotalEspec / 9;
                                                    TotalEspec -= Restado;
                                                }
                                                else
                                                {
                                                    int Restado = TotalEspec / 8;
                                                    TotalEspec -= Restado;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            //Por Reputacion
                            if (Usu.Reputacion >= 10 && Usu.Reputacion < 30)
                            {
                                int Agregar = TotalEspec / 12;
                                TotalEspec += Agregar;
                            }
                            else
                            {
                                if (Usu.Reputacion >= 30 && Usu.Reputacion < 60)
                                {
                                    int Agregar = TotalEspec / 10;
                                    TotalEspec += Agregar;
                                }
                                else
                                {
                                    if (Usu.Reputacion >= 60 && Usu.Reputacion < 80)
                                    {
                                        int Agregar = TotalEspec / 8;
                                        TotalEspec += Agregar;
                                    }
                                    else
                                    {
                                        if (Usu.Reputacion >= 80)
                                        {
                                            int Agregar = TotalEspec / 6;
                                            TotalEspec += Agregar;
                                        }
                                    }
                                }
                            }



                        }
                        if (TotalEspec > item.CapacidadEstadio)
                        {
                            TotalEspec = item.CapacidadEstadio;
                        }
                        if (TotalEspec < 0)
                        {
                            TotalEspec = 0;
                        }
                    }
                }
            }
            return TotalEspec;
        }
        public void GananciaEntradas()
        {

        }
        public void ActualizarConfianzaReputacion()
        {
            int DiferenciaGol;
            if (Usu.Equipo == EquipoLocal)
            {
                DiferenciaGol = Convert.ToInt32(lblJugarGolesLocal.Text) - Convert.ToInt32(lblJugarGolesVisitante.Text);
            }
            else
            {
                DiferenciaGol = Convert.ToInt32(lblJugarGolesVisitante.Text) - Convert.ToInt32(lblJugarGolesLocal.Text);
            }

            if (DiferenciaGol > 0)
            {
                if (DiferenciaGol < 3)
                {
                    if (Usu.ConfianzaDirigentes < 100)
                    {
                        Usu.ConfianzaDirigentes += 2;
                    }
                    if (Usu.ConfianzaHinchada < 100)
                    {
                        Usu.ConfianzaHinchada += 4;
                    }
                    if (Usu.Reputacion < 100)
                    {
                        Usu.Reputacion += 3;
                    }
                }
                else
                {
                    if (DiferenciaGol < 5)
                    {
                        if (Usu.ConfianzaDirigentes < 100)
                        {
                            Usu.ConfianzaDirigentes += 4;
                        }
                        if (Usu.ConfianzaHinchada < 100)
                        {
                            Usu.ConfianzaHinchada += 7;
                        }
                        if (Usu.Reputacion < 100)
                        {
                            Usu.Reputacion += 4;
                        }
                    }
                    else
                    {
                        if (Usu.ConfianzaDirigentes < 100)
                        {
                            Usu.ConfianzaDirigentes += 6;
                        }
                        if (Usu.ConfianzaHinchada < 100)
                        {
                            Usu.ConfianzaHinchada += 9;
                        }
                        if (Usu.Reputacion < 100)
                        {
                            Usu.Reputacion += 5;
                        }
                    }
                }
            }
            else
            {
                if (DiferenciaGol < 0)
                {
                    if (DiferenciaGol > -3)
                    {
                        if (Usu.ConfianzaDirigentes > 0)
                        {
                            Usu.ConfianzaDirigentes -= 2;
                        }
                        if (Usu.ConfianzaHinchada > 0)
                        {
                            Usu.ConfianzaHinchada -= 4;
                        }
                    }
                    else
                    {
                        if (DiferenciaGol > -5)
                        {
                            if (Usu.ConfianzaDirigentes > 0)
                            {
                                Usu.ConfianzaDirigentes -= 4;
                            }
                            if (Usu.ConfianzaHinchada > 0)
                            {
                                Usu.ConfianzaHinchada -= 7;
                            }
                        }
                        else
                        {
                            if (Usu.ConfianzaDirigentes > 0)
                            {
                                Usu.ConfianzaDirigentes -= 6;
                            }
                            if (Usu.ConfianzaHinchada > 0)
                            {
                                Usu.ConfianzaHinchada -= 9;
                            }
                        }
                    }
                }
                else
                {
                    if (Usu.Reputacion < 100)
                    {
                        Usu.Reputacion += 1;
                    }
                }
            }

        }
        public void ActualizarTablas()
        {
            //SIMULO LOS PARTIDOS
            SimularPartidos();
            foreach (var LiUs in Lista.LU)
            {
                if (Usu.NombreEntrenador == LiUs.NombreEntrenador)
                {
                    foreach (var PA in Usu.ListaPartidosCalendario)
                    {
                        if (Convert.ToInt32(lblJornadaJugarPartido.Text) == PA.Jornada)
                        {
                            foreach (var Tab in Usu.ListaTablasTodasUsuario)
                            {
                                if (PA.Competencia == "Primera División")
                                {
                                    foreach (var item in Tab.TablaPrimera)
                                    {
                                        if (PA.EquipoLocal == item.Equipo)//encontre el equipo local
                                        {
                                            if (Convert.ToInt32(PA.GolesLocal) > PA.GolesVisitante) //Victoria del local
                                            {
                                                item.Puntos += 3;
                                                item.Ganados += 1;
                                                foreach (var Aux in Tab.TablaPrimera)
                                                {
                                                    if (Aux.Equipo == PA.EquipoVisitante)
                                                    {
                                                        Aux.Perdidos += 1;
                                                        break;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (Convert.ToInt32(PA.GolesLocal) == PA.GolesVisitante) //Empate
                                                {
                                                    item.Puntos += 1;
                                                    item.Empatados += 1;
                                                    foreach (var Aux in Tab.TablaPrimera)
                                                    {
                                                        if (Aux.Equipo == PA.EquipoVisitante)
                                                        {
                                                            Aux.Puntos += 1;
                                                            Aux.Empatados += 1;
                                                            break;
                                                        }
                                                    }
                                                }
                                                else //Victoria del visitante
                                                {
                                                    item.Perdidos += 1;
                                                    foreach (var Aux in Tab.TablaPrimera)
                                                    {
                                                        if (Aux.Equipo == PA.EquipoVisitante)
                                                        {
                                                            Aux.Puntos += 3;
                                                            Aux.Ganados += 1;
                                                            break;
                                                        }
                                                    }
                                                }
                                            }

                                            //Para el local
                                            item.GolesFavor += Convert.ToInt32(PA.GolesLocal);
                                            item.GolesContra += PA.GolesVisitante;
                                            item.PartidosJugados += 1;
                                            item.DiferenciaGol += Convert.ToInt32(PA.GolesLocal) - PA.GolesVisitante;
                                            //Para el visitante
                                            foreach (var Aux in Tab.TablaPrimera)
                                            {
                                                if (Aux.Equipo == PA.EquipoVisitante)
                                                {
                                                    Aux.GolesFavor += PA.GolesVisitante;
                                                    Aux.GolesContra += Convert.ToInt32(PA.GolesLocal);
                                                    Aux.PartidosJugados += 1;
                                                    Aux.DiferenciaGol += PA.GolesVisitante - Convert.ToInt32(PA.GolesLocal);
                                                    break;
                                                }
                                            }

                                        }
                                    }
                                    
                                }
                                
                            }
                        }
                    }
                }
            }
            ActualizarPosiciones();
        }
        public double SimularFuerzaLocal(string Equipo, int Jornada)
        {
            double FzaLocal = 0;
            int SumaL = 0;
            int CantL = 0;
            foreach (var Jug in Usu.ListaJugadorUsuario)
            {
                if (Equipo == Jug.EquipoActual)
                {
                    SumaL += Jug.Fuerza;
                    CantL += 1;
                }
                if (CantL == 21)
                {
                    break;
                }

                FzaLocal = SumaL / 21;
            }
            return FzaLocal;
        }
        public double SimularFuerzaVisitante(string Equipo, int Jornada)
        {
            double FzaVisitante = 0;
            int SumaL = 0;
            int CantL = 0;
            foreach (var Jug in Usu.ListaJugadorUsuario)
            {
                if (Equipo == Jug.EquipoActual)
                {
                    SumaL += Jug.Fuerza;
                    CantL += 1;
                }
                if (CantL == 21)
                {
                    break;
                }

                FzaVisitante = SumaL / 21;
            }
            return FzaVisitante;
        }
        public void ActualizarPosiciones()
        {
            foreach (var T in Usu.ListaTablasTodasUsuario)
            {
                T.TablaPrimera = T.TablaPrimera.OrderByDescending(PropiedadesTablas => PropiedadesTablas.Puntos).ToList();
            }

        }
        public void SimularPartidos()
        {
            int JornadaActiva = 0;
            Random Ran = new Random();
            int RandomLocal = 0;
            int RandomVisitante = 0;
            int IntentosLocal = 0;
            int IntentosVisitante = 0;
            int SortearLocal = 0;
            int SortearVisitante = 0;
            foreach (var item in Usu.ListaPartidosCalendario)
            {
                if (item.Resultado != null)
                {
                    JornadaActiva = item.Jornada;
                }
            }
            foreach (var item in Usu.ListaPartidosCalendario)
            {
                if (item.Resultado == null)
                {
                    if (JornadaActiva == item.Jornada) //Encontre la fecha que tengo que simular
                    {
                        double FzaLocal = SimularFuerzaLocal(item.EquipoLocal, JornadaActiva);
                        double FzaVisitante = SimularFuerzaVisitante(item.EquipoVisitante, JornadaActiva);
                        if (FzaVisitante >= 70)
                        {
                            RandomVisitante = Ran.Next(0, 10);
                            SortearVisitante = 10;
                        }
                        else
                        {
                            if (FzaVisitante > 67 && FzaVisitante <= 70)
                            {
                                RandomVisitante = Ran.Next(0, 20);
                                SortearVisitante = 20;
                            }
                            else
                            {
                                if (FzaVisitante > 65 && FzaVisitante <= 67)
                                {
                                    RandomVisitante = Ran.Next(0, 30);
                                    SortearVisitante = 30;
                                }
                                else
                                {
                                    if (FzaVisitante > 63 && FzaVisitante <= 65)
                                    {
                                        RandomVisitante = Ran.Next(0, 40);
                                        SortearVisitante = 40;
                                    }
                                    else
                                    {
                                        if (FzaVisitante > 60 && FzaVisitante <= 63)
                                        {
                                            RandomVisitante = Ran.Next(0, 50);
                                            SortearVisitante = 50;
                                        }
                                        else
                                        {
                                            if (FzaVisitante > 57 && FzaVisitante <= 60)
                                            {
                                                RandomVisitante = Ran.Next(0, 60);
                                                SortearVisitante = 60;
                                            }
                                            else
                                            {
                                                if (FzaVisitante <= 57)
                                                {
                                                    RandomVisitante = Ran.Next(0, 70);
                                                    SortearVisitante = 70;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (FzaLocal >= 70)
                        {
                            RandomLocal = Ran.Next(0, 10);
                            SortearLocal = 10;
                        }
                        else
                        {
                            if (FzaLocal > 67 && FzaLocal <= 70)
                            {
                                RandomLocal = Ran.Next(0, 20);
                                SortearLocal = 20;
                            }
                            else
                            {
                                if (FzaLocal > 65 && FzaLocal <= 67)
                                {
                                    RandomLocal = Ran.Next(0, 30);
                                    SortearLocal = 30;
                                }
                                else
                                {
                                    if (FzaLocal > 63 && FzaLocal <= 65)
                                    {
                                        RandomLocal = Ran.Next(0, 40);
                                        SortearLocal = 40;
                                    }
                                    else
                                    {
                                        if (FzaLocal > 60 && FzaLocal <= 63)
                                        {
                                            RandomLocal = Ran.Next(0, 50);
                                            SortearLocal = 50;
                                        }
                                        else
                                        {
                                            if (FzaLocal > 57 && FzaLocal <= 60)
                                            {
                                                RandomLocal = Ran.Next(0, 60);
                                                SortearLocal = 60;
                                            }
                                            else
                                            {
                                                if (FzaLocal <= 57)
                                                {
                                                    RandomLocal = Ran.Next(0, 70);
                                                    SortearLocal = 70;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        int RandomGeneral = Ran.Next(10);
                        if (RandomGeneral == 4 || RandomGeneral == 8) //Si pasa esto hay empate.
                        {
                            //EMPATE
                            item.Resultado = "Empate";
                            item.GolesLocal = Ran.Next(5);
                            while (item.GolesLocal > 5)
                            {
                                item.GolesLocal = Ran.Next(5);
                            }
                            item.GolesVisitante = Convert.ToInt32(item.GolesLocal);
                        }
                        else
                        {
                            Random Ran2 = new Random();
                            while (RandomLocal != RandomGeneral)
                            {
                                IntentosLocal += 1;
                                RandomLocal = Ran2.Next(SortearLocal);
                            }
                            while (RandomVisitante != RandomGeneral)
                            {
                                IntentosVisitante += 1;
                                RandomVisitante = Ran2.Next(SortearVisitante);
                            }
                            if (IntentosLocal < IntentosVisitante) //GANA EL LOCAL
                            {
                                //GANA LOCAL
                                item.Resultado = "Victoria Local";
                                item.GolesLocal = Ran2.Next(1, 5);
                                item.GolesVisitante = Ran2.Next(0, Convert.ToInt32(item.GolesLocal));
                                item.GolesVisitante -= 1;
                                if (item.GolesVisitante < 0)
                                {
                                    item.GolesVisitante = 0;
                                }
                            }
                            else
                            {
                                if (IntentosLocal > IntentosVisitante)
                                {
                                    //GANA VISITANTE
                                    item.Resultado = "Victoria Visitante";
                                    item.GolesVisitante = Ran2.Next(1, 5);
                                    item.GolesLocal = Ran2.Next(item.GolesVisitante);
                                    item.GolesLocal = Convert.ToInt32(item.GolesLocal) - 1;
                                    if (Convert.ToInt32(item.GolesLocal) < 0)
                                    {
                                        item.GolesLocal = 0;
                                    }
                                }
                                else //TAMBIEN HAY EMPATE
                                {
                                    item.Resultado = "Empate";
                                    item.GolesLocal = Ran2.Next(5);
                                    item.GolesVisitante = Convert.ToInt32(item.GolesLocal);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void TiempoMarcador_Tick(object sender, EventArgs e)
        {
            if (TM == 0 && TS == 0)
            {
                Ban = 0;
                Random Ra = new Random();
                MaxGoles = Ra.Next(10);
                PriGol = Ra.Next(90);
                while (SegGol == PriGol)
                {
                    SegGol = Ra.Next(90);
                }
                while (TerGol == SegGol || TerGol == PriGol)
                {
                    TerGol = Ra.Next(90);
                }
                while (CuaGol == TerGol || CuaGol == SegGol || CuaGol == PriGol)
                {
                    CuaGol = Ra.Next(90);
                }
                F = GrillaLeyendasPartido.Rows.Add();
                GrillaLeyendasPartido.Rows[F].Cells[0].Value = 0 + "'";
                GrillaLeyendasPartido.Rows[F].Cells[1].Value = "¡COMIENZA EL PARTIDO!";
                GrillaLeyendasPartido.FirstDisplayedScrollingRowIndex = GrillaLeyendasPartido.RowCount - 1;
            }

            TM += 1;
            if (TM == 60)
            {
                TS += 1;
                TM = 0;
                if (TS == 45)
                {
                    TiempoMarcador.Stop();
                    lblJugarMilisegundos.Text = TM.ToString();
                    lblJugarSegundos.Text = TS.ToString();
                    MessageBox.Show("FINAL DEL PRIMER TIEMPO");
                    Proc.Procedencia = "JugarPartido";
                    GuardarProcedencia();
                    Formacion Forma = new Formacion();
                    Forma.Show();
                }
                if (TS == 90) //TERMINO EL PARTIDO
                {
                    TiempoMarcador.Stop();
                    lblJugarMilisegundos.Text = TM.ToString();
                    lblJugarSegundos.Text = TS.ToString();
                    MessageBox.Show("FINAL DEL PARTIDO");
                    //ACTUALIZO TODOS LOS DATOS DE LA PAN.PRINCIPAL//
                    ActualizarFixture(); //tiene que estar antes que ActualizarTablas();
                    ActualizarConfianzaReputacion();//tiene que estar abajo de ActualizarFixture();
                    ActualizarTablas();

                    GuardarDatosUsuario();
                    this.Hide();
                    Finalizacion_Partido Fin = new Finalizacion_Partido();
                    Fin.Show();
                }
            }
            if (TM <= 9)
            {
                lblJugarMilisegundos.Text = "0" + TM.ToString();
            }
            else
            {
                lblJugarMilisegundos.Text = TM.ToString();
            }
            if (TS <= 9)
            {
                lblJugarSegundos.Text = "0" + TS.ToString();
            }
            else
            {
                lblJugarSegundos.Text = TS.ToString();
            }

            if (Convert.ToInt32(lblJugarGolesVisitante.Text) <= MaxGoles && (Convert.ToInt32(lblJugarGolesLocal.Text) <= MaxGoles))
            {
                if (TS == PriGol || TS == SegGol || TS == TerGol || TS == CuaGol)
                {
                    if (TS != Temporal) // Para que no haya mas de un gol del mismo equipo en el mismo minuto
                    {
                        for (int i = 0; i < GrillaLeyendasPartido.RowCount - 1; i++)
                        {
                            if (GrillaLeyendasPartido.Rows[i].Cells[0].Value.ToString() == TS + "'" && GrillaLeyendasPartido.Rows[i].Cells[1].Value.ToString() == "¡Gol de " + TeamVisitante + "!" || GrillaLeyendasPartido.Rows[i].Cells[0].Value.ToString() == TS + "'" && GrillaLeyendasPartido.Rows[i].Cells[1].Value.ToString() == "¡Gol de " + TeamLocal + "!")
                            {
                                Ban = 1;
                                break;
                            }
                        }
                        if (Ban == 0)
                        {
                            F = GolAleatorioFuerza(F);
                        }
                        Ban = 0;
                        for (int i = 0; i < GrillaLeyendasPartido.RowCount - 1; i++)
                        {
                            if (GrillaLeyendasPartido.Rows[i].Cells[0].Value.ToString() == TS + "'" && GrillaLeyendasPartido.Rows[i].Cells[1].Value.ToString() == "¡Gol de " + TeamVisitante + "!" || GrillaLeyendasPartido.Rows[i].Cells[0].Value.ToString() == TS + "'" && GrillaLeyendasPartido.Rows[i].Cells[1].Value.ToString() == "¡Gol de " + TeamLocal + "!")
                            {
                                Ban = 1;
                                break;
                            }
                        }
                        if (Ban == 0)
                        {
                            F = GolAleatorioTactica(F);
                        }
                        Ban = 0;
                        for (int i = 0; i < GrillaLeyendasPartido.RowCount; i++)
                        {
                            if (GrillaLeyendasPartido.Rows[i].Cells[0].Value.ToString() == TS + "'" && GrillaLeyendasPartido.Rows[i].Cells[1].Value.ToString() == "¡Gol de " + TeamVisitante + "!" || GrillaLeyendasPartido.Rows[i].Cells[0].Value.ToString() == TS + "'" && GrillaLeyendasPartido.Rows[i].Cells[1].Value.ToString() == "¡Gol de " + TeamLocal + "!")
                            {
                                Ban = 1;
                                break;
                            }
                        }
                        if (Ban == 0)
                        {
                            F = GolAleatorioPresion(F);
                        }
                        Ban = 0;
                        for (int i = 0; i < GrillaLeyendasPartido.RowCount; i++)
                        {
                            if (GrillaLeyendasPartido.Rows[i].Cells[0].Value.ToString() == TS + "'" && GrillaLeyendasPartido.Rows[i].Cells[1].Value.ToString() == "¡Gol de " + TeamVisitante + "!" || GrillaLeyendasPartido.Rows[i].Cells[0].Value.ToString() == TS + "'" && GrillaLeyendasPartido.Rows[i].Cells[1].Value.ToString() == "¡Gol de " + TeamLocal + "!")
                            {
                                Ban = 1;
                                break;
                            }
                        }
                        if (Ban == 0)
                        {
                            F = GolAleatorioActitud(F);
                        }
                        Ban = 0;
                        for (int i = 0; i < GrillaLeyendasPartido.RowCount; i++)
                        {
                            if (GrillaLeyendasPartido.Rows[i].Cells[0].Value.ToString() == TS + "'" && GrillaLeyendasPartido.Rows[i].Cells[1].Value.ToString() == "¡Gol de " + TeamVisitante + "!" || GrillaLeyendasPartido.Rows[i].Cells[0].Value.ToString() == TS + "'" && GrillaLeyendasPartido.Rows[i].Cells[1].Value.ToString() == "¡Gol de " + TeamLocal + "!")
                            {
                                Ban = 1;
                                break;
                            }
                        }
                        if (Ban == 0)
                        {
                            F = GolAleatorioAtaque(F);
                        }
                        Ban = 0;

                    }
                    Temporal = TS;
                }
            }
        }

        private void btnAbandonarPartido_Click(object sender, EventArgs e)
        {
            TiempoMarcador.Stop();
            if (MessageBox.Show("¿Está seguro que desea ABANDONAR el partido? Visite el apartado de 'Información General' en la pantalla principal para conocer las sanciones.", "Abandonar Partido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //foreach (var item in Usu.ListaPartidosCalendario)
                //{
                //    if (Usu.Equipo == item.EquipoLocal || Usu.Equipo == item.EquipoVisitante)
                //    {
                //        if (item.Resultado == null)
                //        {

                //            break;
                //        }
                //    }
                //}
                MessageBox.Show("¡Has abandonado el partido! Qué pena, pierdes 3 - 0", "Partido Abandonado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (Usu.Equipo == TeamLocal)
                {
                    lblJugarGolesLocal.Text = "0";
                    lblJugarGolesVisitante.Text = "3";
                }
                else
                {
                    lblJugarGolesVisitante.Text = "0";
                    lblJugarGolesLocal.Text = "3";
                }
                //Finalizacion_Partido Fin = new Finalizacion_Partido();
                //this.Close();
                //Fin.Show();
            }
            else
            {
                TiempoMarcador.Start();
            }
            if (TM <= 9)
            {
                lblJugarMilisegundos.Text = "0" + TM.ToString();
            }
            else
            {
                lblJugarMilisegundos.Text = TM.ToString();
            }
            if (TS <= 9)
            {
                lblJugarSegundos.Text = "0" + TS.ToString();
            }
            else
            {
                lblJugarSegundos.Text = TS.ToString();
            }
        }

        private void btnTerminarYa_Click(object sender, EventArgs e)
        {
            TS = 88;
        }

        private void lblFechaJornada_Click(object sender, EventArgs e)
        {

        }
    }
}
