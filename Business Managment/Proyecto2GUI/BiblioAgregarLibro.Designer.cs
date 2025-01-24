namespace Proyecto2GUI
{
    partial class BiblioAgregarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioAgregarLibro));
            label1 = new Label();
            panel1 = new Panel();
            btneliminar = new Button();
            txtprecio = new TextBox();
            label6 = new Label();
            btneditar = new Button();
            btnguardar = new Button();
            txtcantidad = new TextBox();
            txtmarca = new TextBox();
            txtnombre = new TextBox();
            txtid = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            DGVArticulos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVArticulos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(792, 112);
            label1.TabIndex = 8;
            label1.Text = "Agregar Libro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btneliminar);
            panel1.Controls.Add(txtprecio);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btneditar);
            panel1.Controls.Add(btnguardar);
            panel1.Controls.Add(txtcantidad);
            panel1.Controls.Add(txtmarca);
            panel1.Controls.Add(txtnombre);
            panel1.Controls.Add(txtid);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 112);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 220);
            panel1.TabIndex = 9;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(641, 164);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(132, 39);
            btneliminar.TabIndex = 13;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // txtprecio
            // 
            txtprecio.BorderStyle = BorderStyle.None;
            txtprecio.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtprecio.Location = new Point(206, 150);
            txtprecio.Margin = new Padding(3, 2, 3, 2);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(382, 17);
            txtprecio.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(122, 147);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 11;
            label6.Text = "PRECIO";
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.FromArgb(230, 165, 36);
            btneditar.BackgroundImageLayout = ImageLayout.None;
            btneditar.Cursor = Cursors.Hand;
            btneditar.FlatAppearance.BorderSize = 0;
            btneditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btneditar.Image = (Image)resources.GetObject("btneditar.Image");
            btneditar.ImageAlign = ContentAlignment.MiddleLeft;
            btneditar.Location = new Point(641, 104);
            btneditar.Margin = new Padding(3, 2, 3, 2);
            btneditar.Name = "btneditar";
            btneditar.Padding = new Padding(0, 0, 37, 0);
            btneditar.Size = new Size(132, 30);
            btneditar.TabIndex = 10;
            btneditar.Text = "Editar";
            btneditar.TextAlign = ContentAlignment.MiddleRight;
            btneditar.UseMnemonic = false;
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btnCancelar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.FromArgb(230, 165, 36);
            btnguardar.BackgroundImageLayout = ImageLayout.None;
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderSize = 0;
            btnguardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnguardar.Image = (Image)resources.GetObject("btnguardar.Image");
            btnguardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnguardar.Location = new Point(641, 45);
            btnguardar.Margin = new Padding(3, 2, 3, 2);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(132, 30);
            btnguardar.TabIndex = 9;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnRegistrarLibro_Click;
            // 
            // txtcantidad
            // 
            txtcantidad.BorderStyle = BorderStyle.None;
            txtcantidad.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtcantidad.Location = new Point(206, 117);
            txtcantidad.Margin = new Padding(3, 2, 3, 2);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(382, 17);
            txtcantidad.TabIndex = 8;
            // 
            // txtmarca
            // 
            txtmarca.BorderStyle = BorderStyle.None;
            txtmarca.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtmarca.Location = new Point(206, 86);
            txtmarca.Margin = new Padding(3, 2, 3, 2);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(382, 17);
            txtmarca.TabIndex = 7;
            // 
            // txtnombre
            // 
            txtnombre.BorderStyle = BorderStyle.None;
            txtnombre.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtnombre.Location = new Point(206, 57);
            txtnombre.Margin = new Padding(3, 2, 3, 2);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(382, 17);
            txtnombre.TabIndex = 6;
            // 
            // txtid
            // 
            txtid.BorderStyle = BorderStyle.None;
            txtid.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtid.Location = new Point(206, 30);
            txtid.Margin = new Padding(3, 2, 3, 2);
            txtid.Name = "txtid";
            txtid.Size = new Size(382, 17);
            txtid.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(122, 115);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 3;
            label5.Text = "CANTIDAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(122, 86);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 2;
            label4.Text = "MARCA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(122, 57);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 1;
            label3.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(122, 28);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // DGVArticulos
            // 
            DGVArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVArticulos.Location = new Point(37, 337);
            DGVArticulos.Name = "DGVArticulos";
            DGVArticulos.Size = new Size(736, 318);
            DGVArticulos.TabIndex = 10;
            // 
            // BiblioAgregarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 667);
            Controls.Add(DGVArticulos);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BiblioAgregarLibro";
            Text = "BiblioAgregarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVArticulos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtnombre;
        private TextBox txtid;
        private TextBox txtcantidad;
        private TextBox txtmarca;
        private Button btneditar;
        private Button btnguardar;
        private Label label6;
        private TextBox txtprecio;
        private Button btneliminar;
        private DataGridView DGVArticulos;
    }
}