using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2GUI
{
    public class ReciboInventario //PD. hacer esto mismo con las demas cosas, por cierto REAL es el double en las DB
    {
        public int IDRecibo { get; set; }  // Autoincremental en BD
        public DateTime Fecha { get; set; }  // Cambiado de int a DateTime
        public double Precio { get; set; }  // Cambiado de int a decimal si usas valores decimales 
        public int Cantidad { get; set; }
        public int IDProveedor { get; set; } // Clave foránea
        public Proveedor Proveedor { get; set; } //representa el objeto al que hago referencia usando la llave foránea

        
    }
}
