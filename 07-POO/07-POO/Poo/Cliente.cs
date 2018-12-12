using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoresa.Models
{
    public class Cliente
    {
        private string rut;
        private string nombre;
        private string apellido;
        private int tipo; // 0 - Normal 1 - Vip

        public Cliente() // Constructor por defecto
        {
        }

        public Cliente(string rut, string apellido)
        {
            this.rut = rut;
            this.apellido = apellido;
        }

        public Cliente(string rut, string nombre, string apellido, int tipo)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo = tipo;
        }

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
