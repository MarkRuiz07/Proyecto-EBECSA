using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;//referencias
using CapaDatos;//

namespace CapaNegocio
{
    public class LogicaNegocioProspecto
    {
        accesosDatosProspecto prs = new accesosDatosProspecto();

        public int insertarProspecto(Prospecto pr)
        {
            return prs.insertarProspecto(pr);
        }

        public List<Prospecto> listarProspecto()
        {
            return prs.listarProspecto();
        }

        public int eliminarProspecto(int idpros)
        {
            return prs.eliminarProspecto(idpros);
        }


        public int EditarProspecto(Prospecto pr )
        {
            return prs.EditarProspecto(pr);
        }

        public List<Prospecto> BuscarProspecto(string dato)
        {
            return prs.buscarProspecto(dato);
        }

    }
}
