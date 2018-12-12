using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoresa.Models
{
    public class Venta : IVenta
    {
        public double Agregariva(int totalneto)
        {
            return totalneto * 1.19;
        }

        public int Totalizar(int precio, int cantidad)
        {

            return precio * cantidad;
        }
    }
}
