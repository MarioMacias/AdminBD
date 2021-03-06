using System;
using System.Data.SqlClient;
using System.Data;

namespace Restaruante
{
    class Pedido : Modelo
    {
        private static readonly string COMANDO_INSERCION =
            "INSERT INTO RESTAURANTBD.Pedido(idSucursal, idEmpleado, idCliente, fechaPedido, horaPedido, horaDeseada, comision, total) " +
            "VALUES(@idSucursal, @idEmpleado, @idCliente, @fechaPedido, @horaPedido, @horaDeseada, @comision, @total)";

        private static readonly string COMANDO_MODIFICACION =
            "UPDATE RESTAURANTBD.Pedido " +
            "SET idSucursal = @idSucursal, idEmpleado = @idEmpleado, idCliente = @idCliente, fechaPedido = @fechaPedido, horaPedido = @horaPedido, horaDeseada = @horaDeseada, comision = @comision, total = @total " +
            "WHERE idPedido = @idPedido";

        private static readonly string COMANDO_ELIMINACION =
            "DELETE FROM RESTAURANTBD.Pedido " +
            "WHERE idPedido = @idPedido";

        private static readonly string TODOS =
            "SELECT idPedido, RESTAURANTBD.Pedido.idSucursal, " +
            "CONCAT(RESTAURANTBD.Pedido.idSucursal, ' - ', RESTAURANTBD.Sucursal.nombre) AS Sucursal, RESTAURANTBD.Pedido.idEmpleado," +
            "CONCAT(RESTAURANTBD.Pedido.idEmpleado, ' - ', RESTAURANTBD.Empleado.idSucursal, ' - ', RESTAURANTBD.Empleado.Nombre) AS Empleado, RESTAURANTBD.Pedido.idCliente," +
            "CONCAT(RESTAURANTBD.Pedido.idCliente, ' - ', RESTAURANTBD.Cliente.nombre, ' - ', RESTAURANTBD.Cliente.idZona) AS Cliente," +
            "fechaPedido, horaPedido, horaDeseada, comision, total " +
            "FROM RESTAURANTBD.Pedido " +
            "INNER JOIN RESTAURANTBD.Sucursal ON RESTAURANTBD.Pedido.idSucursal = RESTAURANTBD.Sucursal.idSucursal " +
            "INNER JOIN RESTAURANTBD.Empleado ON RESTAURANTBD.Pedido.idEmpleado = RESTAURANTBD.Empleado.idEmpleado " +
            "INNER JOIN RESTAURANTBD.Cliente ON RESTAURANTBD.Pedido.idCliente = RESTAURANTBD.Cliente.idCliente ";

        public long IdSucursal { get; set; }
        
        public long IdEmpleado { get; set; }
        
        public long IdCliente { get; set; }
        
        public string FechaPedido { get; set; }
        
        public string HoraPedido { get; set; }
        
        public string HoraDeseada { get; set; }
        
        public double Comision { get; set; }
        
        public double Total { get; set; }

        public Pedido() 
        {
            Ocultas = new string[] { "idSucursal", "idEmpleado", "idCliente" };
            NomTabla = "RESTAURANTBD.Pedido";
            FIRST_PK = 1;
        }

        public override void Inserta(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_INSERCION, conexion))
            {
                comando.Parameters.AddWithValue("@idSucursal", IdSucursal);
                comando.Parameters.AddWithValue("@idEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@idCliente", IdCliente);
                comando.Parameters.AddWithValue("@fechaPedido", FechaPedido);
                comando.Parameters.AddWithValue("@horaPedido", HoraPedido);
                comando.Parameters.AddWithValue("@horaDeseada", HoraDeseada);
                comando.Parameters.AddWithValue("@comision", Comision);
                comando.Parameters.AddWithValue("@total", Total);

                Id = Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public override void Modifica(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_MODIFICACION, conexion))
            {
                comando.Parameters.AddWithValue("@idPedido", Id);
                comando.Parameters.AddWithValue("@idSucursal", IdSucursal);
                comando.Parameters.AddWithValue("@idEmpleado", IdEmpleado);
                comando.Parameters.AddWithValue("@idCliente", IdCliente);
                comando.Parameters.AddWithValue("@fechaPedido", FechaPedido);
                comando.Parameters.AddWithValue("@horaPedido", HoraPedido);
                comando.Parameters.AddWithValue("@horaDeseada", HoraDeseada);
                comando.Parameters.AddWithValue("@comision", Comision);
                comando.Parameters.AddWithValue("@total", Total);
                comando.ExecuteNonQuery();
            }
        }

        public override void Elimina(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_ELIMINACION, conexion))
            {
                comando.Parameters.AddWithValue("@idPedido", Id);
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