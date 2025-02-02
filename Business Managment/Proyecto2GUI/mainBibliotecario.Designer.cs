namespace Proyecto2GUI
{
    partial class mainBibliotecario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainBibliotecario));
            barraTitulo = new Panel();
            label3 = new Label();
            tituloBarraBibliotecario = new Label();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelMenuPrincipal = new Panel();
            btnCerrarSesion = new Button();
            PanelGenInformes = new Panel();
            btnEstadisticas = new Button();
            btnPrestamos = new Button();
            BotonGenInformes = new Button();
            PanelGestUsuarios = new Panel();
            btnEditarUsuario = new Button();
            btnRegistrarUsuario = new Button();
            BotonGestUsuarios = new Button();
            PanelSubGestLibros = new Panel();
            btnEliminarLibro = new Button();
            btnBuscarLibro = new Button();
            btnRegistrarLibro = new Button();
            BotonGestionLibros = new Button();
            panel1 = new Panel();
            label2 = new Label();
            lblTituloApp = new Label();
            panel2 = new Panel();
            panelChildForm = new Panel();
            label1 = new Label();
            lblMensajeUser = new Label();
            lblBienvenida = new Label();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelMenuPrincipal.SuspendLayout();
            PanelGenInformes.SuspendLayout();
            PanelGestUsuarios.SuspendLayout();
            PanelSubGestLibros.SuspendLayout();
            panel1.SuspendLayout();
            panelChildForm.SuspendLayout();
            SuspendLayout();
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(49, 53, 56);
            barraTitulo.Controls.Add(label3);
            barraTitulo.Controls.Add(tituloBarraBibliotecario);
            barraTitulo.Controls.Add(btnMinimizar);
            barraTitulo.Controls.Add(btnCerrar);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Margin = new Padding(4, 4, 4, 4);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(1850, 81);
            barraTitulo.TabIndex = 0;
            barraTitulo.Paint += barraTitulo_Paint;
            barraTitulo.MouseDown += barraTitulo_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(860, 21);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 12;
            label3.Text = "BizFlow";
            // 
            // tituloBarraBibliotecario
            // 
            tituloBarraBibliotecario.AutoSize = true;
            tituloBarraBibliotecario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloBarraBibliotecario.ForeColor = Color.Transparent;
            tituloBarraBibliotecario.Location = new Point(779, 22);
            tituloBarraBibliotecario.Margin = new Padding(4, 0, 4, 0);
            tituloBarraBibliotecario.Name = "tituloBarraBibliotecario";
            tituloBarraBibliotecario.Size = new Size(0, 29);
            tituloBarraBibliotecario.TabIndex = 3;
            tituloBarraBibliotecario.MouseDown += tituloBarraBibliotecario_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1722, 15);
            btnMinimizar.Margin = new Padding(4, 4, 4, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(50, 50);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 11;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1785, 15);
            btnCerrar.Margin = new Padding(4, 4, 4, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(50, 50);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 10;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelMenuPrincipal
            // 
            panelMenuPrincipal.BackColor = Color.FromArgb(56, 163, 203);
            panelMenuPrincipal.Controls.Add(btnCerrarSesion);
            panelMenuPrincipal.Controls.Add(PanelGenInformes);
            panelMenuPrincipal.Controls.Add(BotonGenInformes);
            panelMenuPrincipal.Controls.Add(PanelGestUsuarios);
            panelMenuPrincipal.Controls.Add(BotonGestUsuarios);
            panelMenuPrincipal.Controls.Add(PanelSubGestLibros);
            panelMenuPrincipal.Controls.Add(BotonGestionLibros);
            panelMenuPrincipal.Controls.Add(panel1);
            panelMenuPrincipal.Controls.Add(panel2);
            panelMenuPrincipal.Dock = DockStyle.Left;
            panelMenuPrincipal.Location = new Point(0, 81);
            panelMenuPrincipal.Margin = new Padding(4, 4, 4, 4);
            panelMenuPrincipal.Name = "panelMenuPrincipal";
            panelMenuPrincipal.Size = new Size(365, 1019);
            panelMenuPrincipal.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(56, 163, 203);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(115, 193, 203);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 910);
            btnCerrarSesion.Margin = new Padding(4, 4, 4, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(25, 0, 60, 0);
            btnCerrarSesion.Size = new Size(365, 75);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // PanelGenInformes
            // 
            PanelGenInformes.BackColor = Color.FromArgb(224, 224, 224);
            PanelGenInformes.Controls.Add(btnEstadisticas);
            PanelGenInformes.Controls.Add(btnPrestamos);
            PanelGenInformes.Dock = DockStyle.Top;
            PanelGenInformes.Location = new Point(0, 673);
            PanelGenInformes.Margin = new Padding(4, 4, 4, 4);
            PanelGenInformes.Name = "PanelGenInformes";
            PanelGenInformes.Size = new Size(365, 105);
            PanelGenInformes.TabIndex = 6;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.BackColor = Color.FromArgb(244, 134, 180);
            btnEstadisticas.Cursor = Cursors.Hand;
            btnEstadisticas.Dock = DockStyle.Top;
            btnEstadisticas.FlatAppearance.BorderSize = 0;
            btnEstadisticas.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 173, 163);
            btnEstadisticas.FlatStyle = FlatStyle.Flat;
            btnEstadisticas.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnEstadisticas.Image = (Image)resources.GetObject("btnEstadisticas.Image");
            btnEstadisticas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstadisticas.Location = new Point(0, 50);
            btnEstadisticas.Margin = new Padding(4, 4, 4, 4);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Padding = new Padding(75, 0, 21, 0);
            btnEstadisticas.Size = new Size(365, 50);
            btnEstadisticas.TabIndex = 1;
            btnEstadisticas.Text = "Libros y Estadisticas";
            btnEstadisticas.TextAlign = ContentAlignment.MiddleRight;
            btnEstadisticas.UseVisualStyleBackColor = false;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackColor = Color.FromArgb(244, 134, 180);
            btnPrestamos.Cursor = Cursors.Hand;
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 173, 163);
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnPrestamos.Image = (Image)resources.GetObject("btnPrestamos.Image");
            btnPrestamos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrestamos.Location = new Point(0, 0);
            btnPrestamos.Margin = new Padding(4, 4, 4, 4);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Padding = new Padding(75, 0, 35, 0);
            btnPrestamos.Size = new Size(365, 50);
            btnPrestamos.TabIndex = 0;
            btnPrestamos.Text = "Prestamos Activos";
            btnPrestamos.TextAlign = ContentAlignment.MiddleRight;
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // BotonGenInformes
            // 
            BotonGenInformes.BackColor = Color.FromArgb(56, 163, 203);
            BotonGenInformes.Cursor = Cursors.Hand;
            BotonGenInformes.Dock = DockStyle.Top;
            BotonGenInformes.FlatAppearance.BorderSize = 0;
            BotonGenInformes.FlatAppearance.MouseOverBackColor = Color.FromArgb(115, 193, 203);
            BotonGenInformes.FlatStyle = FlatStyle.Flat;
            BotonGenInformes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            BotonGenInformes.Image = (Image)resources.GetObject("BotonGenInformes.Image");
            BotonGenInformes.ImageAlign = ContentAlignment.MiddleLeft;
            BotonGenInformes.Location = new Point(0, 598);
            BotonGenInformes.Margin = new Padding(4, 4, 4, 4);
            BotonGenInformes.Name = "BotonGenInformes";
            BotonGenInformes.Padding = new Padding(25, 0, 96, 0);
            BotonGenInformes.Size = new Size(365, 75);
            BotonGenInformes.TabIndex = 5;
            BotonGenInformes.Text = "Financiero";
            BotonGenInformes.TextAlign = ContentAlignment.MiddleRight;
            BotonGenInformes.UseVisualStyleBackColor = false;
            BotonGenInformes.Click += BotonGenInformes_Click;
            // 
            // PanelGestUsuarios
            // 
            PanelGestUsuarios.BackColor = Color.FromArgb(224, 224, 224);
            PanelGestUsuarios.Controls.Add(btnEditarUsuario);
            PanelGestUsuarios.Controls.Add(btnRegistrarUsuario);
            PanelGestUsuarios.Dock = DockStyle.Top;
            PanelGestUsuarios.Location = new Point(0, 493);
            PanelGestUsuarios.Margin = new Padding(4, 4, 4, 4);
            PanelGestUsuarios.Name = "PanelGestUsuarios";
            PanelGestUsuarios.Size = new Size(365, 105);
            PanelGestUsuarios.TabIndex = 4;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.FromArgb(244, 134, 180);
            btnEditarUsuario.Cursor = Cursors.Hand;
            btnEditarUsuario.Dock = DockStyle.Top;
            btnEditarUsuario.FlatAppearance.BorderSize = 0;
            btnEditarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 173, 163);
            btnEditarUsuario.FlatStyle = FlatStyle.Flat;
            btnEditarUsuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnEditarUsuario.Image = (Image)resources.GetObject("btnEditarUsuario.Image");
            btnEditarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarUsuario.Location = new Point(0, 50);
            btnEditarUsuario.Margin = new Padding(4, 4, 4, 4);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Padding = new Padding(75, 0, 94, 0);
            btnEditarUsuario.Size = new Size(365, 50);
            btnEditarUsuario.TabIndex = 1;
            btnEditarUsuario.Text = "Venta Recibo";
            btnEditarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnEditarUsuario.UseVisualStyleBackColor = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.BackColor = Color.FromArgb(244, 134, 180);
            btnRegistrarUsuario.Cursor = Cursors.Hand;
            btnRegistrarUsuario.Dock = DockStyle.Top;
            btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            btnRegistrarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 173, 163);
            btnRegistrarUsuario.FlatStyle = FlatStyle.Flat;
            btnRegistrarUsuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnRegistrarUsuario.Image = (Image)resources.GetObject("btnRegistrarUsuario.Image");
            btnRegistrarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarUsuario.Location = new Point(0, 0);
            btnRegistrarUsuario.Margin = new Padding(4, 4, 4, 4);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Padding = new Padding(75, 0, 90, 0);
            btnRegistrarUsuario.Size = new Size(365, 50);
            btnRegistrarUsuario.TabIndex = 0;
            btnRegistrarUsuario.Text = "Venta Factura";
            btnRegistrarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarUsuario.UseVisualStyleBackColor = false;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // BotonGestUsuarios
            // 
            BotonGestUsuarios.BackColor = Color.FromArgb(56, 163, 203);
            BotonGestUsuarios.Cursor = Cursors.Hand;
            BotonGestUsuarios.Dock = DockStyle.Top;
            BotonGestUsuarios.FlatAppearance.BorderSize = 0;
            BotonGestUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(115, 193, 203);
            BotonGestUsuarios.FlatStyle = FlatStyle.Flat;
            BotonGestUsuarios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            BotonGestUsuarios.Image = (Image)resources.GetObject("BotonGestUsuarios.Image");
            BotonGestUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            BotonGestUsuarios.Location = new Point(0, 418);
            BotonGestUsuarios.Margin = new Padding(4, 4, 4, 4);
            BotonGestUsuarios.Name = "BotonGestUsuarios";
            BotonGestUsuarios.Padding = new Padding(25, 0, 138, 0);
            BotonGestUsuarios.Size = new Size(365, 75);
            BotonGestUsuarios.TabIndex = 3;
            BotonGestUsuarios.Text = "Ventas";
            BotonGestUsuarios.TextAlign = ContentAlignment.MiddleRight;
            BotonGestUsuarios.UseVisualStyleBackColor = false;
            BotonGestUsuarios.Click += BotonGestLibros_Click;
            // 
            // PanelSubGestLibros
            // 
            PanelSubGestLibros.BackColor = Color.FromArgb(224, 224, 224);
            PanelSubGestLibros.Controls.Add(btnEliminarLibro);
            PanelSubGestLibros.Controls.Add(btnBuscarLibro);
            PanelSubGestLibros.Controls.Add(btnRegistrarLibro);
            PanelSubGestLibros.Dock = DockStyle.Top;
            PanelSubGestLibros.Location = new Point(0, 263);
            PanelSubGestLibros.Margin = new Padding(4, 4, 4, 4);
            PanelSubGestLibros.Name = "PanelSubGestLibros";
            PanelSubGestLibros.Size = new Size(365, 155);
            PanelSubGestLibros.TabIndex = 2;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.BackColor = Color.FromArgb(244, 134, 180);
            btnEliminarLibro.Cursor = Cursors.Hand;
            btnEliminarLibro.Dock = DockStyle.Top;
            btnEliminarLibro.FlatAppearance.BorderSize = 0;
            btnEliminarLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 173, 163);
            btnEliminarLibro.FlatStyle = FlatStyle.Flat;
            btnEliminarLibro.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnEliminarLibro.Image = (Image)resources.GetObject("btnEliminarLibro.Image");
            btnEliminarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarLibro.Location = new Point(0, 100);
            btnEliminarLibro.Margin = new Padding(4, 4, 4, 4);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Padding = new Padding(69, 0, 129, 0);
            btnEliminarLibro.Size = new Size(365, 50);
            btnEliminarLibro.TabIndex = 2;
            btnEliminarLibro.Text = "Compras";
            btnEliminarLibro.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarLibro.UseVisualStyleBackColor = false;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // btnBuscarLibro
            // 
            btnBuscarLibro.BackColor = Color.FromArgb(244, 134, 180);
            btnBuscarLibro.Cursor = Cursors.Hand;
            btnBuscarLibro.Dock = DockStyle.Top;
            btnBuscarLibro.FlatAppearance.BorderSize = 0;
            btnBuscarLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 173, 163);
            btnBuscarLibro.FlatStyle = FlatStyle.Flat;
            btnBuscarLibro.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnBuscarLibro.Image = (Image)resources.GetObject("btnBuscarLibro.Image");
            btnBuscarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarLibro.Location = new Point(0, 50);
            btnBuscarLibro.Margin = new Padding(4, 4, 4, 4);
            btnBuscarLibro.Name = "btnBuscarLibro";
            btnBuscarLibro.Padding = new Padding(69, 0, 56, 0);
            btnBuscarLibro.Size = new Size(365, 50);
            btnBuscarLibro.TabIndex = 1;
            btnBuscarLibro.Text = "Buscar Producto";
            btnBuscarLibro.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarLibro.UseVisualStyleBackColor = false;
            btnBuscarLibro.Click += btnBuscarLibro_Click;
            // 
            // btnRegistrarLibro
            // 
            btnRegistrarLibro.BackColor = Color.FromArgb(244, 134, 180);
            btnRegistrarLibro.BackgroundImageLayout = ImageLayout.None;
            btnRegistrarLibro.Cursor = Cursors.Hand;
            btnRegistrarLibro.Dock = DockStyle.Top;
            btnRegistrarLibro.FlatAppearance.BorderSize = 0;
            btnRegistrarLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 173, 163);
            btnRegistrarLibro.FlatStyle = FlatStyle.Flat;
            btnRegistrarLibro.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnRegistrarLibro.Image = (Image)resources.GetObject("btnRegistrarLibro.Image");
            btnRegistrarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarLibro.Location = new Point(0, 0);
            btnRegistrarLibro.Margin = new Padding(4, 4, 4, 4);
            btnRegistrarLibro.Name = "btnRegistrarLibro";
            btnRegistrarLibro.Padding = new Padding(69, 0, 50, 0);
            btnRegistrarLibro.Size = new Size(365, 50);
            btnRegistrarLibro.TabIndex = 0;
            btnRegistrarLibro.Text = "Agregar Producto";
            btnRegistrarLibro.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarLibro.UseVisualStyleBackColor = false;
            btnRegistrarLibro.Click += btnRegistrarLibro_Click;
            // 
            // BotonGestionLibros
            // 
            BotonGestionLibros.BackColor = Color.FromArgb(56, 163, 203);
            BotonGestionLibros.Cursor = Cursors.Hand;
            BotonGestionLibros.Dock = DockStyle.Top;
            BotonGestionLibros.FlatAppearance.BorderSize = 0;
            BotonGestionLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(115, 193, 203);
            BotonGestionLibros.FlatStyle = FlatStyle.Flat;
            BotonGestionLibros.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            BotonGestionLibros.ForeColor = Color.Black;
            BotonGestionLibros.Image = (Image)resources.GetObject("BotonGestionLibros.Image");
            BotonGestionLibros.ImageAlign = ContentAlignment.MiddleLeft;
            BotonGestionLibros.Location = new Point(0, 188);
            BotonGestionLibros.Margin = new Padding(4, 4, 4, 4);
            BotonGestionLibros.Name = "BotonGestionLibros";
            BotonGestionLibros.Padding = new Padding(25, 0, 102, 0);
            BotonGestionLibros.Size = new Size(365, 75);
            BotonGestionLibros.TabIndex = 1;
            BotonGestionLibros.Text = "Inventario";
            BotonGestionLibros.TextAlign = ContentAlignment.MiddleRight;
            BotonGestionLibros.UseVisualStyleBackColor = false;
            BotonGestionLibros.UseWaitCursor = true;
            BotonGestionLibros.Click += BotonGestionLibros_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(56, 163, 203);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTituloApp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 188);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 53);
            label2.TabIndex = 7;
            label2.Text = "Store";
            // 
            // lblTituloApp
            // 
            lblTituloApp.AutoSize = true;
            lblTituloApp.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloApp.Location = new Point(80, 44);
            lblTituloApp.Margin = new Padding(4, 0, 4, 0);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(201, 53);
            lblTituloApp.TabIndex = 6;
            lblTituloApp.Text = "Make Up";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(56, 163, 203);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 985);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 34);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.WhiteSmoke;
            panelChildForm.Controls.Add(label1);
            panelChildForm.Controls.Add(lblMensajeUser);
            panelChildForm.Controls.Add(lblBienvenida);
            panelChildForm.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            panelChildForm.Location = new Point(429, 138);
            panelChildForm.Margin = new Padding(4, 4, 4, 4);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1369, 900);
            panelChildForm.TabIndex = 2;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(380, 244);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(610, 558);
            label1.TabIndex = 9;
            // 
            // lblMensajeUser
            // 
            lblMensajeUser.BackColor = Color.WhiteSmoke;
            lblMensajeUser.Dock = DockStyle.Top;
            lblMensajeUser.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblMensajeUser.Location = new Point(0, 96);
            lblMensajeUser.Margin = new Padding(4, 0, 4, 0);
            lblMensajeUser.Name = "lblMensajeUser";
            lblMensajeUser.Size = new Size(1369, 98);
            lblMensajeUser.TabIndex = 8;
            lblMensajeUser.Text = "Mensaje";
            lblMensajeUser.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblBienvenida
            // 
            lblBienvenida.BackColor = Color.WhiteSmoke;
            lblBienvenida.Dock = DockStyle.Top;
            lblBienvenida.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            lblBienvenida.Location = new Point(0, 0);
            lblBienvenida.Margin = new Padding(4, 0, 4, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(1369, 96);
            lblBienvenida.TabIndex = 7;
            lblBienvenida.Text = "Bienvenid@: ";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainBibliotecario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1850, 1100);
            Controls.Add(panelChildForm);
            Controls.Add(panelMenuPrincipal);
            Controls.Add(barraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "mainBibliotecario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainBibliotecario";
            barraTitulo.ResumeLayout(false);
            barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelMenuPrincipal.ResumeLayout(false);
            PanelGenInformes.ResumeLayout(false);
            PanelGestUsuarios.ResumeLayout(false);
            PanelSubGestLibros.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelChildForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel barraTitulo;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Label tituloBarraBibliotecario;
        private Panel panelMenuPrincipal;
        private Panel panel1;
        private Label lblTituloApp;
        private Panel panelChildForm;
        private Label lblMensajeUser;
        private Label lblBienvenida;
        private Panel panel2;
        private Button btnCerrarSesion;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel PanelGenInformes;
        private Button btnEstadisticas;
        private Button btnPrestamos;
        private Button BotonGenInformes;
        private Panel PanelGestUsuarios;
        private Button btnEditarUsuario;
        private Button btnRegistrarUsuario;
        private Button BotonGestUsuarios;
        private Panel PanelSubGestLibros;
        private Button btnEliminarLibro;
        private Button btnBuscarLibro;
        private Button btnRegistrarLibro;
        private Button BotonGestionLibros;
    }
}