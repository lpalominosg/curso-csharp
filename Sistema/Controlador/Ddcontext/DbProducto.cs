using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Sistema.Modelo;

namespace Sistema.Controlador.Dbcontext
{
    public class DbProducto : DbContext
    {
        public DbSet<Producto> Producto { get; set; }

        public List<Producto> GetAll()
        {
            List<Producto> productos = this
                                        .Producto
                                        .SqlQuery("SELECT * FROM Producto")
                                        .ToList();
            return productos;
        }
    }
}
