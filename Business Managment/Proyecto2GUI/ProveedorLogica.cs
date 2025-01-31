using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2GUI
{
    public class ProveedorLogica
    {
        //esta es la cadena de conexion que configura la conexion con la base de datos para realizar las Consultas
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        //ahora se pone un patron de diseño singleton, la verdad no entiendo nada de esto
        //pero nos permite hacer una instancia unica de nuestra clase 
        private static ProveedorLogica _instancia = null;

        public ProveedorLogica()
        {

        }
        public static ProveedorLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ProveedorLogica();
                }
                return _instancia;
            }
        }
        //Metodo para guardar / insertar datos en nuestra base dedatos 
        public bool Guardar(Proveedor obj)
        {
            bool respuesta = true;
            //esta cosa pide una cadena de conexcion, la cadena de conexion la declaramos arribia, es la primera
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                //"abrimos la cadena de conexion"
                conexion.Open();
                //un objeto llamado query, que ingresa los datos en nuestra "TABLA Articulo", en los campos
                //" ID, Nombre, Marca, Cantidad, Precio " se trabaja con parametros para evitar la Inyeccion SQL
                //EN RESUMEN AGREGA LOS DATOS QUE LE MANDO
                //string query = "insert into Articulo(ID,Nombre,Marca,Cantidad,Precio) values (@ID,@Nombre,@Marca,@Cantidad,@Precio)";
                string query = "insert into Proveedor(Nombre,Telefono,Contacto,Direccion) values (@Nombre,@Telefono,@Contacto,@Direccion)";

                //esto recibe nuestra query que creamos arriba y nuestra conexion, este CMD se encarga de ejecutar nuestra consulta
                //pero le tenemos que decir que envie unos parametros
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                //el nombre del parametro y el valor, le enviamos un objeto de tipo persona
                // cmd.Parameters.Add(new SQLiteParameter("@ID", obj.ID));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Telefono", obj.Telefono));
                cmd.Parameters.Add(new SQLiteParameter("@Contacto", obj.Contacto));
                cmd.Parameters.Add(new SQLiteParameter("@Direccion", obj.Direccion));
                //ahora le decimos que tipo va a ser 
                cmd.CommandType = System.Data.CommandType.Text;

                //si la cantidad de filas afectadas es menor que 1 significa que no se realizo bien 
                //el comando y que ninguna fila fue afectada
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }
        //metodo para leer y saber si estamos insertando datos 
        public List<Proveedor> Listar()
        {
            List<Proveedor> oLista = new List<Proveedor>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Proveedor";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                //este es el encargado de leer nuestras TUPLAS
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    //mientras lee los agrega a la lista
                    while (dr.Read())
                    {
                        oLista.Add(new Proveedor()
                        {
                            IDProveedor = int.Parse(dr["IDProveedor"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Telefono = int.Parse(dr["Telefono"].ToString()),
                            Contacto = dr["Contacto"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            
                            
                        });
                    }
                }


            }
            return oLista;
        }
        // metodo de eliminar DU'H 
        public bool Eliminar(Articulo obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "delete from Articulo where ID = @ID";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.ID));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }
        //busqueda por ID
        public Articulo ObtenerPorID(int id)
        {
            Articulo articulo = null; // Inicializamos el objeto en null para manejar casos en los que no se encuentre el artículo.

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM Articulo WHERE ID = @ID"; // Usamos un parámetro para evitar inyección SQL.
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", id); // Agregamos el parámetro ID.

                // Ejecutamos el comando y leemos los resultados.
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read()) // Si encuentra un registro.
                    {
                        articulo = new Articulo()
                        {
                            ID = int.Parse(dr["ID"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Marca = dr["Marca"].ToString(),
                            Cantidad = int.Parse(dr["Cantidad"].ToString()),
                            Precio = int.Parse(dr["Precio"].ToString()),
                        };
                    }
                }
            }

            return articulo; // Devuelve el artículo encontrado o null si no existe.
        }


    }
}
