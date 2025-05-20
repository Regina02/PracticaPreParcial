using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaPreParcialService;

namespace PracticaPreParcial
{
    public class Venta
    {

        public int CodUnicoVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public string IdEquipoComprador { get; set; }
        public Producto ProductoVendido { get; set; }
        public Pago PagoVenta { get; set; }

    }
}
