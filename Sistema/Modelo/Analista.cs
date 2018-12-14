using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class Analista : Trabajador
    {
        public override int liquidacion(int sueldobruto)
        {
            return sueldobruto + 250000;
        }
    }
}
