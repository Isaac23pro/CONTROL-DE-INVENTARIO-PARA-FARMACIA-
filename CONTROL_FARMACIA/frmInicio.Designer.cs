namespace CONTROL_FARMACIA
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnPresentacion = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnMenuInventario = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCaducidad = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.panelInventario.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.panelContenedor.Controls.Add(this.panelInventario);
            this.panelContenedor.Controls.Add(this.btnMenuInventario);
            this.panelContenedor.Controls.Add(this.panelSubMenu);
            this.panelContenedor.Controls.Add(this.btnMenu);
            this.panelContenedor.Controls.Add(this.panelPrincipal);
            this.panelContenedor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelContenedor.Location = new System.Drawing.Point(-3, -2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(227, 658);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelInventario
            // 
            this.panelInventario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelInventario.Controls.Add(this.btnCaducidad);
            this.panelInventario.Controls.Add(this.btnProductos);
            this.panelInventario.Controls.Add(this.btnProveedor);
            this.panelInventario.Controls.Add(this.btnPresentacion);
            this.panelInventario.Controls.Add(this.btnCategoria);
            this.panelInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInventario.Location = new System.Drawing.Point(0, 223);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(227, 175);
            this.panelInventario.TabIndex = 3;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProductos.Location = new System.Drawing.Point(0, 84);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(227, 28);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Producto";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProveedor.Location = new System.Drawing.Point(0, 56);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnProveedor.Size = new System.Drawing.Size(227, 28);
            this.btnProveedor.TabIndex = 2;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnPresentacion
            // 
            this.btnPresentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPresentacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresentacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPresentacion.Location = new System.Drawing.Point(0, 28);
            this.btnPresentacion.Name = "btnPresentacion";
            this.btnPresentacion.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPresentacion.Size = new System.Drawing.Size(227, 28);
            this.btnPresentacion.TabIndex = 1;
            this.btnPresentacion.Text = "Presentacion";
            this.btnPresentacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPresentacion.UseVisualStyleBackColor = false;
            this.btnPresentacion.Click += new System.EventHandler(this.btnPresentacion_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCategoria.Location = new System.Drawing.Point(0, 0);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCategoria.Size = new System.Drawing.Size(227, 28);
            this.btnCategoria.TabIndex = 0;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnMenuInventario
            // 
            this.btnMenuInventario.BackColor = System.Drawing.Color.White;
            this.btnMenuInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInventario.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuInventario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuInventario.Location = new System.Drawing.Point(0, 194);
            this.btnMenuInventario.Name = "btnMenuInventario";
            this.btnMenuInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuInventario.Size = new System.Drawing.Size(227, 29);
            this.btnMenuInventario.TabIndex = 2;
            this.btnMenuInventario.Text = "Menu Inventario";
            this.btnMenuInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuInventario.UseVisualStyleBackColor = false;
            this.btnMenuInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSubMenu.Controls.Add(this.btnVentas);
            this.panelSubMenu.Controls.Add(this.btnReportes);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 135);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(227, 59);
            this.panelSubMenu.TabIndex = 2;
            this.panelSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubMenu_Paint);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVentas.Location = new System.Drawing.Point(0, 29);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(227, 30);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReportes.Location = new System.Drawing.Point(0, 0);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(227, 29);
            this.btnReportes.TabIndex = 0;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenu.Location = new System.Drawing.Point(0, 100);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(227, 35);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(227, 100);
            this.panelPrincipal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farmacia";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.pictureBox1);
            this.panelControl.Location = new System.Drawing.Point(230, 12);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1043, 578);
            this.panelControl.TabIndex = 1;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1031, 572);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCaducidad
            // 
            this.btnCaducidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCaducidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaducidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaducidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCaducidad.Location = new System.Drawing.Point(0, 112);
            this.btnCaducidad.Name = "btnCaducidad";
            this.btnCaducidad.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCaducidad.Size = new System.Drawing.Size(227, 28);
            this.btnCaducidad.TabIndex = 4;
            this.btnCaducidad.Text = "Caducidad";
            this.btnCaducidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaducidad.UseVisualStyleBackColor = false;
            this.btnCaducidad.Click += new System.EventHandler(this.btnCaducidad_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1273, 588);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelContenedor);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelInventario.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnMenuInventario;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.Button btnPresentacion;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCaducidad;
    }
}