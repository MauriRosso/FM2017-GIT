using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Manager_2016
{
    public partial class FixtureCompleto : Form
    {
        public FixtureCompleto()
        {
            InitializeComponent();
        }
        Usuario Usu = new Usuario();
        public void CargarArchivo()
        {
            string LeerTemp = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamReader Entrada = new StreamReader(LeerTemp))
            {
                string contenido = Entrada.ReadToEnd();

               Usu = JsonConvert.DeserializeObject<Usuario>(contenido);
            }
        }
        int NumeroItem;
        public void CargarFixture()
        {
            NumeroItem = 0;
            foreach (var item in Usu.ListaPartidosCalendario)
            {
                if (item.Jornada == Convert.ToInt32(txtFechaActual.Text))
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
                        ListaFixture.SubItems.Add(item.Jornada.ToString());
                        listViewFixture.Items.Add(ListaFixture);
                    }
                }
                
            }
        }
        int FechaActual;
        private void FixtureCompleto_Load(object sender, EventArgs e)
        {
            FechaActual = 1;
            txtFechaActual.Text = Convert.ToString(FechaActual);
            CargarArchivo();
            CargarFixture();           
        }

        private void listViewFixture_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void txtFechaActual_TextChanged(object sender, EventArgs e)
        {
            listViewFixture.Items.Clear();
            CargarFixture();
        }
        private void btnFechaAdelante_Click(object sender, EventArgs e)
        {
            if (FechaActual < 30)
            {
                FechaActual += 1;
                txtFechaActual.Text = Convert.ToString(FechaActual);
                
            }
        }

        private void btnFechaAtras_Click(object sender, EventArgs e)
        {
            if (FechaActual > 1)
            {
                FechaActual -= 1;
                txtFechaActual.Text = Convert.ToString(FechaActual);
            }
        }
    }
}
