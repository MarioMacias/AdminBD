using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaruante
{
    class ZonaDomicilio:Modelo
    {

        private static readonly string COMANDO_INSERCION =
            "INSERT INTO RESTAURANTBD.ZonaDomicilio(nombre, codigoPostal, comisionCobro) " +
            "VALUES(@nombre, @codigoPostal, @comisionCobro)";

        private static readonly string COMANDO_MODIFICACION =
            "UPDATE RESTAURANTBD.ZonaDomicilio " +
            "SET nombre = @nombre, codigoPostal = @codigoPostal, comisionCobro = @comisionCobro " +
            "WHERE idZona = @idZona";

        private static readonly string COMANDO_ELIMINACION =
            "DELETE RESTAURANTBD.ZonaDomicilio " +
            "WHERE idZona = @idZona";

        public long IdZona { get; set; }

        public string Nombre { get; set; }

        public string CodigoPostal { get; set; }

        public double ComisionCobro { get; set; }

        public ZonaDomicilio()
        {
            NomTabla = "RESTAURANTBD.ZonaDomicilio";
            FIRST_PK = 1;
        }

        public override void Inserta(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_INSERCION, conexion))
            {
                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@codigoPostal", CodigoPostal);
                comando.Parameters.AddWithValue("@comisionCobro", ComisionCobro);

                Id = Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public override void Modifica(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_MODIFICACION, conexion))
            {
                comando.Parameters.AddWithValue("@idZona", Id);
                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@codigoPostal", CodigoPostal);
                comando.Parameters.AddWithValue("@comisionCobro", ComisionCobro);

                comando.ExecuteNonQuery();
            }
        }

        public override void Elimina(SqlConnection conexion)
        {
            using (var comando = new SqlCommand(COMANDO_ELIMINACION, conexion))
            {
                comando.Parameters.AddWithValue("@idZona", Id);
                comando.ExecuteNonQuery();
            }
        }
    }
}
