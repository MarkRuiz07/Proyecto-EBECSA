using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;//referencias
using CapaDatos;//

namespace CapaNegocio
{
    public class LogicaNegocioProveedor
    {
        accesoDatosProveedor pro = new accesoDatosProveedor();

        public int insertarProveedor(Proveedor pr)
        {
            return pro.insertarProveedor(pr);
        }

        public List<Proveedor> listarProveedor()
        {
            return pro.listarProveedor();
        }

        public int eliminarProveedor(int idpro)
        {
            return pro.eliminarProveedor(idpro);
        }


        public int EditarProveedor(Proveedor pr)
        {
            return pro.EditarProveedor(pr);
        }

        public List<Proveedor> BuscarProveedor(string dato)
        {
            return pro.buscarProveedor(dato);
        }

    }
}

