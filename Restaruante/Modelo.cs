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
    abstract class Modelo
    {
        protected string NomTabla { get; set; }

        public string[] Ocultas { get; protected set; }

        public long Id { get; set; }

        public int FIRST_PK { get; set; }

        public abstract void Inserta(SqlConnection conexion);

        public abstract void Modifica(SqlConnection conexion);

        public abstract void Elimina(SqlConnection conexion);

        public virtual DataTable Todos(SqlConnection conexion)
        {
            var tabla = new DataTable();
            var set = new DataSet();
            using (var adaptador = new SqlDataAdapter("SELECT * FROM " + NomTabla, conexion))
            {
                adaptador.Fill(tabla);
            }

            return tabla;
        }
    }
}
