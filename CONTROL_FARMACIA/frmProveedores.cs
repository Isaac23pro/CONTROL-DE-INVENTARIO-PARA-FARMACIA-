using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;
using NEGOCIO;

namespace CONTROL_FARMACIA
{
    public partial class frmProveedores : Form
    {
        private ProveedoresNegocio proveedoresNegocio;
        private List<Proveedores> listaproveedores;

        public frmProveedores()
        {
            InitializeComponent();
            proveedoresNegocio = new ProveedoresNegocio();
            listaproveedores = new List<Proveedores>();
            // Mensaje de ayuda al abrir el formulario
            this.Load += (s, e) =>
            {
                MessageBox.Show("Aquí puedes agregar, editar o eliminar proveedores. Recuerda llenar todos los campos obligatorios.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();  
            CambiarEstado(false);
            ObtenerMarcas();
        }

        private void CargarProveedores()
        {
            listaproveedores = proveedoresNegocio.ObtenerProveedores();
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = listaproveedores;

        }

        private void LimpiarFormulario() 
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtCedula.Clear();
            cbIdMarca.SelectedIndex = -1;
        }

        private void LimpiarCampos() 
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtCedula.Clear();
            cbIdMarca.SelectedIndex = -1;
        }
        private void CambiarEstado(bool enEdicion)
        {
            txtNombre.Enabled = enEdicion;
            txtCorreo.Enabled = enEdicion;
            txtCedula.Enabled = enEdicion;
            cbIdMarca.Enabled = enEdicion;

            btnNuevo.Enabled = !enEdicion;
            btnActualizar.Enabled = !enEdicion;
            btnAgregar.Enabled = enEdicion;
            btnEliminar.Enabled = enEdicion;
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CambiarEstado(false);
            var proveedor = (Proveedores)dgvProveedores.CurrentRow.DataBoundItem;
            txtNombre.Text = proveedor.Nombre;
            txtCorreo.Text = proveedor.Correo;
            txtCedula.Text = proveedor.Cedula;
            cbIdMarca.Text = proveedor.IdMarca.ToString();
            CambiarEstado(true);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CambiarEstado(true);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                try
                {
                    if (dgvProveedores.Rows.Count > 0)
                    {
                        var proveedor = (Proveedores)dgvProveedores.CurrentRow.DataBoundItem;
                        proveedor.Nombre = txtNombre.Text;
                        proveedor.Correo = txtCorreo.Text;
                        proveedor.Cedula = txtCedula.Text;
                        proveedor.IdMarca = Convert.ToInt32(cbIdMarca.Text);

                        proveedoresNegocio.ActualizarProveedor(proveedor);
                        MessageBox.Show("Proveedor actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProveedores();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un proveedor.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar proveedor: {ex.Message}");

                }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {
                if (dgvProveedores.Rows.Count > 0)
                {
                    var proveedor = (Proveedores)dgvProveedores.CurrentRow.DataBoundItem;
                    // Confirmación antes de eliminar
                    var confirm = MessageBox.Show($"¿Estás seguro de eliminar al proveedor '{proveedor.Nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        proveedoresNegocio.EliminarProveedor(proveedor.IdProveedor);
                        CargarProveedores();
                        MessageBox.Show("Proveedor eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;
                try
                {
                    Proveedores proveedores = new Proveedores
                        (
                            0,
                            txtNombre.Text,
                            txtCorreo.Text,
                            txtCedula.Text,
                            Convert.ToInt32(cbIdMarca.SelectedValue)

                        );

                    proveedoresNegocio.AgregarProveedor(proveedores);
                    MessageBox.Show("Proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores();
                    LimpiarCampos();
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show ($"Error al agregar proveedor: {ex.Message}");
                }
            LimpiarCampos();
            CambiarEstado(false);
            CargarProveedores();

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            CambiarEstado(true);
            txtNombre.Focus();
            dgvProveedores.ClearSelection();
            LimpiarFormulario();

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                Proveedores proveedorseleccionado = (Proveedores)dgvProveedores.SelectedRows[0].DataBoundItem;
                proveedorseleccionado.Nombre = txtNombre.Text;
                proveedorseleccionado.Cedula = txtCedula.Text;
                proveedorseleccionado.Correo = txtCorreo.Text;
                proveedorseleccionado.IdMarca = Convert.ToInt32(cbIdMarca.Text);
                ValidarFormulario();

                proveedoresNegocio.ActualizarProveedor(proveedorseleccionado);
                MessageBox.Show("Proveedor actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProveedores();
                LimpiarCampos();
                CambiarEstado(false);

            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para actualizar.");
            }

        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El correo es obligatorio.");
                txtCorreo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("La cedula es obligatoria.");
                txtCedula.Focus();
                return false;
            }
            if (cbIdMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el proveedor del producto.");
                cbIdMarca.Focus();
                return false;
            }
            return true;
        }

        private void ObtenerMarcas()
        {
            try
            {
                MarcaDatos marcaDatos = new MarcaDatos();
                var marcas = marcaDatos.ObtenerMarcas();

                cbIdMarca.DataSource = marcas; 
                cbIdMarca.DisplayMember = "Nombre";
                cbIdMarca.ValueMember = "IdMarca"; 
                cbIdMarca.SelectedIndex = -1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las marcas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
