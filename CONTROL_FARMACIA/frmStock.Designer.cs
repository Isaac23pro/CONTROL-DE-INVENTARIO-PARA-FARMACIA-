using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CONTROL_FARMACIA
{
    partial class frmStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private TextBox textBox1;
        private Panel panel6;
        private Label label10;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Panel panel3;
        private DataGridView dgvStock;

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
            this.components = new Container();
            this.panel1 = new Panel();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.panel2 = new Panel();
            this.label7 = new Label();
            this.textBox1 = new TextBox();
            this.panel6 = new Panel();
            this.label10 = new Label();
            this.textBox2 = new TextBox();
            this.comboBox1 = new ComboBox();
            this.comboBox2 = new ComboBox();
            this.button1 = new Button();
            this.panel3 = new Panel();
            this.dgvStock = new DataGridView();
            ((ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.FromArgb(0, 91, 150);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(227, 658);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new Size(112, 28);
            this.label1.Text = "Farma-di";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(57, 125);
            this.label2.Name = "label2";
            this.label2.Size = new Size(90, 19);
            this.label2.Text = "Dashboard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = Color.White;
            this.label3.Location = new Point(57, 193);
            this.label3.Name = "label3";
            this.label3.Size = new Size(86, 19);
            this.label3.Text = "Inventario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = Color.White;
            this.label4.Location = new Point(57, 265);
            this.label4.Name = "label4";
            this.label4.Size = new Size(58, 19);
            this.label4.Text = "Ventas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = Color.White;
            this.label5.Location = new Point(57, 338);
            this.label5.Name = "label5";
            this.label5.Size = new Size(89, 19);
            this.label5.Text = "Caducidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = Color.White;
            this.label6.Location = new Point(57, 417);
            this.label6.Name = "label6";
            this.label6.Size = new Size(75, 19);
            this.label6.Text = "Reportes";
            // 
            // panel2
            // 
            this.panel2.BackColor = Color.White;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new Point(225, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(1010, 38);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = Color.FromArgb(0, 91, 150);
            this.label7.Location = new Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new Size(60, 19);
            this.label7.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(86, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(444, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Buscar";
            // 
            // panel6
            // 
            this.panel6.BackColor = Color.White;
            this.panel6.Controls.Add(this.comboBox2);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new Point(243, 114);
            this.panel6.Name = "panel6";
            this.panel6.Size = new Size(977, 135);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = Color.Black;
            this.label10.Location = new Point(12, 17);
            this.label10.Name = "label10";
            this.label10.Size = new Size(77, 25);
            this.label10.Text = "Filtros";
            // 
            // textBox2
            // 
            this.textBox2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = Color.SlateGray;
            this.textBox2.Location = new Point(17, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(341, 29);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Búsqueda por nombre o código";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = Color.SlateGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(374, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(296, 32);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Todas las categorías";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = Color.SlateGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new Point(690, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new Size(266, 32);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "Todas las ubicaciones";
            // 
            // button1
            // 
            this.button1.BackColor = Color.FromArgb(0, 91, 150);
            this.button1.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = Color.White;
            this.button1.Location = new Point(1019, 58);
            this.button1.Name = "button1";
            this.button1.Size = new Size(127, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = Color.White;
            this.panel3.Controls.Add(this.dgvStock);
            this.panel3.Location = new Point(243, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(978, 352);
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Dock = DockStyle.Fill;
            this.dgvStock.Location = new Point(0, 0);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new Size(978, 352);
            this.dgvStock.TabIndex = 0;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1232, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmStock";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Stock Disponible";
            ((ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
} 