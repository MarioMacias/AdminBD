namespace Restaruante
{
    partial class Datos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            this.AnimacionAparecer = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel_Menu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_cocinero = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_gerente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_repartidor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.botonSucursal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.botonEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.dgv_Datos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_Datos = new System.Windows.Forms.Panel();
            this.panel_Empleado = new System.Windows.Forms.Panel();
            this.panel_Botones = new System.Windows.Forms.Panel();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Menu = new System.Windows.Forms.Panel();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.AnimacionOcultar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_detalles = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).BeginInit();
            this.Panel_Datos.SuspendLayout();
            this.panel_Botones.SuspendLayout();
            this.Menu.SuspendLayout();
            this.MenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimacionAparecer
            // 
            this.AnimacionAparecer.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionAparecer.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(0);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 0F;
            this.AnimacionAparecer.DefaultAnimation = animation11;
            // 
            // panel_Menu
            // 
            this.panel_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Menu.BackgroundImage")));
            this.panel_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Menu.Controls.Add(this.btn_detalles);
            this.panel_Menu.Controls.Add(this.btn_cocinero);
            this.panel_Menu.Controls.Add(this.btn_gerente);
            this.panel_Menu.Controls.Add(this.btn_repartidor);
            this.panel_Menu.Controls.Add(this.botonSucursal);
            this.panel_Menu.Controls.Add(this.bunifuFlatButton3);
            this.panel_Menu.Controls.Add(this.bunifuFlatButton5);
            this.panel_Menu.Controls.Add(this.bunifuFlatButton4);
            this.panel_Menu.Controls.Add(this.botonEmpleado);
            this.panel_Menu.Controls.Add(this.label2);
            this.panel_Menu.Controls.Add(this.label3);
            this.panel_Menu.Controls.Add(this.pictureBox1);
            this.panel_Menu.Controls.Add(this.bunifuSeparator1);
            this.AnimacionOcultar.SetDecoration(this.panel_Menu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.panel_Menu, BunifuAnimatorNS.DecorationType.None);
            this.panel_Menu.GradientBottomLeft = System.Drawing.Color.DarkGreen;
            this.panel_Menu.GradientBottomRight = System.Drawing.Color.Green;
            this.panel_Menu.GradientTopLeft = System.Drawing.Color.OliveDrab;
            this.panel_Menu.GradientTopRight = System.Drawing.Color.DarkOliveGreen;
            this.panel_Menu.Location = new System.Drawing.Point(13, 6);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Quality = 10;
            this.panel_Menu.Size = new System.Drawing.Size(199, 574);
            this.panel_Menu.TabIndex = 0;
            // 
            // btn_cocinero
            // 
            this.btn_cocinero.Activecolor = System.Drawing.Color.Black;
            this.btn_cocinero.BackColor = System.Drawing.Color.Transparent;
            this.btn_cocinero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cocinero.BorderRadius = 0;
            this.btn_cocinero.ButtonText = "Cocinero";
            this.btn_cocinero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAparecer.SetDecoration(this.btn_cocinero, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.btn_cocinero, BunifuAnimatorNS.DecorationType.None);
            this.btn_cocinero.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cocinero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cocinero.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cocinero.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_cocinero.Iconimage")));
            this.btn_cocinero.Iconimage_right = null;
            this.btn_cocinero.Iconimage_right_Selected = null;
            this.btn_cocinero.Iconimage_Selected = null;
            this.btn_cocinero.IconMarginLeft = 0;
            this.btn_cocinero.IconMarginRight = 0;
            this.btn_cocinero.IconRightVisible = true;
            this.btn_cocinero.IconRightZoom = 0D;
            this.btn_cocinero.IconVisible = true;
            this.btn_cocinero.IconZoom = 90D;
            this.btn_cocinero.IsTab = false;
            this.btn_cocinero.Location = new System.Drawing.Point(40, 254);
            this.btn_cocinero.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_cocinero.Name = "btn_cocinero";
            this.btn_cocinero.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_cocinero.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_cocinero.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cocinero.selected = false;
            this.btn_cocinero.Size = new System.Drawing.Size(138, 34);
            this.btn_cocinero.TabIndex = 18;
            this.btn_cocinero.Text = "Cocinero";
            this.btn_cocinero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cocinero.Textcolor = System.Drawing.Color.White;
            this.btn_cocinero.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cocinero.Click += new System.EventHandler(this.btn_cocinero_Click);
            // 
            // btn_gerente
            // 
            this.btn_gerente.Activecolor = System.Drawing.Color.Black;
            this.btn_gerente.BackColor = System.Drawing.Color.Transparent;
            this.btn_gerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_gerente.BorderRadius = 0;
            this.btn_gerente.ButtonText = "Gerente";
            this.btn_gerente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAparecer.SetDecoration(this.btn_gerente, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.btn_gerente, BunifuAnimatorNS.DecorationType.None);
            this.btn_gerente.DisabledColor = System.Drawing.Color.Gray;
            this.btn_gerente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerente.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_gerente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_gerente.Iconimage")));
            this.btn_gerente.Iconimage_right = null;
            this.btn_gerente.Iconimage_right_Selected = null;
            this.btn_gerente.Iconimage_Selected = null;
            this.btn_gerente.IconMarginLeft = 0;
            this.btn_gerente.IconMarginRight = 0;
            this.btn_gerente.IconRightVisible = true;
            this.btn_gerente.IconRightZoom = 0D;
            this.btn_gerente.IconVisible = true;
            this.btn_gerente.IconZoom = 90D;
            this.btn_gerente.IsTab = false;
            this.btn_gerente.Location = new System.Drawing.Point(40, 212);
            this.btn_gerente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_gerente.Name = "btn_gerente";
            this.btn_gerente.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_gerente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_gerente.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_gerente.selected = false;
            this.btn_gerente.Size = new System.Drawing.Size(138, 34);
            this.btn_gerente.TabIndex = 17;
            this.btn_gerente.Text = "Gerente";
            this.btn_gerente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gerente.Textcolor = System.Drawing.Color.White;
            this.btn_gerente.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerente.Click += new System.EventHandler(this.btn_gerente_Click);
            // 
            // btn_repartidor
            // 
            this.btn_repartidor.Activecolor = System.Drawing.Color.Black;
            this.btn_repartidor.BackColor = System.Drawing.Color.Transparent;
            this.btn_repartidor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_repartidor.BorderRadius = 0;
            this.btn_repartidor.ButtonText = "Repartidor";
            this.btn_repartidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAparecer.SetDecoration(this.btn_repartidor, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.btn_repartidor, BunifuAnimatorNS.DecorationType.None);
            this.btn_repartidor.DisabledColor = System.Drawing.Color.Gray;
            this.btn_repartidor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repartidor.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_repartidor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_repartidor.Iconimage")));
            this.btn_repartidor.Iconimage_right = null;
            this.btn_repartidor.Iconimage_right_Selected = null;
            this.btn_repartidor.Iconimage_Selected = null;
            this.btn_repartidor.IconMarginLeft = 0;
            this.btn_repartidor.IconMarginRight = 0;
            this.btn_repartidor.IconRightVisible = true;
            this.btn_repartidor.IconRightZoom = 0D;
            this.btn_repartidor.IconVisible = true;
            this.btn_repartidor.IconZoom = 90D;
            this.btn_repartidor.IsTab = false;
            this.btn_repartidor.Location = new System.Drawing.Point(40, 170);
            this.btn_repartidor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_repartidor.Name = "btn_repartidor";
            this.btn_repartidor.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_repartidor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_repartidor.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_repartidor.selected = false;
            this.btn_repartidor.Size = new System.Drawing.Size(138, 34);
            this.btn_repartidor.TabIndex = 16;
            this.btn_repartidor.Text = "Repartidor";
            this.btn_repartidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_repartidor.Textcolor = System.Drawing.Color.White;
            this.btn_repartidor.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repartidor.Click += new System.EventHandler(this.btn_repartidor_Click);
            // 
            // botonSucursal
            // 
            this.botonSucursal.Activecolor = System.Drawing.Color.Black;
            this.botonSucursal.BackColor = System.Drawing.Color.Transparent;
            this.botonSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSucursal.BorderRadius = 0;
            this.botonSucursal.ButtonText = "Sucursal";
            this.botonSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAparecer.SetDecoration(this.botonSucursal, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.botonSucursal, BunifuAnimatorNS.DecorationType.None);
            this.botonSucursal.DisabledColor = System.Drawing.Color.Gray;
            this.botonSucursal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSucursal.Iconcolor = System.Drawing.Color.Transparent;
            this.botonSucursal.Iconimage = ((System.Drawing.Image)(resources.GetObject("botonSucursal.Iconimage")));
            this.botonSucursal.Iconimage_right = null;
            this.botonSucursal.Iconimage_right_Selected = null;
            this.botonSucursal.Iconimage_Selected = null;
            this.botonSucursal.IconMarginLeft = 0;
            this.botonSucursal.IconMarginRight = 0;
            this.botonSucursal.IconRightVisible = true;
            this.botonSucursal.IconRightZoom = 0D;
            this.botonSucursal.IconVisible = true;
            this.botonSucursal.IconZoom = 90D;
            this.botonSucursal.IsTab = false;
            this.botonSucursal.Location = new System.Drawing.Point(5, 371);
            this.botonSucursal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.botonSucursal.Name = "botonSucursal";
            this.botonSucursal.Normalcolor = System.Drawing.Color.Transparent;
            this.botonSucursal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.botonSucursal.OnHoverTextColor = System.Drawing.Color.White;
            this.botonSucursal.selected = false;
            this.botonSucursal.Size = new System.Drawing.Size(189, 44);
            this.botonSucursal.TabIndex = 15;
            this.botonSucursal.Text = "Sucursal";
            this.botonSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonSucursal.Textcolor = System.Drawing.Color.White;
            this.botonSucursal.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSucursal.Click += new System.EventHandler(this.BotonSucursal_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Pedidos";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAparecer.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(5, 293);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(189, 44);
            this.bunifuFlatButton3.TabIndex = 14;
            this.bunifuFlatButton3.Text = "Pedidos";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.BotonPedidos_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Black;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Clientes";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAparecer.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(5, 475);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(189, 44);
            this.bunifuFlatButton5.TabIndex = 13;
            this.bunifuFlatButton5.Text = "Clientes";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.BotonClientes_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Black;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Platillo";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAparecer.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(5, 423);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(189, 44);
            this.bunifuFlatButton4.TabIndex = 12;
            this.bunifuFlatButton4.Text = "Platillo";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.BotonPlatillo_Click);
            // 
            // botonEmpleado
            // 
            this.botonEmpleado.Activecolor = System.Drawing.Color.Black;
            this.botonEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.botonEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonEmpleado.BorderRadius = 0;
            this.botonEmpleado.ButtonText = "Empleado";
            this.botonEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAparecer.SetDecoration(this.botonEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.botonEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.botonEmpleado.DisabledColor = System.Drawing.Color.Gray;
            this.botonEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.botonEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("botonEmpleado.Iconimage")));
            this.botonEmpleado.Iconimage_right = null;
            this.botonEmpleado.Iconimage_right_Selected = null;
            this.botonEmpleado.Iconimage_Selected = null;
            this.botonEmpleado.IconMarginLeft = 0;
            this.botonEmpleado.IconMarginRight = 0;
            this.botonEmpleado.IconRightVisible = true;
            this.botonEmpleado.IconRightZoom = 0D;
            this.botonEmpleado.IconVisible = true;
            this.botonEmpleado.IconZoom = 90D;
            this.botonEmpleado.IsTab = false;
            this.botonEmpleado.Location = new System.Drawing.Point(5, 128);
            this.botonEmpleado.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.botonEmpleado.Name = "botonEmpleado";
            this.botonEmpleado.Normalcolor = System.Drawing.Color.Transparent;
            this.botonEmpleado.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.botonEmpleado.OnHoverTextColor = System.Drawing.Color.White;
            this.botonEmpleado.selected = false;
            this.botonEmpleado.Size = new System.Drawing.Size(189, 44);
            this.botonEmpleado.TabIndex = 8;
            this.botonEmpleado.Text = "Empleado";
            this.botonEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonEmpleado.Textcolor = System.Drawing.Color.White;
            this.botonEmpleado.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEmpleado.Click += new System.EventHandler(this.BotonEmpleado_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionAparecer.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(104, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionAparecer.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(88, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionAparecer.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionOcultar.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 90);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(193, 32);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionAparecer.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(918, 7);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(25, 25);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 1;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionAparecer.SetDecoration(this.Cerrar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.Cerrar, BunifuAnimatorNS.DecorationType.None);
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(954, 7);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 0;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionAparecer.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(918, 8);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(25, 25);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 4;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionAparecer.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(394, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "RESTAURANTE";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseUp);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionAparecer.SetDecoration(this.btn_Menu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.btn_Menu, BunifuAnimatorNS.DecorationType.None);
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.Location = new System.Drawing.Point(13, 7);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(25, 25);
            this.btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Menu.TabIndex = 3;
            this.btn_Menu.TabStop = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionAparecer.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(882, 7);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.SystemColors.Desktop;
            this.Contenedor.Controls.Add(this.dgv_Datos);
            this.Contenedor.Controls.Add(this.Panel_Datos);
            this.AnimacionOcultar.SetDecoration(this.Contenedor, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.Contenedor, BunifuAnimatorNS.DecorationType.None);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(227, 39);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(768, 592);
            this.Contenedor.TabIndex = 5;
            // 
            // dgv_Datos
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Datos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Datos.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_Datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.AnimacionAparecer.SetDecoration(this.dgv_Datos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.dgv_Datos, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Datos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_Datos.DoubleBuffered = true;
            this.dgv_Datos.EnableHeadersVisualStyles = false;
            this.dgv_Datos.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_Datos.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Datos.Location = new System.Drawing.Point(6, 204);
            this.dgv_Datos.Name = "dgv_Datos";
            this.dgv_Datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Datos.Size = new System.Drawing.Size(750, 376);
            this.dgv_Datos.TabIndex = 1;
            this.dgv_Datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Datos_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Panel_Datos
            // 
            this.Panel_Datos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Datos.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Datos.Controls.Add(this.panel_Empleado);
            this.Panel_Datos.Controls.Add(this.panel_Botones);
            this.AnimacionOcultar.SetDecoration(this.Panel_Datos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.Panel_Datos, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Datos.Location = new System.Drawing.Point(6, 6);
            this.Panel_Datos.Name = "Panel_Datos";
            this.Panel_Datos.Size = new System.Drawing.Size(750, 190);
            this.Panel_Datos.TabIndex = 0;
            // 
            // panel_Empleado
            // 
            this.panel_Empleado.BackColor = System.Drawing.Color.Black;
            this.AnimacionOcultar.SetDecoration(this.panel_Empleado, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.panel_Empleado, BunifuAnimatorNS.DecorationType.None);
            this.panel_Empleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Empleado.Location = new System.Drawing.Point(171, 0);
            this.panel_Empleado.Name = "panel_Empleado";
            this.panel_Empleado.Size = new System.Drawing.Size(579, 190);
            this.panel_Empleado.TabIndex = 1;
            // 
            // panel_Botones
            // 
            this.panel_Botones.Controls.Add(this.bunifuFlatButton8);
            this.panel_Botones.Controls.Add(this.bunifuFlatButton7);
            this.panel_Botones.Controls.Add(this.bunifuFlatButton6);
            this.AnimacionOcultar.SetDecoration(this.panel_Botones, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.panel_Botones, BunifuAnimatorNS.DecorationType.None);
            this.panel_Botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Botones.Location = new System.Drawing.Point(0, 0);
            this.panel_Botones.Name = "panel_Botones";
            this.panel_Botones.Size = new System.Drawing.Size(171, 190);
            this.panel_Botones.TabIndex = 0;
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 5;
            this.bunifuFlatButton8.ButtonText = "Eliminar";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAparecer.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton8.Iconimage")));
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(0, 128);
            this.bunifuFlatButton8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.DarkGreen;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(171, 64);
            this.bunifuFlatButton8.TabIndex = 5;
            this.bunifuFlatButton8.Text = "Eliminar";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 5;
            this.bunifuFlatButton7.ButtonText = "Modificar";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAparecer.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(0, 64);
            this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.DarkGreen;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(171, 64);
            this.bunifuFlatButton7.TabIndex = 4;
            this.bunifuFlatButton7.Text = "Modificar";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 5;
            this.bunifuFlatButton6.ButtonText = "Agregar";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAparecer.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.DarkGreen;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(171, 64);
            this.bunifuFlatButton6.TabIndex = 3;
            this.bunifuFlatButton6.Text = "Agregar";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Black;
            this.Menu.Controls.Add(this.panel_Menu);
            this.AnimacionOcultar.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 39);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(227, 592);
            this.Menu.TabIndex = 4;
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.Black;
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.btn_Menu);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Cerrar);
            this.AnimacionOcultar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(995, 39);
            this.MenuTop.TabIndex = 3;
            this.MenuTop.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuTop_Paint);
            this.MenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            this.MenuTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseMove);
            this.MenuTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseUp);
            // 
            // AnimacionOcultar
            // 
            this.AnimacionOcultar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionOcultar.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 1;
            animation12.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 2F;
            animation12.TransparencyCoeff = 0F;
            this.AnimacionOcultar.DefaultAnimation = animation12;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.panel_Menu;
            // 
            // btn_detalles
            // 
            this.btn_detalles.Activecolor = System.Drawing.Color.Black;
            this.btn_detalles.BackColor = System.Drawing.Color.Transparent;
            this.btn_detalles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_detalles.BorderRadius = 0;
            this.btn_detalles.ButtonText = "Detalles";
            this.btn_detalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionAparecer.SetDecoration(this.btn_detalles, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.btn_detalles, BunifuAnimatorNS.DecorationType.None);
            this.btn_detalles.DisabledColor = System.Drawing.Color.Gray;
            this.btn_detalles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalles.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_detalles.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_detalles.Iconimage")));
            this.btn_detalles.Iconimage_right = null;
            this.btn_detalles.Iconimage_right_Selected = null;
            this.btn_detalles.Iconimage_Selected = null;
            this.btn_detalles.IconMarginLeft = 0;
            this.btn_detalles.IconMarginRight = 0;
            this.btn_detalles.IconRightVisible = true;
            this.btn_detalles.IconRightZoom = 0D;
            this.btn_detalles.IconVisible = true;
            this.btn_detalles.IconZoom = 90D;
            this.btn_detalles.IsTab = false;
            this.btn_detalles.Location = new System.Drawing.Point(40, 333);
            this.btn_detalles.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_detalles.Name = "btn_detalles";
            this.btn_detalles.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_detalles.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_detalles.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_detalles.selected = false;
            this.btn_detalles.Size = new System.Drawing.Size(138, 34);
            this.btn_detalles.TabIndex = 19;
            this.btn_detalles.Text = "Detalles";
            this.btn_detalles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_detalles.Textcolor = System.Drawing.Color.White;
            this.btn_detalles.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalles.Click += new System.EventHandler(this.btn_detalles_Click);
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 631);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuTop);
            this.AnimacionOcultar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).EndInit();
            this.Panel_Datos.ResumeLayout(false);
            this.panel_Botones.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition AnimacionAparecer;
        private BunifuAnimatorNS.BunifuTransition AnimacionOcultar;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_Menu;
        private Bunifu.Framework.UI.BunifuFlatButton botonEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Menu;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel MenuTop;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Datos;
        private System.Windows.Forms.Panel Panel_Datos;
        private System.Windows.Forms.Panel panel_Empleado;
        private System.Windows.Forms.Panel panel_Botones;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton botonSucursal;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cocinero;
        private Bunifu.Framework.UI.BunifuFlatButton btn_gerente;
        private Bunifu.Framework.UI.BunifuFlatButton btn_repartidor;
        private Bunifu.Framework.UI.BunifuFlatButton btn_detalles;
    }
}