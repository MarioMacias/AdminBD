using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaruante
{
    class Repartidor : Modelo
    {
        private static readonly string COMANDO_INSERCION =
            "INSERT INTO RESTAURANTBD.Repartidor(idEmpleado, pago) " +
            "VALUES(@idEmpleado, @pago)";

        private static readonly string COMANDO_MODIFICACION =
            "UPDATE RESTAURANTBD.Repartidor " +
            "SET idEmpleado = @idEmpleado, pago = @pago " +
            "WHERE idEmpleado = @idEmpleado";

        private static readonly string COMANDO_ELIMINACION =
            "DELETE RESTAURANTBD.Repartidor " +
            "WHERE idEmpleado = @idEmpleado";

        private static readonly string TODOS =
            "SELECT CONCAT(RESTAURANTBD.Empleado.idEmpleado, ' - ', RESTAURANTBD.Sucursal.idSucursal, ' - ', RESTAURANTBD.Sucursal.nombre) AS idEmpleado, " +
            "pago " +
            "FROM RESTAURANTBD.Repartidor"+
            " INNER JOIN RESTAURANTBD.Empleado " +
            "ON RESTAURANTBD.Repartidor.idEmpleado = RESTAURANTBD.Empleado.idEmpleado" +
            " INNER JOIN RESTAURANTBD.Sucursal " +
            "ON RESTAURANTBD.Empleado.idSucursal = RESTAURANTBD.Sucursal.idSucursal";

        public long IdEmpleado{ get; set; }

        public string Pago { get; set; }

        public Repartidor()
        {
            Ocultas = new string[] {  };
            NomTabla = "RESTAURANTBD.Repartidor";
            FIRST_PK = 0;
        }

        public override void Inserta(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_INSERCION, conexion))
            {
                comando.Parameters.AddWithValue("@idEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@pago", Pago);

                Id = Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public override void Modifica(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_MODIFICACION, conexion))
            {
                comando.Parameters.AddWithValue("@idEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@pago", Pago);
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
