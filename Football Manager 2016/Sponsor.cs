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
    public partial class Sponsor : Form
    {
        public Sponsor()
        {
            InitializeComponent();
        }
        Usuario Usu = new Usuario();
        PantallaPrincipal Pan = new PantallaPrincipal();
       
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
        private void Sponsor_Load(object sender, EventArgs e)
        {
            CargarUsuario();
        }

        private void btnContratarSponsor_Click(object sender, EventArgs e)
        {
            int Ban = 0;
            if (rbtnSponsorCocaCola.Checked)
            {
                Usu.Sponsor = "CocaCola";
                Ban = 1;
            }
            if (rbtnSponsorBlackBerry.Checked)
            {
                Usu.Sponsor = "BlackBerry";
                Ban = 1;
            }
            if (rbtnSponsorBBVA.Checked)
            {
                Usu.Sponsor = "BBVA";
                Ban = 1;
            }
            if (rbtnSponsorFlyEmirates.Checked)
            {
                Usu.Sponsor = "FlyEmirates";
                Ban = 1;
            }
            if (rbtnSponsorHP.Checked)
            {
                Usu.Sponsor = "HP";
                Ban = 1;
            }
            if (rbtnSponsorHuawei.Checked)
            {
                Usu.Sponsor = "Huawei";
                Ban = 1;
            }
            if (rbtnSponsorIntel.Checked)
            {
                Usu.Sponsor = "Intel";
                Ban = 1;
            }
            if (rbtnSponsorLG.Checked)
            {
                Usu.Sponsor = "LG";
                Ban = 1;
            }
            if (rbtnSponsorMasterCard.Checked)
            {
                Usu.Sponsor = "MasterCard";
                Ban = 1;
            }
            if (rbtnSponsorMicrosoft.Checked)
            {
                Usu.Sponsor = "Microsoft";
                Ban = 1;
            }
            if (rbtnSponsorNextel.Checked)
            {
                Usu.Sponsor = "Nextel";
                Ban = 1;
            }
            if (rbtnSponsorRedBull.Checked)
            {
                Usu.Sponsor = "RedBull";
                Ban = 1;
            }
            if (rbtnSponsorSamsung.Checked)
            {
                Usu.Sponsor = "Samsung";
                Ban = 1;
            }
            if (rbtnSponsorSony.Checked)
            {
                Usu.Sponsor = "Sony";
                Ban = 1;
            }
            if (rbtnSponsorSubWay.Checked)
            {
                Usu.Sponsor = "SubWay";
                Ban = 1;
            }
            if (rbtnSponsorToyota.Checked)
            {
                Usu.Sponsor = "Toyota";
                Ban = 1;
            }

            if (Ban == 1)
            {
                if (MessageBox.Show("¿Estás seguro que deseas contratar este sponsor?", "Contratar Sponsor", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (Usu.Reputacion >= 50)
                    {
                        GuardarUsuario();
                        MessageBox.Show("¡Sponsor contratado exitosamente!", "Contratar Sponsor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tu reputación es demasiado baja para contratar un sponsor. (REPUTACIÓN MÍNIMA REQUERIDA: 50 Pts)", "Contratar Sponsor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("¡No has seleccionado ningún sponsor!", "Contratar Sponsor",  MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
