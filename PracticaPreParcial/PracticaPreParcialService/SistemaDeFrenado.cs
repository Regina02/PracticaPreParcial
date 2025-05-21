using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPreParcialService
{
    public class SistemaDeFrenado : Producto
    {

        public sistemaFrenado tipoSistemaFrenado { get; set; }
        public bool CapacidadDeFrenadoAlta { get; set; }
        public string MaterialFAbricacion { get; set; }
        public int NroPistones { get; set; }

        public override void RegistrarProducto(List<Producto>listaProductos)
        {
            SistemaDeFrenado productoSistFrenado = new SistemaDeFrenado();
            productoSistFrenado.CodUnicoProd = listaProductos.Count() + 1;
            productoSistFrenado.NombreProd = NombreProd;
            productoSistFrenado.NombreFabricante = NombreFabricante;
            productoSistFrenado.PrecioBase = PrecioBase;
            productoSistFrenado.FechaMaximaVenta = FechaMaximaVenta;
            productoSistFrenado.FechaLanzamiento = FechaLanzamiento;
            productoSistFrenado.tipoSistemaFrenado = tipoSistemaFrenado;
            productoSistFrenado.CapacidadDeFrenadoAlta = CapacidadDeFrenadoAlta;
            productoSistFrenado.MaterialFAbricacion = MaterialFAbricacion;
            productoSistFrenado.NroPistones = NroPistones;
            listaProductos.Add(productoSistFrenado);
        }

    }
}
