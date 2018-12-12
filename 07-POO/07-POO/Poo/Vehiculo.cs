using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoresa.Models
{
    public class Vehiculo
    {
        private string matricula;
        private string modelo;
        private string marca;
        private int  ruedas;


        public string Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Ruedas { get => ruedas; set => ruedas = value; }
    }

}
