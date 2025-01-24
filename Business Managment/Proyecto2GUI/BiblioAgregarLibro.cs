using Proyecto2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //  lblMensajeUsuario.Visible = false;

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
        {

        }

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
    }
}
