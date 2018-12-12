using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoresa.Models
{
    public class Hijo : Padre
    {
        private string nombre;
        private string mama;

        public Hijo() {
        }

        public Hijo(string apellido, int herencia) : base(apellido, herencia)
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Mama { get => mama; set => mama = value; }
    }


}
