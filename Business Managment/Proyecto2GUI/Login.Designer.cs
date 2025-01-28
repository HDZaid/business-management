using System.Drawing.Drawing2D;

namespace Proyecto2GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            NombreUser = new Label();
            PassUser = new Label();
            txtNombre = new TextBox();
            txtPassword = new TextBox();
            BtnEntrar = new Button();
            btnSalir = new Button();
            BtnCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NombreUser
            // 
            NombreUser.AutoSize = true;
            NombreUser.Cursor = Cursors.IBeam;
            NombreUser.Font = new Font("Segoe UI Variable Small", 12F);
            NombreUser.Location = new Point(282, 148);
            NombreUser.Name = "NombreUser";
            NombreUser.Size = new Size(87, 27);
            NombreUser.TabIndex = 0;
            NombreUser.Text = "Usuario:";
            // 
            // PassUser
            // 
            PassUser.AutoSize = true;
            PassUser.Font = new Font("Segoe UI Variable Small", 12F);
            PassUser.Location = new Point(281, 225);
            PassUser.Name = "PassUser";
            PassUser.Size = new Size(122, 27);
            PassUser.TabIndex = 1;
            PassUser.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(281, 185);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 30);
            txtNombre.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(281, 255);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(285, 30);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // BtnEntrar
            // 
            BtnEntrar.BackColor = Color.DodgerBlue;
            BtnEntrar.Cursor = Cursors.Hand;
            BtnEntrar.FlatAppearance.BorderColor = Color.Lavender;
            BtnEntrar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            BtnEntrar.FlatStyle = FlatStyle.Flat;
            BtnEntrar.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold);
            BtnEntrar.Location = new Point(309, 301);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(105, 33);
            BtnEntrar.TabIndex = 5;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = false;
            BtnEntrar.Click += BtnEntrar_Click;
            BtnEntrar.KeyDown += BtnEntrar_KeyDown;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DodgerBlue;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold);
            btnSalir.Location = new Point(434, 301);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(105, 33);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button2_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Cursor = Cursors.Hand;
            BtnCerrar.Image = (Image)resources.GetObject("BtnCerrar.Image");
            BtnCerrar.Location = new Point(613, 12);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(25, 25);
            BtnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnCerrar.TabIndex = 7;
            BtnCerrar.TabStop = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 400);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 12F);
            label1.Location = new Point(364, 101);
            label1.Name = "label1";
            label1.Size = new Size(133, 27);
            label1.TabIndex = 11;
            label1.Text = "Iniciar Sesion";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(235, 235, 235);
            ClientSize = new Size(650, 400);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(BtnCerrar);
            Controls.Add(btnSalir);
            Controls.Add(BtnEntrar);
            Controls.Add(txtPassword);
            Controls.Add(txtNombre);
            Controls.Add(PassUser);
            Controls.Add(NombreUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NombreUser;
        private Label PassUser;
        private TextBox txtNombre;
        private TextBox txtPassword;
        private Button BtnEntrar;
        private Button btnSalir;
        private PictureBox BtnCerrar;
        private PictureBox pictureBox1;
        private Label label1;
    }
}