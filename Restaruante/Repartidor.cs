using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public long IdEmpleado{ get; set; }

        public string Pago { get; set; }

        public Repartidor()
        {
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
                comando.Parameters.AddWithValue("@idEmpleado", Id);
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
    }
}
