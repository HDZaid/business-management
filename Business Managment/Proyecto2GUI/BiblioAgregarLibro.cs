using Proyecto2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto2GUI
{
    public partial class BiblioAgregarLibro : Form
    {
        Biblioteca _biblioteca;
        public BiblioAgregarLibro(Biblioteca biliotecaActual)
        {
            _biblioteca = biliotecaActual;
            InitializeComponent();
            Estilo();// gird
            //  lblMensajeUsuario.Visible = false;

            BotonRedondeadoHelper.AplicarRedondeo(button1, 30);
            BotonRedondeadoHelper.AplicarRedondeo(btneditar, 30);
            BotonRedondeadoHelper.AplicarRedondeo(btnguardar, 30);

        }

        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {

            Articulo objeto = new Articulo()
            {//ID *en el video no lo coloco porque es para eliminar y editar * en este caso no se usa porque es autoincrementable
                Nombre = txtnombre.Text,
                Marca = txtmarca.Text,
                Cantidad = int.Parse(txtcantidad.Text),
                Precio = int.Parse(txtprecio.Text)

            };
            //devuelve una respuesta
            bool respuesta = ArticuloLogica.Instancia.Guardar(objeto);

            if (respuesta)
            {
                //ESTA COSA ES LA QUE MEUSTRA LA TABLA 
                mostrar_Articulo();
            }


        }


        
        //este metodo nos permite ver lo que tenemos en la data grip view (metodo reutilizable)
        public void mostrar_Articulo()
        {
            DGVArticulos.DataSource = null;
            DGVArticulos.DataSource = ArticuloLogica.Instancia.Listar();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Articulo objeto = new Articulo()

            {
                ID = int.Parse(txtid.Text),
                Nombre = txtnombre.Text,
                Marca = txtmarca.Text,
                Cantidad = int.Parse(txtcantidad.Text),
                Precio = int.Parse(txtprecio.Text)
            };

            bool respuesta = ArticuloLogica.Instancia.Editar(objeto);

            if (respuesta)
            {
                mostrar_Articulo();
            }
        }

        private void LimpiarCampos()
        {
            //  lblMensajeUsuario.Visible = false;
            txtid.Clear();
            txtnombre.Clear();
            txtmarca.Clear();
            txtcantidad.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Articulo objeto = new Articulo()
            {
                //aca solo es necesario el parametro de ID
                ID = int.Parse(txtid.Text),
            };

            bool respuesta = ArticuloLogica.Instancia.Eliminar(objeto);

            if (respuesta)
            {
                mostrar_Articulo();
            }
        }

        public void Estilo()
        {


            DGVArticulos.ScrollBars = ScrollBars.Both;
            DGVArticulos.Width = 700; // Ajusta el ancho
                                      // DGVArticulos.Height = 200; // Ajusta el alto

            DGVArticulos.BackgroundColor = Color.FromArgb(240, 235, 220); // Beige fondo
            DGVArticulos.GridColor = Color.FromArgb(200, 200, 200); // Gris líneas
            DGVArticulos.DefaultCellStyle.BackColor = Color.FromArgb(245, 240, 230); // Beige claro
            DGVArticulos.DefaultCellStyle.ForeColor = Color.Black; // Texto oscuro
            DGVArticulos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(244, 162, 97); // Naranja en selección
            DGVArticulos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            DGVArticulos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193); // Rosa pastel
            DGVArticulos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            button1.FlatStyle = FlatStyle.Flat;
            //button1.BackColor = Color.FromArgb(173, 216, 230); // Azul claro
            button1.ForeColor = Color.White;
            button1.FlatAppearance.BorderSize = 0; // Sin bordes
            button1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(135, 206, 250); // Azul hover
            btneditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(135, 206, 250); // Azul hover
            btnguardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(135, 206, 250); // Azul hover
            btneditar.FlatAppearance.BorderSize = 0;
            btnguardar.FlatAppearance.BorderSize = 0;
        }
    }



}
