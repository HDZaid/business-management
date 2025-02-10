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
            lblFecha = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtPrecio = new TextBox();
            txtIDproveedor = new TextBox();
            lblPrecio = new Label();
            label2 = new Label();
            label3 = new Label();
            Cantidad = new Label();
            txtCantidad = new TextBox();
            label5 = new Label();
            btnAgregarUsuario = new Button();
            btnLimpiarCampos = new Button();
            label1 = new Label();
            DGVlista = new DataGridView();
            mostrarTodo = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVlista).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mostrarTodo);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnAgregarUsuario);
            panel1.Controls.Add(btnLimpiarCampos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 353);
            panel1.TabIndex = 11;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(706, 32);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(64, 20);
            lblFecha.TabIndex = 31;
            lblFecha.Text = "lblFecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(603, 32);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 30;
            label6.Text = "Fecha Actual:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtIDproveedor);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Cantidad);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label5);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(27, 72);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(811, 206);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Area de Ventas";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(33, 156);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 31;
            // 
            // txtIDproveedor
            // 
            txtIDproveedor.Location = new Point(49, 68);
            txtIDproveedor.Name = "txtIDproveedor";
            txtIDproveedor.Size = new Size(125, 27);
            txtIDproveedor.TabIndex = 30;
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(654, 58);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(136, 26);
            lblPrecio.TabIndex = 29;
            lblPrecio.Text = "lblPrecio";
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label2.Location = new Point(654, 22);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 28;
            label2.Text = "Cantidad:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label3.Location = new Point(24, 33);
            label3.Name = "label3";
            label3.Size = new Size(140, 27);
            label3.TabIndex = 1;
            label3.Text = "ID Proveedor:";
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            Cantidad.Location = new Point(338, 33);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(102, 27);
            Cantidad.TabIndex = 0;
            Cantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Font = new Font("Segoe UI Variable Small", 10.8F);
            txtCantidad.Location = new Point(343, 62);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(263, 24);
            txtCantidad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label5.Location = new Point(33, 112);
            label5.Name = "label5";
            label5.Size = new Size(71, 27);
            label5.TabIndex = 26;
            label5.Text = "Precio";
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
            btnAgregarUsuario.Location = new Point(281, 297);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(168, 40);
            btnAgregarUsuario.TabIndex = 9;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
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
            btnLimpiarCampos.Location = new Point(474, 297);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(168, 40);
            btnLimpiarCampos.TabIndex = 25;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(982, 53);
            label1.TabIndex = 9;
            label1.Text = "Facturas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DGVlista
            // 
            DGVlista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVlista.Location = new Point(127, 444);
            DGVlista.Name = "DGVlista";
            DGVlista.RowHeadersWidth = 51;
            DGVlista.Size = new Size(734, 188);
            DGVlista.TabIndex = 12;
            // 
            // mostrarTodo
            // 
            mostrarTodo.Location = new Point(860, 28);
            mostrarTodo.Name = "mostrarTodo";
            mostrarTodo.Size = new Size(94, 29);
            mostrarTodo.TabIndex = 32;
            mostrarTodo.Text = "mostrar";
            mostrarTodo.UseVisualStyleBackColor = true;
            mostrarTodo.Click += mostrarTodo_Click;
            // 
            // BiblioAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 654);
            Controls.Add(DGVlista);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "BiblioAgregarUsuario";
            Text = "BiblioAgregarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVlista).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnAgregarUsuario;
        private TextBox txtCantidad;
        private Label label3;
        private Label Cantidad;
        private Button btnLimpiarCampos;
        private Label label5;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblFecha;
        private Label label6;
        private Label lblPrecio;
        private Label label2;
        private DataGridView DGVlista;
        private TextBox txtPrecio;
        private TextBox txtIDproveedor;
        private Button mostrarTodo;
    }
}