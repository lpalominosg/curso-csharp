using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public abstract class  Trabajador
    {
        private string rut;
        private string nombrecompleto;
        private string tipocargo;

        public string Rut { get => rut; set => rut = value; }
        public string Nombrecompleto { get => nombrecompleto; set => nombrecompleto = value; }
        public string Tipocargo { get => tipocargo; set => tipocargo = value; }

        public abstract int liquidacion(int sueldobruto);
        

    }
}
