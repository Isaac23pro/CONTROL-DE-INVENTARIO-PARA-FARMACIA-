using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using DATOS;

namespace NEGOCIO
{
    public class PresentacionNegocio
    {
        private Conexion conexion = new Conexion();

        private readonly PresentacionDatos presentacionDatos = new PresentacionDatos();
        public List<Presentacion> ObtenerPresentaciones()
        {
            return presentacionDatos.ObtenerPresentaciones();
        }
        public void EliminarPresentacion(int idProducto)
        {
            presentacionDatos.EliminarPresentacion(idProducto);
        }

        public void AgregarPresentacion(Presentacion presentacion)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Presentacion (Descripcion, UnidadMedida, CantidadUnidadMedida) " +
                    "VALUES (@Descripcion, @UnidadMedida, @CantidadUnidadMedida)", con);

                cmd.Parameters.AddWithValue("@NombreComercial", presentacion.Descripcion);
                cmd.Parameters.AddWithValue("@UnidadMedida", presentacion.UnidadMedida);
                cmd.Parameters.AddWithValue("@CantidadUnidadMedida", presentacion.CantidadUnidadMedida);
               

                cmd.ExecuteNonQuery();
            }
        }








        public Presentacion ObtenerPresentacionPorId(int id)
        {
            return presentacionDatos.ObtenerPresentacionPorId(id);
        }
    }
}
