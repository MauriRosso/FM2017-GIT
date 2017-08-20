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
    public partial class Ayudante_de_campo : Form
    {
        public Ayudante_de_campo()
        {
            InitializeComponent();
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
        public void GuardarDatosUsuario()
        {
            string path = @"C:\Users\mauri\Desktop\MAURI\FootballManager2016\Archivos\DatosTemp.json";

            using (StreamWriter file = new StreamWriter(path, false))
            {
                string Salida = JsonConvert.SerializeObject(Usu);
                file.Write(Salida);
            }
        }
        private void ptbAyudante6_Click(object sender, EventArgs e)
        {

        }

        private void Ayudante_de_campo_Load(object sender, EventArgs e)
        {
            CargarArchivosUsuario();
            CargarUsuario();
            cpbAyudante1.Value = 15;
            cpbAyudante1.Text = 15 + "%";
            cpbAyudante2.Value = 30;
            cpbAyudante2.Text = 30 + "%";
            cpbAyudante3.Value = 50;
            cpbAyudante3.Text = 50 + "%";
            cpbAyudante4.Value = 70;
            cpbAyudante4.Text = 70 + "%";
            cpbAyudante5.Value = 85;
            cpbAyudante5.Text = 85 + "%";
            cpbAyudante6.Value = 100;
            cpbAyudante6.Text = 100 + "%";
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnContratar_Click(object sender, EventArgs e)
        {
            if (rbAyudante1.Checked)
            {
                if ("Cristian García" != Usu.AyudanteCampo)
                {
                    if (MessageBox.Show("¿Estas seguro que deseas contratar a Cristian García como tu ayudante de campo?", "Contratar ayudante de campo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (Usu.Presupuesto >= 50000)
                        {
                            Usu.Presupuesto -= 50000;
                            Usu.AyudanteCampo = "Cristian García";
                            MessageBox.Show("¡Ya tienes un nuevo ayudante de campo!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("¡Fondos insuficientes!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("¡Ya tienes contratado a este ayudante de campo!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rbAyudante2.Checked)
            {
                if ("Marco Gregorio" != Usu.AyudanteCampo)
                {
                    if (MessageBox.Show("¿Estas seguro que deseas contratar a Marco Gregorio como tu ayudante de campo?", "Contratar ayudante de campo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (Usu.Presupuesto >= 300000)
                        {
                            Usu.Presupuesto -= 300000;
                            Usu.AyudanteCampo = "Marco Gregorio";
                            MessageBox.Show("¡Ya tienes un nuevo ayudante de campo!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("¡Fondos insuficientes!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("¡Ya tienes contratado a este ayudante de campo!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rbAyudante3.Checked)
            {
                if ("Antonio Palmieri" != Usu.AyudanteCampo)
                {
                    if (MessageBox.Show("¿Estas seguro que deseas contratar a Antonio Palmieri como tu ayudante de campo?", "Contratar ayudante de campo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (Usu.Presupuesto >= 750000)
                        {
                            Usu.Presupuesto -= 750000;
                            Usu.AyudanteCampo = "Antonio Palmieri";
                            MessageBox.Show("¡Ya tienes un nuevo ayudante de campo!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("¡Fondos insuficientes!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("¡Ya tienes contratado a este ayudante de campo!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rbAyudante4.Checked)
            {
                if ("Patric Loovren" != Usu.AyudanteCampo)
                {
                    if (MessageBox.Show("¿Estas seguro que deseas contratar a Patric Loovren como tu ayudante de campo?", "Contratar ayudante de campo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (Usu.Presupuesto >= 1000000)
                        {
                            Usu.Presupuesto -= 1000000;
                            Usu.AyudanteCampo = "Patric Loovren";
                            MessageBox.Show("¡Ya tienes un nuevo ayudante de campo!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("¡Fondos insuficientes!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("¡Ya tienes contratado a este ayudante de campo!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rbAyudante5.Checked)
            {
                if ("Ronnie Keane" != Usu.AyudanteCampo)
                {
                    if (MessageBox.Show("¿Estas seguro que deseas contratar a Ronnie Keane como tu ayudante de campo?", "Contratar ayudante de campo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (Usu.Presupuesto >= 3000000)
                        {
                            Usu.Presupuesto -= 3000000;
                            Usu.AyudanteCampo = "Ronnie Keane";
                            MessageBox.Show("¡Ya tienes un nuevo ayudante de campo!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("¡Fondos insuficientes!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("¡Ya tienes contratado a este ayudante de campo!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rbAyudante6.Checked)
            {
                if ("Hans Günther" != Usu.AyudanteCampo)
                {
                    if (MessageBox.Show("¿Estas seguro que deseas contratar a Hans Günther como tu ayudante de campo?", "Contratar ayudante de campo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (Usu.Presupuesto >= 5000000)
                        {
                            Usu.Presupuesto -= 5000000;
                            Usu.AyudanteCampo = "Hans Günther";
                            MessageBox.Show("¡Ya tienes un nuevo ayudante de campo!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("¡Fondos insuficientes!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("¡Ya tienes contratado a este ayudante de campo!", "Contratar ayudante de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            GuardarDatosUsuario();
        }

        private void btnCerrarAyudante_Click(object sender, EventArgs e)
        {
            PantallaPrincipal Pan = new PantallaPrincipal();
            Pan.Show();
            this.Close();
        }
    }
}
