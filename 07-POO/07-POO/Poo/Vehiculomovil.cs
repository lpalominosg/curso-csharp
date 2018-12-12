using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoresa.Models
{
    public class Vehiculomovil
    {
        private string matricula;
        private string marca;
        private string color;

        public Vehiculomovil() {

        }

        public Vehiculomovil(string matricula, string marca, string color)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
    }
}
