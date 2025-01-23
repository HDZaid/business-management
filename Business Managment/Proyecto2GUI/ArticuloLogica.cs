using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite; //importamos todo lo necesario para interactuar con SQLite :V 

using System.Configuration;

namespace Proyecto2GUI
{
    public class ArticuloLogica
    {
        //esta es la cadena de conexion que configura la conexion con la base de datos para realizar las Consultas
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        //ahora se pone un patron de diseño singleton, la verdad no entiendo nada de esto
        //pero nos permite hacer una instancia unica de nuestra clase 
        private static ArticuloLogica _instancia = null;

        public ArticuloLogica()
        {

        }
        public static ArticuloLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia= new ArticuloLogica();
                }
                return _instancia;
            }
        }
        //Metodo para guardar / insertar datos en nuestra base dedatos 
        public bool Guardar(Articulo obj)
        {
            bool respuesta = true;
            //esta cosa pide una cadena de conexcion, la cadena de conexion la declaramos arribia, es la primera
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                //"abrimos la cadena de conexion"
                conexion.Open();
                //un objeto llamado query, que ingresa los datos en nuestra "TABLA Articulo", en los campos
                //" ID, Nombre, Marca, Cantidad, Precio " se trabaja con parametros para evitar la Inyeccion SQL
                string query = "insert into Articulo(ID,Nombre,Marca,Cantidad,Precio) values (@ID,@Nombre,@Marca,@Cantidad,@Precio)";

                //esto recibe nuestra query que creamos arriba y nuestra conexion, este CMD se encarga de ejecutar nuestra consulta
                //pero le tenemos que decir que envie unos parametros
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                //el nombre del parametro y el valor, le enviamos un objeto de tipo persona
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.ID));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Marca", obj.Marca));
                cmd.Parameters.Add(new SQLiteParameter("@Cantidad", obj.Cantidad));
                cmd.Parameters.Add(new SQLiteParameter("@Precio", obj.Precio));
                //ahora le decimos que tipo va a ser 
                cmd.CommandType = System.Data.CommandType.Text;

                //si la cantidad de filas afectadas es menor que 1 significa que no se realizo bien 
                //el comando y que ninguna fila fue afectada
                if(cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }
        //metodo para leer y saber si estamos insertando datos 
        public List<Articulo> Listar()
        {
            List<Articulo> oLista = new List<Articulo>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Articulo";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                //este es el encargado de leer nuestras TUPLAS
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    //mientras lee los agrega a la lista
                    while (dr.Read())
                    {
                        oLista.Add(new Articulo()
                        {
                            ID = int.Parse(dr["ID"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Marca = dr["Marca"].ToString(),
                            Cantidad = int.Parse(dr["Cantidad"].ToString()),
                            Precio = int.Parse(dr["Precio"].ToString()),
                        });
                    }
                }


            }
            return oLista;
        }





    }
}
