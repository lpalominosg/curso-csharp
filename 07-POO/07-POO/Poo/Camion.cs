using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoresa.Models
{
     public class Camion : Vehiculomovil
    { 
        
        private int carga;

        public Camion() {
        }

        public Camion(int carga)
        {
            this.carga = carga;
        }

        public int Carga { get => carga; set => carga = value; }
    }
}
