using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Controlador.Dbcontext;
using Sistema.Modelo;

namespace Sistema.Controlador.Dbcontroller
{
    public class ProductoController
    {
        private DbProducto dbProducto;

        public ProductoController() {
            dbProducto = new DbProducto();
        }

        private DbProducto database {
            get {
                return dbProducto;
            }
        }
    }
}
