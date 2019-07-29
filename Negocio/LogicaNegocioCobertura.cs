using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;//referencias
using CapaDatos;//

namespace CapaNegocio
{
    public class LogicaNegocioCobertura
    {
        accesoDatosCobertura cob = new accesoDatosCobertura();

        public int insertarCobertura(Cobertura cobr)
        {
            return cob.insertarCobertura(cobr);
        }

        public List<Cobertura> listarCobertura()
        {
            return cob.listarCobertura();
        }

        public int eliminarCobertura(int idCober)
        {
            return cob.eliminarCobertura(idCober);
        }


        public int EditarCobertura(Cobertura cobr)
        {
            return cob.EditarCobertura(cobr);
        }

        public List<Cobertura> BuscarCobertura(string dato)
        {
            return cob.buscarCobertura(dato);
        }

    }
}
