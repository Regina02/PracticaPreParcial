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

    }
}
