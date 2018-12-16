using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using VistaWindows.Vista;

namespace Sistema.Vista
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto fprod = new frmProducto();
            fprod.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta fventa = new frmVenta();
            fventa.Show();

        }
    }
}
