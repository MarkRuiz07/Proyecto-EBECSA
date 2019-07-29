using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class Vehiculo
    {
        public int idVehiculo { get; set; }

        public String marca { get; set; }

        public String modelo { get; set; }

        public String color { get; set; }

        public String colorSecundario { get; set; }

        public int añoFabricacion { get; set; }
        
        public String VersionCaracteristicas { get; set; }

        public int NumeroPasajeros { get; set; }

        public String NumeroCirculacion { get; set; }

        public int idProspecto { get; set; }

        public int idseguros { get; set; }

        public int idcategoria { get; set; }

    }
}
