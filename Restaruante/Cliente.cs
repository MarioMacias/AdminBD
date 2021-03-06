using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaruante
{
    class Cliente : Modelo
    {
        private static readonly string COMANDO_INSERCION =
           "INSERT INTO RESTAURANTBD.Cliente(idZona, nombre, domicilio, direccion, telefono, email) " +
           "VALUES(@idZona, @nombre, @domicilio, @direccion, @telefono, @email)";

        private static readonly string COMANDO_MODIFICACION =
            "UPDATE RESTAURANTBD.Cliente " +
            "SET idZona = @idZona, nombre = @nombre, domicilio = @domicilio, direccion = @direccion, telefono = @telefono, email = @email " +
            "WHERE idCliente = @idCliente";

        private static readonly string COMANDO_ELIMINACION =
            "DELETE FROM RESTAURANTBD.Cliente " +
            "WHERE idCliente = @idCliente";

        private static readonly string TODOS =
            "SELECT idCliente, RESTAURANTBD.Cliente.idZona, " +
            "CONCAT(RESTAURANTBD.ZonaDomicilio.idZona, ' - ', RESTAURANTBD.ZonaDomicilio.nombre, ' - ', RESTAURANTBD.ZonaDomicilio.codigoPostal) AS Zona, " +
            "RESTAURANTBD.Cliente.nombre, domicilio, direccion, telefono, email " +
            "FROM RESTAURANTBD.Cliente INNER JOIN RESTAURANTBD.ZonaDomicilio " +
            "ON RESTAURANTBD.Cliente.idZona = RESTAURANTBD.ZonaDomicilio.idZona";

        public long IdZona { get; set; }

        public string Nombre { get; set; }

        public string Domicilio { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public Cliente() 
        {
            Ocultas = new string[] { "idZona" };
            NomTabla = "RESTAURANTBD.Cliente";
            FIRST_PK = 1;
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

        public override DataTable Todos(SqlConnection conexion)
        {
            var tabla = new DataTable();
            using (var adaptador = new SqlDataAdapter(TODOS, conexion))
            {
                adaptador.Fill(tabla);
            }

            return tabla;
        }
    }
}