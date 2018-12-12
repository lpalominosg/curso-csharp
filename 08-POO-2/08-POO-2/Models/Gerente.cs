using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public class Gerente : Trabajador
    {
        public Gerente()
        {
        }

        public Gerente(string nombre, string tipo) : base(nombre, tipo)
        {
        }

        public override int Liquidación(int sueldobase)
        {
            return sueldobase + 100000;
        }
    }
}
