using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;
using NEGOCIO;

namespace CONTROL_FARMACIA
{
    public partial class frmInventario : Form
    {

        private ProductoNegocio productoNegocio; 
        private List<LaboratorioProducto> listaLaboratorioProducto; 
        public frmInventario()
        {
            InitializeComponent();
            productoNegocio = new ProductoNegocio();
            listaLaboratorioProducto = new List<LaboratorioProducto>();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {

        }

        private void CargarProductos()
        {
            listaLaboratorioProducto = productoNegocio.ObtenerProductos();
            dgvMedicamentos.DataSource = null;
            dgvMedicamentos.DataSource = listaLaboratorioProducto;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Llamar al método existente para cargar los productos
                CargarProductos();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Ocurrió un error al cargar los medicamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
