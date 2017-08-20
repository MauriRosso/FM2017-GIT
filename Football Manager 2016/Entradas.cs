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
    public partial class Entradas : Form
    {
        public Entradas()
        {
            InitializeComponent();
        }
        Usuario Usu = new Usuario();
        PantallaPrincipal Pan = new PantallaPrincipal();
        
        private void btnEntradasActualizar_Click(object sender, EventArgs e)
        {
            Usu.PrecioPopulares = Convert.ToInt32(upPopulares.Value);
            Usu.PrecioPlateas = Convert.ToInt32(upPlateas.Value);
            Usu.PrecioPalcos = Convert.ToInt32(upPalcos.Value);
            GuardarUsuario();
            MessageBox.Show("Los precios de las entradas han sido actualizados correctamente.", "Actualizar precios de las entradas", MessageBoxButtons.OK, MessageBoxIcon.Information);   
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
        public void GuardarUsuario()
        {
            string ArchivoTemp = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamWriter file = new StreamWriter(ArchivoTemp, false))
            {
                string Salida = JsonConvert.SerializeObject(Usu);
                file.Write(Salida);
            }
        }
        private void Entradas_Load(object sender, EventArgs e)
        {
            CargarUsuario();
            upPopulares.Value = Usu.PrecioPopulares;
            upPlateas.Value = Usu.PrecioPlateas;
            upPalcos.Value = Usu.PrecioPalcos;
        }
    }
}
