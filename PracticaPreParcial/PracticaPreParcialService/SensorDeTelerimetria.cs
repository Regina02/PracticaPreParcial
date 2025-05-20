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

        public parametro ParametroMedible { get; set; }
        public int RangoDesde { get; set; }
        public int RangoHasta { get; set; }
        public string Descripción { get; set; }
        public tecnologia TecnologíaTransimsion { get; set; } 

    }
}
