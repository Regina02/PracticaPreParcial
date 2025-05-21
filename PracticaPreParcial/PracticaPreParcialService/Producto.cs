namespace PracticaPreParcialService
{
    public abstract class Producto
    {

        public int CodUnicoProd { get; set; }
        public string NombreProd { get; set; }
        public string NombreFabricante { get; set; }
        public int PrecioBase { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public DateTime FechaMaximaVenta { get; set; }

        

        public virtual void RegistrarProducto(List<Producto> listaProductos)
        {

        }
    }
}
