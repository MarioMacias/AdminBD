using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaruante
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
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

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

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
            if (mov) this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
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
                //Contenedor.Width = 994;
                Menu.Visible = false;
                AnimacionAparecer.Show(Menu);
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            datos.Show();
        }

        private void MenuTop_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }
    }
}
