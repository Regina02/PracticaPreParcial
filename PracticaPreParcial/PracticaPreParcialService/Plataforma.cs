using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPreParcialService
{
    public class Plataforma
    {
        //public virtual void RegistrarProducto(string nombreProd, string nombreFabric, int precioBase, DateTime fechaVentaMax, DateTime fechaLanzamiento)
        //{
        //    SistemaDeFrenado productoSistFrenado = new SistemaDeFrenado();
        //    productoSistFrenado.NombreProd = nombreProd;
        //    productoSistFrenado.NombreFabricante = nombreFabric;
        //    productoSistFrenado.PrecioBase = precioBase;
        //    productoSistFrenado.FechaMaximaVenta = fechaVentaMax;
        //    productoSistFrenado.FechaLanzamiento = fechaLanzamiento;
        //}
        List<Producto> listaProductos = new List<Producto>();
        List<Venta> listaVentas = new List<Venta>();
        List<Venta> listaPagos = new List<Venta>();
        double CalcularIndiceDeRendimiento(int codUnicoProd)
        {
            double indice = 00;
            Producto productoEncontrado = listaProductos.FirstOrDefault(x=>x.CodUnicoProd == codUnicoProd);
            if (productoEncontrado != null)
            {
                if (productoEncontrado is SensorDeTelerimetria sensor)
                {
                    indice = 70; 
                    
                    List<parametro> parametrosEncontrados = sensor.ParametroMedible;
                    foreach(var p in parametrosEncontrados)
                    {
                        if (p != parametro.aceleracion)
                        {
                            indice += indice * 0.10; 
                        } else
                        {
                            indice += indice * 0.13; 
                        }
                    }
                    sensor.TecnologíaTransimsion = tecnologia.bluetooth;
                    indice += indice * 0.20; 

                } else if (productoEncontrado is SistemaDeFrenado sistema)
                {
                    indice = 60;
                    if (sistema.CapacidadDeFrenadoAlta)
                    {
                        indice += indice * 0.15; 
                    }
                    if (sistema.NroPistones >= 6)
                    {
                        indice += indice * 0.25;
                    }
                }
               
            }
            return indice;
        }
        double CalcularImporteTotalDeVenta(int codUnicoProd)
        {
            Producto productoEncontrado = listaProductos.FirstOrDefault(x => x.CodUnicoProd == codUnicoProd);
            double indice = CalcularIndiceDeRendimiento(codUnicoProd);
            double importe = (productoEncontrado.PrecioBase + (productoEncontrado.PrecioBase * indice) / 100);
            return importe;
        }

        public void GenerarPago( DateTime fechaDelPago, double importe, int codUnicoProd)
        {
            double importeAPagar = CalcularImporteTotalDeVenta(codUnicoProd);
            Pago pago = new Pago();
            pago.FechaDePago = fechaDelPago;
            pago.CodUnicoPago = listaPagos.Count() + 1;
            pago.MontoTotal = importeAPagar; 
        }
        bool RegistroDeVenta(string idEquipoComprador, int codUnicoProd)
        {
            
            Venta venta = new Venta();
            venta.FechaVenta = DateTime.Now;
            venta.IdEquipoComprador = idEquipoComprador;
            venta.ProductoVendido = listaProductos.FirstOrDefault(x => x.CodUnicoProd == codUnicoProd);
            venta.CodUnicoVenta = listaVentas.Count() + 1; 
            //venta.PagoVenta= GenerarPago()


            return false;
        }
    }
}
