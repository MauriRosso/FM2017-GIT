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
    public partial class SeleccionIngresoEquipo : Form
    {
        public SeleccionIngresoEquipo()
        {
            InitializeComponent();
        }
        Jugadores Jdores = new Jugadores();
        public void CargarLista()
        {
            string LeerDatos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosUsuarios.json";

            using (StreamReader Entrada = new StreamReader(LeerDatos))
            {
                string contenido = Entrada.ReadToEnd();

                Lista.LU = JsonConvert.DeserializeObject<List<Usuario>>(contenido);
            }
        }
        public void CargarEquipos()
        {
            string LeerDatos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosEquipos.json";

            using (StreamReader Entrada = new StreamReader(LeerDatos))
            {
                string contenido = Entrada.ReadToEnd();

                Equ.ListaEquipos = JsonConvert.DeserializeObject<List<PropiedadesEquipos>>(contenido);
            }
        }
        public void CargarPartidos()
        {

            string LeerDatos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosPartidos.json";

            using (StreamReader Entrada = new StreamReader(LeerDatos))
            {
                string contenido = Entrada.ReadToEnd();

                Par.ListaPartidos = JsonConvert.DeserializeObject<List<Partido>>(contenido);
            }
        }
        public void CargarJugadores()
        {
            string LeerDatos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosJugadores.json";

            using (StreamReader Entrada = new StreamReader(LeerDatos))
            {
                string contenido = Entrada.ReadToEnd();

                Jdores.ListaJugadores = JsonConvert.DeserializeObject<List<Jugador>>(contenido);
            }
        }
        private void SeleccionIngresoEquipo_Load(object sender, EventArgs e)
        {
            CargarLista();
            lblSeleccioneEquipo.Parent = ptbSeleccionIngresoEquipo;
            lblSeleccioneEquipo.BackColor = Color.Transparent;
            lblCreandoNuevaPartida.Parent = ptbSeleccionIngresoEquipo;
            lblCreandoNuevaPartida.BackColor = Color.Transparent;
            lblPrimeraDivision.Parent = ptbSeleccionIngresoEquipo;
            lblPrimeraDivision.BackColor = Color.Transparent;
            lblBNacional.Parent = ptbSeleccionIngresoEquipo;
            lblBNacional.BackColor = Color.Transparent;
        }
        int BanderaA = 0;
        int BanderaB = 0;
        private void cbxSeleccionEquipoIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ptbImagenEquipoSel.Parent = ptbSeleccionIngresoEquipo;
            ptbImagenEquipoSel.BackColor = Color.Transparent;

            BanderaA = 1;
            lblPrimeraDivision.BackColor = Color.Green;
            lblBNacional.BackColor = Color.Transparent;
            BanderaB = 0;

            if (cbxSeleccionEquipoIngreso.SelectedItem.ToString() == "Argentinos Juniors")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("ArgentinosJuniors.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem.ToString() == "Arsenal")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Arsenal.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Atlético Tucumán")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("AtleticoTucuman.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Banfield")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Banfield.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Belgrano")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Belgrano.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Boca Juniors")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("BocaJuniors.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Colón")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Colon.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Chacarita Juniors")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Chacarita.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Defensa y Justicia")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("DefensaYjusticia.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Estudiantes (LP)")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Estudiantes.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Gimnasia (LP)")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Gimnasia.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Godoy Cruz")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("GodoyCruz.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Huracán")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Huracan.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Independiente")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Independiente.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Lanus")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Lanus.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Newell's")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Newells.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Olimpo")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Olimpo.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Patronato")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Patronato.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Racing Club")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("RacingClub.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "River Plate")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("RiverPlate.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Rosario Central")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("RosarioCentral.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "San Lorenzo")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("SanLorenzo.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "San Martín (SJ)")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("SanMartinSJ.png");
                Usu.TorneoLocal = "Primera División";
            }

            if (cbxSeleccionEquipoIngreso.SelectedItem == "Talleres")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Talleres.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Temperley")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Temperley.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Tigre")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Tigre.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Unión")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Union.png");
                Usu.TorneoLocal = "Primera División";
            }
            if (cbxSeleccionEquipoIngreso.SelectedItem == "Velez Sarfield")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("VelezSarfield.png");
                Usu.TorneoLocal = "Primera División";
            }
        }
        private void btnVolverAPartidas_Click(object sender, EventArgs e)
        {
            Partidas Par = new Partidas();
            this.Hide();
            Par.Show();
        }
        ListaUsuario Lista = new ListaUsuario();
        Usuario Usu = new Usuario();
        Partidos Par = new Partidos();
        Equipos Equ = new Equipos();
        TablasSeparadas TabSe = new TablasSeparadas();
        public void GuardarArchivoLista()
        {
            string ArchivosUsuarios = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosUsuarios.json";

            using (StreamWriter file = new StreamWriter(ArchivosUsuarios, false))
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

        public void CargoJugadoresUsuario()
        {
            CargarJugadores();
            foreach (var item in Jdores.ListaJugadores)
            {
                Jugador Jug = new Jugador();
                Jug.Condicion = item.Condicion;
                Jug.Edad = item.Edad;
                Jug.EquipoActual = item.EquipoActual;
                Jug.Fuerza = item.Fuerza;
                Jug.GolesConvertidos = item.GolesConvertidos;
                Jug.Nombre = item.Nombre;
                Jug.Pie = item.Pie;
                Jug.Posicion = item.Posicion;
                Jug.Salario = item.Salario;
                Jug.Valor = item.Valor;
                Jug.FinalizacionContrato = item.FinalizacionContrato;
                Jug.Amarillas = item.Amarillas;
                Jug.Rojas = item.Rojas;
                Jug.PartidosJugados = item.PartidosJugados;

                Usu.ListaJugadorUsuario.Add(Jug);
            }
        }
        public List<PropiedadesEquipos> MezclarEquipos()
        {
            List<PropiedadesEquipos> ListaDuplicada = new List<PropiedadesEquipos>();
            List<PropiedadesEquipos> ListaMezclada = new List<PropiedadesEquipos>();
            foreach (var item in Equ.ListaEquipos) //Filtro los equipos solo de ARG
            {
                if (item.Division == "Primera División" || item.Division == "B Nacional")
                {
                    ListaDuplicada.Add(item);
                }
            }
            Random RN = new Random();
            for (int i = 0; i < 21; i++) //Saco 21 equipos aleatoriamente para tener los 32 equipos que van a jugar la Copa ARG
            {
                int ran = RN.Next(0, ListaDuplicada.Count - 1);
                ListaDuplicada.RemoveAt(ran);
            }
            Random RandNum = new Random();
            while (ListaDuplicada.Count > 0)
            {
                int ran = RandNum.Next(0, ListaDuplicada.Count - 1);
                ListaMezclada.Add(ListaDuplicada[ran]);
                ListaDuplicada.RemoveAt(ran);
            }
            return ListaMezclada;
        }
        public void CargarCopaArgentina()
        {
            List<PropiedadesEquipos> EquiposCopaArg = MezclarEquipos(); //Sirve para cargar los equipos de la copa argentina
            foreach (var itemCA in EquiposCopaArg)
            {
                PropiedadesCopaArgentina PTCA = new PropiedadesCopaArgentina();
                int CantCA = 0;
                foreach (var item in Equ.ListaEquipos)
                {
                    CantCA += 1;

                    if (item == itemCA)
                    {
                        PTCA.Equipo = item.Nombre;
                        PTCA.PartidosJugados = 0;
                        PTCA.Fase = 16;
                        if (CantCA <= 16)
                        {
                            PTCA.Zona = 'A';
                        }
                        else
                        {
                            PTCA.Zona = 'B';
                        }
                        if (CantCA > 16)
                        {
                            PTCA.Llave = CantCA - 16 + PTCA.Zona.ToString();
                        }
                        TabSe.TablaCopaArgentina.Add(PTCA);
                    }
                }


            }

        }
        public void CargoTablas()
        {
            CargarEquipos();
            foreach (var item in Equ.ListaEquipos)
            {

                if (item.Division == "Primera División" || item.Division == "B Nacional")
                {
                    PropiedadesTablasLocal PTL = new PropiedadesTablasLocal();

                    PTL.Equipo = item.Nombre;
                    PTL.Posicion = 1;
                    PTL.Puntos = 0;
                    PTL.PartidosJugados = 0;
                    PTL.GolesFavor = 0;
                    PTL.GolesContra = 0;
                    PTL.Ganados = 0;
                    PTL.Empatados = 0;
                    PTL.Perdidos = 0;
                    PTL.DiferenciaGol = 0;
                    if (item.Division == "Primera División")
                    {
                        TabSe.TablaPrimera.Add(PTL);
                    }
                    else
                    {
                        TabSe.TablaBNacional.Add(PTL);
                    }

                }
                else
                {
                    PropiedadesTablasInternacional PTI = new PropiedadesTablasInternacional();
                    if (item.Division == "Libertadores")
                    {
                        //PTI.Grupo
                        PTI.Fase = 0;
                        PTI.Equipo = item.Nombre;
                        PTI.Posicion = 1;
                        PTI.Puntos = 0;
                        PTI.PartidosJugados = 0;
                        PTI.GolesFavor = 0;
                        PTI.GolesContra = 0;
                        PTI.Ganados = 0;
                        PTI.Empatados = 0;
                        PTI.Perdidos = 0;
                        PTI.DiferenciaGol = 0;

                        TabSe.TablaLibertadores.Add(PTI);
                    }
                    else
                    {
                        TabSe.TablaSudamericana.Add(PTI);
                    }
                }
            }
            CargarCopaArgentina();
            Usu.ListaTablasTodasUsuario.Add(TabSe);
        }
        public void CargoPresupuesto()
        {
            foreach (var item in Equ.ListaEquipos)
            {
                if (Usu.Equipo == item.Nombre)
                {
                    Usu.Presupuesto = item.Presupuesto;
                }
            }
        }
        public void CargarMensajes()
        {
            Mensaje Msj = new Mensaje();
            Msj.Leido = false;
            Msj.Fecha = new DateTime(2016, 08, 26);
            Msj.Asunto = "¡Bienvenido a " + Usu.Equipo + "!";
            Msj.Emisor = "Gerencia de " + Usu.Equipo;
            Msj.Cuerpo = "Bienvenido a nuestro club. Estamos muy entusiasmados y contentos sobre tu llegada, confiamos en que vas a dar lo mejor por nuestro club. A partir de este momento eres el encargado de administrar en todos sus ambitos a " + Usu.Equipo + ". ¡Buena suerte!";

            Usu.ListaMensajes.Add(Msj);
        }
        public void CompeticionInternacionalUsuario()
        {
            if (Usu.Equipo == "Boca Juniors" || Usu.Equipo == "River Plate" || Usu.Equipo == "San Lorenzo" || Usu.Equipo == "Racing Club" || Usu.Equipo == "Atlético Tucumán" || Usu.Equipo == "Independiente")
            {
                Usu.TorneoInternacional = "Copa Libertadores";
            }
            else
            {
                if (Usu.Equipo == "Lanus" || Usu.Equipo == "Defensa y Justicia" || Usu.Equipo == "Colón" || Usu.Equipo == "Newell's" || Usu.Equipo == "Banfield" || Usu.Equipo == "Rosario Central")
                {
                    Usu.TorneoInternacional = "Copa Sudamericana";
                }
                else
                {
                    Usu.TorneoInternacional = "";
                }
            }
        }
        public void CargarCalendarioCompleto()
        {
            CargarPartidos();
            foreach (var item in Par.ListaPartidos)
            {
                Usu.ListaPartidosCalendario.Add(item);
            }
            Usu.ListaPartidosCalendario.OrderBy(x => x.FechaPartido).ToList(); //Ordeno mi calendario por fechas de partidos
        }
        private void btnElegirEquipoInicial_Click(object sender, EventArgs e)
        {
            if (cbxSeleccionEquipoIngreso.SelectedIndex > -1 || cbxSeleccionIngresoEquipoB.SelectedIndex > -1 && txtSuNombre.Text != "")
            {
                if (BanderaA == 1)
                {
                    Usu.Equipo = Convert.ToString(cbxSeleccionEquipoIngreso.SelectedItem);
                }
                else
                {
                    Usu.Equipo = Convert.ToString(cbxSeleccionIngresoEquipoB.SelectedItem);
                }
                Usu.NombreEntrenador = txtSuNombre.Text;
                Usu.FechaCreacion = DateTime.Now;
                Usu.PrecioPopulares = 50;
                Usu.PrecioPlateas = 150;
                Usu.PrecioPalcos = 300;
                Usu.Sponsor = "";
                Usu.AyudanteCampo = "";
                Usu.ConfianzaDirigentes = 100;
                Usu.ConfianzaHinchada = 100;
                Usu.Reputacion = 0;
                Usu.FechaCalendario = new DateTime(2017, 8, 1);
                CompeticionInternacionalUsuario();
                CargoTablas();
                CargoJugadoresUsuario();
                CargoPresupuesto();
                CargarMensajes();
                CargarCalendarioCompleto();

                Lista.LU.Add(Usu);
                GuardarArchivoLista();
                GuardarArchivoTemp();

                lblCreandoNuevaPartida.Visible = true;
                pbSeleccionEquipo.Visible = true;
                for (int i = 0; i < 100; i++)
                {
                    pbSeleccionEquipo.Increment(1);
                    System.Threading.Thread.Sleep(40);
                }

                PantallaPrincipal Pan = new PantallaPrincipal();
                this.Hide();
                Pan.Show();
            }
        }

        private void cbxSeleccionIngresoEquipoB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///////////////////////////    ---- B NACIONAL ---- //////////////////////////
            ptbImagenEquipoSel.Parent = ptbSeleccionIngresoEquipo;
            ptbImagenEquipoSel.BackColor = Color.Transparent;

            BanderaA = 0;
            lblBNacional.BackColor = Color.Green;
            lblPrimeraDivision.BackColor = Color.Transparent;
            BanderaB = 1;

            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Agropecuario")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Agropecuario.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "All Boys")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("AllBoys.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Almagro")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Almagro.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Aldosivi")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Aldosivi.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Atlético Rafaela")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("AtleticoRafaela.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Boca Unidos")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("BocaUnidos.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Brown de Adrogué")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Brown.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Sarmiento de Junín")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("SarmientoDeJunin.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Deportivo Morón")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Moron.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Deportivo Riestra")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("DeportivoRiestra.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Ferro Carril Oeste")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("FerroCarrilOeste.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Flandria")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Flandria.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Gimnasia de Jujuy")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("GimnasiaJujuy.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Guillermo Brown")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("GuillermoBrown.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Independiente Rivadavia")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("IndependienteRivadavia.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Instituto")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Instituto.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Juventud Unida")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("JuventudUnida.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Los Andes")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("LosAndes.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Mitre")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Mitre.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Nueva Chicago")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("NuevaChicago.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Quilmes")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("Quilmes.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Santamarina de Tandil")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("SantamarinaDeTandil.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "San Martín de Tucumán")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("SanMartinTucuman.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Estudiantes (SL)")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("EstudiantesSL.png");
                Usu.TorneoLocal = "B Nacional";
            }
            if (cbxSeleccionIngresoEquipoB.SelectedItem.ToString() == "Villa Dálmine")
            {
                ptbImagenEquipoSel.Image = Image.FromFile("VillaDalmine.png");
                Usu.TorneoLocal = "B Nacional";
            }
        }
    }
}
