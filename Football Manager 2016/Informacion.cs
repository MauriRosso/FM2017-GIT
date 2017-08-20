using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Manager_2016
{
    public partial class Informacion : Form
    {
        public Informacion()
        {
            InitializeComponent();
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            
        }

        private void ArbolInformacion_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode Nodo = ArbolInformacion.SelectedNode;
            if (Nodo.Text == "Guardar Partida")
            {
                txtInformacionMostrar.Text = "\r\n";
                txtInformacionMostrar.Text += "                                                                    GUARDAR PARTIDA";
                txtInformacionMostrar.Text += "\r\n" + "\r\n" + "\r\n";
                txtInformacionMostrar.Text += " Pulsa el boton GUARDAR PARTIDA para guardar la partida actual. ";
                txtInformacionMostrar.Text += "\r\n";
                txtInformacionMostrar.Text += " Asegúrate de guardarla cada vez que finalizes un encuentro o realizes un ajuste en cualquier apartado.";
                txtInformacionMostrar.Text += "\r\n";
            }
            if (Nodo.Text == "Fixture")
            {
                txtInformacionMostrar.Text = "\r\n";
                txtInformacionMostrar.Text += "                                                                        FIXTURE";
                txtInformacionMostrar.Text += "\r\n" + "\r\n" + "\r\n";
                txtInformacionMostrar.Text += " Pulsa el boton FIXTURE para ver el calendario de partidos de tu equipo.";

            }
            if (Nodo.Text == "Tabla de Posiciones")
            {
                txtInformacionMostrar.Text = "\r\n";
                txtInformacionMostrar.Text += "                                                                         POSICIONES";
                txtInformacionMostrar.Text += "\r\n" + "\r\n" + "\r\n";
                txtInformacionMostrar.Text += " Pulsa el boton POSICIONES para ver la tabla de posiciones de las competiciones existentes.";
                txtInformacionMostrar.Text += "\r\n";
                txtInformacionMostrar.Text += " El equipo que salga en 1ERA posición sera el campeón de la liga.";
                txtInformacionMostrar.Text += "\r\n";
                txtInformacionMostrar.Text += " Los últimos 4 equipos descenderán a la Primera 'B' Nacional.";
                txtInformacionMostrar.Text += "\r\n";
                txtInformacionMostrar.Text += " Los mejores 5 equipos y el campeón de la COPA ARGENTINA clasificarán a la próxima COPA LIBERTADORES.";
                txtInformacionMostrar.Text += "\r\n";
                txtInformacionMostrar.Text += " Los siguientes 6 puestos del Torneo de Primera División que no estén clasificados a la Copa Libertadores clasificarán a la próxima COPA SUDAMERICANA.";
            }
        }
    }
}
