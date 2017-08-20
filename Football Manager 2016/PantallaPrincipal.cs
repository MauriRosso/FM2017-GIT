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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }
        ListaUsuario Lista = new ListaUsuario();
        Usuario Usu = new Usuario();
        public void CargarArchivosUsuario()
        {
            string LeerDatos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosUsuarios.json";

            using (StreamReader Entrada = new StreamReader(LeerDatos))
            {
                string contenido = Entrada.ReadToEnd();

                Lista.LU = JsonConvert.DeserializeObject<List<Usuario>>(contenido);
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
        Equipos Equ = new Equipos();
        public void CargarArchivosEquipos()
        {
            string LeerListaEquipos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosEquipos.json";

            using (StreamReader Entrada = new StreamReader(LeerListaEquipos))
            {
                string contenido = Entrada.ReadToEnd();

                Equ.ListaEquipos = JsonConvert.DeserializeObject<List<PropiedadesEquipos>>(contenido);
            }
        }
        Partidos Par = new Partidos();
        //public void CargarArchivosPartidos()
        //{
        //    string LeerListaPartidos = @"C:\Users\Usuario\Desktop\FootballManager2016\Archivos\DatosPartidos.json";

        //    using (StreamReader Entrada = new StreamReader(LeerListaPartidos))
        //    {
        //        string contenido = Entrada.ReadToEnd();

        //        Par.ListaPartidos = JsonConvert.DeserializeObject<List<Partido>>(contenido);
        //    }
        //}
        public void CargarEscudos()
        {
            lblEquipoPantallaPrincipal.Text = Usu.Equipo;

            if (Usu.Equipo == "Aldosivi")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("aldosivi_arg.jpg");
                //ptbFondoPantallaPrin.Image = Image.FromFile("")
            }
            if (Usu.Equipo == "Arsenal")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("arsenal_arg.jpg");
                //ptbFondoPantallaPrin.Image = Image.FromFile("")
            }
            if (Usu.Equipo == "Atlético Rafaela")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("atlrafaela_arg.jpg");
                ptbFondoPantallaPrin.Image = Image.FromFile("fondo_atleticorafaela.jpg");
                gbxDetallesDelJugador.BackgroundImage = Image.FromFile("fondo_atleticorafaela.jpg");
            }
            if (Usu.Equipo == "Atlético Tucumán")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("atl_tucuman_arg.jpg");
            }
            if (Usu.Equipo == "Banfield")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("banfield_arg.jpg");
            }
            if (Usu.Equipo == "Belgrano")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("belgrano_arg.jpg");
            }
            if (Usu.Equipo == "Boca Juniors")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("bocajuniors_arg.jpg");
            }
            if (Usu.Equipo == "Colón")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("colon_arg.jpg");
            }
            if (Usu.Equipo == "Defensa y Justicia")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("defensayjusticia_arg.jpg");
            }
            if (Usu.Equipo == "Estudiantes (LP)")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("estudiantes_arg.jpg");
            }
            if (Usu.Equipo == "Gimnasia (LP)")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("gimnasia_arg.jpg");
            }
            if (Usu.Equipo == "Godoy Cruz")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("godoy_cruz_arg.jpg");
            }
            if (Usu.Equipo == "Huracán")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("huracan_arg.jpg");
            }
            if (Usu.Equipo == "Independiente")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("independiente_arg.jpg");
            }
            if (Usu.Equipo == "Lanus")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("lanus_arg.jpg");
            }
            if (Usu.Equipo == "Newell's")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("newells_arg.jpg");
            }
            if (Usu.Equipo == "Olimpo")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("olimpo_arg.jpg");
            }
            if (Usu.Equipo == "Patronato")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("patronato_arg.jpg");
            }
            if (Usu.Equipo == "Quilmes")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("quilmes_arg.jpg");
            }
            if (Usu.Equipo == "Racing Club")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("racing_arg.jpg");
            }
            if (Usu.Equipo == "River Plate")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("riverplate_arg.jpg");
            }
            if (Usu.Equipo == "Rosario Central")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("rosariocentral_arg.jpg");
            }
            if (Usu.Equipo == "San Lorenzo")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("sanlorenzo_arg.jpg");
            }
            if (Usu.Equipo == "San Martín (SJ)")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("sanmartin_sanjuan_arg.jpg");
            }
            if (Usu.Equipo == "Sarmiento de Junín")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("sarmiento_arg.jpg");
            }
            if (Usu.Equipo == "Talleres")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("talleres_arg.jpg");
            }
            if (Usu.Equipo == "Temperley")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("temperley_arg.jpg");
            }
            if (Usu.Equipo == "Tigre")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("tigre_arg.jpg");
            }
            if (Usu.Equipo == "Unión")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("union_arg.jpg");
            }
            if (Usu.Equipo == "Velez Sarfield")
            {
                ptbEscudoPantallaPrincipal.Image = Image.FromFile("velezsarfield.jpg");
            }

            //Escudo Visitante

            foreach (var item123 in Lista.LU)
            {
                if (Usu.NombreEntrenador == item123.NombreEntrenador)
                {
                    foreach (var item in Usu.ListaPartidosCalendario)
                    {
                        if (item.Resultado == null)
                        {
                            if (item.EquipoLocal == Usu.Equipo || item.EquipoVisitante == Usu.Equipo)
                            {
                                if (Usu.Equipo == item.EquipoLocal)
                                {
                                    if (item.EquipoVisitante == "Aldosivi")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("aldosivi_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Arsenal")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("arsenal_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Atlético Rafaela")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("atlrafaela_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Atlético Tucumán")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("atl_tucuman_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Banfield")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("banfield_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Belgrano")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("belgrano_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Boca Juniors")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("bocajuniors_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Colón")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("colon_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Defensa y Justicia")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("defensayjusticia_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Estudiantes (LP)")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("estudiantes_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Gimnasia (LP)")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("gimnasia_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Godoy Cruz")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("godoy_cruz_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Huracán")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("huracan_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Independiente")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("independiente_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Lanus")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("lanus_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Newell's")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("newells_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Olimpo")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("olimpo_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Patronato")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("patronato_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Quilmes")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("quilmes_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Racing Club")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("racing_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "River Plate")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("riverplate_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Rosario Central")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("rosariocentral_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "San Lorenzo")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("sanlorenzo_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "San Martín (SJ)")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("sanmartin_sanjuan_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Sarmiento de Junín")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("sarmiento_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Talleres")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("talleres_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Temperley")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("temperley_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Tigre")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("tigre_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Unión")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("union_arg.jpg");
                                    }
                                    if (item.EquipoVisitante == "Velez Sarfield")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("velezsarfield.jpg");
                                    }
                                }
                                else
                                {
                                    if (item.EquipoLocal == "Aldosivi")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("aldosivi_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Arsenal")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("arsenal_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Atlético Rafaela")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("atlrafaela_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Atlético Tucumán")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("atl_tucuman_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Banfield")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("banfield_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Belgrano")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("belgrano_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Boca Juniors")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("bocajuniors_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Colón")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("colon_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Defensa y Justicia")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("defensayjusticia_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Estudiantes (LP)")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("estudiantes_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Gimnasia (LP)")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("gimnasia_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Godoy Cruz")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("godoy_cruz_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Huracán")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("huracan_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Independiente")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("independiente_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Lanus")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("lanus_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Newell's")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("newells_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Olimpo")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("olimpo_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Patronato")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("patronato_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Quilmes")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("quilmes_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Racing Club")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("racing_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "River Plate")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("riverplate_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Rosario Central")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("rosariocentral_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "San Lorenzo")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("sanlorenzo_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "San Martín (SJ)")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("sanmartin_sanjuan_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Sarmiento de Junín")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("sarmiento_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Talleres")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("talleres_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Temperley")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("temperley_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Tigre")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("tigre_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Unión")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("union_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Velez Sarfield")
                                    {
                                        ptbEscudoProximoPartido.Image = Image.FromFile("velezsarfield.jpg");
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }
        public void CargarEntrenador()
        {
            lblEntrenadorPantallaPrincipal.Text = Usu.NombreEntrenador;
        }
        public void ParentYtransparencia()
        {
            lblJugadoresEquipo.Parent = ptbFondoPantallaPrin;
            lblJugadoresEquipo.BackColor = Color.Transparent;
            lblMuestroPresupuesto.Parent = ptbFondoPantallaPrin;
            lblMuestroPresupuesto.BackColor = Color.Transparent;
            ptbEscudoProximoPartido.Parent = ptbFondoPantallaPrin;
            ptbEscudoProximoPartido.BackColor = Color.Transparent;
            lblEntrenadorPantallaPrincipal.Parent = ptbFondoPantallaPrin;
            lblEntrenadorPantallaPrincipal.BackColor = Color.Transparent;
            lblEquipoPantallaPrincipal.Parent = ptbFondoPantallaPrin;
            lblEquipoPantallaPrincipal.BackColor = Color.Transparent;
            lblPorcentajeDirigentes.Parent = ptbFondoPantallaPrin;
            lblPorcentajeDirigentes.BackColor = Color.Transparent;
            lblPorcentajeHinchada.Parent = ptbFondoPantallaPrin;
            lblPorcentajeHinchada.BackColor = Color.Transparent;
            lblConfianzaDirigentes.Parent = ptbFondoPantallaPrin;
            lblConfianzaDirigentes.BackColor = Color.Transparent;
            lblConfianzaHinchada.Parent = ptbFondoPantallaPrin;
            lblConfianzaHinchada.BackColor = Color.Transparent;
            ptbEscudoPantallaPrincipal.Parent = ptbFondoPantallaPrin;
            ptbEscudoPantallaPrincipal.BackColor = Color.Transparent;
            btnFixture.Parent = ptbPasto1;
            btnFixture.BackColor = Color.Transparent;
            btnGuardarPartida.Parent = ptbPasto1;
            btnGuardarPartida.BackColor = Color.Transparent;
            btnPosiciones.Parent = ptbPasto1;
            btnPosiciones.BackColor = Color.Transparent;
            btnFinanzas.Parent = ptbPasto1;
            btnFinanzas.BackColor = Color.Transparent;
            btnEstadio.Parent = ptbPasto1;
            btnEstadio.BackColor = Color.Transparent;
            btnMiEquipo.Parent = ptbPasto1;
            btnMiEquipo.BackColor = Color.Transparent;
            btnGoleadores.Parent = ptbPasto1;
            btnGoleadores.BackColor = Color.Transparent;
            btnClubConMasHinchada.Parent = ptbPasto1;
            btnClubConMasHinchada.BackColor = Color.Transparent;
            btnNegociaciones.Parent = ptbPasto1;
            btnNegociaciones.BackColor = Color.Transparent;
            btnMiCarreraDT.Parent = ptbPasto1;
            btnMiCarreraDT.BackColor = Color.Transparent;
            btnSponsor.Parent = ptbPasto1;
            btnSponsor.BackColor = Color.Transparent;
            btnCompeticiones.Parent = ptbPasto1;
            btnCompeticiones.BackColor = Color.Transparent;
            btnInformacion.Parent = ptbPasto1;
            btnInformacion.BackColor = Color.Transparent;
            btnAjustes.Parent = ptbPasto1;
            btnAjustes.BackColor = Color.Transparent;
            btnPrecioEntradas.Parent = ptbPasto1;
            btnPrecioEntradas.BackColor = Color.Transparent;
            lblDivisionLocal.Parent = ptbFondoPantallaPrin;
            lblDivisionLocal.BackColor = Color.Transparent;
            lblEquipoProximoPartido.Parent = ptbFondoPantallaPrin;
            lblEquipoProximoPartido.BackColor = Color.Transparent;
            lblDivisionVisitante.Parent = ptbFondoPantallaPrin;
            lblDivisionVisitante.BackColor = Color.Transparent;
            lblLocalVisitante.Parent = ptbFondoPantallaPrin;
            lblLocalVisitante.BackColor = Color.Transparent;
            lblGuion.Parent = ptbFondoPantallaPrin;
            lblGuion.BackColor = Color.Transparent;
            lblJornadaNumero.Parent = ptbFondoPantallaPrin;
            lblJornadaNumero.BackColor = Color.Transparent;
            lblFechaNumero.Parent = ptbFondoPantallaPrin;
            lblFechaNumero.BackColor = Color.Transparent;
            ptbJugadores.Parent = ptbFondoPantallaPrin;
            ptbJugadores.BackColor = Color.Transparent;
            ptbPresupuesto.Parent = ptbFondoPantallaPrin;
            ptbPresupuesto.BackColor = Color.Transparent;
            lblCantJugadoresEquipo.Parent = ptbFondoPantallaPrin;
            lblCantJugadoresEquipo.BackColor = Color.Transparent;
            ptbCanchita3d.Parent = ptbFondoPantallaPrin;
            ptbCanchita3d.BackColor = Color.Transparent;
            btnFormacionTactica.Parent = ptbFondoPantallaPrin;
            btnFormacionTactica.BackColor = Color.Transparent;
            lblNombreDetalles.Parent = gbxDetallesDelJugador;
            lblNombreDetalles.BackColor = Color.Transparent;
            ptbSeparacionDetalles.Parent = gbxDetallesDelJugador;
            ptbSeparacionDetalles.BackColor = Color.Transparent;
            lblFueDet.Parent = gbxDetallesDelJugador;
            lblFueDet.BackColor = Color.Transparent;
            lblFuerzaDetalles.Parent = gbxDetallesDelJugador;
            lblFuerzaDetalles.BackColor = Color.Transparent;
            lblPosDet.Parent = gbxDetallesDelJugador;
            lblPosDet.BackColor = Color.Transparent;
            lblPosicionDetalles.Parent = gbxDetallesDelJugador;
            lblPosicionDetalles.BackColor = Color.Transparent;
            lblEdDet.Parent = gbxDetallesDelJugador;
            lblEdDet.BackColor = Color.Transparent;
            lblEdadDetalles.Parent = gbxDetallesDelJugador;
            lblEdadDetalles.BackColor = Color.Transparent;
            lblParDet.Parent = gbxDetallesDelJugador;
            lblParDet.BackColor = Color.Transparent;
            lblPartidosJugadosDetalles.Parent = gbxDetallesDelJugador;
            lblPartidosJugadosDetalles.BackColor = Color.Transparent;
            lblValDet.Parent = gbxDetallesDelJugador;
            lblValDet.BackColor = Color.Transparent;
            lblValorDetalles.Parent = gbxDetallesDelJugador;
            lblValorDetalles.BackColor = Color.Transparent;
            lblSalDet.Parent = gbxDetallesDelJugador;
            lblSalDet.BackColor = Color.Transparent;
            lblSalarioDetalles.Parent = gbxDetallesDelJugador;
            lblSalarioDetalles.BackColor = Color.Transparent;
            lblContDet.Parent = gbxDetallesDelJugador;
            lblContDet.BackColor = Color.Transparent;
            lblFechaContratoDetalles.Parent = gbxDetallesDelJugador;
            lblFechaContratoDetalles.BackColor = Color.Transparent;
            ptbGolesDetalles.Parent = gbxDetallesDelJugador;
            ptbGolesDetalles.BackColor = Color.Transparent;
            lblGolesDetalles.Parent = gbxDetallesDelJugador;
            lblGolesDetalles.BackColor = Color.Transparent;
            lblAmarillasDetalles.Parent = gbxDetallesDelJugador;
            lblAmarillasDetalles.BackColor = Color.Transparent;
            lblRojasDetalles.Parent = gbxDetallesDelJugador;
            lblRojasDetalles.BackColor = Color.Transparent;
            lblRepu.Parent = ptbFondoPantallaPrin;
            lblRepu.BackColor = Color.Transparent;
            lblReputacion.Parent = ptbFondoPantallaPrin;
            lblReputacion.BackColor = Color.Transparent;
            ptbCorreo.Parent = ptbFondoPantallaPrin;
            ptbCorreo.BackColor = Color.Transparent;
            lblNumeroMensajes.Parent = ptbFondoPantallaPrin;
            lblNumeroMensajes.BackColor = Color.Transparent;
            lblMensajesNuevos.Parent = ptbFondoPantallaPrin;
            lblMensajesNuevos.BackColor = Color.Transparent;
            lblFechaActual.Parent = ptbFondoPantallaPrin;
            lblFechaActual.BackColor = Color.Transparent;
        }
        public void ImagenPresupuestoYjugadores()
        {
            ptbPresupuesto.Image = Image.FromFile("$$.PNG");
            ptbJugadores.Image = Image.FromFile("Camiseta.PNG");
        }
        public void InicializarBarrasProgreso()
        {
            pbConfianzaDirigentes.Value = Usu.ConfianzaDirigentes;
            lblPorcentajeDirigentes.Text = Convert.ToString(pbConfianzaDirigentes.Value) + " %";
            pbConfianzaHinchada.Value = Usu.ConfianzaHinchada;
            lblPorcentajeHinchada.Text = Convert.ToString(pbConfianzaHinchada.Value) + " %";
            pbReputacion.Value = Usu.Reputacion;
            lblReputacion.Text = Convert.ToString(pbReputacion.Value) + " Pts";
        }
        public void PresupuestoEquipoYCantidadJugadores()
        {
            lblMuestroPresupuesto.Text = Usu.Presupuesto.ToString("C0");

            int CantidadJugadores = 0;
            foreach (var item in Usu.ListaJugadorUsuario)
            {
                if (Usu.Equipo == item.EquipoActual)
                {
                    CantidadJugadores += 1;
                }
            }
            lblCantJugadoresEquipo.Text = Convert.ToString(CantidadJugadores);
        }

        public void ProximoRival()
        {
            foreach (var item in Usu.ListaPartidosCalendario)
            {
                if (Usu.Equipo == item.EquipoLocal || Usu.Equipo == item.EquipoVisitante)
                {
                    if (item.Resultado == null)
                    {
                        lblCompetenciaProxPartido.Text = item.Competencia;
                        lblFechaNumero.Text = item.Jornada.ToString();
                        if (Usu.Equipo == item.EquipoLocal)
                        {
                            lblLocalVisitante.Text = "Local";
                            lblEquipoProximoPartido.Text = item.EquipoVisitante;
                            foreach (var team in Equ.ListaEquipos)
                            {
                                if (Usu.Equipo == team.Nombre)
                                {
                                    lblDivisionLocal.Text = team.Division;
                                }
                                else
                                {
                                    if (item.EquipoVisitante == team.Nombre)
                                    {
                                        lblDivisionVisitante.Text = team.Division;
                                    }
                                }
                            }     
                            
                            break;
                        }
                        else //quiere decir que el equipo del usuario es visitante
                        {
                            lblLocalVisitante.Text = "Visitante";
                            lblEquipoProximoPartido.Text = item.EquipoLocal;
                            foreach (var team in Equ.ListaEquipos)
                            {
                                if (Usu.Equipo == team.Nombre)
                                {
                                    lblDivisionLocal.Text = team.Division;
                                }
                                else
                                {
                                    if (item.EquipoLocal == team.Nombre)
                                    {
                                        lblDivisionVisitante.Text = team.Division;
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }
        
        public void CargoGrillaJugadores()
        {
            GrillaJugadores.RowHeadersVisible = false;
            int F = 0;
            foreach (var item in Usu.ListaJugadorUsuario)
            {
                if (Usu.Equipo == item.EquipoActual)
                {
                    F = GrillaJugadores.Rows.Add();

                    GrillaJugadores.Rows[F].Cells[0].Value = item.Posicion;
                    GrillaJugadores.Rows[F].Cells[1].Value = item.Nombre;
                    GrillaJugadores.Rows[F].Cells[2].Value = item.Fuerza;
                    GrillaJugadores.Rows[F].Cells[3].Value = item.Pie;
                    GrillaJugadores.Rows[F].Cells[4].Value = item.Condicion;
                    GrillaJugadores.Rows[F].Cells[5].Value = item.Salario;
                    GrillaJugadores.Rows[F].Cells[6].Value = item.Valor;
                    GrillaJugadores.Rows[F].Cells[7].Value = item.Edad;
                }
            }

        }
        public void CargoDetallesJugador()
        {
            lblNombreDetalles.Text = Convert.ToString(GrillaJugadores.CurrentRow.Cells[1].Value);
            lblFuerzaDetalles.Text = Convert.ToString(GrillaJugadores.CurrentRow.Cells[2].Value);
            lblPosicionDetalles.Text = Convert.ToString(GrillaJugadores.CurrentRow.Cells[0].Value);
            lblEdadDetalles.Text = Convert.ToString(GrillaJugadores.CurrentRow.Cells[7].Value);
            lblValorDetalles.Text = Convert.ToString(GrillaJugadores.CurrentRow.Cells[6].Value);
            lblSalarioDetalles.Text = Convert.ToString(GrillaJugadores.CurrentRow.Cells[5].Value);

            foreach (var item in Usu.ListaJugadorUsuario)
            {
                if (lblNombreDetalles.Text == item.Nombre)
                {
                    lblPartidosJugadosDetalles.Text = Convert.ToString(item.PartidosJugados);
                    lblFechaContratoDetalles.Text = Convert.ToString(item.FinalizacionContrato.ToShortDateString());
                    lblGolesDetalles.Text = Convert.ToString(item.GolesConvertidos);
                    lblAmarillasDetalles.Text = Convert.ToString(item.Amarillas);
                    lblRojasDetalles.Text = Convert.ToString(item.Rojas);
                    break;
                }
            }
        }
        public void CargarCantidadMsj()
        {
            int NoLeidos = 0;
            foreach (var item123 in Lista.LU)
            {
                if (Usu.NombreEntrenador == item123.NombreEntrenador)
                {
                    foreach (var item in Usu.ListaMensajes)
                    {
                        if (item.Leido == false)
                        {
                            NoLeidos += 1;
                        }
                    }
                }
            }
            lblEtiquetaNumeroMensajes.Text = NoLeidos.ToString();
            lblNumeroMensajes.Text = lblEtiquetaNumeroMensajes.Text;
        }
        public void CargarFecha()
        {
            foreach (var item in Lista.LU)
            {
                if (Usu.NombreEntrenador == item.NombreEntrenador)
                {
                    lblFechaActual.Text = item.FechaCalendario.ToShortDateString();
                }
            }
        }
        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            CargarArchivosEquipos();
            CargarArchivosUsuario();
            CargarUsuario();
            CargarEscudos();
            InicializarBarrasProgreso();
            ParentYtransparencia();
            CargarEntrenador();
            PresupuestoEquipoYCantidadJugadores();
            ProximoRival();
            CargoGrillaJugadores();
            CargoDetallesJugador();
            CargarCantidadMsj();
            CargarFecha();
        }
        public void GuardarPartida()
        {
            foreach (var item in Lista.LU)
            {
                if (Usu.NombreEntrenador == item.NombreEntrenador)
                {
                    item.Equipo = Usu.Equipo;
                    item.NombreEntrenador = Usu.NombreEntrenador;
                    item.FechaCreacion = Usu.FechaCreacion;
                    item.ListaJugadorUsuario = Usu.ListaJugadorUsuario;                  
                    item.ListaPartidosCalendario = Usu.ListaPartidosCalendario;
                    item.ListaTablasTodasUsuario = Usu.ListaTablasTodasUsuario;
                    item.PrecioPalcos = Usu.PrecioPalcos;
                    item.PrecioPlateas = Usu.PrecioPlateas;
                    item.PrecioPopulares = Usu.PrecioPopulares;
                    item.Sponsor = Usu.Sponsor;
                    break;
                }
            }

            string ArchivosUsuarios = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosUsuarios.json";

            using (StreamWriter file = new StreamWriter(ArchivosUsuarios, false))
            {
                string Salida = JsonConvert.SerializeObject(Lista.LU);
                file.Write(Salida);
            }
        }
        private void btnGuardarPartida_Click(object sender, EventArgs e)
        {
            CargarUsuario();
            GuardarPartida();
            MessageBox.Show("Partida guardada exitosamente", "Guardar partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFixture_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Fixture))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Fixture Fix = new Fixture();
                Fix.Show();

            }

        }

        private void btnPosiciones_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Tablas))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Tablas Tab = new Tablas();
                Tab.Show();
            }
        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Finanzas))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Finanzas Fin = new Finanzas();
                Fin.Show();
            }
        }

        private void btnEstadio_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Estadio))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Estadio Est = new Estadio();
                Est.Show();
            }
        }

        private void btnPrecioEntradas_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Entradas))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Entradas Ent = new Entradas();
                Ent.Show();
            }
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
        private void btnFormacionTactica_Click(object sender, EventArgs e)
        {
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
                Formacion For = new Formacion();
                Proc.Procedencia = "PantallaPrincipal";
                GuardarProcedencia();
                For.Show();
                this.Hide();
            }
        }

        private void GrillaJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargoDetallesJugador();
        }
        private void btnSponsor_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Sponsor))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Sponsor Spo = new Sponsor();
                Spo.Show();
            }
        }

        private void btnClubConMasHinchada_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Hinchadas))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Hinchadas Hin = new Hinchadas();
                Hin.Show();
            }
        }

        private void btnCompeticiones_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Competiciones))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Competiciones Com = new Competiciones();
                Com.Show();
            }
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Informacion))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Informacion Inf = new Informacion();
                Inf.Show();
            }
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Ajustes))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Ajustes Aju = new Ajustes();
                Aju.Show();
            }
        }

        private void btnAyudanteDeCampo_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Ayudante_de_campo))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                this.Hide();
                Ayudante_de_campo Ayu = new Ayudante_de_campo();
                Ayu.Show();
            }
        }

        private void btnNegociaciones_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Negociaciones))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Negociaciones Neg = new Negociaciones();
                Neg.Show();
            }
        }

        private void ptbCorreo_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(BandejaMensajes))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                BandejaMensajes Msj = new BandejaMensajes();
                this.Hide();
                Msj.Show();
            }
        }

        private void lblEtiquetaNumeroMensajes_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(BandejaMensajes))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                BandejaMensajes Msj = new BandejaMensajes();
                Msj.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(BandejaMensajes))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                BandejaMensajes Msj = new BandejaMensajes();
                Msj.Show();
                this.Hide();
            }
        }

        private void lblNumeroMensajes_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(BandejaMensajes))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                BandejaMensajes Msj = new BandejaMensajes();
                Msj.Show();
                this.Hide();
            }
        }

        private void lblMensajesNuevos_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(BandejaMensajes))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                BandejaMensajes Msj = new BandejaMensajes();
                Msj.Show();
                this.Hide();
            }
        }

        private void GrillaJugadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            CargoDetallesJugador();
        }

        private void GrillaJugadores_KeyUp(object sender, KeyEventArgs e)
        {
            CargoDetallesJugador();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            int Abierto = 0;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Calendario))
                {
                    Abierto = 1;
                    frm.BringToFront();
                    break;
                }
            }
            if (Abierto == 0)
            {
                Calendario Cale = new Calendario();
                Cale.Show();
            }
        }
    }
}
