using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaruante
{
    class Cocinero : Modelo
    {
        private static readonly string COMANDO_INSERCION =
            "INSERT INTO RESTAURANTBD.Cocinero(idEmpleado, cantidadPlatillos, horasContrato, pago) " +
            "VALUES(@idEmpleado, @cantidadPlatillos, @horasContrato, @pago)";

        private static readonly string COMANDO_MODIFICACION =
            "UPDATE RESTAURANTBD.Cocinero " +
            "SET idEmpleado = @idEmpleado, cantidadPlatillos = @cantidadPlatillos, horasContrato = @horasContrato, pago = @pago " +
            "WHERE idEmpleado = @idEmpleado";

        private static readonly string COMANDO_ELIMINACION =
            "DELETE RESTAURANTBD.Cocinero " +
            "WHERE idEmpleado = @idEmpleado";

        public long IdEmpleado { get; set; }

        public string CantidadPlatillos { get; set; }

        public string HorasContrato { get; set; }

        public double Pago { get; set; }

        public Cocinero()
        {
            Ocultas = new string[] { };
            NomTabla = "RESTAURANTBD.Cocinero";
            FIRST_PK = 0;
        }

        public override void Inserta(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_INSERCION, conexion))
            {
                comando.Parameters.AddWithValue("@idEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@cantidadPlatillos", CantidadPlatillos);
                comando.Parameters.AddWithValue("@horasContrato", HorasContrato);
                comando.Parameters.AddWithValue("@pago", Pago);

                Id = Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public override void Modifica(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_MODIFICACION, conexion))
            {
                comando.Parameters.AddWithValue("@idEmpleado", Id);
                comando.Parameters.AddWithValue("@cantidadPlatillos", CantidadPlatillos);
                comando.Parameters.AddWithValue("@horasContrato", HorasContrato);
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
