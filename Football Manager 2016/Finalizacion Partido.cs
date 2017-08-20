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
    public partial class Finalizacion_Partido : Form
    {
        public Finalizacion_Partido()
        {
            InitializeComponent();
        }

        private void Finalizacion_Partido_Load(object sender, EventArgs e)
        {
            CargarArchivosUsuario();
            CargarUsuario();
            CargarLabels();
            CargarEscudos();
        }
        public void CargarEscudos()
        {
            foreach (var item123 in Lista.LU)
            {
                if (Usu.NombreEntrenador == item123.NombreEntrenador)
                {
                    foreach (var item in Usu.ListaPartidosCalendario)
                    {
                        if (item.Resultado != null)
                        {
                            if (Usu.Equipo == item.EquipoLocal)
                            {
                                if (Usu.Equipo == "Aldosivi")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("aldosivi_arg.jpg");
                                }
                                if (Usu.Equipo == "Arsenal")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("arsenal_arg.jpg");
                                }
                                if (Usu.Equipo == "Atlético Rafaela")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("atlrafaela_arg.jpg");
                                }
                                if (Usu.Equipo == "Atlético Tucumán")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("atl_tucuman_arg.jpg");
                                }
                                if (Usu.Equipo == "Banfield")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("banfield_arg.jpg");
                                }
                                if (Usu.Equipo == "Belgrano")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("belgrano_arg.jpg");
                                }
                                if (Usu.Equipo == "Boca Juniors")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("bocajuniors_arg.jpg");
                                }
                                if (Usu.Equipo == "Colón")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("colon_arg.jpg");
                                }
                                if (Usu.Equipo == "Defensa y Justicia")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("defensayjusticia_arg.jpg");
                                }
                                if (Usu.Equipo == "Estudiantes (LP)")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("estudiantes_arg.jpg");
                                }
                                if (Usu.Equipo == "Gimnasia (LP)")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("gimnasia_arg.jpg");
                                }
                                if (Usu.Equipo == "Godoy Cruz")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("godoy_cruz_arg.jpg");
                                }
                                if (Usu.Equipo == "Huracán")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("huracan_arg.jpg");
                                }
                                if (Usu.Equipo == "Independiente")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("independiente_arg.jpg");
                                }
                                if (Usu.Equipo == "Lanus")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("lanus_arg.jpg");
                                }
                                if (Usu.Equipo == "Newell's")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("newells_arg.jpg");
                                }
                                if (Usu.Equipo == "Olimpo")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("olimpo_arg.jpg");
                                }
                                if (Usu.Equipo == "Patronato")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("patronato_arg.jpg");
                                }
                                if (Usu.Equipo == "Quilmes")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("quilmes_arg.jpg");
                                }
                                if (Usu.Equipo == "Racing Club")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("racing_arg.jpg");
                                }
                                if (Usu.Equipo == "River Plate")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("riverplate_arg.jpg");
                                }
                                if (Usu.Equipo == "Rosario Central")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("rosariocentral_arg.jpg");
                                }
                                if (Usu.Equipo == "San Lorenzo")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("sanlorenzo_arg.jpg");
                                }
                                if (Usu.Equipo == "San Martín (SJ)")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("sanmartin_sanjuan_arg.jpg");
                                }
                                if (Usu.Equipo == "Sarmiento de Junín")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("sarmiento_arg.jpg");
                                }
                                if (Usu.Equipo == "Talleres")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("talleres_arg.jpg");
                                }
                                if (Usu.Equipo == "Temperley")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("temperley_arg.jpg");
                                }
                                if (Usu.Equipo == "Tigre")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("tigre_arg.jpg");
                                }
                                if (Usu.Equipo == "Unión")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("union_arg.jpg");
                                }
                                if (Usu.Equipo == "Velez Sarfield")
                                {
                                    ptbEscudoLocal.Image = Image.FromFile("velezsarfield.jpg");
                                }


                                //CARGO EL VISITANTE



                                if (item.EquipoVisitante == "Aldosivi")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("aldosivi_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Arsenal")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("arsenal_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Atlético Rafaela")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("atlrafaela_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Atlético Tucumán")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("atl_tucuman_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Banfield")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("banfield_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Belgrano")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("belgrano_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Boca Juniors")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("bocajuniors_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Colón")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("colon_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Defensa y Justicia")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("defensayjusticia_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Estudiantes (LP)")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("estudiantes_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Gimnasia (LP)")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("gimnasia_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Godoy Cruz")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("godoy_cruz_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Huracán")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("huracan_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Independiente")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("independiente_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Lanus")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("lanus_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Newell's")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("newells_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Olimpo")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("olimpo_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Patronato")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("patronato_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Quilmes")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("quilmes_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Racing Club")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("racing_arg.jpg");
                                }
                                if (item.EquipoVisitante == "River Plate")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("riverplate_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Rosario Central")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("rosariocentral_arg.jpg");
                                }
                                if (item.EquipoVisitante == "San Lorenzo")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("sanlorenzo_arg.jpg");
                                }
                                if (item.EquipoVisitante == "San Martín (SJ)")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("sanmartin_sanjuan_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Sarmiento de Junín")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("sarmiento_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Talleres")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("talleres_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Temperley")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("temperley_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Tigre")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("tigre_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Unión")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("union_arg.jpg");
                                }
                                if (item.EquipoVisitante == "Velez Sarfield")
                                {
                                    ptbEscudoVisitante.Image = Image.FromFile("velezsarfield.jpg");
                                }
                            }
                            else //El usuario es el equipo visitante
                            {
                                if (Usu.Equipo == item.EquipoVisitante)
                                {
                                    if (Usu.Equipo == "Aldosivi")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("aldosivi_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Arsenal")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("arsenal_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Atlético Rafaela")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("atlrafaela_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Atlético Tucumán")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("atl_tucuman_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Banfield")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("banfield_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Belgrano")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("belgrano_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Boca Juniors")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("bocajuniors_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Colón")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("colon_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Defensa y Justicia")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("defensayjusticia_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Estudiantes (LP)")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("estudiantes_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Gimnasia (LP)")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("gimnasia_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Godoy Cruz")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("godoy_cruz_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Huracán")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("huracan_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Independiente")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("independiente_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Lanus")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("lanus_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Newell's")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("newells_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Olimpo")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("olimpo_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Patronato")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("patronato_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Quilmes")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("quilmes_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Racing Club")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("racing_arg.jpg");
                                    }
                                    if (Usu.Equipo == "River Plate")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("riverplate_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Rosario Central")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("rosariocentral_arg.jpg");
                                    }
                                    if (Usu.Equipo == "San Lorenzo")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("sanlorenzo_arg.jpg");
                                    }
                                    if (Usu.Equipo == "San Martín (SJ)")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("sanmartin_sanjuan_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Sarmiento de Junín")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("sarmiento_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Talleres")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("talleres_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Temperley")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("temperley_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Tigre")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("tigre_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Unión")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("union_arg.jpg");
                                    }
                                    if (Usu.Equipo == "Velez Sarfield")
                                    {
                                        ptbEscudoVisitante.Image = Image.FromFile("velezsarfield.jpg");
                                    }


                                    //CARGO EL VISITANTE



                                    if (item.EquipoLocal == "Aldosivi")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("aldosivi_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Arsenal")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("arsenal_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Atlético Rafaela")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("atlrafaela_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Atlético Tucumán")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("atl_tucuman_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Banfield")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("banfield_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Belgrano")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("belgrano_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Boca Juniors")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("bocajuniors_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Colón")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("colon_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Defensa y Justicia")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("defensayjusticia_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Estudiantes (LP)")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("estudiantes_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Gimnasia (LP)")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("gimnasia_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Godoy Cruz")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("godoy_cruz_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Huracán")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("huracan_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Independiente")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("independiente_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Lanus")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("lanus_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Newell's")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("newells_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Olimpo")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("olimpo_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Patronato")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("patronato_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Quilmes")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("quilmes_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Racing Club")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("racing_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "River Plate")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("riverplate_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Rosario Central")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("rosariocentral_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "San Lorenzo")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("sanlorenzo_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "San Martín (SJ)")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("sanmartin_sanjuan_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Sarmiento de Junín")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("sarmiento_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Talleres")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("talleres_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Temperley")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("temperley_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Tigre")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("tigre_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Unión")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("union_arg.jpg");
                                    }
                                    if (item.EquipoLocal == "Velez Sarfield")
                                    {
                                        ptbEscudoLocal.Image = Image.FromFile("velezsarfield.jpg");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            
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
        public void CargarLabels()
        {
            int F = 0;
            int jor = 0;
            foreach (var item in Lista.LU)
            {
                if (item.NombreEntrenador == Usu.NombreEntrenador)
                {
                    foreach (var Objeto in Usu.ListaPartidosCalendario)
                    {
                        if (Objeto.EquipoLocal == Usu.Equipo || Objeto.EquipoVisitante == Usu.Equipo)
                        {
                            if (Objeto.Resultado != null)
                            {
                                lblNumeroFecha.Text = Objeto.Jornada.ToString();
                                lblGolesLocal.Text = Objeto.GolesLocal.ToString();
                                lblEquipoLocal.Text = Objeto.EquipoLocal;
                                lblEquipoVisitante.Text = Objeto.EquipoVisitante;
                                lblGolesVIsitante.Text = Objeto.GolesVisitante.ToString();
                                lblNombreEstadio.Text = Objeto.Estadio;
                                lblEspectadores.Text = Objeto.CantidadEspectadores.ToString();
                                lblFecha.Text = Convert.ToString(Objeto.FechaPartido.ToShortDateString());
                                jor = Objeto.Jornada;
                            }
                        }
                    }
                    foreach (var Objeto in Usu.ListaPartidosCalendario)
                    {
                        if (jor == Objeto.Jornada)
                        {
                            F = GrillaResultados.Rows.Add();

                            GrillaResultados.Rows[F].Cells[1].Value = Objeto.EquipoLocal;
                            GrillaResultados.Rows[F].Cells[2].Value = Objeto.GolesLocal;
                            GrillaResultados.Rows[F].Cells[3].Value = "x";
                            GrillaResultados.Rows[F].Cells[4].Value = Objeto.GolesVisitante;
                            GrillaResultados.Rows[F].Cells[5].Value = Objeto.EquipoVisitante;
                            if (Objeto.EquipoLocal == "Aldosivi")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("aldosivi_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Arsenal")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("arsenal_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Atlético Rafaela")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("atlrafaela_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Atlético Tucumán")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("atl_tucuman_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Banfield")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("banfield_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Belgrano")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("belgrano_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Boca Juniors")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("bocajuniors_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Colón")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("colon_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Defensa y Justicia")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("defensayjusticia_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Estudiantes (LP)")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("estudiantes_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Gimnasia (LP)")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("gimnasia_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Godoy Cruz")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("godoy_cruz_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Huracán")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("huracan_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Independiente")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("independiente_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Lanus")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("lanus_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Newell's")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("newells_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Olimpo")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("olimpo_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Patronato")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("patronato_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Quilmes")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("quilmes_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Racing Club")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("racing_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "River Plate")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("riverplate_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Rosario Central")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("rosariocentral_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "San Lorenzo")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("sanlorenzo_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "San Martín (SJ)")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("sanmartin_sanjuan_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Sarmiento de Junín")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("sarmiento_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Talleres")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("talleres_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Temperley")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("temperley_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Tigre")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("tigre_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Unión")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("union_arg.jpg");
                            }
                            if (Objeto.EquipoLocal == "Velez Sarfield")
                            {
                                GrillaResultados.Rows[F].Cells[0].Value = Image.FromFile("velezsarfield_arg.jpg");
                            }
                            ////ESCUDO VISITANTE

                            if (Objeto.EquipoVisitante == "Aldosivi")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("aldosivi_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Arsenal")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("arsenal_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Atlético Rafaela")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("atlrafaela_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Atlético Tucumán")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("atl_tucuman_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Banfield")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("banfield_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Belgrano")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("belgrano_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Boca Juniors")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("bocajuniors_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Colón")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("colon_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Defensa y Justicia")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("defensayjusticia_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Estudiantes (LP)")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("estudiantes_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Gimnasia (LP)")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("gimnasia_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Godoy Cruz")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("godoy_cruz_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Huracán")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("huracan_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Independiente")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("independiente_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Lanus")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("lanus_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Newell's")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("newells_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Olimpo")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("olimpo_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Patronato")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("patronato_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Quilmes")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("quilmes_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Racing Club")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("racing_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "River Plate")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("riverplate_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Rosario Central")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("rosariocentral_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "San Lorenzo")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("sanlorenzo_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "San Martín (SJ)")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("sanmartin_sanjuan_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Sarmiento de Junín")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("sarmiento_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Talleres")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("talleres_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Temperley")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("temperley_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Tigre")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("tigre_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Unión")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("union_arg.jpg");
                            }
                            if (Objeto.EquipoVisitante == "Velez Sarfield")
                            {
                                GrillaResultados.Rows[F].Cells[6].Value = Image.FromFile("velezsarfield_arg.jpg");
                            }
                        }  
                    }
                }
            }
        }     
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaPrincipal Pan = new PantallaPrincipal();
            Pan.Show();
        }
    }
}
