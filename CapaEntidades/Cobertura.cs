using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class Cobertura
    {
        public int idcobertura { get; set; }

        public String descripcion { get; set; }

        public Decimal sumaAseguradora { get; set; }

        public int idseguros { get; set; }

    }
}
