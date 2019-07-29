using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;//referencias
using CapaDatos;//

namespace CapaNegocio
{
    public class LogicaNegocioSeguros
    {
        accesoDatosSeguros sg = new accesoDatosSeguros();

        public int insertarSeguros(Seguros sgr)
        {
            return sg.insertarSeguros(sgr);
        }

        public List<Seguros> listarSeguros()
        {
            return sg.listarSeguros();
        }

        public int eliminarSeguros(int idseg)
        {
            return sg.eliminarSeguros(idseg);
        }


        public int EditarSeguros(Seguros sgr)
        {
            return sg.EditarSeguro(sgr);
        }

        public List<Seguros> BuscarSeguros(string dato)
        {
            return sg.buscarSeguro(dato);
        }

    }
}
