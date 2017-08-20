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
    public partial class Configurar_Juego_Fixture_Editar : Form
    {
        public Configurar_Juego_Fixture_Editar()
        {
            InitializeComponent();
        }
        public Configurar_Juego_Fixture_Editar(DateTime Fecha, string EquipoLocal, string EquipoVisitante)
        {
            InitializeComponent();
            lblEquipoLocal.Text = EquipoLocal;
            lblEquipoVisitante.Text = EquipoVisitante;
            lblFechaAntigua.Text = Fecha.ToLongDateString();
        }
        public void CargarArchivosPartidos()
        {
            string LeerListaPartidos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosPartidos.json";

            using (StreamReader Entrada = new StreamReader(LeerListaPartidos))
            {
                string contenido = Entrada.ReadToEnd();

                Partidos.ListaPartidos = JsonConvert.DeserializeObject<List<Partido>>(contenido);
            }
        }
        public void GuardarArchivosPartidos()
        {
            string ArchivosPartidos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosPartidos.json";

            using (StreamWriter file = new StreamWriter(ArchivosPartidos, false))
            {
                string Salida = JsonConvert.SerializeObject(Partidos.ListaPartidos);
                file.Write(Salida);
            }
        }
        Partidos Partidos = new Partidos();
        private void Configurar_Juego_Fixture_Editar_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CargarArchivosPartidos();
            foreach (var item in Partidos.ListaPartidos)
            {
               
                if (item.FechaPartido == Convert.ToDateTime(lblFechaAntigua.Text) && item.EquipoLocal == lblEquipoLocal.Text && item.EquipoVisitante == lblEquipoVisitante.Text)
                {
                    item.FechaPartido = Convert.ToDateTime(dtpNuevaFecha.Value); ////////////ERRORRRRRRRR
                    break;
                }
            }
            Partidos.ListaPartidos = Partidos.ListaPartidos.OrderBy(x => x.FechaPartido).ToList();
            GuardarArchivosPartidos();
            this.Close();
        }
    }
}
/// El problema esta en como comparo el formato de hora. GUARDAR sin hora.
