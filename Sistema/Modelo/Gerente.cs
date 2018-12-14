using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class Gerente : Trabajador
    {
        public override int liquidacion(int sueldobruto)
        {
            return sueldobruto + 100000;
        }
    }
}
