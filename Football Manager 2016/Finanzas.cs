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
    public partial class Finanzas : Form
    {
        public Finanzas()
        {
            InitializeComponent();
        }
        public void Transparencias()
        {
            lblFinanzas.Parent = ptbFinanzas;
            lblFinanzas.BackColor = Color.Transparent;
            lblIngresos.Parent = ptbFinanzas;
            lblIngresos.BackColor = Color.Transparent;
            lblEntr.Parent = ptbFinanzas;
            lblEntr.BackColor = Color.Transparent;
            lblEntradas.Parent = ptbFinanzas;
            lblEntradas.BackColor = Color.Transparent;
            lblPrem.Parent = ptbFinanzas;
            lblPrem.BackColor = Color.Transparent;
            lblPremios.Parent = ptbFinanzas;
            lblPremios.BackColor = Color.Transparent;
            lblVentJug.Parent = ptbFinanzas;
            lblVentJug.BackColor = Color.Transparent;
            lblPresBan.Parent = ptbFinanzas;
            lblPresBan.BackColor = Color.Transparent;
            lblSpon.Parent = ptbFinanzas;
            lblSpon.BackColor = Color.Transparent;
            lblVentasJugadores.Parent = ptbFinanzas;
            lblVentasJugadores.BackColor = Color.Transparent;
            lblPrestamoBancario.Parent = ptbFinanzas;
            lblPrestamoBancario.BackColor = Color.Transparent;
            lblSponsor.Parent = ptbFinanzas;
            lblSponsor.BackColor = Color.Transparent;
            lblSubT1.Parent = ptbFinanzas;
            lblSubT1.BackColor = Color.Transparent;
            lblSubTotal1.Parent = ptbFinanzas;
            lblSubTotal1.BackColor = Color.Transparent;
            lblGastos.Parent = ptbFinanzas;
            lblGastos.BackColor = Color.Transparent;
            lblCompJug.Parent = ptbFinanzas;
            lblCompJug.BackColor = Color.Transparent;
            lblComprasJugadores.Parent = ptbFinanzas;
            lblComprasJugadores.BackColor = Color.Transparent;
            lblEst.Parent = ptbFinanzas;
            lblEst.BackColor = Color.Transparent;
            lblEstadio.Parent = ptbFinanzas;
            lblEstadio.BackColor = Color.Transparent;
            lblSal.Parent = ptbFinanzas;
            lblSal.BackColor = Color.Transparent;
            lblSalarios.Parent = ptbFinanzas;
            lblSalarios.BackColor = Color.Transparent;
            lblImp.Parent = ptbFinanzas;
            lblImp.BackColor = Color.Transparent;
            lblImpuestos.Parent = ptbFinanzas;
            lblImpuestos.BackColor = Color.Transparent;
            lblMult.Parent = ptbFinanzas;
            lblMult.BackColor = Color.Transparent;
            lblMultas.Parent = ptbFinanzas;
            lblMultas.BackColor = Color.Transparent;
            lblSubT2.Parent = ptbFinanzas;
            lblSubT2.BackColor = Color.Transparent;
            lblSubTotal2.Parent = ptbFinanzas;
            lblSubTotal2.BackColor = Color.Transparent;
            lblSald.Parent = ptbFinanzas;
            lblSald.BackColor = Color.Transparent;
            lblSaldo.Parent = ptbFinanzas;
            lblSaldo.BackColor = Color.Transparent;
            lblSala.Parent = ptbFinanzas;
            lblSala.BackColor = Color.Transparent;
            lblSalarioMensual.Parent = ptbFinanzas;
            lblSalarioMensual.BackColor = Color.Transparent;
            lblPrestamoAFA.Parent = ptbFinanzas;
            lblPrestamoAFA.BackColor = Color.Transparent;
            btnPrestamoAFA.Parent = ptbFinanzas;
            btnPrestamoAFA.BackColor = Color.Transparent;


        }
        private void Finanzas_Load(object sender, EventArgs e)
        {
            Transparencias();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
