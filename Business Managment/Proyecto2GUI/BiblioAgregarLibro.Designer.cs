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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
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
            label1.BackColor = Color.FromArgb(240, 235, 220);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Top;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 162, 97);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(905, 190);
            label1.TabIndex = 8;
            label1.Text = "Agregar Producto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 235, 220);
            panel1.Controls.Add(button1);
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
            panel1.Location = new Point(0, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 293);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(732, 122);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 0, 42, 0);
            button1.Size = new Size(151, 40);
            button1.TabIndex = 13;
            button1.Text = "Eliminar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btneliminar_Click;
            // 
            // txtprecio
            // 
            txtprecio.BackColor = Color.SeaShell;
            txtprecio.BorderStyle = BorderStyle.None;
            txtprecio.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtprecio.Location = new Point(235, 200);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(437, 21);
            txtprecio.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(244, 162, 97);
            label6.Location = new Point(92, 198);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 11;
            label6.Text = "PRECIO";
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.FromArgb(156, 215, 230);
            btneditar.BackgroundImageLayout = ImageLayout.None;
            btneditar.Cursor = Cursors.Hand;
            btneditar.FlatAppearance.BorderSize = 0;
            btneditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btneditar.ForeColor = Color.White;
            btneditar.Image = (Image)resources.GetObject("btneditar.Image");
            btneditar.ImageAlign = ContentAlignment.MiddleLeft;
            btneditar.Location = new Point(732, 76);
            btneditar.Name = "btneditar";
            btneditar.Padding = new Padding(0, 0, 42, 0);
            btneditar.Size = new Size(151, 40);
            btneditar.TabIndex = 10;
            btneditar.Text = "Editar";
            btneditar.TextAlign = ContentAlignment.MiddleRight;
            btneditar.UseMnemonic = false;
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btnCancelar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.FromArgb(156, 215, 230);
            btnguardar.BackgroundImageLayout = ImageLayout.None;
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderSize = 0;
            btnguardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnguardar.ForeColor = Color.White;
            btnguardar.Image = (Image)resources.GetObject("btnguardar.Image");
            btnguardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnguardar.Location = new Point(732, 31);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(151, 40);
            btnguardar.TabIndex = 9;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnRegistrarLibro_Click;
            // 
            // txtcantidad
            // 
            txtcantidad.BackColor = Color.SeaShell;
            txtcantidad.BorderStyle = BorderStyle.None;
            txtcantidad.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtcantidad.Location = new Point(235, 156);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(437, 21);
            txtcantidad.TabIndex = 8;
            // 
            // txtmarca
            // 
            txtmarca.BackColor = Color.SeaShell;
            txtmarca.BorderStyle = BorderStyle.None;
            txtmarca.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtmarca.Location = new Point(235, 115);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(437, 21);
            txtmarca.TabIndex = 7;
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.SeaShell;
            txtnombre.BorderStyle = BorderStyle.None;
            txtnombre.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtnombre.Location = new Point(235, 76);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(437, 21);
            txtnombre.TabIndex = 6;
            // 
            // txtid
            // 
            txtid.BackColor = Color.SeaShell;
            txtid.BorderStyle = BorderStyle.None;
            txtid.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtid.Location = new Point(235, 40);
            txtid.Name = "txtid";
            txtid.Size = new Size(437, 21);
            txtid.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(244, 162, 97);
            label5.Location = new Point(92, 156);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 3;
            label5.Text = "CANTIDAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(244, 162, 97);
            label4.Location = new Point(95, 115);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 2;
            label4.Text = "MARCA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(244, 162, 97);
            label3.Location = new Point(95, 74);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 1;
            label3.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.LightSalmon;
            label2.Location = new Point(139, 37);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // DGVArticulos
            // 
            DGVArticulos.BackgroundColor = Color.FromArgb(240, 235, 220);
            DGVArticulos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightCoral;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Azure;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SeaShell;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            DGVArticulos.GridColor = Color.Beige;
            DGVArticulos.Location = new Point(101, 435);
            DGVArticulos.Margin = new Padding(3, 4, 3, 4);
            DGVArticulos.Name = "DGVArticulos";
            DGVArticulos.RowHeadersWidth = 51;
            DGVArticulos.Size = new Size(801, 329);
            DGVArticulos.TabIndex = 10;
            // 
            // BiblioAgregarLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 235, 220);
            ClientSize = new Size(905, 889);
            Controls.Add(DGVArticulos);
            Controls.Add(panel1);
            Controls.Add(label1);
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
        private DataGridView DGVArticulos;
        private Button button1;
    }
}