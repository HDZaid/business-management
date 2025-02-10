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
    public partial class BiblioAgregarUsuario : Form
    {
        Biblioteca _biblioteca;
        public BiblioAgregarUsuario(Biblioteca biblioteca)
        {
            _biblioteca = biblioteca;
            InitializeComponent();

        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

            ReciboInventario objeto = new ReciboInventario()
            {//ID *en el video no lo coloco porque es para eliminar y editar * en este caso no se usa porque es autoincrementable
                IDProveedor = int.Parse(txtIDproveedor.Text),
                // Fecha = txtmarca.Text,
                Cantidad = int.Parse(txtCantidad.Text),
                Precio = int.Parse(txtPrecio.Text)

            };
            //devuelve una respuesta
            bool respuesta = ReciboInventario_Logica.Instancia.Guardar(objeto);

            if (respuesta)
            {
                //ESTA COSA ES LA QUE MEUSTRA LA TABLA 
                mostrar_Recibo();
            }

            // LimpiarCampos();
        }
        public void mostrar_Recibo()
        { 
            //EDITAR COSO
            List<ReciboInventario> lista = ReciboInventario_Logica.Instancia.ListarRecibos();

            // Transformar la lista para mostrar solo los datos necesarios
            var listaSimplificada = lista.Select(r => new
            {
                r.IDRecibo,
                r.Fecha,
                r.Precio,
                r.IDProveedor,
                r.Cantidad,
                NombreProveedor = r.Proveedor?.Nombre ?? "Sin proveedor" // Manejo de valores nulos
            }).ToList();

            // Asignar la lista procesada al DataGridView
            DGVlista.DataSource = null;
            DGVlista.DataSource = listaSimplificada;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            /*RecibirID.Clear();
            RecibirNombre.Clear();
            RecibirContraseña.Clear();
            RecibirRol.SelectedIndex = -1;
            lblMensajeUsuario.Visible = false;
            */
        }

        private void mostrarTodo_Click(object sender, EventArgs e)
        {
            mostrar_Recibo();
        }
    }
}
