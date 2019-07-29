using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;//referencias
using CapaDatos;//

namespace CapaNegocio
{
    public class LogicaNegocioVehiculo
    {
        accesoDatosVehiculo vh = new accesoDatosVehiculo();

        public int insertarVehiculo(Vehiculo veh)
        {
            return vh.insertarVehiculo(veh);
        }

        public List<Vehiculo> listarVehiculo()
        {
            return vh.listarVehiculo();
        }

        public int eliminarVehiculo(int idvehi)
        {
            return vh.eliminarVehiculo(idvehi);
        }


        public int EditarVehiculo(Vehiculo veh)
        {
            return vh.EditarVehiculo(veh);
        }

        public List<Vehiculo> BuscarVehiculo(string dato)
        {
            return vh.buscarVehiculo(dato);
        }

    }
}
