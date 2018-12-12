using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoresa.Models
{
    public class Auto : Vehiculomovil
    {
        private string tipo;

        public Auto() {

        }

        public Auto(string tipo)
        {
            this.tipo = tipo;
        }

        public string Tipo { get => tipo; set => tipo = value; }
    }
}
