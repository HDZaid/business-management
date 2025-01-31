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
    public partial class BiblioEliminarLibro : Form
    {
        Biblioteca _biblioteca;
        Libro libroBuscado;
        public BiblioEliminarLibro(Biblioteca biblioteca)
        {
            _biblioteca = biblioteca;
            InitializeComponent();
            LimpiarSalidaDatos();
        }
        private void LimpiarSalidaDatos()
        {
            
        }

        private void btnBuscarLibro_Click_1(object sender, EventArgs e)
        {//boton para agregar
            Proveedor objeto = new Proveedor()
            {//ID *en el video no lo coloco porque es para eliminar y editar * en este caso no se usa porque es autoincrementable
                Nombre = txtNombre.Text,
                Contacto = TxtContacto.Text,
                Direccion = TxtDireccion.Text,
                Telefono = int.Parse(TxtTelefono.Text),
               

            };
            //devuelve una respuesta
            bool respuesta = ProveedorLogica.Instancia.Guardar(objeto);

            if (respuesta)
            {
                //ESTA COSA ES LA QUE MEUSTRA LA TABLA 
                mostrar_Proveedor();
            }



        }

        public void mostrar_Proveedor()
        {
            DGVProveedores.DataSource = null;
            DGVProveedores.DataSource = ProveedorLogica.Instancia.Listar();
        }


        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {//boton para editar

        }

        private void button2_Click(object sender, EventArgs e)
        {//boton para eliminar XD si sorry wey, no me di cuenta que ya habia un eliminar

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
