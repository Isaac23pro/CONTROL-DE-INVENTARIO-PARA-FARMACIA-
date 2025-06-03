using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIO;
using DATOS;

namespace CONTROL_FARMACIA
{
    public partial class frmCaducidad : Form
    {
        private CaducidadNegocio caducidadNegocio;

        public frmCaducidad()
        {
            InitializeComponent();
            caducidadNegocio = new CaducidadNegocio();
        }

        private void frmcaducidad_Load(object sender, EventArgs e)
        {
            CargarDatosCaducidad();
        }

        private void CargarDatosCaducidad()
        {
            try
            {
                var listaCaducidad = caducidadNegocio.ObtenerProductosCaducidad();
                dgvCaducidad.DataSource = listaCaducidad;

                // Configurar las columnas del DataGridView
                dgvCaducidad.Columns["IdCaducidad"].Visible = false;
                dgvCaducidad.Columns["IdProducto"].Visible = false;
                dgvCaducidad.Columns["IdLote"].Visible = false;
                dgvCaducidad.Columns["Observaciones"].Visible = false;

                // Configurar los encabezados de las columnas
                dgvCaducidad.Columns["NombreProducto"].HeaderText = "Producto";
                dgvCaducidad.Columns["Categoria"].HeaderText = "Categoría";
                dgvCaducidad.Columns["Cantidad"].HeaderText = "Stock";
                dgvCaducidad.Columns["FechaCaducidad"].HeaderText = "Fecha de Caducidad";
                dgvCaducidad.Columns["DiasRestantes"].HeaderText = "Días Restantes";
                dgvCaducidad.Columns["Estado"].HeaderText = "Estado";

                // Ajustar el ancho de las columnas
                dgvCaducidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatosCaducidad();
        }

        private void dgvCaducidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
