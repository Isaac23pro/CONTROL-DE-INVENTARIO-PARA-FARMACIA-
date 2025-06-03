using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datalayer;
using DATOS;
using NEGOCIO;
using System.IO;

namespace CONTROL_FARMACIA
{
    public partial class frmProducto : Form
    {

        private ProductoNegocio productoNegocio; 
        private List<Producto> listaProducto; 
        public frmProducto()
        {
            InitializeComponent();
            productoNegocio = new ProductoNegocio();
            listaProducto = new List<Producto>();
            // Mensaje de ayuda al abrir el formulario
            this.Load += (s, e) =>
            {
                MessageBox.Show("En esta pantalla puedes gestionar el inventario: agregar, editar, eliminar productos y exportar a Excel. Usa los filtros y la búsqueda para encontrar productos fácilmente.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarCategorias();
            cbCategorias.SelectedIndexChanged += cbCategorias_SelectedIndexChanged;
            PersonalizarDataGridView();
            ObtenerCategorias();
            ObtenerProveedores();
            ObtenerPresentaciones();
            ObtenerConcentraciones();
            ObtenerLotes();

        }

        private void CargarCategorias()
        {
            CategoriaDatos categoriaDatos = new CategoriaDatos();
            var categorias = categoriaDatos.ObtenerCategorias();

            cbCategorias.DataSource = categorias;
            cbCategorias.DisplayMember = "Nombre";   
            cbCategorias.ValueMember = "IdCategoria"; 
        }

        private void CargarProductos()
        {
            try
            {
                listaProducto = productoNegocio.ObtenerProductos();
                dgvMedicamentos.DataSource = null;
                dgvMedicamentos.DataSource = listaProducto;

                dgvMedicamentos.Columns["IdProducto"].HeaderText = "ID Producto";
                dgvMedicamentos.Columns["NombreComercial"].HeaderText = "Nombre Comercial";
                dgvMedicamentos.Columns["NombreGenerico"].HeaderText = "Nombre Genérico";
                dgvMedicamentos.Columns["IdCategoria"].HeaderText = "Categoría";
                dgvMedicamentos.Columns["PrecioCompra"].HeaderText = "Precio Compra";
                dgvMedicamentos.Columns["PrecioVenta"].HeaderText = "Precio Venta";                
                dgvMedicamentos.Columns["IdPresentacion"].HeaderText = "Presentación";
                dgvMedicamentos.Columns["IdConcentracion"].HeaderText = "Concentración";
                dgvMedicamentos.Columns["IdProveedor"].HeaderText = "Proveedor";
                dgvMedicamentos.Columns["IdLote"].HeaderText = "Lote";

                dgvMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                       

        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedValue is int idCategoria)
            {
                ProductoDatos productoDatos = new ProductoDatos();
                var productos = productoDatos.ObtenerProductoPorCategoria(idCategoria);
                dgvMedicamentos.DataSource = productos;
            }
        }

      

        private void txtBuscarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string texto = txtBuscarNombre.Text.Trim();
                dgvMedicamentos.DataSource = productoNegocio.BuscarPorNombre(texto);

            }
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            txtNombreComercial.Clear();
            txtNombreGenerico.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();          
            cbCategoria.SelectedIndex = -1;
            cbProveedor.SelectedIndex = -1;
            cbPresentacion.SelectedIndex = -1;
            cbConcentracion.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            try
            {
                Producto nuevoProducto = new Producto
                {
                    NombreComercial = txtNombreComercial.Text.Trim(),
                    NombreGenerico = txtNombreGenerico.Text.Trim(),
                    PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text),
                    PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text),
                    IdCategoria = (int)cbCategoria.SelectedValue,
                    IdProveedor = (int)cbProveedor.SelectedValue,
                    IdPresentacion = (int)cbPresentacion.SelectedValue,
                    IdConcentracion = (int)cbConcentracion.SelectedValue,
                    IdLote = (int)cbNumeroLote.SelectedValue
                };

                productoNegocio.AgregarProducto(nuevoProducto);
                MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombreComercial.Clear();
            txtNombreGenerico.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            cbCategoria.SelectedIndex = -1;
            cbProveedor.SelectedIndex = -1;
            cbPresentacion.SelectedIndex = -1;
            cbConcentracion.SelectedIndex = -1;
            cbNumeroLote.SelectedIndex = -1;
        }

        private void CambiarEstadoDeControles(bool enEdicion)
        {
            txtNombreComercial.Enabled = enEdicion;
            txtNombreGenerico.Enabled = enEdicion;
            txtPrecioCompra.Enabled = enEdicion;
            txtPrecioVenta.Enabled = enEdicion;
            cbCategoria.Enabled = enEdicion;
            cbProveedor.Enabled = enEdicion;
            cbPresentacion.Enabled = enEdicion;
            cbConcentracion.Enabled = enEdicion;
            cbNumeroLote.Enabled = enEdicion;

        }

         private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNombreComercial.Text))
            {
                MessageBox.Show("El nombre comercial del producto es obligatorio.");
                txtNombreComercial.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombreGenerico.Text))
            {
                MessageBox.Show("El nombre genérico del producto es obligatorio.");
                txtNombreGenerico.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrecioCompra.Text) || !decimal.TryParse(txtPrecioCompra.Text, out _))
            {
                MessageBox.Show("El precio de compra es obligatorio y debe ser un número válido.");
                txtPrecioCompra.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrecioVenta.Text) || !decimal.TryParse(txtPrecioVenta.Text, out _))
            {
                MessageBox.Show("El precio de venta es obligatorio y debe ser un número válido.");
                txtPrecioVenta.Focus();
                return false;
            }
            
            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el estado del producto.");
                cbCategoria.Focus();
                return false;
            }
            
            if (cbProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el proveedor del producto.");
                cbProveedor.Focus();
                return false;
            }
            if (cbPresentacion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la presentación del producto.");
                cbPresentacion.Focus();
                return false;
            }


            return true;
        }

        private void PersonalizarDataGridView()
        {
            dgvMedicamentos.BackgroundColor = Color.White;
            dgvMedicamentos.BorderStyle = BorderStyle.None;
            dgvMedicamentos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMedicamentos.GridColor = Color.LightGray;

            dgvMedicamentos.EnableHeadersVisualStyles = false;
            dgvMedicamentos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMedicamentos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 91, 150);
            dgvMedicamentos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMedicamentos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            dgvMedicamentos.DefaultCellStyle.BackColor = Color.White;
            dgvMedicamentos.DefaultCellStyle.ForeColor = Color.Black;
            dgvMedicamentos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvMedicamentos.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvMedicamentos.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvMedicamentos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvMedicamentos.RowTemplate.Height = 30;
            dgvMedicamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ObtenerCategorias()
        {
            try
            {

                CategoriaDatos categoriaDatos = new CategoriaDatos();
                var categorias = categoriaDatos.ObtenerCategorias();
                cbCategoria.DataSource = categorias;
                cbCategoria.DisplayMember = "Nombre";
                cbCategoria.ValueMember = "IdCategoria"; 

                cbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerProveedores()
        {
            try
            {

                ProveedoresDatos proveedorDatos = new ProveedoresDatos();
                var proveedores = proveedorDatos.ObtenerProveedores();
                cbProveedor.DataSource = proveedores;
                cbProveedor.DisplayMember = "Nombre";
                cbProveedor.ValueMember = "IdProveedor";

                cbProveedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ObtenerPresentaciones()
        {
            try
            {
                PresentacionDatos presentacionDatos = new PresentacionDatos();
                var presentaciones = presentacionDatos.ObtenerPresentaciones();
                cbPresentacion.DataSource = presentaciones;
                cbPresentacion.DisplayMember = "Descripcion";
                cbPresentacion.ValueMember = "IdPresentacion";
                cbPresentacion.SelectedIndex = -1;
            }
            catch (Exception)
            {

               MessageBox.Show("No se pudo cargar la presentación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void ObtenerConcentraciones()
        {
            try
            {
                ConcentracionDatos concentracionDatos = new ConcentracionDatos();
                var concentraciones = concentracionDatos.ObtenerConcentraciones();
                cbConcentracion.DataSource = concentraciones;
                cbConcentracion.DisplayMember = "VolumenFormateado";
                cbConcentracion.ValueMember = "IdConcentracion";
                cbConcentracion.SelectedIndex = -1;
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo cargar la concentración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void ObtenerLotes()
        {
            try
            {
                LoteDatos loteDatos = new LoteDatos();
                var lotes = loteDatos.ObtenerLotes();
                cbNumeroLote.DataSource = lotes;
                cbNumeroLote.DisplayMember = "NumeroLote";
                cbNumeroLote.ValueMember = "IdLote";

                cbNumeroLote.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al cargar los lotes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeControles(true);
            txtNombreGenerico.Focus();
            dgvMedicamentos.ClearSelection();
            LimpiarFormulario();
        }

        private void cbPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos Excel (*.csv)|*.csv";
            saveFileDialog.Title = "Exportar a Excel";
            saveFileDialog.FileName = "InventarioFarmacia.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Escribir encabezados
                        for (int i = 0; i < dgvMedicamentos.Columns.Count; i++)
                        {
                            sw.Write(dgvMedicamentos.Columns[i].HeaderText);
                            if (i < dgvMedicamentos.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Escribir filas
                        foreach (DataGridViewRow row in dgvMedicamentos.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgvMedicamentos.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());
                                    if (i < dgvMedicamentos.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }
                    }
                    MessageBox.Show("Inventario exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
