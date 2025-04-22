using SQL_GESTION.DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_GESTION.PRESENTACION
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        #region"metodos"
      

        private void CargarEmpleados(string cBusqueda) 
        {
            D_Empleados Datos = new D_Empleados();
            dgvLista.DataSource = Datos.Listar_Empleados(cBusqueda);

            FormatoListaEmpleados();
        }

        private void FormatoListaEmpleados() 
        {
            dgvLista.Columns[0].Width = 45;
            dgvLista.Columns[1].Width = 150;
            dgvLista.Columns[2].Width = 150;
            dgvLista.Columns[5].Width = 290;
          
            

        }

        private void CargarDepartamentos() 
        {
            D_Departamentos Datos = new D_Departamentos();
            cmbDepartamento.DataSource = Datos.Listar_Departamentos();
            cmbDepartamento.ValueMember = "id_departamentos";
            cmbDepartamento.DisplayMember = "nombre_departamento";          
        }

        private void CargarCargos()
        {
            D_cargos Datos = new D_cargos();
            DataTable dataTable = Datos.Listar_Cargos();
            cmbCargo.ValueMember = "id_cargo";
            cmbCargo.DisplayMember = "nombre_cargo";
        }

        #endregion


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados("%");
            CargarDepartamentos();
            CargarCargos();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscar.Text);
           
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            CargarEmpleados(txtBuscar.Text);
        }

        
    }
}
