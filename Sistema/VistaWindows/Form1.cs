using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sistema.Controlador.Tools;
using Sistema.Modelo;

namespace VistaWindows
{
    public partial class frmProducto : Form
    {

        public List<Producto> baseProducto;


        public frmProducto()
        {
            InitializeComponent();
            txtCantidad.Enabled = false;
            txtCantidad.Text= "0";
            txtSumaPU.Text = "0";
            baseProducto = new List<Producto>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarFormulario();
        }

        public void LimpiarFormulario() {
            txtCodProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioUnitario.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Codprod = txtCodProducto.Text;
            producto.Nombre = txtNombreProducto.Text;
            producto.Valorunitario = int.Parse(txtPrecioUnitario.Text);
            baseProducto.Add(producto);

            txtCantidad.Text = "" + VentaControlador.CantidadBaseProducto(baseProducto);
            txtSumaPU.Text = "" + VentaControlador.SumaPUBaseProducto(baseProducto);
            this.LimpiarFormulario();
 
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
