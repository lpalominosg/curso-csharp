using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoresa.Models
{
    class VentaAlcholes : IVenta
    {
        public double Agregariva(int totalneto)
        {
            return totalneto * 1.45;
        }

        public int Totalizar(int precio, int cantidad)
        {
            return precio * cantidad;
        }
    }
}
