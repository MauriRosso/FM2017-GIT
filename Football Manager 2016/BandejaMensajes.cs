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
    public partial class BandejaMensajes : Form
    {
        public BandejaMensajes()
        {
            InitializeComponent();
        }

        private void BandejaMensajes_Load(object sender, EventArgs e)
        {
            CargarArchivosUsuario();
            CargarUsuario();
            CargarGrilla();
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
        public void GuardarArchivoTemp()
        {
            string ArchivoTemp = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamWriter file = new StreamWriter(ArchivoTemp, false))
            {
                string Salida = JsonConvert.SerializeObject(Usu);
                file.Write(Salida);
            }
        }
        public void CargarGrilla()
        {
            int F = 0;
            foreach (var item in Usu.ListaMensajes)
            {
                F = GrillaMensajes.Rows.Add();

                if (item.Leido == false)
                {
                    GrillaMensajes.Rows[F].Cells[0].Value = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Imagenes Generales\Mensaje_Cerrado.png");
                    GrillaMensajes.Rows[F].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    GrillaMensajes.Rows[F].Cells[0].Value = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Imagenes Generales\Mensaje_Abierto.png");
                }
                GrillaMensajes.Rows[F].Cells[2].Value = item.Asunto;
                GrillaMensajes.Rows[F].Cells[3].Value = item.Emisor;
                GrillaMensajes.Rows[F].Cells[4].Value = item.Fecha;
            }          
        }

        private void GrillaMensajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GrillaMensajes.CurrentRow.Cells[0].Value = Image.FromFile(@"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Imagenes Generales\Mensaje_Abierto.png");
            GrillaMensajes.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
            foreach (var item in Usu.ListaMensajes)
            {
                if (GrillaMensajes.CurrentRow.Cells[2].Value.ToString() == item.Asunto)
                {
                    txtCuerpoMensaje.Text = item.Cuerpo;
                    item.Leido = true;
                    break;
                }
            }
            GuardarArchivoTemp();
        }

        private void btnCerrarBandejaMensajes_Click(object sender, EventArgs e)
        {
            PantallaPrincipal Pan = new PantallaPrincipal();
            Pan.Show();
            this.Close();
        }
    }
}
