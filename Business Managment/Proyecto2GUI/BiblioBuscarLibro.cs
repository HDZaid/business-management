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
    public partial class BiblioBuscarLibro : Form
    {
        Biblioteca _bibliotecaActual;
        DataTable _dataLibrosEncontrados;
        public BiblioBuscarLibro(Biblioteca biblioteca)
        {
            _bibliotecaActual = biblioteca;   
            InitializeComponent();
            lblMensajeUsuario.Text = String.Empty;
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                int IDbuscado = int.Parse(RecibirBuscar.Text); // Convertir el texto a entero.
                Articulo articulo = ArticuloLogica.Instancia.ObtenerPorID(IDbuscado); // Buscar el artículo.

                if (articulo != null) // Verificar si se encontró el artículo.
                {
                    // Convertir el objeto en una lista con un solo elemento.
                    TablaLibrosBuscados.DataSource = new List<Articulo> { articulo };
                }
                else
                {
                    MessageBox.Show("No se encontró ningún artículo con el ID especificado.");
                    TablaLibrosBuscados.DataSource = null; // Limpiar la tabla si no hay resultados.
                }

                TablaLibrosBuscados.Show(); // Mostrar la tabla.
                //Limpiar(); // Limpiar los campos de entrada.
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        /*
        private void Consultar()
        {
            
        }
        */
        private void Limpiar()
        {
            RecibirBuscar.Text = String.Empty;
        }

        /*ublic void mostrar_Articulo()
        {
            TablaLibrosBuscados.DataSource = null;
            TablaLibrosBuscados.DataSource = ArticuloLogica.Instancia.ObtenerPorID();
        }
        */
    }
}
