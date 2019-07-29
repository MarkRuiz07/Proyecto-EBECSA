using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data; 

namespace CapaDatos
{
    public class accesoDatosVehiculo
    {
        SqlConnection cnx; //Conexion 
        Vehiculo v = new Vehiculo(); //Capa Entidades 
        Conexion cn = new Conexion(); //Conexion
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar CRUD
        //Para cargar datos
        SqlDataReader dr = null;
        List<Vehiculo> listaVehiculo = null;
        public int insertarVehiculo(Vehiculo v)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion

                cm = new SqlCommand("Pr_Vehiculo", cnx); //Nombre del procedimiento 
                cm.Parameters.AddWithValue("@b", 1); //Valores que toman los parametros
                cm.Parameters.AddWithValue("@idVehiculo", ""); //del procedimiento
                cm.Parameters.AddWithValue("@marca", v.marca);
                cm.Parameters.AddWithValue("@modelo", v.modelo);
                cm.Parameters.AddWithValue("@color", v.color);
                cm.Parameters.AddWithValue("@colorSecundario", v.colorSecundario);
                cm.Parameters.AddWithValue("@añoFabricacion", v.añoFabricacion);
                cm.Parameters.AddWithValue("@VersionCaracteristicas", v.VersionCaracteristicas);
                cm.Parameters.AddWithValue("@NumeroPasajeros", v.NumeroPasajeros);
                cm.Parameters.AddWithValue("@NumeroCirculacion", v.NumeroCirculacion);
                cm.Parameters.AddWithValue("@idProspecto", v.idProspecto);
                cm.Parameters.AddWithValue("@idseguros", v.idseguros);
                cm.Parameters.AddWithValue("@idcategoria", v.idcategoria);

                cm.CommandType = CommandType.StoredProcedure; //Tipo de comando ejecutado
                cnx.Open(); //Abrir conexion de BD
                cm.ExecuteNonQuery(); //Ejecucion de consulta
                indicador = 1; //Valor del indicador
            }
            catch (Exception e)
            {
                e.Message.ToString(); //Mostrar mensaje en caso error
                indicador = 0;

            }
            finally
            {
                cm.Connection.Close(); //Cierre de conexion
            }
            return indicador;


        }

        public List<Vehiculo> listarVehiculo()
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_Vehiculo", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idVehiculo", "");
                cm.Parameters.AddWithValue("@marca", "");
                cm.Parameters.AddWithValue("@modelo", "");
                cm.Parameters.AddWithValue("@color", "");
                cm.Parameters.AddWithValue("@colorSecundario", "");
                cm.Parameters.AddWithValue("@añoFabricacion", "");
                cm.Parameters.AddWithValue("@VersionCaracteristicas", "");
                cm.Parameters.AddWithValue("@NumeroPasajeros", "");
                cm.Parameters.AddWithValue("@NumeroCirculacion","");
                cm.Parameters.AddWithValue("@idProspecto", "");
                cm.Parameters.AddWithValue("@idseguros", "");
                cm.Parameters.AddWithValue("@idcategoria", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaVehiculo = new List<Vehiculo>(); //Lista de cuentas
                while (dr.Read()) //Recorrer cada registro
                {
                    Vehiculo v = new Vehiculo();
                    v.idVehiculo = Convert.ToInt32(dr["idVehiculo"].ToString());
                    v.marca = dr["marca"].ToString();
                    v.modelo = dr["modelo"].ToString();
                    v.color = dr["color"].ToString();
                    v.colorSecundario = dr["colorSecundario"].ToString();
                    v.añoFabricacion = Convert.ToInt32(dr["añoFabricacion"].ToString());
                    v.VersionCaracteristicas = dr["VersionCaracteristicas"].ToString();
                    v.NumeroPasajeros = Convert.ToInt32(dr["NumeroPasajeros"].ToString());
                    v.NumeroCirculacion = dr["NumeroCirculacion"].ToString();
                    v.idProspecto = Convert.ToInt32(dr["idProspecto"].ToString());
                    v.idseguros = Convert.ToInt32(dr["idseguros"].ToString());
                    v.idcategoria = Convert.ToInt32(dr["idcategoria"].ToString());
                    listaVehiculo.Add(v); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaVehiculo = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaVehiculo; //regresa lista de registros



        }

        public int eliminarVehiculo(int idveh)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("Pr_Vehiculo", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idVehiculo", idveh); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@marca", "");
                cm.Parameters.AddWithValue("@modelo", "");
                cm.Parameters.AddWithValue("@color", "");
                cm.Parameters.AddWithValue("@colorSecundario", "");
                cm.Parameters.AddWithValue("@añoFabricacion", "");
                cm.Parameters.AddWithValue("@VersionCaracteristicas", "");
                cm.Parameters.AddWithValue("@NumeroPasajeros", "");
                cm.Parameters.AddWithValue("@NumeroCirculacion", "");
                cm.Parameters.AddWithValue("@idProspecto", "");
                cm.Parameters.AddWithValue("@idseguros", "");
                cm.Parameters.AddWithValue("@idcategoria", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            { cm.Connection.Close(); }
            return indicador;
        }
        public int EditarVehiculo(Vehiculo v)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_Vehiculo", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idVehiculo", ""); //del procedimiento
                cm.Parameters.AddWithValue("@marca", v.marca);
                cm.Parameters.AddWithValue("@modelo", v.modelo);
                cm.Parameters.AddWithValue("@color", v.color);
                cm.Parameters.AddWithValue("@colorSecundario", v.colorSecundario);
                cm.Parameters.AddWithValue("@añoFabricacion", v.añoFabricacion);
                cm.Parameters.AddWithValue("@VersionCaracteristicas", v.VersionCaracteristicas);
                cm.Parameters.AddWithValue("@NumeroPasajeros", v.NumeroPasajeros);
                cm.Parameters.AddWithValue("@NumeroCirculacion", v.NumeroCirculacion);
                cm.Parameters.AddWithValue("@idProspecto", v.idProspecto);
                cm.Parameters.AddWithValue("@idseguros", v.idseguros);
                cm.Parameters.AddWithValue("@idcategoria", v.idcategoria);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public List<Vehiculo> buscarVehiculo(string dato)
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_Vehiculo", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idVehiculo", ""); //del procedimiento
                cm.Parameters.AddWithValue("@marca", dato);
                cm.Parameters.AddWithValue("@modelo", v.modelo);
                cm.Parameters.AddWithValue("@color", dato);
                cm.Parameters.AddWithValue("@colorSecundario", dato);
                cm.Parameters.AddWithValue("@añoFabricacion", dato);
                cm.Parameters.AddWithValue("@VersionCaracteristicas", dato);
                cm.Parameters.AddWithValue("@NumeroPasajeros", dato);
                cm.Parameters.AddWithValue("@NumeroCirculacion", dato);
                cm.Parameters.AddWithValue("@idProspecto", dato);
                cm.Parameters.AddWithValue("@idseguros", "");
                cm.Parameters.AddWithValue("@idcategoria", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaVehiculo= new List<Vehiculo>(); //Lista 
                while (dr.Read()) //Recorrer cada registro
                {

                    Vehiculo v = new Vehiculo();
                    v.idVehiculo = Convert.ToInt32(dr["idVehiculo"].ToString());
                    v.marca = dr["marca"].ToString();
                    v.modelo = dr["modelo"].ToString();
                    v.color = dr["color"].ToString();
                    v.colorSecundario = dr["colorSecundario"].ToString();
                    v.añoFabricacion = Convert.ToInt32(dr["añoFabricacion"].ToString());
                    v.VersionCaracteristicas = dr["VersionCaracteristicas"].ToString();
                    v.NumeroPasajeros = Convert.ToInt32(dr["NumeroPasajeros"].ToString());
                    v.NumeroCirculacion = dr["NumeroCirculacion"].ToString();
                    v.idProspecto = Convert.ToInt32(dr["idProspecto"].ToString());
                    v.idseguros = Convert.ToInt32(dr["idseguros"].ToString());
                    v.idcategoria = Convert.ToInt32(dr["idcategoria"].ToString());

                    listaVehiculo.Add(v); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaVehiculo = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaVehiculo; //regresa lista 
        }
    }
}
