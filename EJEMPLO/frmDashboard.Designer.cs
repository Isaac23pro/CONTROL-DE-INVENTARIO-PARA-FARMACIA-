namespace FarmaciaGenesis
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvCaducidades = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvStockCritico = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFiltroPersonalizado = new System.Windows.Forms.Button();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnUltimos30Dias = new System.Windows.Forms.Button();
            this.btnUltimos7Dias = new System.Windows.Forms.Button();
            this.btnHoy = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaducidades)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockCritico)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 60);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dgvCaducidades);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(717, 73);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 200);
            this.panel6.TabIndex = 9;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(15, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Caducidad Próxima";
            // 
            // dgvCaducidades
            // 
            this.dgvCaducidades.AllowUserToAddRows = false;
            this.dgvCaducidades.AllowUserToDeleteRows = false;
            this.dgvCaducidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaducidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvCaducidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCaducidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaducidades.Location = new System.Drawing.Point(15, 45);
            this.dgvCaducidades.Name = "dgvCaducidades";
            this.dgvCaducidades.ReadOnly = true;
            this.dgvCaducidades.Size = new System.Drawing.Size(260, 140);
            this.dgvCaducidades.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dgvStockCritico);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(369, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 200);
            this.panel5.TabIndex = 10;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(15, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Stock Crítico";
            // 
            // dgvStockCritico
            // 
            this.dgvStockCritico.AllowUserToAddRows = false;
            this.dgvStockCritico.AllowUserToDeleteRows = false;
            this.dgvStockCritico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockCritico.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockCritico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStockCritico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockCritico.Location = new System.Drawing.Point(15, 45);
            this.dgvStockCritico.Name = "dgvStockCritico";
            this.dgvStockCritico.ReadOnly = true;
            this.dgvStockCritico.Size = new System.Drawing.Size(260, 140);
            this.dgvStockCritico.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(21, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 200);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(15, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ventas del día";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Location = new System.Drawing.Point(21, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 350);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(15, 15);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(956, 320);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.btnFiltroPersonalizado);
            this.panel2.Controls.Add(this.dtpFin);
            this.panel2.Controls.Add(this.dtpInicio);
            this.panel2.Controls.Add(this.btnUltimos30Dias);
            this.panel2.Controls.Add(this.btnUltimos7Dias);
            this.panel2.Controls.Add(this.btnHoy);
            this.panel2.Location = new System.Drawing.Point(21, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 50);
            this.panel2.TabIndex = 6;
            // 
            // btnFiltroPersonalizado
            // 
            this.btnFiltroPersonalizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFiltroPersonalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroPersonalizado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltroPersonalizado.ForeColor = System.Drawing.Color.White;
            this.btnFiltroPersonalizado.Location = new System.Drawing.Point(600, 13);
            this.btnFiltroPersonalizado.Name = "btnFiltroPersonalizado";
            this.btnFiltroPersonalizado.Size = new System.Drawing.Size(100, 30);
            this.btnFiltroPersonalizado.TabIndex = 5;
            this.btnFiltroPersonalizado.Text = "Filtrar";
            this.btnFiltroPersonalizado.UseVisualStyleBackColor = false;
            this.btnFiltroPersonalizado.Click += new System.EventHandler(this.btnFiltroPersonalizado_Click);
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(500, 16);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(94, 23);
            this.dtpFin.TabIndex = 4;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(400, 16);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(94, 23);
            this.dtpInicio.TabIndex = 3;
            // 
            // btnUltimos30Dias
            // 
            this.btnUltimos30Dias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUltimos30Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimos30Dias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUltimos30Dias.ForeColor = System.Drawing.Color.White;
            this.btnUltimos30Dias.Location = new System.Drawing.Point(300, 13);
            this.btnUltimos30Dias.Name = "btnUltimos30Dias";
            this.btnUltimos30Dias.Size = new System.Drawing.Size(94, 30);
            this.btnUltimos30Dias.TabIndex = 2;
            this.btnUltimos30Dias.Text = "Últimos 30 días";
            this.btnUltimos30Dias.UseVisualStyleBackColor = false;
            this.btnUltimos30Dias.Click += new System.EventHandler(this.btnUltimos30Dias_Click);
            // 
            // btnUltimos7Dias
            // 
            this.btnUltimos7Dias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUltimos7Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimos7Dias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUltimos7Dias.ForeColor = System.Drawing.Color.White;
            this.btnUltimos7Dias.Location = new System.Drawing.Point(200, 13);
            this.btnUltimos7Dias.Name = "btnUltimos7Dias";
            this.btnUltimos7Dias.Size = new System.Drawing.Size(94, 30);
            this.btnUltimos7Dias.TabIndex = 1;
            this.btnUltimos7Dias.Text = "Últimos 7 días";
            this.btnUltimos7Dias.UseVisualStyleBackColor = false;
            this.btnUltimos7Dias.Click += new System.EventHandler(this.btnUltimos7Dias_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHoy.ForeColor = System.Drawing.Color.White;
            this.btnHoy.Location = new System.Drawing.Point(100, 13);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(94, 30);
            this.btnHoy.TabIndex = 0;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = false;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1027, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaducidades)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockCritico)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvCaducidades;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvStockCritico;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFiltroPersonalizado;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btnUltimos30Dias;
        private System.Windows.Forms.Button btnUltimos7Dias;
        private System.Windows.Forms.Button btnHoy;
    }
} 