namespace diseño
{
    partial class Tienda
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.grbFiltroAvanzado = new System.Windows.Forms.GroupBox();
            this.btnFiltroAvanzado = new System.Windows.Forms.Button();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grbFiltroAvanzado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvProductos.Location = new System.Drawing.Point(46, 89);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(899, 232);
            this.dgvProductos.TabIndex = 0;
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiltroRapido.Location = new System.Drawing.Point(46, 60);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(787, 20);
            this.txtFiltroRapido.TabIndex = 1;
            this.txtFiltroRapido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroRapido_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(858, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 20);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(46, 347);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 20);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(154, 347);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 20);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(267, 347);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 20);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerDetalle.BackColor = System.Drawing.Color.White;
            this.btnVerDetalle.FlatAppearance.BorderSize = 0;
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.Location = new System.Drawing.Point(383, 347);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(107, 20);
            this.btnVerDetalle.TabIndex = 7;
            this.btnVerDetalle.Text = "VER DETALLE";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // grbFiltroAvanzado
            // 
            this.grbFiltroAvanzado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbFiltroAvanzado.Controls.Add(this.btnFiltroAvanzado);
            this.grbFiltroAvanzado.Controls.Add(this.txtFiltroAvanzado);
            this.grbFiltroAvanzado.Controls.Add(this.lblFiltroAvanzado);
            this.grbFiltroAvanzado.Controls.Add(this.lblCriterio);
            this.grbFiltroAvanzado.Controls.Add(this.cbxCriterio);
            this.grbFiltroAvanzado.Controls.Add(this.cbxCampo);
            this.grbFiltroAvanzado.Controls.Add(this.lblCampo);
            this.grbFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFiltroAvanzado.Location = new System.Drawing.Point(46, 386);
            this.grbFiltroAvanzado.Name = "grbFiltroAvanzado";
            this.grbFiltroAvanzado.Size = new System.Drawing.Size(662, 100);
            this.grbFiltroAvanzado.TabIndex = 8;
            this.grbFiltroAvanzado.TabStop = false;
            this.grbFiltroAvanzado.Text = "FILTRO AVANZADO";
            // 
            // btnFiltroAvanzado
            // 
            this.btnFiltroAvanzado.BackColor = System.Drawing.Color.White;
            this.btnFiltroAvanzado.FlatAppearance.BorderSize = 0;
            this.btnFiltroAvanzado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroAvanzado.Location = new System.Drawing.Point(569, 53);
            this.btnFiltroAvanzado.Name = "btnFiltroAvanzado";
            this.btnFiltroAvanzado.Size = new System.Drawing.Size(87, 20);
            this.btnFiltroAvanzado.TabIndex = 9;
            this.btnFiltroAvanzado.Text = "FILTRAR";
            this.btnFiltroAvanzado.UseVisualStyleBackColor = false;
            this.btnFiltroAvanzado.Click += new System.EventHandler(this.btnFiltroAvanzado_Click);
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(390, 53);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(156, 20);
            this.txtFiltroAvanzado.TabIndex = 5;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(387, 36);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(51, 13);
            this.lblFiltroAvanzado.TabIndex = 4;
            this.lblFiltroAvanzado.Text = "FILTRO";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(197, 36);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(66, 13);
            this.lblCriterio.TabIndex = 3;
            this.lblCriterio.Text = "CRITERIO";
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(200, 52);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(156, 21);
            this.cbxCriterio.TabIndex = 2;
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(9, 52);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(156, 21);
            this.cbxCampo.TabIndex = 1;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(6, 36);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(50, 13);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "CAMPO";
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1225, 498);
            this.Controls.Add(this.grbFiltroAvanzado);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.dgvProductos);
            this.MaximizeBox = false;
            this.Name = "Tienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda";
            this.Load += new System.EventHandler(this.Tienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grbFiltroAvanzado.ResumeLayout(false);
            this.grbFiltroAvanzado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.GroupBox grbFiltroAvanzado;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.Button btnFiltroAvanzado;
    }
}