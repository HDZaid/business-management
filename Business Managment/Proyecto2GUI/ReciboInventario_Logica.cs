using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2GUI
{
    public class ReciboInventario_Logica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static ReciboInventario_Logica _instancia = null;

        public ReciboInventario_Logica()
        {

        }
        public static ReciboInventario_Logica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ReciboInventario_Logica();
                }
                return _instancia;
            }
        }
        //METODO PARA AGREGAR 1 OBJETO

        public bool Guardar(ReciboInventario obj)
        {
            bool respuesta = false;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open(); // Abre la conexión

                    // Habilitar claves foráneas
                    using (SQLiteCommand cmdForeignKeys = new SQLiteCommand("PRAGMA foreign_keys = ON;", conexion))
                    {
                        cmdForeignKeys.ExecuteNonQuery();
                    }

                    string query = @"INSERT INTO Recibo (Fecha, IDProveedor, Precio, Cantidad) 
                             VALUES (CURRENT_TIMESTAMP, @IDProveedor, @Precio, @Cantidad);
                             SELECT last_insert_rowid();"; // Obtener el ID del nuevo registro

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@IDProveedor", obj.IDProveedor);
                        cmd.Parameters.AddWithValue("@Precio", obj.Precio);
                        cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);

                        // Ejecutar la consulta y obtener el ID insertado
                        long lastId = (long)cmd.ExecuteScalar();
                        Console.WriteLine("Último ID insertado en Recibo: " + lastId);
                        respuesta = true;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return respuesta;
        }
        public List<ReciboInventario> ListarRecibos()
        {
            List<ReciboInventario> oLista = new List<ReciboInventario>();

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = @"SELECT r.IDRecibo, r.Fecha, r.IDProveedor, r.Precio, r.Cantidad, p.Nombre 
                             FROM Recibo r
                             INNER JOIN Proveedor p ON r.IDProveedor = p.IDProveedor"; // Hacemos un JOIN para obtener el nombre del proveedor

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                oLista.Add(new ReciboInventario()
                                {
                                    IDRecibo = Convert.ToInt32(dr["IDRecibo"]),
                                    Fecha = Convert.ToDateTime(dr["Fecha"]),
                                    IDProveedor = Convert.ToInt32(dr["IDProveedor"]),
                                    Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                    Precio = Convert.ToDouble(dr["Precio"]),
                                    Proveedor = new Proveedor() { Nombre = dr["Nombre"].ToString() } // Creamos un objeto Proveedor con su Nombre
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar los recibos: " + ex.Message);
            }

            return oLista;
        }
        //buscar

        



    }
}
