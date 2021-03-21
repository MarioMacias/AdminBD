using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaruante
{
    class Empleado : Modelo
    {
        private static readonly string COMANDO_INSERCION =
            "INSERT INTO RESTAURANTBD.empleado(idSucursal, nombre, NSS, celular, telefono, domicilio, email) " +
            "VALUES(@idSucursal, @nombre, @NSS, @celular, @telefono, @domicilio, @email)";

        private static readonly string COMANDO_MODIFICACION =
            "UPDATE RESTAURANTBD.empleado " +
            "SET idSucursal = @idSucursal, nombre = @nombre, NSS = @NSS, celular = @celular, telefono = @telefono, domicilio = @domicilio, email = @email " +
            "WHERE idEmpleado = @idEmpleado";

        private static readonly string COMANDO_ELIMINACION =
            "DELETE FROM RESTAURANTBD.empleado " +
            "WHERE idEmpleado = @idEmpleado";

        public long IdSucursal { get; set; }
        
        public string Nombre { get; set; }

        public string NSS { get; set; }

        public string Celular { get; set; }

        public string Telefono { get; set; }

        public string Domicilio { get; set; }

        public string Email { get; set; }

        public Empleado()
        {
            NomTabla = "RESTAURANTBD.empleado";
        }
        public Empleado(long idSucursal, string nombre, string nss, string celular, string telefono, string domicilio, string email)
        {
            NomTabla = "RESTAURANTBD.empleado";
            IdSucursal = idSucursal;
            Nombre = nombre;
            NSS = nss;
            Celular = celular;
            Telefono = telefono;
            Domicilio = domicilio;
            Email = email;
        }

        public override void Inserta(SqlConnection conexion)
        {
            try
            {
                using (var comando = new SqlCommand(COMANDO_INSERCION, conexion))
                {
                    comando.Parameters.AddWithValue("@idSucursal", IdSucursal); 
                    comando.Parameters.AddWithValue("@nombre", Nombre);
                    comando.Parameters.AddWithValue("@NSS", NSS);
                    comando.Parameters.AddWithValue("@celular", Celular);
                    comando.Parameters.AddWithValue("@telefono", Telefono);
                    comando.Parameters.AddWithValue("@domicilio", Domicilio);
                    comando.Parameters.AddWithValue("@email", Email);

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
                    comando.Parameters.AddWithValue("@idEmpleado", Id);
                    comando.Parameters.AddWithValue("@idSucursal", IdSucursal);
                    comando.Parameters.AddWithValue("@nombre", Nombre);
                    comando.Parameters.AddWithValue("@NSS", NSS);
                    comando.Parameters.AddWithValue("@celular", Celular);
                    comando.Parameters.AddWithValue("@telefono", Telefono);
                    comando.Parameters.AddWithValue("@domicilio", Domicilio);
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.ExecuteNonQuery();
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
                    comando.Parameters.AddWithValue("@idEmpleado", Id);
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
