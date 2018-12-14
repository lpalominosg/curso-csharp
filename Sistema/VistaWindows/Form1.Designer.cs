namespace VistaWindows
{
    partial class frmProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.lbCodProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lbNombreProducto = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lbPrecioUnitario = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSumaPU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(169, 39);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodProducto.TabIndex = 0;
            this.txtCodProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbCodProducto
            // 
            this.lbCodProducto.AutoSize = true;
            this.lbCodProducto.Location = new System.Drawing.Point(47, 42);
            this.lbCodProducto.Name = "lbCodProducto";
            this.lbCodProducto.Size = new System.Drawing.Size(86, 13);
            this.lbCodProducto.TabIndex = 1;
            this.lbCodProducto.Text = "Código Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(169, 65);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 2;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbNombreProducto
            // 
            this.lbNombreProducto.AutoSize = true;
            this.lbNombreProducto.Location = new System.Drawing.Point(47, 68);
            this.lbNombreProducto.Name = "lbNombreProducto";
            this.lbNombreProducto.Size = new System.Drawing.Size(90, 13);
            this.lbNombreProducto.TabIndex = 3;
            this.lbNombreProducto.Text = "Nombre Producto";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(169, 92);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioUnitario.TabIndex = 4;
            this.txtPrecioUnitario.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbPrecioUnitario
            // 
            this.lbPrecioUnitario.AutoSize = true;
            this.lbPrecioUnitario.Location = new System.Drawing.Point(47, 95);
            this.lbPrecioUnitario.Name = "lbPrecioUnitario";
            this.lbPrecioUnitario.Size = new System.Drawing.Size(76, 13);
            this.lbPrecioUnitario.TabIndex = 5;
            this.lbPrecioUnitario.Text = "Precio Unitario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(88, 136);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(169, 136);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cant. Productos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(169, 220);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(50, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Suma PU";
            // 
            // txtSumaPU
            // 
            this.txtSumaPU.Location = new System.Drawing.Point(335, 220);
            this.txtSumaPU.Name = "txtSumaPU";
            this.txtSumaPU.Size = new System.Drawing.Size(100, 20);
            this.txtSumaPU.TabIndex = 11;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 286);
            this.Controls.Add(this.txtSumaPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbPrecioUnitario);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.lbNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lbCodProducto);
            this.Controls.Add(this.txtCodProducto);
            this.Name = "frmProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label lbCodProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lbNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lbPrecioUnitario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSumaPU;
    }
}

