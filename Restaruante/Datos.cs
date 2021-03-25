using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using Bunifu.Framework.UI;
using System.Windows.Forms;

namespace Restaruante
{
    public partial class Datos : Form
    {
        private Controlador Controlador { get; set; }

        private int FIRST_PK {get; set;}

        private List<BunifuMaterialTextbox> Inputs { get; set; }

        public Datos()
        {
            InitializeComponent();
            InicializaControlesAdicionales();
        }

        private void InicializaControlesAdicionales() 
        {
            Inputs = new List<BunifuMaterialTextbox>();
            Controlador = new Controlador(new Empleado());
            CargaModelo(Controlador.ModeloActual);
        }

        private void LimpiaControles()
        {
            dgv_Datos.Columns.Clear();
            Inputs.ForEach((textBox) => panel_Empleado.Controls.Remove(textBox));
            Inputs.Clear();
        }

        private void LlenaControles()
        {
            var punto = new Point(23, 7);
            var aux = punto;
            
            for (int i = FIRST_PK; i < dgv_Datos.Columns.Count && i < 5; i++)
                CreaTextBox(dgv_Datos.Columns[i].Name, ref aux);

            punto.X += 220;
            aux = punto;

            for (int i = 5; i < dgv_Datos.Columns.Count; i++)
                CreaTextBox(dgv_Datos.Columns[i].Name, ref aux);
        }

        private void CreaTextBox(string nomCol, ref Point punto)
        {
            var textBox = new BunifuMaterialTextbox()
            {
                Location = punto,
                Text = nomCol,
                Size = new Size(187, 33),
                LineFocusedColor = Color.MediumSeaGreen,
                LineIdleColor = Color.SeaGreen,
                LineMouseHoverColor = Color.MediumSeaGreen,
                Font = new Font("Century Gothic", 9.75F),
                ForeColor = Color.White
            };
            panel_Empleado.Controls.Add(textBox);
            Inputs.Add(textBox);
            punto.Y += 35;
        }

        private void CargaModelo(Modelo modelo)
        {
            LimpiaControles();

            FIRST_PK = modelo.FIRST_PK;
            Controlador.ModeloActual = modelo;
            dgv_Datos.DataSource = Controlador.TablaDeDatos();
            LlenaControles();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e) => Close();

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }

        bool mov;
        int movX, movY;
        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            movX = e.X;
            movY = e.Y;
        }

        private void MenuTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov) SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 227)
            {
                Menu.Width = 0;
                Menu.Visible = false;
                AnimacionOcultar.Show(Menu);
            }
            else
            {
                Menu.Width = 227;
                Menu.Visible = false;
                AnimacionAparecer.Show(Menu);
            }
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void BotonEmpleado_Click(object sender, EventArgs e) => CargaModelo(new Empleado());

        private void btn_repartidor_Click(object sender, EventArgs e) => CargaModelo(new Repartidor());
        
        private void btn_gerente_Click(object sender, EventArgs e) => CargaModelo(new Gerente());

        private void btn_cocinero_Click(object sender, EventArgs e) => CargaModelo(new Cocinero());

        private void BotonPedidos_Click(object sender, EventArgs e) => CargaModelo(new Pedido());
        
        private void btn_detalles_Click(object sender, EventArgs e) => CargaModelo(new DetallePedido());

        private void BotonSucursal_Click(object sender, EventArgs e) => CargaModelo(new Sucursal());

        private void BotonPlatillo_Click(object sender, EventArgs e) => CargaModelo(new Platillo());

        private void BotonClientes_Click(object sender, EventArgs e) => CargaModelo(new Cliente());
        private void btn_zona_Click(object sender, EventArgs e) => CargaModelo(new ZonaDomicilio());

        private void dgv_Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ren = dgv_Datos.CurrentCellAddress.Y;

                for (int i = 0; i < Inputs.Count; i++)
                    Inputs[i].Text = dgv_Datos.Rows[ren].Cells[i + FIRST_PK].Value.ToString();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Solo una celda");
            }
        }
        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var valores = Inputs.Select(input => input.Text).ToArray();
                Controlador.Agrega(valores);
                CargaModelo(Controlador.ModeloActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al insertar: " + ex.Message, "¡Ha ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.CurrentCellAddress.Y == -1)
                return;

            try            
            {
                int ren = dgv_Datos.CurrentCellAddress.Y;
                long id = long.Parse(dgv_Datos.Rows[ren].Cells[0].Value.ToString());
                var valores = Inputs.Select(input => input.Text).ToArray();

                Controlador.Modifica(id, valores); 
                CargaModelo(Controlador.ModeloActual);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocurrió un error al modificar: " + ex.Message, "¡Ha ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Datos.CurrentCellAddress.Y == -1)
                return;

            try
            {
                int ren = dgv_Datos.CurrentCellAddress.Y;
                long id = long.Parse(dgv_Datos.Rows[ren].Cells[0].Value.ToString());
                var valores = Inputs.Select(input => input.Text).ToArray();
                Controlador.Elimina(id, valores);
                CargaModelo(Controlador.ModeloActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar: " + ex.Message, "¡Ha ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuTop_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }
    }
}