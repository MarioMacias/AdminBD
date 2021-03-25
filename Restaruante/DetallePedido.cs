using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaruante
{
    class DetallePedido : Modelo
    {
        private static readonly string COMANDO_INSERCION =
            "INSERT INTO RESTAURANTBD.DetallePedido(idPedido, idPlatillo, cantidadProductos, subtotal) " +
            "VALUES(@idPedido, @idPlatillo, @cantidadProductos, @subtotal)";

        private static readonly string COMANDO_MODIFICACION =
            "UPDATE RESTAURANTBD.DetallePedido " +
            "SET idPedido = @idPedido, idPlatillo = @idPlatillo, cantidadProductos = @cantidadProductos, subtotal = @subtotal " +
            "WHERE idPedido = @idPedido AND idPlatillo = @idPlatillo";

        private static readonly string COMANDO_ELIMINACION =
            "DELETE RESTAURANTBD.DetallePedido " +
            "WHERE idPedido = @idPedido AND idPlatillo = @idPlatillo";

        public long IdPedido { get; set; }

        public long IdPlatillo { get; set; }

        public string CantidadProductos { get; set; }

        public double Subtotal { get; set; }

        public DetallePedido()
        {
            NomTabla = "RESTAURANTBD.DetallePedido";
            FIRST_PK = 0;
        }

        public override void Inserta(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_INSERCION, conexion))
            {
                comando.Parameters.AddWithValue("@idPedido", IdPedido);
                comando.Parameters.AddWithValue("@idPlatillo", IdPlatillo);
                comando.Parameters.AddWithValue("@cantidadProductos", CantidadProductos);
                comando.Parameters.AddWithValue("@pago", Subtotal);

                Id = Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public override void Modifica(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_MODIFICACION, conexion))
            {
                comando.Parameters.AddWithValue("@idPedido", IdPedido);
                comando.Parameters.AddWithValue("@idPlatillo", IdPlatillo);
                comando.Parameters.AddWithValue("@cantidadProductos", CantidadProductos);
                comando.Parameters.AddWithValue("@pago", Subtotal);
                comando.ExecuteNonQuery();
            }
        }

        public override void Elimina(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_ELIMINACION, conexion))
            {
                comando.Parameters.AddWithValue("@idPedido", IdPedido);
                comando.Parameters.AddWithValue("@idPlatillo", IdPlatillo);
                comando.ExecuteNonQuery();
            }
        }
    }
}
