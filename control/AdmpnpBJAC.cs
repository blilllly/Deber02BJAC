using Deber2BJAC.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deber2BJAC.control
{
    class AdmpnpBJAC
    {
        private List<ProductoBJAC> lista = new List<ProductoBJAC>();
        ValidacionBJAC v = new ValidacionBJAC();

        public ProductoNoPerecibleBJAC MasCaro()
        {

            //hay productos?
            if (lista.Count == 0) return null;
            return (ProductoNoPerecibleBJAC)lista.OrderBy(producto => producto.PrecioU).Last();
        }
        public List<ProductoBJAC> OrdenarXCaduccion()
        {
            if (lista.Count == 0) return null;
            lista.Sort((x, y) => x.Tiempo.CompareTo(y.Tiempo));
            return lista;
        }
        public void HabilitarCompraVenta(ComboBox tipo, TextBox nombre, TextBox codigo, NumericUpDown cantidad, TextBox stock, TextBox precioU, DateTimePicker fechaE, DateTimePicker fechaV)
        {
            if (tipo.Text == "Compra" || tipo.Text == "Venta")
            {
                nombre.Enabled = true;
                codigo.Enabled = true;
                cantidad.Enabled = true;
                stock.Enabled = true;
                fechaE.Enabled = true;
                fechaV.Enabled = true;
                precioU.Enabled = true;
            }
        }

        internal bool CamposVacios(TextBox nombre, TextBox codigo, TextBox stock, TextBox precioU, DateTimePicker fechaE, DateTimePicker fechaV)
        {

            if (nombre.Text == "" || codigo.Text == "" || precioU.Text == "" || stock.Text == "" || fechaE.Text == "" || fechaV.Text == "" || !v.EsReal(precioU.Text) || !v.EsEntero(codigo.Text))
            {
                MessageBox.Show("Por favor llene todos los campos correctamente");
                return true;
            }
            return false;
        }

        internal Boolean ComprobarFechas(DateTimePicker dtcFechaE, DateTimePicker dtcFechaV)
        {
            DateTime fechaE = dtcFechaE.Value.Date;
            DateTime fechaV = dtcFechaV.Value.Date;

            if (fechaV.CompareTo(fechaE) != 1)
            {
                MessageBox.Show("La fecha de elaboracion no puede ser mayor o igual a la de vencimiento");
                return true;
            }

            return false;
        }

        internal void Guardar(ComboBox item, TextBox txtNombre, TextBox txtCodigo, TextBox txtStock, TextBox txtPrecioU, DateTimePicker dtcFechaE, DateTimePicker dtcFechaV, NumericUpDown nudCantidad, ComboBox cmbCV)
        {

            string nombre = txtNombre.Text;
            int codigo = v.AEntero(txtCodigo.Text);
            int cantidad = v.AEntero(nudCantidad.Text);
            int stock = v.AEntero(txtStock.Text);
            double precioU = v.AReal(txtPrecioU.Text);
            DateTime fechaE = dtcFechaE.Value.Date;
            DateTime fechaV = dtcFechaV.Value.Date;

            ProductoNoPerecibleBJAC pNP = new ProductoNoPerecibleBJAC(nombre, precioU, stock, codigo, fechaE, fechaV);

            if (cmbCV.Text == "Compra")
            {
                pNP.Comprar(cantidad);
            }
            else
            {
                pNP.Vender(cantidad);
            }


            lista.Add(pNP);

            MessageBox.Show("Datos de la "+item.Text+ " guardados Satisfactoriamente");

        }

        internal void ListarProductos(TextBox txtListado)
        {
            if (lista.Count == 0) return;
            txtListado.Text = "";
            lista.ForEach(producto => {
                txtListado.Text += producto.ToString();
            });
        }
    }
}
