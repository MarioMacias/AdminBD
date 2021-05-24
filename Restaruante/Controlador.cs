using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaruante
{
    class Controlador
    {
        // Cadena de conexión del Mazacote.
        private static readonly string CADENA_CON = "Data Source=DESKTOP-7N21SII\\SQLEXPRESS;Initial Catalog=restaurant;Integrated Security=True";
        //private static readonly string CADENA_CON = "Data Source=DESKTOP-ARRUD19\\SQLEXPRESS;Initial Catalog=restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlConnection Conexion { get; }

        // Modelo actual.
        public Modelo ModeloActual { get; set; }

        /**
         * Construye un controlador y le asigna el modelo actual.
         */
        public Controlador(Modelo modelo)
        {
            Conexion = new SqlConnection(CADENA_CON);
            Conexion.Open();
            ModeloActual = modelo;
        }

        /**
         * Crea un nuevo empleado
         */
        private void NuevoEmpleado(Empleado empleado, string[] valores)
        {
            empleado.IdSucursal = long.Parse(valores[0]);
            empleado.Nombre = valores[1];
            empleado.NSS = valores[2];
            empleado.Celular = valores[3];
            empleado.Telefono = valores[4];
            empleado.Domicilio = valores[5];
            empleado.Email = valores[6];
        }

        /**
         * Crea un nuevo Pedido
         */
        private void NuevoPedido(Pedido pedido, string[] valores)
        {
            pedido.IdSucursal = long.Parse(valores[0]);
            pedido.IdEmpleado = long.Parse(valores[1]);
            pedido.IdCliente = long.Parse(valores[2]);
            pedido.FechaPedido = valores[3];
            pedido.HoraPedido = valores[4];
            pedido.HoraDeseada = valores[5];
            pedido.Comision = double.Parse(valores[6]);
            pedido.Total = 0;
        }

        /**
         * Crea una nueva sucursal. 
         */
        private void NuevaSucursal(Sucursal sucursal, string[] valores) 
        {
            sucursal.Nombre = valores[0];
            sucursal.Direccion = valores[1];
        }

        /**
         * Crea un nuevo platillo.
         */
        private void NuevoPlatillo(Platillo platillo, string[] valores) 
        {
            platillo.Nombre = valores[0];
            platillo.Descripcion = valores[1];
            platillo.Costo = double.Parse(valores[2]);
        }

        /**
         * Crea un nuevo cliente.
         */
        private void NuevoCliente(Cliente cliente, string[] valores)
        {
            cliente.IdZona = long.Parse(valores[0]);
            cliente.Nombre = valores[1];
            cliente.Domicilio = valores[2];
            cliente.Direccion = valores[3];
            cliente.Telefono = valores[4];
            cliente.Email = valores[5];
        }

        /**
         * Crea un nuevo repartidor.
         */
        private void NuevoRepartidor(Repartidor repartidor, string[] valores)
        {
            repartidor.IdEmpleado = long.Parse(valores[0]);
            repartidor.Pago = valores[1];
        }

        /**
         * Crea un nuevo gerente.
         */
        private void NuevoGerente(Gerente gerente, string[] valores)
        {
            gerente.IdEmpleado = long.Parse(valores[0]);
            gerente.sueldoFijo = valores[1];
        }

        /**
         * Crea un nuevo cocinero.
         */
        private void NuevoCocinero(Cocinero cocinero, string[] valores)
        {
            cocinero.IdEmpleado = long.Parse(valores[0]);
            cocinero.CantidadPlatillos = valores[1];
            cocinero.HorasContrato = valores[2];
            cocinero.Pago = double.Parse(valores[3]);
        }

        /** 
         * Crea un nuevo detalle para un pedido.
         */
        private void NuevoDetallePedido(DetallePedido detallePedido, string[] valores)
        {
            detallePedido.IdPedido = long.Parse(valores[0]);
            detallePedido.IdPlatillo = long.Parse(valores[1]);
            detallePedido.CantidadProductos = valores[2];
            detallePedido.Subtotal = double.Parse(valores[3]);
        }

        /**
         * Crea una nueva zona de domicilio.
         */
        private void NuevoZonaDomicilio(ZonaDomicilio zonaDomicilio, string[] valores)
        {
            zonaDomicilio.Nombre = valores[0];
            zonaDomicilio.CodigoPostal = valores[1];
            zonaDomicilio.ComisionCobro = double.Parse(valores[2]);
        }

        /**
         * Determina el tipo de modelo actual genera una instancia de dicho
         * modelo.
         */
        private void SeleccionaModelo(string[] valores)
        {
            if (ModeloActual is Empleado)
                NuevoEmpleado(ModeloActual as Empleado, valores);
            else if (ModeloActual is Pedido)
                NuevoPedido(ModeloActual as Pedido, valores);
            else if (ModeloActual is DetallePedido)
                NuevoDetallePedido(ModeloActual as DetallePedido, valores);
            else if (ModeloActual is Sucursal)
                NuevaSucursal(ModeloActual as Sucursal, valores);
            else if (ModeloActual is Platillo)
                NuevoPlatillo(ModeloActual as Platillo, valores);
            else if (ModeloActual is Cliente)
                NuevoCliente(ModeloActual as Cliente, valores);
            else if (ModeloActual is Repartidor)
                NuevoRepartidor(ModeloActual as Repartidor, valores);
            else if (ModeloActual is Gerente)
                NuevoGerente(ModeloActual as Gerente, valores);
            else if (ModeloActual is Cocinero)
                NuevoCocinero(ModeloActual as Cocinero, valores);
            else if (ModeloActual is Cocinero)
                NuevoDetallePedido(ModeloActual as DetallePedido, valores);
            else if (ModeloActual is ZonaDomicilio)
                NuevoZonaDomicilio(ModeloActual as ZonaDomicilio, valores);
        }

        /**
         * Valida los datos del modelo
         */
        public bool ValidaDatos(string[] valores)
        {
            return valores.All(valor => valor.Length > 0);
        }

        /**
         * Agrega un nuevo modelo a la base de datos.
         */
        public void Agrega(string[] valores)
        {
            SeleccionaModelo(valores);
            ModeloActual.Inserta(Conexion);
        }

        /**
         * Modifica el modelo que coincida con el id proporcionado
         * y asigna los valores correspondientes a dicho modelo.
         */
        public void Modifica(long id, string[] valores)
        {
            SeleccionaModelo(valores);
            ModeloActual.Id = id;
            ModeloActual.Modifica(Conexion);
        }

        /**
         * Elimina el modelo que coincida con el id proporcionado.
         */

        public void Elimina(long id, string[] valores)
        {
            SeleccionaModelo(valores);
            ModeloActual.Id = id;
            ModeloActual.Elimina(Conexion);
        }

        /**
         * Obtiene la tabla de datos correspondiente a un modelo.
         */
        public DataTable TablaDeDatos() => ModeloActual.Todos(Conexion);
    }
}