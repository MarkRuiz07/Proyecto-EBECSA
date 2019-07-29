using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;//referencias
using CapaDatos;//

namespace CapaNegocio
{
    public class LogicaNegocioAseguradora
    {
        accesoDatosAseguradora ase = new accesoDatosAseguradora();

        public int insertarAseguradora(Aseguradora A)
        {
            return ase.insertarAseguradora(A);
            
            }

        public List<Aseguradora> listarAseguradora()
        {
            return ase.listarAseguradora();
        }

        public int eliminarAseguradora(int idaseg)
        {
            return ase.eliminarAseguradora(idaseg);
        }


        public int EditarAseguradora(Aseguradora A)
        {
            return ase.EditarAseguradora(A);
        }

        public List<Aseguradora> BuscarAseguradora(string dato)
        {
            return ase.buscarAseguradora(dato);
        }

    }
}
