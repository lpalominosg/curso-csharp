using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public abstract class Trabajador
    {
        private string nombre;
        private string tipo;

        public Trabajador()
        {
        }
        public Trabajador(string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public abstract int Liquidación(int sueldobase);
    }
}
