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
    public partial class Estadio : Form
    {
        public Estadio()
        {
            InitializeComponent();
        }

        private void ptbFondoEstadio_Click(object sender, EventArgs e)
        {

        }
        public void Transparencias()
        {
            lblEstadioNomClu.Parent = ptbFondoEstadio;
            lblEstadioNomClu.BackColor = Color.Transparent;
            lblEstadioNombreClub.Parent = ptbFondoEstadio;
            lblEstadioNombreClub.BackColor = Color.Transparent;
            lblNomEst.Parent = ptbFondoEstadio;
            lblNomEst.BackColor = Color.Transparent;
            lblNombreEstadio.Parent = ptbFondoEstadio;
            lblNombreEstadio.BackColor = Color.Transparent;
            lblEspectadores.Parent = ptbFondoEstadio;
            lblEspectadores.BackColor = Color.Transparent;
            lblEstCap.Parent = ptbFondoEstadio;
            lblEstCap.BackColor = Color.Transparent;
            lblEstadioCapacidad.Parent = ptbFondoEstadio;
            lblEstadioCapacidad.BackColor = Color.Transparent;
        }
        private void Estadio_Load(object sender, EventArgs e)
        {
            CargarArchivos();
            CargaDatos();
            Transparencias();
        }
        Usuario Usu = new Usuario();
        Equipos Equ = new Equipos();
        public void CargarArchivos()
        {       
            string LeerTemp = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamReader Entrada = new StreamReader(LeerTemp))
            {
                string contenido = Entrada.ReadToEnd();

                Usu = JsonConvert.DeserializeObject<Usuario>(contenido);
            }

            string LeerEquipos = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosEquipos.json";

            using (StreamReader Entrada = new StreamReader(LeerEquipos))
            {
                string contenido = Entrada.ReadToEnd();

                Equ.ListaEquipos = JsonConvert.DeserializeObject<List<PropiedadesEquipos>>(contenido);
            }
        }
        //Guardar en Lista.LU tambien
        public void CargaDatos()
        {
            foreach (var item in Equ.ListaEquipos)
            {
                if (item.Nombre == Usu.Equipo)
                {
                    lblEstadioNombreClub.Text = item.Nombre;
                    lblNombreEstadio.Text = item.NombreEstadio;
                    lblEstadioCapacidad.Text = item.CapacidadEstadio.ToString("N0");
                }
            }
           
        }
    }
}
