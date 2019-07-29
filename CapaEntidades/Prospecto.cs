using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Prospecto
    {
        public int idProspecto { get; set; }

        public String cedula { get; set; }

        public String nombres { get; set; }

        public String apellidoPaterno { get; set; }

        public String apellidoMaterno { get; set; }

        public String correoElectronico { get; set; }

        public String TelefonP { get; set; }
    }
}
