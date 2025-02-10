using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2GUI
{
    public class Proveedor
    {
        public int IDProveedor { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }

        //ver si esta bien declarado, porque lo que hace es almacenar todos los recibos de 1 solo proveedor, no se si va aqui por cierto
        //si al final no tiene ninguna referencia se tiene que volar 
        public List<ReciboInventario> Recibos { get; set; } = new List<ReciboInventario>();

    }
}
