using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaruante
{
    class Cliente : Modelo
    {
        private static readonly string COMANDO_INSERCION =
           "INSERT INTO RESTAURANTBD.cliente(idZona, nombre, domicilio, direccion, telefono, email) " +
           "VALUES(@idZona, @nombre, @domicilio, @direccion, @telefono, @email)";

        private static readonly string COMANDO_MODIFICACION =
            "UPDATE RESTAURANTBD.cliente " +
            "SET idZona = @idZona, nombre = @nombre, domicilio = @domicilio, direccion = @direccion, telefono = @telefono, email = @email " +
            "WHERE idCliente = @idCliente";

        private static readonly string COMANDO_ELIMINACION =
            "DELETE FROM RESTAURANTBD.cliente " +
            "WHERE idCliente = @idCliente";

        public long IdZona { get; set; }

        public string Nombre { get; set; }

        public string Domicilio { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public Cliente() 
        {
            NomTabla = "RESTAURANTBD.Cliente";
        }

        public override void Inserta(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_INSERCION, conexion))
            {
                comando.Parameters.AddWithValue("@idZona", IdZona);
                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@domicilio", Domicilio);
                comando.Parameters.AddWithValue("@direccion", Direccion);
                comando.Parameters.AddWithValue("@telefono", Telefono);
                comando.Parameters.AddWithValue("@email", Email);

                Id = Convert.ToInt32(comando.ExecuteScalar());
            }
        }
        public override void Modifica(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_MODIFICACION, conexion))
            {
                comando.Parameters.AddWithValue("@idCliente", Id);
                comando.Parameters.AddWithValue("@idZona", IdZona);
                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@domicilio", Domicilio);
                comando.Parameters.AddWithValue("@direccion", Direccion);
                comando.Parameters.AddWithValue("@telefono", Telefono);
                comando.Parameters.AddWithValue("@email", Email);

                Id = Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public override void Elimina(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_ELIMINACION, conexion))
            {
                comando.Parameters.AddWithValue("@idCliente", Id);
                comando.ExecuteNonQuery();
            }
        }
    }
}