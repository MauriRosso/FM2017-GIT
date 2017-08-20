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
    public partial class Tablas : Form
    {
        public List<Equipos> EquiposCopaArgentina { get; set; }
        public Tablas()
        {
            InitializeComponent();
        }
        public List<TextBox> ListaCuadrosCopaArg = new List<TextBox>();

        ListaUsuario ListaUsu = new ListaUsuario();
        Usuario Usu = new Usuario();
        public void CargarTablasUsuario()
        {
            string LeerDatos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosUsuarios.json";

            using (StreamReader Entrada = new StreamReader(LeerDatos))
            {
                string contenido = Entrada.ReadToEnd();

                ListaUsu.LU = JsonConvert.DeserializeObject<List<Usuario>>(contenido);
            }
            string LeerTemp = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamReader Entrada = new StreamReader(LeerTemp))
            {
                string contenido = Entrada.ReadToEnd();

                Usu = JsonConvert.DeserializeObject<Usuario>(contenido);
            }
        }
        private void RemarcarUsuario()
        {
            for (int i = 0; i < GrillaTablaPrimera.RowCount; i++)
            {
                if (GrillaTablaPrimera.Rows[i].Cells[2].Value.ToString() == Usu.Equipo)
                {
                    GrillaTablaPrimera.Rows[i].Cells[0].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaPrimera.Rows[i].Cells[2].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaPrimera.Rows[i].Cells[3].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaPrimera.Rows[i].Cells[4].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaPrimera.Rows[i].Cells[5].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaPrimera.Rows[i].Cells[6].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaPrimera.Rows[i].Cells[7].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaPrimera.Rows[i].Cells[8].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaPrimera.Rows[i].Cells[9].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaPrimera.Rows[i].Cells[10].Style.ForeColor = Color.DarkBlue;
                }
            }
            for (int i = 0; i < GrillaTablaBNacional.RowCount; i++)
            {
                if (GrillaTablaBNacional.Rows[i].Cells[2].Value.ToString() == Usu.Equipo)
                {
                    GrillaTablaBNacional.Rows[i].Cells[0].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaBNacional.Rows[i].Cells[2].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaBNacional.Rows[i].Cells[3].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaBNacional.Rows[i].Cells[4].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaBNacional.Rows[i].Cells[5].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaBNacional.Rows[i].Cells[6].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaBNacional.Rows[i].Cells[7].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaBNacional.Rows[i].Cells[8].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaBNacional.Rows[i].Cells[9].Style.ForeColor = Color.DarkBlue;
                    GrillaTablaBNacional.Rows[i].Cells[10].Style.ForeColor = Color.DarkBlue;
                }
            }
            foreach (var item in ListaCuadrosCopaArg)
            {
                if (item.Text == Usu.Equipo)
                {
                    item.ForeColor = Color.DarkBlue;
                }
            }
        }
        public void CargoGrillaTablaBNacional()
        {
            int F;
            foreach (var T in Usu.ListaTablasTodasUsuario)
            {
                foreach (var item in T.TablaBNacional)
                {
                    F = GrillaTablaBNacional.Rows.Add();

                    GrillaTablaBNacional.Rows[F].Cells[0].Value = item.Posicion;
                    GrillaTablaBNacional.Rows[F].Cells[2].Value = item.Equipo;
                    GrillaTablaBNacional.Rows[F].Cells[3].Value = item.Puntos;
                    GrillaTablaBNacional.Rows[F].Cells[4].Value = item.PartidosJugados;
                    GrillaTablaBNacional.Rows[F].Cells[5].Value = item.Ganados;
                    GrillaTablaBNacional.Rows[F].Cells[6].Value = item.Empatados;
                    GrillaTablaBNacional.Rows[F].Cells[7].Value = item.Perdidos;
                    GrillaTablaBNacional.Rows[F].Cells[8].Value = item.GolesFavor;
                    GrillaTablaBNacional.Rows[F].Cells[9].Value = item.GolesContra;
                    GrillaTablaBNacional.Rows[F].Cells[10].Value = item.DiferenciaGol;

                    //ESCUDOS DE LOS EQUIPOS DE LA PBN
                    if (item.Equipo == "Agropecuario")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("agropecuario_arg.png");
                    }
                    if (item.Equipo == "Aldosivi")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("aldosivi_arg.jpg");
                    }
                    if (item.Equipo == "All Boys")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("allboys_arg.png");
                    }
                    if (item.Equipo == "Almagro")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("almagro_arg.png");
                    }
                    if (item.Equipo == "Atlético Rafaela")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("atlrafaela_arg.jpg");
                    }
                    if (item.Equipo == "Boca Unidos")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("bocaunidos_arg.png");
                    }
                    if (item.Equipo == "Brown de Adrogué")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("brown_arg.png");
                    
                    }
                    if (item.Equipo == "Sarmiento de Junín")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("sarmiento_arg.jpg");
                    }
                    if (item.Equipo == "Deportivo Morón")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("moron_arg.png");
                     
                    }
                    if (item.Equipo == "Deportivo Riestra")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("deportivoriestra_arg.png");
                     
                    }
                    if (item.Equipo == "Ferro Carril Oeste")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("ferrocarril_arg.png");
                     
                    }
                    if (item.Equipo == "Flandria")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("flandria_arg.png");
                     
                    }
                    if (item.Equipo == "Gimnasia de Jujuy")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("gimnasiajujuy_arg.png");
                     
                    }
                    if (item.Equipo == "Guillermo Brown")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("guillermobrown_arg.png");
                     
                    }
                    if (item.Equipo == "Independiente Rivadavia")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("independienteriv_arg.png");
                     
                    }
                    if (item.Equipo == "Instituto")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("instituto_arg.png");
                        
                    }
                    if (item.Equipo == "Juventud Unida")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("juventudunida_arg.png");
                        
                    }
                    if (item.Equipo == "Los Andes")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("losandes_arg.png");
                        
                    }
                    if (item.Equipo == "Mitre")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("mitre_arg.png");
                        
                    }
                    if (item.Equipo == "Nueva Chicago")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("nuevachicago_arg.png");
                        
                    }
                    if (item.Equipo == "Quilmes")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("quilmes_arg.jpg");
                        
                    }
                    if (item.Equipo == "Santamarina de Tandil")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("santamarina_arg.png");
                        
                    }
                    if (item.Equipo == "San Martín de Tucumán")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("sanmartin_arg.png");
                        
                    }
                    if (item.Equipo == "Estudiantes (SL)")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("estudiantessl_arg.png");
                        
                    }
                    if (item.Equipo == "Villa Dálmine")
                    {
                        GrillaTablaBNacional.Rows[F].Cells[1].Value = Image.FromFile("villadalmine_arg.png");
                        
                    }
                }
            }
        }
        public void CargoGrillaTablaPrimera()
        {
            int F;
            foreach (var LUsu in ListaUsu.LU)
            {
                if (Usu.NombreEntrenador == LUsu.NombreEntrenador)
                {
                    foreach (var T in Usu.ListaTablasTodasUsuario)
                    {
                        foreach (var item in T.TablaPrimera)
                        {
                            F = GrillaTablaPrimera.Rows.Add();

                            GrillaTablaPrimera.Rows[F].Cells[0].Value = item.Posicion;
                            GrillaTablaPrimera.Rows[F].Cells[2].Value = item.Equipo;
                            GrillaTablaPrimera.Rows[F].Cells[3].Value = item.Puntos;
                            GrillaTablaPrimera.Rows[F].Cells[4].Value = item.PartidosJugados;
                            GrillaTablaPrimera.Rows[F].Cells[5].Value = item.Ganados;
                            GrillaTablaPrimera.Rows[F].Cells[6].Value = item.Empatados;
                            GrillaTablaPrimera.Rows[F].Cells[7].Value = item.Perdidos;
                            GrillaTablaPrimera.Rows[F].Cells[8].Value = item.GolesFavor;
                            GrillaTablaPrimera.Rows[F].Cells[9].Value = item.GolesContra;
                            GrillaTablaPrimera.Rows[F].Cells[10].Value = item.DiferenciaGol;

                            
                            if (item.Equipo == "Argentinos Juniors")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("argentinos_arg.png");
                            }
                            if (item.Equipo == "Arsenal")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("arsenal_arg.jpg");
                            }
                            
                            if (item.Equipo == "Atlético Tucumán")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("atl_tucuman_arg.jpg");
                            }
                            if (item.Equipo == "Banfield")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("banfield_arg.jpg");
                            }
                            if (item.Equipo == "Belgrano")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("belgrano_arg.jpg");
                            }
                            if (item.Equipo == "Boca Juniors")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("bocajuniors_arg.jpg");
                            }
                            if (item.Equipo == "Colón")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("colon_arg.jpg");
                            }
                            if (item.Equipo == "Chacarita Juniors")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("chacaritajuniors_arg.png");
                            }
                            if (item.Equipo == "Defensa y Justicia")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("defensayjusticia_arg.jpg");
                            }
                            if (item.Equipo == "Estudiantes (LP)")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("estudiantes_arg.jpg");
                            }
                            if (item.Equipo == "Gimnasia (LP)")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("gimnasia_arg.jpg");
                            }
                            if (item.Equipo == "Godoy Cruz")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("godoy_cruz_arg.jpg");
                            }
                            if (item.Equipo == "Huracán")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("huracan_arg.jpg");
                            }
                            if (item.Equipo == "Independiente")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("independiente_arg.jpg");
                            }
                            if (item.Equipo == "Lanus")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("lanus_arg.jpg");
                            }
                            if (item.Equipo == "Newell's")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("newells_arg.jpg");
                            }
                            if (item.Equipo == "Olimpo")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("olimpo_arg.jpg");
                            }
                            if (item.Equipo == "Patronato")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("patronato_arg.jpg");
                            }
                            
                            if (item.Equipo == "Racing Club")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("racing_arg.jpg");
                            }
                            if (item.Equipo == "River Plate")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("riverplate_arg.jpg");
                            }
                            if (item.Equipo == "Rosario Central")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("rosariocentral_arg.jpg");
                            }
                            if (item.Equipo == "San Lorenzo")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("sanlorenzo_arg.jpg");
                            }
                            if (item.Equipo == "San Martín (SJ)")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("sanmartin_sanjuan_arg.jpg");
                            }
                            
                            if (item.Equipo == "Talleres")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("talleres_arg.jpg");
                            }
                            if (item.Equipo == "Temperley")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("temperley_arg.jpg");
                            }
                            if (item.Equipo == "Tigre")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("tigre_arg.jpg");
                            }
                            if (item.Equipo == "Unión")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("union_arg.jpg");
                            }
                            if (item.Equipo == "Velez Sarfield")
                            {
                                GrillaTablaPrimera.Rows[F].Cells[1].Value = Image.FromFile("velezsarfield_arg.jpg");
                            }
                        }                       
                    }
                }
            }
        }
        private void CargarCuadroCopaArgentina()
        {
            ListaCuadrosCopaArg.Add(txtCA161);
            ListaCuadrosCopaArg.Add(txtCA162);
            ListaCuadrosCopaArg.Add(txtCA163);
            ListaCuadrosCopaArg.Add(txtCA164);
            ListaCuadrosCopaArg.Add(txtCA165);
            ListaCuadrosCopaArg.Add(txtCA166);
            ListaCuadrosCopaArg.Add(txtCA167);
            ListaCuadrosCopaArg.Add(txtCA168);
            ListaCuadrosCopaArg.Add(txtCA169);
            ListaCuadrosCopaArg.Add(txtCA1610);
            ListaCuadrosCopaArg.Add(txtCA1611);
            ListaCuadrosCopaArg.Add(txtCA1612);
            ListaCuadrosCopaArg.Add(txtCA1613);
            ListaCuadrosCopaArg.Add(txtCA1614);
            ListaCuadrosCopaArg.Add(txtCA1615);
            ListaCuadrosCopaArg.Add(txtCA1616);
            ListaCuadrosCopaArg.Add(txtCA1617);
            ListaCuadrosCopaArg.Add(txtCA1618);
            ListaCuadrosCopaArg.Add(txtCA1619);
            ListaCuadrosCopaArg.Add(txtCA1620);
            ListaCuadrosCopaArg.Add(txtCA1621);
            ListaCuadrosCopaArg.Add(txtCA1622);
            ListaCuadrosCopaArg.Add(txtCA1623);
            ListaCuadrosCopaArg.Add(txtCA1624);
            ListaCuadrosCopaArg.Add(txtCA1625);
            ListaCuadrosCopaArg.Add(txtCA1626);
            ListaCuadrosCopaArg.Add(txtCA1627);
            ListaCuadrosCopaArg.Add(txtCA1628);
            ListaCuadrosCopaArg.Add(txtCA1629);
            ListaCuadrosCopaArg.Add(txtCA1630);
            ListaCuadrosCopaArg.Add(txtCA1631);
            ListaCuadrosCopaArg.Add(txtCA1632);
            //ListaCuadrosCopaArg.Add(txtCA81);
            //ListaCuadrosCopaArg.Add(txtCA82);
            //ListaCuadrosCopaArg.Add(txtCA83);
            //ListaCuadrosCopaArg.Add(txtCA84);
            //ListaCuadrosCopaArg.Add(txtCA85);
            //ListaCuadrosCopaArg.Add(txtCA86);
            //ListaCuadrosCopaArg.Add(txtCA87);
            //ListaCuadrosCopaArg.Add(txtCA88);
            //ListaCuadrosCopaArg.Add(txtCA89);
            //ListaCuadrosCopaArg.Add(txtCA810);
            //ListaCuadrosCopaArg.Add(txtCA811);
            //ListaCuadrosCopaArg.Add(txtCA812);
            //ListaCuadrosCopaArg.Add(txtCA813);
            //ListaCuadrosCopaArg.Add(txtCA814);
            //ListaCuadrosCopaArg.Add(txtCA815);
            //ListaCuadrosCopaArg.Add(txtCA816);
            //ListaCuadrosCopaArg.Add(txtCA41);
            //ListaCuadrosCopaArg.Add(txtCA42);
            //ListaCuadrosCopaArg.Add(txtCA43);
            //ListaCuadrosCopaArg.Add(txtCA44);
            //ListaCuadrosCopaArg.Add(txtCA45);
            //ListaCuadrosCopaArg.Add(txtCA46);
            //ListaCuadrosCopaArg.Add(txtCA47);
            //ListaCuadrosCopaArg.Add(txtCA48);
            //ListaCuadrosCopaArg.Add(txtCA21);
            //ListaCuadrosCopaArg.Add(txtCA22);
            //ListaCuadrosCopaArg.Add(txtCA23);
            //ListaCuadrosCopaArg.Add(txtCA24);
            //ListaCuadrosCopaArg.Add(txtCA11);
            //ListaCuadrosCopaArg.Add(txtCA12);
            //ListaCuadrosCopaArg.Add(txtCACampeon);
            foreach (var Tab in Usu.ListaTablasTodasUsuario)
            {
                for (int i = 0; i < Tab.TablaCopaArgentina.Count(); i++)
                {
                    ListaCuadrosCopaArg[i].Text = Tab.TablaCopaArgentina[i].Equipo;
                }
            }            
        }
        private void CargoFormatoPrimeraDivision()
        {
            GrillaTablaPrimera.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;
            GrillaTablaPrimera.Rows[1].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            GrillaTablaPrimera.Rows[2].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            GrillaTablaPrimera.Rows[3].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            GrillaTablaPrimera.Rows[4].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            GrillaTablaPrimera.Rows[5].DefaultCellStyle.BackColor = Color.Yellow;
            GrillaTablaPrimera.Rows[6].DefaultCellStyle.BackColor = Color.Yellow;
            GrillaTablaPrimera.Rows[7].DefaultCellStyle.BackColor = Color.Yellow;
            GrillaTablaPrimera.Rows[8].DefaultCellStyle.BackColor = Color.Yellow;
            GrillaTablaPrimera.Rows[9].DefaultCellStyle.BackColor = Color.Yellow;
            GrillaTablaPrimera.Rows[10].DefaultCellStyle.BackColor = Color.Yellow;
            GrillaTablaPrimera.Rows[24].DefaultCellStyle.BackColor = Color.LightPink;
            GrillaTablaPrimera.Rows[25].DefaultCellStyle.BackColor = Color.LightPink;
            GrillaTablaPrimera.Rows[26].DefaultCellStyle.BackColor = Color.LightPink;
            GrillaTablaPrimera.Rows[27].DefaultCellStyle.BackColor = Color.LightPink;
        }
        private void CargoFormatoBNacional()
        {
            GrillaTablaBNacional.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;
            GrillaTablaBNacional.Rows[1].DefaultCellStyle.BackColor = Color.LightGreen;
            GrillaTablaBNacional.Rows[19].DefaultCellStyle.BackColor = Color.LightPink;
            GrillaTablaBNacional.Rows[20].DefaultCellStyle.BackColor = Color.LightPink;
            GrillaTablaBNacional.Rows[21].DefaultCellStyle.BackColor = Color.LightPink;
            GrillaTablaBNacional.Rows[22].DefaultCellStyle.BackColor = Color.LightPink;
            GrillaTablaBNacional.Rows[23].DefaultCellStyle.BackColor = Color.LightPink;
            GrillaTablaBNacional.Rows[24].DefaultCellStyle.BackColor = Color.LightPink;
        }
        private void Tablas_Load(object sender, EventArgs e)
        {
            CargarTablasUsuario();
            CargoGrillaTablaPrimera();
            CargoFormatoPrimeraDivision();
            CargoGrillaTablaBNacional();
            CargoFormatoBNacional();
            CargarCuadroCopaArgentina();
            RemarcarUsuario();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void TabCopaArgentina_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void TabCopaSudamericana_Click(object sender, EventArgs e)
        {
        }

        private void TabCopaLibertadores_Click(object sender, EventArgs e)
        {
        }

        private void TabBNacional_Click(object sender, EventArgs e)
        {
        }

        private void lblTorneo_Click(object sender, EventArgs e)
        {
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabCopaArgentina_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
