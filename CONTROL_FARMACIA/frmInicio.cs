using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROL_FARMACIA
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            Panel();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void Panel()
        { 
            panelInventario.Visible = false;
            panelSubMenu.Visible = false;
        }

        private void MostrarPanel(Panel SubMenu)
        {
            if (SubMenu.Visible == false) 
            { 
                OcultarPanel();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;

        }

        private void OcultarPanel()
        {
            if (panelInventario.Visible == true)
                panelInventario.Visible = false;
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelSubMenu);
        }

        
        private Form activateForm = null;
        private void abrirFormulario(Form formulariohijo)
        {
            if (activateForm != null)
             activateForm.Close();
            activateForm = formulariohijo;
            formulariohijo.TopLevel = false;
            formulariohijo.FormBorderStyle = FormBorderStyle.None;
            formulariohijo.Dock = DockStyle.Fill;
            panelControl.Controls.Add(formulariohijo);
            panelControl.Tag = formulariohijo;
            formulariohijo.BringToFront();
            formulariohijo.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmVentas());
            Panel();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
           MostrarPanel(panelInventario);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmDashboard());

            Panel();

        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmCategorias());
            Panel();
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmPresentacion());
            Panel();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmProveedores());
            Panel();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmProducto());
            Panel();
        }

        private void btnCaducidad_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmCaducidad());
            Panel();
        }
    }      

}
