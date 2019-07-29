using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;//referencias
using CapaDatos;//

namespace CapaNegocio
{
    public class LogicaNegocioCategoria
    {
        accesoDatosCategoria cat= new accesoDatosCategoria();

        public int insertarCategoria(Categoria c)
        {
            return cat.insertarCategoria(c);
        }

        public List<Categoria> listarCategoria()
        {
            return cat.listarCategoria();
        }

        public int eliminarCategoria(int idCateg)
        {
            return cat.eliminarCategoria(idCateg);
        }


        public int EditarCategoria(Categoria c)
        {
            return cat.EditarCategoria(c);
        }

        public List<Categoria> BuscarCategoria(string dato)
        {
            return cat.buscarCategoria(dato);
        }

    }
}
