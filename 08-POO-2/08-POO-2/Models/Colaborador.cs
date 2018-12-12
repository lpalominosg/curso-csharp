using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public class Colaborador : Trabajador
    {
        public Colaborador()
        {
        }

        public Colaborador(string nombre, string tipo) : base(nombre, tipo)
        {
        }

        public override int Liquidación(int sueldobase)
        {
            return sueldobase + 20000;
        }
    }
}
