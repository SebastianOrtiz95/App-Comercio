namespace diseño
{
    partial class ArticulosGestion
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
            this.grbxArticulo = new System.Windows.Forms.GroupBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.grbxMarcaCategoria = new System.Windows.Forms.GroupBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.pbxArticuloAlta = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbxArticulo.SuspendLayout();
            this.grbxMarcaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // grbxArticulo
            // 
            this.grbxArticulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbxArticulo.Controls.Add(this.lblPrecio);
            this.grbxArticulo.Controls.Add(this.txtPrecio);
            this.grbxArticulo.Controls.Add(this.lblDescripcion);
            this.grbxArticulo.Controls.Add(this.txtUrlImagen);
            this.grbxArticulo.Controls.Add(this.lblUrlImagen);
            this.grbxArticulo.Controls.Add(this.txtDescripcion);
            this.grbxArticulo.Controls.Add(this.lblCodigo);
            this.grbxArticulo.Controls.Add(this.txtCodigo);
            this.grbxArticulo.Controls.Add(this.lblNombre);
            this.grbxArticulo.Controls.Add(this.txtNombre);
            this.grbxArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxArticulo.Location = new System.Drawing.Point(36, 3);
            this.grbxArticulo.Name = "grbxArticulo";
            this.grbxArticulo.Size = new System.Drawing.Size(394, 175);
            this.grbxArticulo.TabIndex = 0;
            this.grbxArticulo.TabStop = false;
            this.grbxArticulo.Text = "ARTICULO";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 121);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 13);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "PRECIO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(6, 137);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(189, 20);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(6, 72);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(198, 89);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(189, 20);
            this.txtUrlImagen.TabIndex = 6;
            this.txtUrlImagen.Validating += new System.ComponentModel.CancelEventHandler(this.txtUrlImagen_Validating);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.Location = new System.Drawing.Point(195, 72);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(84, 13);
            this.lblUrlImagen.TabIndex = 5;
            this.lblUrlImagen.Text = "IMAGEN URL";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(6, 89);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(189, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(195, 24);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "CODIGO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(198, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(189, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "CATEGORIA";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(3, 19);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 13);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "MARCA";
            // 
            // grbxMarcaCategoria
            // 
            this.grbxMarcaCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbxMarcaCategoria.Controls.Add(this.cbxCategoria);
            this.grbxMarcaCategoria.Controls.Add(this.cbxMarca);
            this.grbxMarcaCategoria.Controls.Add(this.lblMarca);
            this.grbxMarcaCategoria.Controls.Add(this.label1);
            this.grbxMarcaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxMarcaCategoria.Location = new System.Drawing.Point(36, 184);
            this.grbxMarcaCategoria.Name = "grbxMarcaCategoria";
            this.grbxMarcaCategoria.Size = new System.Drawing.Size(394, 78);
            this.grbxMarcaCategoria.TabIndex = 12;
            this.grbxMarcaCategoria.TabStop = false;
            this.grbxMarcaCategoria.Text = "ARTICULO MARCA Y CATEGORIA";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(197, 35);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(190, 21);
            this.cbxCategoria.TabIndex = 13;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(6, 35);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(189, 21);
            this.cbxMarca.TabIndex = 12;
            // 
            // pbxArticuloAlta
            // 
            this.pbxArticuloAlta.BackColor = System.Drawing.Color.White;
            this.pbxArticuloAlta.Location = new System.Drawing.Point(36, 268);
            this.pbxArticuloAlta.Name = "pbxArticuloAlta";
            this.pbxArticuloAlta.Size = new System.Drawing.Size(394, 348);
            this.pbxArticuloAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticuloAlta.TabIndex = 13;
            this.pbxArticuloAlta.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(36, 622);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 20);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(343, 622);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 20);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ArticulosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 654);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbxArticuloAlta);
            this.Controls.Add(this.grbxMarcaCategoria);
            this.Controls.Add(this.grbxArticulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "ArticulosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR ARTICULO";
            this.Load += new System.EventHandler(this.ArticulosGestion_Load);
            this.grbxArticulo.ResumeLayout(false);
            this.grbxArticulo.PerformLayout();
            this.grbxMarcaCategoria.ResumeLayout(false);
            this.grbxMarcaCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloAlta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox grbxMarcaCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.PictureBox pbxArticuloAlta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}