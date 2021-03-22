using System;
using System.Data.SqlClient;

namespace Restaruante
{
    class Sucursal : Modelo
    {
        private static readonly string COMANDO_INSERCION =
            "INSERT INTO RESTAURANTBD.sucursal(nombre,direccion) " +
            "VALUES(@nombre, @direccion)";

        private static readonly string COMANDO_MODIFICACION =
            "UPDATE RESTAURANTBD.sucursal " +
            "SET nombre = @nombre, direccion = @direccion " +
            "WHERE idSucursal = @idSucursal";

        private static readonly string COMANDO_ELIMINACION =
            "DELETE FROM RESTAURANTBD.sucursal " +
            "WHERE idSucursal = @idSucursal";

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public Sucursal() 
        {
            NomTabla = "RESTAURANTBD.sucursal";
        }

        public override void Inserta(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_INSERCION, conexion))
            {
                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@direccion", Direccion);
                Id = Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public override void Modifica(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_MODIFICACION, conexion))
            {
                comando.Parameters.AddWithValue("@idSucursal", Id);
                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@direccion", Direccion);
                comando.ExecuteNonQuery();
            }
        }
        public override void Elimina(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_ELIMINACION, conexion))
            {
                comando.Parameters.AddWithValue("@idSucursal", Id);
                comando.ExecuteNonQuery();
            }
        }
    }
}
