using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber2BJAC.model
{
    class ProductoBJAC
    {
        private string nombre;
        private double precioU;
        private int stock;
        private int codigo;
        private int tiempo;
        private DateTime fecha=DateTime.Now;


        public ProductoBJAC(string nombre, double precioU, int stock, int codigo)
        {

            this.nombre = nombre;
            this.precioU = precioU;
            this.stock = stock;
            this.codigo = codigo;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double PrecioU { get => precioU; set => precioU = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Tiempo { get => tiempo; set => tiempo = value; }

        public override string ToString()
        {
            return "Nombre: "+Nombre+"\r\nId: "+Codigo+"\r\nPrecio: "+PrecioU+"\r\nStock: "+Stock+"\r\nFecha Actual: "+fecha+"\r\n";
        }

        public void Comprar(int cantidad)
        {
            Stock += cantidad;
        }

        public void Vender(int cantidad)
        {
            Stock -= cantidad;
        }

    }
}
