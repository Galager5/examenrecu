using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class Cliente
    {
        public string TipoCliente { get; set; }
        public int Edad { get; set; }
    }

    public class Ruta
    {
        public string NombreRuta { get; set; }
        public decimal Precio { get; set; }
    }

    public class Venta
    {
        public Cliente Cliente { get; set; }
        public Ruta Ruta { get; set; }
        public int Cantidad { get; set; }
        public decimal Descuento { get; set; }
        public decimal ImportePago { get; set; }
    }
}
