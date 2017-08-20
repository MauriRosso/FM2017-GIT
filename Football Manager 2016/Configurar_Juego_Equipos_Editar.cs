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
    public partial class Configurar_Juego_Equipos_Editar : Form
    {
        public Configurar_Juego_Equipos_Editar()
        {
            InitializeComponent();
        }

        public Configurar_Juego_Equipos_Editar(string EquipoModificar, string Estadio, string Capacidad, string Presupuesto)
        {
            InitializeComponent();
            lblEquipoEditar.Text = EquipoModificar;
            txtEstadio.Text = Estadio;
            ntxtCapacidad.Text = Capacidad;
            ntxtPresupuesto.Text = Presupuesto;
        }
        Equipos Equ = new Equipos();

        public void GuardarArchivosEquipos()
        {
            string ArchivoEquipos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosEquipos.json";

            using (StreamWriter file = new StreamWriter(ArchivoEquipos, false))
            {
                string Salida = JsonConvert.SerializeObject(Equ.ListaEquipos);
                file.Write(Salida);
            }
        }
        public void CargarArchivosEquipos()
        {
            string LeerEquipos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosEquipos.json";

            using (StreamReader Entrada = new StreamReader(LeerEquipos))
            {
                string contenido = Entrada.ReadToEnd();

                Equ.ListaEquipos = JsonConvert.DeserializeObject<List<PropiedadesEquipos>>(contenido);
            }
        }
        private void Configurar_Juego_Equipos_Editar_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CargarArchivosEquipos();
            foreach (var item in Equ.ListaEquipos)
            {
                if (item.Nombre == lblEquipoEditar.Text)
                {
                    item.Division = cbxCfgDivisionEquipo.SelectedItem.ToString();
                    item.NombreEstadio = txtEstadio.Text;
                    item.CapacidadEstadio = Convert.ToInt32(ntxtCapacidad.Text);
                    item.Presupuesto = Convert.ToInt32(ntxtPresupuesto.Text);
                    break;
                }
            }
            GuardarArchivosEquipos();
            this.Close();
        }
    }
}
