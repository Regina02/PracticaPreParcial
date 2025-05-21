using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPreParcialService
{
    public class SensorDeTelerimetria : Producto
    {

        public List<parametro> ParametroMedible { get; set; }
        public int RangoDesde { get; set; }
        public int RangoHasta { get; set; }
        public string Descripcion { get; set; }
        public tecnologia TecnologíaTransimsion { get; set; }

        public override void RegistrarProducto(List<Producto> listaProductos)
        {
            SensorDeTelerimetria sistemaDeTele = new SensorDeTelerimetria();
            sistemaDeTele.CodUnicoProd = listaProductos.Count() + 1;
            sistemaDeTele.NombreProd = NombreProd;
            sistemaDeTele.NombreFabricante = NombreFabricante;
            sistemaDeTele.PrecioBase = PrecioBase;
            sistemaDeTele.FechaMaximaVenta = FechaMaximaVenta;
            sistemaDeTele.FechaLanzamiento = FechaLanzamiento;
            sistemaDeTele.ParametroMedible = ParametroMedible;
            sistemaDeTele.RangoDesde = RangoDesde;
            sistemaDeTele.RangoHasta = RangoHasta;
            sistemaDeTele.Descripcion = Descripcion;
            sistemaDeTele.TecnologíaTransimsion = TecnologíaTransimsion;
            listaProductos.Add(sistemaDeTele);
        }


    }
}
