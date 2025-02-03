namespace Proyecto2GUI
{
    partial class BiblioAgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioAgregarUsuario));
            panel1 = new Panel();
            RecibirRol = new ComboBox();
            RecibirContraseña = new TextBox();
            label5 = new Label();
            btnLimpiarCampos = new Button();
            btnAgregarUsuario = new Button();
            label3 = new Label();
            Cantidad = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            lblFecha = new Label();
            label2 = new Label();
            lblPrecio = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnLimpiarCampos);
            panel1.Controls.Add(btnAgregarUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 66);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 441);
            panel1.TabIndex = 11;
            // 
            // RecibirRol
            // 
            RecibirRol.DisplayMember = "0, 1";
            RecibirRol.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecibirRol.FormattingEnabled = true;
            RecibirRol.Items.AddRange(new object[] { "Bibliotecario", "Lector" });
            RecibirRol.Location = new Point(30, 77);
            RecibirRol.Margin = new Padding(4, 4, 4, 4);
            RecibirRol.Name = "RecibirRol";
            RecibirRol.Size = new Size(368, 35);
            RecibirRol.TabIndex = 27;
            RecibirRol.ValueMember = "1, 2";
            // 
            // RecibirContraseña
            // 
            RecibirContraseña.BorderStyle = BorderStyle.None;
            RecibirContraseña.Font = new Font("Segoe UI Variable Small", 10.8F);
            RecibirContraseña.Location = new Point(429, 77);
            RecibirContraseña.Margin = new Padding(4, 4, 4, 4);
            RecibirContraseña.Name = "RecibirContraseña";
            RecibirContraseña.Size = new Size(329, 29);
            RecibirContraseña.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label5.Location = new Point(30, 132);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 32);
            label5.TabIndex = 26;
            label5.Text = "Rol:";
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.FromArgb(230, 165, 36);
            btnLimpiarCampos.BackgroundImageLayout = ImageLayout.None;
            btnLimpiarCampos.Cursor = Cursors.Hand;
            btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            btnLimpiarCampos.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnLimpiarCampos.Image = (Image)resources.GetObject("btnLimpiarCampos.Image");
            btnLimpiarCampos.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarCampos.Location = new Point(252, 368);
            btnLimpiarCampos.Margin = new Padding(4, 4, 4, 4);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(210, 50);
            btnLimpiarCampos.TabIndex = 25;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.FromArgb(230, 165, 36);
            btnAgregarUsuario.BackgroundImageLayout = ImageLayout.None;
            btnAgregarUsuario.Cursor = Cursors.Hand;
            btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            btnAgregarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            btnAgregarUsuario.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnAgregarUsuario.Image = (Image)resources.GetObject("btnAgregarUsuario.Image");
            btnAgregarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarUsuario.Location = new Point(34, 368);
            btnAgregarUsuario.Margin = new Padding(4, 4, 4, 4);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(210, 50);
            btnAgregarUsuario.TabIndex = 9;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label3.Location = new Point(30, 41);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 32);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            Cantidad.Location = new Point(422, 41);
            Cantidad.Margin = new Padding(4, 0, 4, 0);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(124, 32);
            Cantidad.TabIndex = 0;
            Cantidad.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1228, 66);
            label1.TabIndex = 9;
            label1.Text = "Facturas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(RecibirRol);
            groupBox1.Controls.Add(Cantidad);
            groupBox1.Controls.Add(RecibirContraseña);
            groupBox1.Controls.Add(label5);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(34, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1014, 258);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Area de Ventas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(754, 40);
            label6.Name = "label6";
            label6.Size = new Size(126, 25);
            label6.TabIndex = 30;
            label6.Text = "Fecha Actual:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(883, 40);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(76, 25);
            lblFecha.TabIndex = 31;
            lblFecha.Text = "lblFecha";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label2.Location = new Point(817, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 46);
            label2.TabIndex = 28;
            label2.Text = "Cantidad:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(817, 73);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(170, 33);
            lblPrecio.TabIndex = 29;
            lblPrecio.Text = "lblPrecio";
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BiblioAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 691);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "BiblioAgregarUsuario";
            Text = "BiblioAgregarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnAgregarUsuario;
        private TextBox RecibirContraseña;
        private Label label3;
        private Label Cantidad;
        private Button btnLimpiarCampos;
        private Label label5;
        private ComboBox RecibirRol;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblFecha;
        private Label label6;
        private Label lblPrecio;
        private Label label2;
    }
}