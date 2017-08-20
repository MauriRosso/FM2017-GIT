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
    public partial class Configurar_juego_Calendario : Form
    {
        public Configurar_juego_Calendario()
        {
            InitializeComponent();
        }

        private void Configurar_juego_Calendario_Load(object sender, EventArgs e)
        {
            
        }

        CalendarioCompleto Cal = new CalendarioCompleto(); 

        public void GuardarArchivoCalendario()
        {
            string ArchivoEquipos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosCalendario.json";

            using (StreamWriter file = new StreamWriter(ArchivoEquipos, false))
            {
                string Salida = JsonConvert.SerializeObject(Cal.ListaPartidosCalendario);
                file.Write(Salida);
            }
        }
        public void CargarArchivoCalendario()
        {
            string LeerEquipos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosCalendario.json";

            using (StreamReader Entrada = new StreamReader(LeerEquipos))
            {
                string contenido = Entrada.ReadToEnd();

                Cal.ListaPartidosCalendario = JsonConvert.DeserializeObject<List<Partido>>(contenido);
            }
        }
    }
}
