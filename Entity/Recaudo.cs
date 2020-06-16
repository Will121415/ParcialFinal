using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Recaudo
    {
        public string NitAgente { get; set; }
        public int MesReporte { get; set; }
        public int VigenciaReporte { get; set; }
        public string TipoEstampilla { get; set; }
        public decimal ValorImpuesto { get; set; }
        public Contratista Contratista { get; set; }

    }
}
