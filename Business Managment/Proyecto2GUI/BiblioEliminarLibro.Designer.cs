namespace Proyecto2GUI
{
    partial class BiblioEliminarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiblioEliminarLibro));
            label1 = new Label();
            panel1 = new Panel();
            TxtDireccion = new TextBox();
            txtIDproveedor = new TextBox();
            TxtContacto = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblISBN = new Label();
            BTNEliminar = new Button();
            BTNEditar = new Button();
            BTNAgregar = new Button();
            TxtTelefono = new TextBox();
            label2 = new Label();
            DGVProveedores = new DataGridView();
            mostrarTodo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 116);
            label1.TabIndex = 11;
            label1.Text = "Compras y Proveedores";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(TxtDireccion);
            panel1.Controls.Add(txtIDproveedor);
            panel1.Controls.Add(TxtContacto);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblISBN);
            panel1.Controls.Add(BTNEliminar);
            panel1.Controls.Add(BTNEditar);
            panel1.Controls.Add(BTNAgregar);
            panel1.Controls.Add(TxtTelefono);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 305);
            panel1.TabIndex = 12;
            // 
            // TxtDireccion
            // 
            TxtDireccion.Location = new Point(278, 237);
            TxtDireccion.Margin = new Padding(2, 2, 2, 2);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(402, 27);
            TxtDireccion.TabIndex = 24;
            // 
            // txtIDproveedor
            // 
            txtIDproveedor.Location = new Point(278, 42);
            txtIDproveedor.Margin = new Padding(2, 2, 2, 2);
            txtIDproveedor.Name = "txtIDproveedor";
            txtIDproveedor.Size = new Size(402, 27);
            txtIDproveedor.TabIndex = 23;
            // 
            // TxtContacto
            // 
            TxtContacto.Location = new Point(278, 186);
            TxtContacto.Margin = new Padding(2, 2, 2, 2);
            TxtContacto.Name = "TxtContacto";
            TxtContacto.Size = new Size(402, 27);
            TxtContacto.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(278, 89);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(402, 27);
            txtNombre.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label6.Location = new Point(72, 185);
            label6.Name = "label6";
            label6.Size = new Size(100, 27);
            label6.TabIndex = 17;
            label6.Text = "Contacto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label5.Location = new Point(72, 132);
            label5.Name = "label5";
            label5.Size = new Size(93, 27);
            label5.TabIndex = 16;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label4.Location = new Point(72, 237);
            label4.Name = "label4";
            label4.Size = new Size(102, 27);
            label4.TabIndex = 15;
            label4.Text = "Direccion";
            label4.Click += label4_Click;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblISBN.Location = new Point(72, 38);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(181, 27);
            lblISBN.TabIndex = 14;
            lblISBN.Text = "Codigo Proveedor";
            // 
            // BTNEliminar
            // 
            BTNEliminar.BackColor = Color.FromArgb(156, 215, 230);
            BTNEliminar.Cursor = Cursors.Hand;
            BTNEliminar.FlatAppearance.BorderSize = 0;
            BTNEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            BTNEliminar.FlatStyle = FlatStyle.Flat;
            BTNEliminar.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            BTNEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BTNEliminar.Location = new Point(730, 188);
            BTNEliminar.Name = "BTNEliminar";
            BTNEliminar.Padding = new Padding(0, 0, 38, 0);
            BTNEliminar.Size = new Size(150, 40);
            BTNEliminar.TabIndex = 13;
            BTNEliminar.Text = "ELIMINAR";
            BTNEliminar.TextAlign = ContentAlignment.MiddleRight;
            BTNEliminar.UseVisualStyleBackColor = false;
            BTNEliminar.Click += button2_Click;
            // 
            // BTNEditar
            // 
            BTNEditar.BackColor = Color.LightCoral;
            BTNEditar.Cursor = Cursors.Hand;
            BTNEditar.FlatAppearance.BorderSize = 0;
            BTNEditar.FlatAppearance.MouseOverBackColor = Color.Tomato;
            BTNEditar.FlatStyle = FlatStyle.Flat;
            BTNEditar.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            BTNEditar.ForeColor = Color.Black;
            BTNEditar.ImageAlign = ContentAlignment.MiddleLeft;
            BTNEditar.Location = new Point(730, 127);
            BTNEditar.Name = "BTNEditar";
            BTNEditar.Size = new Size(150, 40);
            BTNEditar.TabIndex = 12;
            BTNEditar.Text = "EDITAR";
            BTNEditar.TextAlign = ContentAlignment.MiddleRight;
            BTNEditar.UseVisualStyleBackColor = false;
            BTNEditar.Click += btnEliminarLibro_Click;
            // 
            // BTNAgregar
            // 
            BTNAgregar.BackColor = Color.FromArgb(156, 215, 230);
            BTNAgregar.Cursor = Cursors.Hand;
            BTNAgregar.FlatAppearance.BorderSize = 0;
            BTNAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            BTNAgregar.FlatStyle = FlatStyle.Flat;
            BTNAgregar.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            BTNAgregar.Image = (Image)resources.GetObject("BTNAgregar.Image");
            BTNAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BTNAgregar.Location = new Point(730, 34);
            BTNAgregar.Name = "BTNAgregar";
            BTNAgregar.Padding = new Padding(10, 0, 20, 0);
            BTNAgregar.Size = new Size(150, 40);
            BTNAgregar.TabIndex = 11;
            BTNAgregar.Text = "agregar";
            BTNAgregar.TextAlign = ContentAlignment.MiddleRight;
            BTNAgregar.UseVisualStyleBackColor = false;
            BTNAgregar.Click += btnBuscarLibro_Click_1;
            // 
            // TxtTelefono
            // 
            TxtTelefono.BorderStyle = BorderStyle.None;
            TxtTelefono.Cursor = Cursors.IBeam;
            TxtTelefono.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTelefono.Location = new Point(278, 142);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(402, 27);
            TxtTelefono.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label2.Location = new Point(72, 86);
            label2.Name = "label2";
            label2.Size = new Size(196, 27);
            label2.TabIndex = 0;
            label2.Text = "Nombre Proveedor:";
            label2.Click += label2_Click;
            // 
            // DGVProveedores
            // 
            DGVProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProveedores.Location = new Point(127, 446);
            DGVProveedores.Margin = new Padding(2, 2, 2, 2);
            DGVProveedores.Name = "DGVProveedores";
            DGVProveedores.RowHeadersWidth = 62;
            DGVProveedores.Size = new Size(766, 97);
            DGVProveedores.TabIndex = 13;
            // 
            // mostrarTodo
            // 
            mostrarTodo.Location = new Point(852, 34);
            mostrarTodo.Name = "mostrarTodo";
            mostrarTodo.Size = new Size(94, 29);
            mostrarTodo.TabIndex = 14;
            mostrarTodo.Text = "mostrar";
            mostrarTodo.UseVisualStyleBackColor = true;
            mostrarTodo.Click += button1_Click;
            // 
            // BiblioEliminarLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(mostrarTodo);
            Controls.Add(DGVProveedores);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "BiblioEliminarLibro";
            Text = "BiblioEliminarLibro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button BTNEliminar;
        private Button BTNEditar;
        private Button BTNAgregar;
        private TextBox TxtTelefono;
        private Label label2;
        private Label lblISBN;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView DGVProveedores;
        private TextBox txtNombre;
        private TextBox txtIDproveedor;
        private TextBox TxtContacto;
        private TextBox TxtDireccion;
        private Button mostrarTodo;
    }
}