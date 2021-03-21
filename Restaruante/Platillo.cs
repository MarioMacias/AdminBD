using System;
using System.Data.SqlClient;

namespace Restaruante
{
    class Platillo : Modelo
    {
        private static readonly string COMANDO_INSERCION =
            "INSERT INTO RESTAURANTBD.platillo(nombre, descripcion, costo) " +
            "VALUES(@nombre, @descripcion, @costo)";

        private static readonly string COMANDO_MODIFICACION =
            "UPDATE RESTAURANTBD.platillo " +
            "SET nombre = @nombre, descripcion = @descripcion, costo = @costo " +
            "WHERE idPlatillo = @idPlatillo";

        private static readonly string COMANDO_ELIMINACION =
            "DELETE FROM RESTAURANTBD.platillo " +
            "WHERE idPlatillo = @idPlatillo";

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public double Costo { get; set; }

        public Platillo()
        {
            NomTabla = "RESTAURANTBD.platillo";
        }

        public Platillo(string nombre, string descripcion, double costo)
        {
            NomTabla = "RESTAURANTBD.platillo";
            Nombre = nombre;
            Descripcion = descripcion;
            Costo = costo;
        }

        public override void Inserta(SqlConnection conexion)
        {
            try
            {
                using (var comando = new SqlCommand(COMANDO_INSERCION, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", Nombre);
                    comando.Parameters.AddWithValue("@descripcion", Descripcion);
                    comando.Parameters.AddWithValue("@costo", Costo);

                    Id = Convert.ToInt32(comando.ExecuteScalar());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void Modifica(SqlConnection conexion)
        {
            try
            {
                using (var comando = new SqlCommand(COMANDO_MODIFICACION, conexion))
                {
                    comando.Parameters.AddWithValue("@idPlatillo", Id);
                    comando.Parameters.AddWithValue("@nombre", Nombre);
                    comando.Parameters.AddWithValue("@descripcion", Descripcion);
                    comando.Parameters.AddWithValue("@costo", Costo);

                    Id = Convert.ToInt32(comando.ExecuteScalar());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void Elimina(SqlConnection conexion)
        {
            try
            {
                using (var comando = new SqlCommand(COMANDO_ELIMINACION, conexion))
                {
                    comando.Parameters.AddWithValue("@idPlatillo", Id);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
