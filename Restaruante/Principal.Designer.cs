namespace Restaruante
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.Panel();
            this.panel_Menu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Contenedor = new System.Windows.Forms.Panel();
            this.flp_Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards5 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards6 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards8 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards9 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards7 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards11 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards12 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards10 = new Bunifu.Framework.UI.BunifuCards();
            this.AnimacionOcultar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionAparecer = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.dataSet = new System.Data.DataSet();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.Menu.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Contenedor.SuspendLayout();
            this.flp_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
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
            this.AnimacionAparecer.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(994, 39);
            this.MenuTop.TabIndex = 0;
            this.MenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            this.MenuTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseMove);
            this.MenuTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseUp);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionOcultar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(917, 6);
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
            this.AnimacionOcultar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
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
            this.AnimacionOcultar.SetDecoration(this.btn_Menu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.btn_Menu, BunifuAnimatorNS.DecorationType.None);
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
            this.AnimacionOcultar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(881, 7);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionOcultar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(917, 7);
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
            this.AnimacionOcultar.SetDecoration(this.Cerrar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.Cerrar, BunifuAnimatorNS.DecorationType.None);
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(953, 7);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 0;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Black;
            this.Menu.Controls.Add(this.panel_Menu);
            this.AnimacionAparecer.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 39);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(227, 593);
            this.Menu.TabIndex = 1;
            // 
            // panel_Menu
            // 
            this.panel_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Menu.BackgroundImage")));
            this.panel_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Menu.Controls.Add(this.bunifuTextbox1);
            this.panel_Menu.Controls.Add(this.bunifuFlatButton5);
            this.panel_Menu.Controls.Add(this.bunifuFlatButton4);
            this.panel_Menu.Controls.Add(this.bunifuFlatButton3);
            this.panel_Menu.Controls.Add(this.bunifuFlatButton2);
            this.panel_Menu.Controls.Add(this.bunifuFlatButton1);
            this.panel_Menu.Controls.Add(this.label2);
            this.panel_Menu.Controls.Add(this.label3);
            this.panel_Menu.Controls.Add(this.pictureBox1);
            this.panel_Menu.Controls.Add(this.bunifuSeparator1);
            this.AnimacionAparecer.SetDecoration(this.panel_Menu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.panel_Menu, BunifuAnimatorNS.DecorationType.None);
            this.panel_Menu.GradientBottomLeft = System.Drawing.Color.DarkGreen;
            this.panel_Menu.GradientBottomRight = System.Drawing.Color.Green;
            this.panel_Menu.GradientTopLeft = System.Drawing.Color.OliveDrab;
            this.panel_Menu.GradientTopRight = System.Drawing.Color.DarkOliveGreen;
            this.panel_Menu.Location = new System.Drawing.Point(13, 6);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Quality = 10;
            this.panel_Menu.Size = new System.Drawing.Size(199, 575);
            this.panel_Menu.TabIndex = 0;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnimacionAparecer.SetDecoration(this.bunifuTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(5, 112);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(187, 36);
            this.bunifuTextbox1.TabIndex = 13;
            this.bunifuTextbox1.text = "Búsqueda";
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Black;
            this.bunifuFlatButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Nuevos Datos";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionOcultar.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuFlatButton5.TabIndex = 12;
            this.bunifuFlatButton5.Text = "Nuevos Datos";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Black;
            this.bunifuFlatButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Salir";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionOcultar.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuFlatButton4.Location = new System.Drawing.Point(3, 527);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(189, 44);
            this.bunifuFlatButton4.TabIndex = 11;
            this.bunifuFlatButton4.Text = "Salir";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Pedidos";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionOcultar.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuFlatButton3.Location = new System.Drawing.Point(5, 211);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(189, 44);
            this.bunifuFlatButton3.TabIndex = 10;
            this.bunifuFlatButton3.Text = "Pedidos";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Sucursales";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionOcultar.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(5, 263);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(189, 44);
            this.bunifuFlatButton2.TabIndex = 9;
            this.bunifuFlatButton2.Text = "Sucursales";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Menú";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionOcultar.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(5, 159);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(189, 44);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Menú";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionOcultar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
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
            this.AnimacionOcultar.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
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
            this.AnimacionOcultar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
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
            this.AnimacionAparecer.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 90);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(193, 32);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.panel_Menu;
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.Black;
            this.Contenedor.Controls.Add(this.flp_Principal);
            this.AnimacionAparecer.SetDecoration(this.Contenedor, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.Contenedor, BunifuAnimatorNS.DecorationType.None);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(227, 39);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(767, 593);
            this.Contenedor.TabIndex = 2;
            // 
            // flp_Principal
            // 
            this.flp_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Principal.AutoScroll = true;
            this.flp_Principal.BackColor = System.Drawing.Color.Transparent;
            this.flp_Principal.Controls.Add(this.bunifuCards1);
            this.flp_Principal.Controls.Add(this.bunifuCards2);
            this.flp_Principal.Controls.Add(this.bunifuCards3);
            this.flp_Principal.Controls.Add(this.bunifuCards4);
            this.flp_Principal.Controls.Add(this.bunifuCards5);
            this.flp_Principal.Controls.Add(this.bunifuCards6);
            this.flp_Principal.Controls.Add(this.bunifuCards8);
            this.flp_Principal.Controls.Add(this.bunifuCards9);
            this.flp_Principal.Controls.Add(this.bunifuCards7);
            this.flp_Principal.Controls.Add(this.bunifuCards11);
            this.flp_Principal.Controls.Add(this.bunifuCards12);
            this.flp_Principal.Controls.Add(this.bunifuCards10);
            this.AnimacionOcultar.SetDecoration(this.flp_Principal, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionAparecer.SetDecoration(this.flp_Principal, BunifuAnimatorNS.DecorationType.None);
            this.flp_Principal.Location = new System.Drawing.Point(8, 6);
            this.flp_Principal.Name = "flp_Principal";
            this.flp_Principal.Size = new System.Drawing.Size(749, 575);
            this.flp_Principal.TabIndex = 0;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.OliveDrab;
            this.AnimacionAparecer.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(15, 3);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(214, 200);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.OliveDrab;
            this.AnimacionAparecer.SetDecoration(this.bunifuCards2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuCards2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(254, 3);
            this.bunifuCards2.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(214, 200);
            this.bunifuCards2.TabIndex = 1;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.OliveDrab;
            this.AnimacionAparecer.SetDecoration(this.bunifuCards3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuCards3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(493, 3);
            this.bunifuCards3.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(214, 200);
            this.bunifuCards3.TabIndex = 1;
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.OliveDrab;
            this.AnimacionAparecer.SetDecoration(this.bunifuCards4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuCards4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(15, 209);
            this.bunifuCards4.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(214, 200);
            this.bunifuCards4.TabIndex = 1;
            // 
            // bunifuCards5
            // 
            this.bunifuCards5.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards5.BorderRadius = 5;
            this.bunifuCards5.BottomSahddow = true;
            this.bunifuCards5.color = System.Drawing.Color.OliveDrab;
            this.AnimacionAparecer.SetDecoration(this.bunifuCards5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuCards5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards5.LeftSahddow = false;
            this.bunifuCards5.Location = new System.Drawing.Point(254, 209);
            this.bunifuCards5.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.bunifuCards5.Name = "bunifuCards5";
            this.bunifuCards5.RightSahddow = true;
            this.bunifuCards5.ShadowDepth = 20;
            this.bunifuCards5.Size = new System.Drawing.Size(214, 200);
            this.bunifuCards5.TabIndex = 1;
            // 
            // bunifuCards6
            // 
            this.bunifuCards6.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards6.BorderRadius = 5;
            this.bunifuCards6.BottomSahddow = true;
            this.bunifuCards6.color = System.Drawing.Color.OliveDrab;
            this.AnimacionAparecer.SetDecoration(this.bunifuCards6, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuCards6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards6.LeftSahddow = false;
            this.bunifuCards6.Location = new System.Drawing.Point(493, 209);
            this.bunifuCards6.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.bunifuCards6.Name = "bunifuCards6";
            this.bunifuCards6.RightSahddow = true;
            this.bunifuCards6.ShadowDepth = 20;
            this.bunifuCards6.Size = new System.Drawing.Size(214, 200);
            this.bunifuCards6.TabIndex = 1;
            // 
            // bunifuCards8
            // 
            this.bunifuCards8.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards8.BorderRadius = 5;
            this.bunifuCards8.BottomSahddow = true;
            this.bunifuCards8.color = System.Drawing.Color.OliveDrab;
            this.AnimacionAparecer.SetDecoration(this.bunifuCards8, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuCards8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards8.LeftSahddow = false;
            this.bunifuCards8.Location = new System.Drawing.Point(15, 415);
            this.bunifuCards8.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.bunifuCards8.Name = "bunifuCards8";
            this.bunifuCards8.RightSahddow = true;
            this.bunifuCards8.ShadowDepth = 20;
            this.bunifuCards8.Size = new System.Drawing.Size(214, 200);
            this.bunifuCards8.TabIndex = 3;
            // 
            // bunifuCards9
            // 
            this.bunifuCards9.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards9.BorderRadius = 5;
            this.bunifuCards9.BottomSahddow = true;
            this.bunifuCards9.color = System.Drawing.Color.OliveDrab;
            this.AnimacionAparecer.SetDecoration(this.bunifuCards9, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuCards9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards9.LeftSahddow = false;
            this.bunifuCards9.Location = new System.Drawing.Point(254, 415);
            this.bunifuCards9.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.bunifuCards9.Name = "bunifuCards9";
            this.bunifuCards9.RightSahddow = true;
            this.bunifuCards9.ShadowDepth = 20;
            this.bunifuCards9.Size = new System.Drawing.Size(214, 200);
            this.bunifuCards9.TabIndex = 4;
            // 
            // bunifuCards7
            // 
            this.bunifuCards7.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards7.BorderRadius = 5;
            this.bunifuCards7.BottomSahddow = true;
            this.bunifuCards7.color = System.Drawing.Color.OliveDrab;
            this.AnimacionAparecer.SetDecoration(this.bunifuCards7, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuCards7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards7.LeftSahddow = false;
            this.bunifuCards7.Location = new System.Drawing.Point(493, 415);
            this.bunifuCards7.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.bunifuCards7.Name = "bunifuCards7";
            this.bunifuCards7.RightSahddow = true;
            this.bunifuCards7.ShadowDepth = 20;
            this.bunifuCards7.Size = new System.Drawing.Size(214, 200);
            this.bunifuCards7.TabIndex = 2;
            // 
            // bunifuCards11
            // 
            this.bunifuCards11.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards11.BorderRadius = 5;
            this.bunifuCards11.BottomSahddow = true;
            this.bunifuCards11.color = System.Drawing.Color.OliveDrab;
            this.AnimacionAparecer.SetDecoration(this.bunifuCards11, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuCards11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards11.LeftSahddow = false;
            this.bunifuCards11.Location = new System.Drawing.Point(15, 621);
            this.bunifuCards11.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.bunifuCards11.Name = "bunifuCards11";
            this.bunifuCards11.RightSahddow = true;
            this.bunifuCards11.ShadowDepth = 20;
            this.bunifuCards11.Size = new System.Drawing.Size(214, 200);
            this.bunifuCards11.TabIndex = 7;
            // 
            // bunifuCards12
            // 
            this.bunifuCards12.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards12.BorderRadius = 5;
            this.bunifuCards12.BottomSahddow = true;
            this.bunifuCards12.color = System.Drawing.Color.OliveDrab;
            this.AnimacionAparecer.SetDecoration(this.bunifuCards12, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuCards12, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards12.LeftSahddow = false;
            this.bunifuCards12.Location = new System.Drawing.Point(254, 621);
            this.bunifuCards12.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.bunifuCards12.Name = "bunifuCards12";
            this.bunifuCards12.RightSahddow = true;
            this.bunifuCards12.ShadowDepth = 20;
            this.bunifuCards12.Size = new System.Drawing.Size(214, 200);
            this.bunifuCards12.TabIndex = 5;
            // 
            // bunifuCards10
            // 
            this.bunifuCards10.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards10.BorderRadius = 5;
            this.bunifuCards10.BottomSahddow = true;
            this.bunifuCards10.color = System.Drawing.Color.OliveDrab;
            this.AnimacionAparecer.SetDecoration(this.bunifuCards10, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this.bunifuCards10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards10.LeftSahddow = false;
            this.bunifuCards10.Location = new System.Drawing.Point(493, 621);
            this.bunifuCards10.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.bunifuCards10.Name = "bunifuCards10";
            this.bunifuCards10.RightSahddow = true;
            this.bunifuCards10.ShadowDepth = 20;
            this.bunifuCards10.Size = new System.Drawing.Size(214, 200);
            this.bunifuCards10.TabIndex = 6;
            // 
            // AnimacionOcultar
            // 
            this.AnimacionOcultar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionOcultar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionOcultar.DefaultAnimation = animation1;
            // 
            // AnimacionAparecer
            // 
            this.AnimacionAparecer.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionAparecer.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionAparecer.DefaultAnimation = animation2;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(994, 632);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuTop);
            this.AnimacionAparecer.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionOcultar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurante";
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.Menu.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Contenedor.ResumeLayout(false);
            this.flp_Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox btn_Menu;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_Menu;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Contenedor;
        private BunifuAnimatorNS.BunifuTransition AnimacionOcultar;
        private BunifuAnimatorNS.BunifuTransition AnimacionAparecer;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.FlowLayoutPanel flp_Principal;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private Bunifu.Framework.UI.BunifuCards bunifuCards5;
        private Bunifu.Framework.UI.BunifuCards bunifuCards6;
        private Bunifu.Framework.UI.BunifuCards bunifuCards8;
        private Bunifu.Framework.UI.BunifuCards bunifuCards9;
        private Bunifu.Framework.UI.BunifuCards bunifuCards7;
        private Bunifu.Framework.UI.BunifuCards bunifuCards11;
        private Bunifu.Framework.UI.BunifuCards bunifuCards12;
        private Bunifu.Framework.UI.BunifuCards bunifuCards10;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Data.DataSet dataSet;
    }
}

