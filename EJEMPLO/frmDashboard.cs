using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FarmaciaGenesis
{
    public partial class frmDashboard : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FarmaciaGenesisAPP;Integrated Security=True";
        private DataTable dtVentas;
        private DataTable dtStockCritico;
        private DataTable dtCaducidades;

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            CargarVentasHoy();
            CargarStockCritico();
            CargarCaducidades();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 10;
                Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
                path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
                path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseAllFigures();

                panel.Region = new Region(path);
            }

            // Dibujar sombra
            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
                {
                    g.FillRectangle(brush, new Rectangle(5, 5, panel.Width - 10, panel.Height - 10));
                }
            }
        }

        // ... resto del código existente ...
    }
} 