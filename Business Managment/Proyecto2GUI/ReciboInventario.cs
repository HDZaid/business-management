using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2GUI
{
    internal class ReciboInventario
    {
        public int IDRecibo { get; set; }
        public int Fecha { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public int IDArticulo { get; set; }
        public int IDProveedor { get; set; }
    }
}
