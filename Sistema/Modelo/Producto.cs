using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class Producto
    {
        private string codprod;
        private string nombre;
        private int valorunitario;

        public Producto() {
        }

        public Producto(string codprod, string nombre, int valorunitario)
        {
            this.codprod = codprod;
            this.nombre = nombre;
            this.valorunitario = valorunitario;
        }

        public string Codprod { get => codprod; set => codprod = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Valorunitario { get => valorunitario; set => valorunitario = value; }
    }
}
