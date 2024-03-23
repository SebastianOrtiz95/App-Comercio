namespace diseño
{
    partial class Detalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxDetalleArticulo = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.grbxDetalle = new System.Windows.Forms.GroupBox();
            this.grbxInformacionArticulo = new System.Windows.Forms.GroupBox();
            this.txtPrecioDetalle = new System.Windows.Forms.TextBox();
            this.txtDescripcionDetalle = new System.Windows.Forms.TextBox();
            this.txtNombreDetalle = new System.Windows.Forms.TextBox();
            this.txtCategoriaDetalle = new System.Windows.Forms.TextBox();
            this.txtMarcaDetalle = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalleArticulo)).BeginInit();
            this.grbxDetalle.SuspendLayout();
            this.grbxInformacionArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxDetalleArticulo
            // 
            this.pbxDetalleArticulo.Location = new System.Drawing.Point(25, 19);
            this.pbxDetalleArticulo.Name = "pbxDetalleArticulo";
            this.pbxDetalleArticulo.Size = new System.Drawing.Size(425, 395);
            this.pbxDetalleArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDetalleArticulo.TabIndex = 0;
            this.pbxDetalleArticulo.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(12, 30);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(64, 16);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "MARCA:";
            // 
            // grbxDetalle
            // 
            this.grbxDetalle.Controls.Add(this.grbxInformacionArticulo);
            this.grbxDetalle.Controls.Add(this.pbxDetalleArticulo);
            this.grbxDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxDetalle.Location = new System.Drawing.Point(57, 12);
            this.grbxDetalle.Name = "grbxDetalle";
            this.grbxDetalle.Size = new System.Drawing.Size(456, 674);
            this.grbxDetalle.TabIndex = 2;
            this.grbxDetalle.TabStop = false;
            this.grbxDetalle.Text = "DETALLE PRODUCTO";
            // 
            // grbxInformacionArticulo
            // 
            this.grbxInformacionArticulo.Controls.Add(this.txtPrecioDetalle);
            this.grbxInformacionArticulo.Controls.Add(this.txtDescripcionDetalle);
            this.grbxInformacionArticulo.Controls.Add(this.txtNombreDetalle);
            this.grbxInformacionArticulo.Controls.Add(this.txtCategoriaDetalle);
            this.grbxInformacionArticulo.Controls.Add(this.txtMarcaDetalle);
            this.grbxInformacionArticulo.Controls.Add(this.lblPrecio);
            this.grbxInformacionArticulo.Controls.Add(this.lblDescripcion);
            this.grbxInformacionArticulo.Controls.Add(this.lblNombre);
            this.grbxInformacionArticulo.Controls.Add(this.lblCategoria);
            this.grbxInformacionArticulo.Controls.Add(this.lblMarca);
            this.grbxInformacionArticulo.Location = new System.Drawing.Point(25, 420);
            this.grbxInformacionArticulo.Name = "grbxInformacionArticulo";
            this.grbxInformacionArticulo.Size = new System.Drawing.Size(425, 248);
            this.grbxInformacionArticulo.TabIndex = 1;
            this.grbxInformacionArticulo.TabStop = false;
            this.grbxInformacionArticulo.Text = "INFORMACION DEL ARTICULO";
            // 
            // txtPrecioDetalle
            // 
            this.txtPrecioDetalle.Location = new System.Drawing.Point(207, 168);
            this.txtPrecioDetalle.Name = "txtPrecioDetalle";
            this.txtPrecioDetalle.ReadOnly = true;
            this.txtPrecioDetalle.Size = new System.Drawing.Size(212, 20);
            this.txtPrecioDetalle.TabIndex = 10;
            // 
            // txtDescripcionDetalle
            // 
            this.txtDescripcionDetalle.Location = new System.Drawing.Point(207, 210);
            this.txtDescripcionDetalle.Name = "txtDescripcionDetalle";
            this.txtDescripcionDetalle.ReadOnly = true;
            this.txtDescripcionDetalle.Size = new System.Drawing.Size(212, 20);
            this.txtDescripcionDetalle.TabIndex = 9;
            // 
            // txtNombreDetalle
            // 
            this.txtNombreDetalle.Location = new System.Drawing.Point(207, 118);
            this.txtNombreDetalle.Name = "txtNombreDetalle";
            this.txtNombreDetalle.ReadOnly = true;
            this.txtNombreDetalle.Size = new System.Drawing.Size(212, 20);
            this.txtNombreDetalle.TabIndex = 8;
            // 
            // txtCategoriaDetalle
            // 
            this.txtCategoriaDetalle.Location = new System.Drawing.Point(207, 72);
            this.txtCategoriaDetalle.Name = "txtCategoriaDetalle";
            this.txtCategoriaDetalle.ReadOnly = true;
            this.txtCategoriaDetalle.Size = new System.Drawing.Size(212, 20);
            this.txtCategoriaDetalle.TabIndex = 7;
            // 
            // txtMarcaDetalle
            // 
            this.txtMarcaDetalle.Location = new System.Drawing.Point(207, 25);
            this.txtMarcaDetalle.Name = "txtMarcaDetalle";
            this.txtMarcaDetalle.ReadOnly = true;
            this.txtMarcaDetalle.Size = new System.Drawing.Size(212, 20);
            this.txtMarcaDetalle.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(9, 168);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(67, 16);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "PRECIO:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(9, 214);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(113, 16);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "DESCRIPCION:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 122);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(9, 76);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(98, 16);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "CATEGORIA:";
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 698);
            this.Controls.Add(this.grbxDetalle);
            this.MaximizeBox = false;
            this.Name = "Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalleArticulo)).EndInit();
            this.grbxDetalle.ResumeLayout(false);
            this.grbxInformacionArticulo.ResumeLayout(false);
            this.grbxInformacionArticulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDetalleArticulo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox grbxDetalle;
        private System.Windows.Forms.GroupBox grbxInformacionArticulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtPrecioDetalle;
        private System.Windows.Forms.TextBox txtDescripcionDetalle;
        private System.Windows.Forms.TextBox txtNombreDetalle;
        private System.Windows.Forms.TextBox txtCategoriaDetalle;
        private System.Windows.Forms.TextBox txtMarcaDetalle;
    }
}