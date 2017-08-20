using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Manager_2016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ptbFootMan2017.Parent = ptbFondoFootball;
            ptbFootMan2017.BackColor = Color.Transparent;          
            //BORRAR
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Partidas Par = new Partidas();
        private void btnJugar_Click(object sender, EventArgs e)
        {
                       
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Partidas))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                this.Hide();
                Par.Show();
            }
        }
        
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Configurar_Juego Cfg = new Configurar_Juego();
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Configurar_Juego))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                
                Cfg.Show();

            }
        }

        private void btnVerEquipos_Click(object sender, EventArgs e)
        {
            PrueboLOGO Pru = new PrueboLOGO();
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(PrueboLOGO))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {

                Pru.Show();

            }
        }

        private void btnVerLigas_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Ver_Ligas))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Ver_Ligas Ligas = new Ver_Ligas();
                Ligas.Show();
            }
        }
    }
    public class Usuario
    {
        public string NombreEntrenador { get; set; }
        public string Equipo { get; set; }
        public int PrecioPopulares { get; set; }
        public int PrecioPlateas { get; set; }
        public int PrecioPalcos { get; set; }
        public string Sponsor { get; set; }
        public double Presupuesto { get; set; }
        public int ConfianzaHinchada { get; set; }
        public int ConfianzaDirigentes { get; set; }
        public int Reputacion { get; set; }
        public int MensajesNoLeidos { get; set; }
        public string AyudanteCampo { get; set; }
        public string TorneoLocal { get; set; }
        public string TorneoInternacional { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaCalendario { get; set; }
        public List<TablasSeparadas> ListaTablasTodasUsuario = new List<TablasSeparadas>();
        public List<Jugador> ListaJugadorUsuario = new List<Jugador>();
        public List<Partido> ListaPartidosCalendario = new List<Partido>();
        public List<Mensaje> ListaMensajes = new List<Mensaje>();
    }
    public class ListaUsuario
    {     
        public List<Usuario> LU = new List<Usuario>();
    }
   
    public class PropiedadesEquipos
    {
        public string NombreEstadio { get; set; }
        public int CapacidadEstadio { get; set; }
        public string Nombre { get; set; }
        public double Presupuesto { get; set; }
        public string Division { get; set; }
        public int ConfianzaDirigentes { get; set; }
        public int ConfianzaHinchada { get; set; }
        public int Reputacion { get; set; }
        public string ProximoEquipo { get; set; }
        public int ProximoEquipoDivision { get; set; }      
    }
    public class Jugador
    {
        public string Posicion { get; set; }
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public string Pie { get; set; }
        public int Condicion { get; set; }
        public double Salario { get; set; }
        public double Valor { get; set; }
        public int Edad { get; set; }
        public string EquipoActual { get; set; }
        public int GolesConvertidos { get; set; }
        public int PartidosJugados { get; set; }
        public int Amarillas { get; set; }
        public int Rojas { get; set; }
        public DateTime FinalizacionContrato { get; set; }
    }

    public class Partido
    {
        public DateTime FechaPartido { get; set; }
        public string Resultado { get; set; } //Victoria, empate o derrota
        public string EquipoLocal { get; set; }
        public int? GolesLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public int GolesVisitante { get; set; }
        public string Estadio { get; set; }
        public int Jornada { get; set; }
        public int CantidadEspectadores { get; set; }
        public int GananciaEntradas { get; set; }
        public string Competencia { get; set; }
    }
    public class Registros
    {
        public double GananciasEntradas { get; set; }
        public int CantidadEspectadores { get; set; }
        public int CantAmarillasJugador { get; set; }
        public string NomAmarillasJugador { get; set; }
        public int CantRojasJugador { get; set; }
        public string NomRojasJugador { get; set; }
        public int CantGolesJugador { get; set; }
        public string NomGolesJugador { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
    }
    public class PropiedadesTablasLocal
    {
        public int Posicion { get; set; }
        public string Equipo { get; set; }
        public int Puntos { get; set; }
        public int PartidosJugados { get; set; }
        public int Ganados { get; set; }
        public int Empatados { get; set; }
        public int Perdidos { get; set; }
        public int GolesFavor { get; set; }
        public int GolesContra { get; set; }
        public int DiferenciaGol { get; set; }
    }
    public class PropiedadesTablasInternacional
    {
        public char Grupo { get; set; } //A, B..
        public int Fase { get; set; } // 8avos, 4tos..
        public int Posicion { get; set; }
        public string Equipo { get; set; }
        public int Puntos { get; set; }
        public int PartidosJugados { get; set; }
        public int Ganados { get; set; }
        public int Empatados { get; set; }
        public int Perdidos { get; set; }
        public int GolesFavor { get; set; }
        public int GolesContra { get; set; }
        public int DiferenciaGol { get; set; }
    }
    public class PropiedadesCopaArgentina
    {
        public string Equipo { get; set; }
        public int PartidosJugados { get; set; }
        public int Fase { get; set; } //32avos, 16avos..
        public char Zona { get; set; } //A (cuadrante izq) o B (cuadrante der)
        public string Llave { get; set; } //16 llaves por cada Zona, Formato: 1A, 7B..
    }

    public class Mensaje
    {
        public bool Leido { get; set; }
        public string Asunto { get; set; }
        public string Emisor { get; set; }
        public DateTime Fecha { get; set; }
        public string Cuerpo { get; set; }
    }
    public class Equipos
    {
       public List<PropiedadesEquipos> ListaEquipos = new List<PropiedadesEquipos>();
    }
    public class Partidos
    {
       public List<Partido> ListaPartidos = new List<Partido>();
    }
    public class Jugadores
    {
       public List<Jugador> ListaJugadores = new List<Jugador>();
    }
    public class TablasSeparadas
    {
        public List<PropiedadesTablasLocal> TablaPrimera = new List<PropiedadesTablasLocal>();
        public List<PropiedadesTablasLocal> TablaBNacional = new List<PropiedadesTablasLocal>();
        public List<PropiedadesTablasInternacional> TablaLibertadores = new List<PropiedadesTablasInternacional>();
        public List<PropiedadesTablasInternacional> TablaSudamericana = new List<PropiedadesTablasInternacional>();
        public List<PropiedadesCopaArgentina> TablaCopaArgentina = new List<PropiedadesCopaArgentina>();
    }
    public class CalendarioCompleto
    {
        public List<Partido> ListaPartidosCalendario = new List<Partido>(); //Tengo la lista de partidos ordenada por fecha
    }
    public class ProcedenciasFormacion
    {
        public string Procedencia { get; set; }
    }
}
