using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoresa.Models
{
    public class Cuenta : ICuenta
    {
        public double Aplicacargo(int monto)
        {
            return monto + monto * 0.20;
        }
    }
}
