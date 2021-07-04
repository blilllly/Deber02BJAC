using Deber2BJAC.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deber2BJAC
{
    public partial class FrmProductoBJAC : Form
    {
        AdmpnpBJAC admPNP = new AdmpnpBJAC();
        public FrmProductoBJAC()
        {
            InitializeComponent();
        }

        private void cmbCV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            admPNP.HabilitarCompraVenta(cmbCV, txtProducto, txtCodigo, nudCantidad, txtStock, txtPrecioU, dtcFechaE, dtcFechaV);
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetter(c) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioU_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back)) && c != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (admPNP.CamposVacios(txtProducto, txtCodigo, txtStock, txtPrecioU, dtcFechaE, dtcFechaV)) return;
            if (admPNP.ComprobarFechas(dtcFechaE, dtcFechaV)) return;
            admPNP.Guardar(cmbCV, txtProducto, txtCodigo, txtStock, txtPrecioU, dtcFechaE, dtcFechaV, nudCantidad, cmbCV);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            admPNP.ListarProductos(txtArea);
        }

        private void btnPMC_Click(object sender, EventArgs e)
        {
            txtArea.Text = admPNP.MasCaro() != null ? admPNP.MasCaro().ToString() : "";
        }

        private void btnCaduccion_Click(object sender, EventArgs e)
        {
            admPNP.OrdenarXCaduccion();
            admPNP.ListarProductos(txtArea);
        }
    }
}
