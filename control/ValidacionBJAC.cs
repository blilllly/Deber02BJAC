using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deber2BJAC.control
{
    class ValidacionBJAC
    {
        public Boolean EsReal(string valor)
        {
            try
            {
                Convert.ToDouble(valor);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean EsEntero(string valor)
        {
            try
            {
                Convert.ToInt32(valor);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int AEntero(string valor)
        {
            int x = 0;

            try
            {
                x = Convert.ToInt32(valor);
                return x;
            }
            catch
            {
                MessageBox.Show("ERROR: Hay campos mal insertados");
                return x;
            }
        }

        public double AReal(string valor)
        {
            double x = 0;

            try
            {
                x = Convert.ToDouble(valor);
                return x;
            }
            catch
            {
                MessageBox.Show("ERROR: Hay campos mal insertados");
                return x;
            }
        }
    }
}
