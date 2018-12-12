using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoresa.Models
{
    public class Padre
    {
        private string apellido;
        private int herencia;

        public Padre()
        {
        }

        public Padre(string apellido, int herencia)
        {
            this.apellido = apellido;
            this.herencia = herencia;
        }

        public string Apellido { get => apellido; set => apellido = value; }
        public int Herencia { get => herencia; set => herencia = value; }
    }
}
