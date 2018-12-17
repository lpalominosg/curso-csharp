using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sistema.Modelo
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        [Required]
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
