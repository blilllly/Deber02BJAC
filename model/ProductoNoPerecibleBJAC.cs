using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber2BJAC.model
{
    class ProductoNoPerecibleBJAC: ProductoBJAC
    {
        private DateTime fechaE;
        private DateTime fechaV;

        public ProductoNoPerecibleBJAC(string nombre, double precioU, int stock, int codigo, DateTime fechaE, DateTime fechaV) : base(nombre, precioU, stock, codigo)
        {
            this.fechaE = fechaE;
            this.fechaV = fechaV;
        }

        public DateTime FechaE { get => fechaE; set => fechaE = value; }
        public DateTime FechaV { get => fechaV; set => fechaV = value; }

        public override string ToString()
        {
            return base.ToString()+"Fecha de Elaboracion: "+FechaE+"\r\nFecha de Vencimiento: "+FechaV+"\r\n"+TiempoCaduccion()+"\r\n\r\n";
        }

        public string TiempoCaduccion()
        {
            Tiempo = FechaV.Subtract(FechaE).Days;
            string dias = Tiempo.ToString();

            return "Tiempo de Caduccion: "+dias+ " dias";
        }
    }
}
