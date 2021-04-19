using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaruante
{
    class Gerente : Modelo
    {
        private static readonly string COMANDO_INSERCION =
            "INSERT INTO RESTAURANTBD.Gerente(idEmpleado, sueldoFijo) " +
            "VALUES(@idEmpleado, @sueldoFijo)";

        private static readonly string COMANDO_MODIFICACION =
            "UPDATE RESTAURANTBD.Gerente " +
            "SET idEmpleado = @idEmpleado, sueldoFijo = @sueldoFijo " +
            "WHERE idEmpleado = @idEmpleado";

        private static readonly string COMANDO_ELIMINACION =
            "DELETE RESTAURANTBD.Gerente " +
            "WHERE idEmpleado = @idEmpleado";

        private static readonly string TODOS =
            "SELECT CONCAT(RESTAURANTBD.Empleado.idEmpleado, ' - ', RESTAURANTBD.Sucursal.idSucursal, ' - ', RESTAURANTBD.Sucursal.nombre) AS idEmpleado, " +
            "sueldoFijo " +
            "FROM RESTAURANTBD.Gerente" +
            " INNER JOIN RESTAURANTBD.Empleado " +
            "ON RESTAURANTBD.Gerente.idEmpleado = RESTAURANTBD.Empleado.idEmpleado" +
            " INNER JOIN RESTAURANTBD.Sucursal " +
            "ON RESTAURANTBD.Empleado.idSucursal = RESTAURANTBD.Sucursal.idSucursal";

        public long IdEmpleado { get; set; }

        public string sueldoFijo { get; set; }

        public Gerente()
        {
            Ocultas = new string[] { };
            NomTabla = "RESTAURANTBD.Gerente";
            FIRST_PK = 0;
        }

        public override void Inserta(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_INSERCION, conexion))
            {
                comando.Parameters.AddWithValue("@idEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@sueldoFijo", sueldoFijo);

                Id = Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public override void Modifica(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_MODIFICACION, conexion))
            {
                comando.Parameters.AddWithValue("@idEmpleado", Id);
                comando.Parameters.AddWithValue("@sueldoFijo", sueldoFijo);
                comando.ExecuteNonQuery();
            }
        }

        public override void Elimina(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_ELIMINACION, conexion))
            {
                comando.Parameters.AddWithValue("@idEmpleado", Id);
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
