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
   public class accesosDatosProspecto
    {
        SqlConnection cnx; //Conexion 
        Prospecto p = new Prospecto(); //Capa Entidades 
        Conexion cn = new Conexion(); //Conexion
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar CRUD
        //Para cargar datos
        SqlDataReader dr = null;
        List<Prospecto> listaProspecto = null;
        public int insertarProspecto(Prospecto p)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion

                cm = new SqlCommand("Pr_Prospecto", cnx); //Nombre del procedimiento 
                cm.Parameters.AddWithValue("@b", 1); //Valores que toman los parametros
                cm.Parameters.AddWithValue("@idProspecto", ""); //del procedimiento
                cm.Parameters.AddWithValue("@cedula", p.cedula);
                cm.Parameters.AddWithValue("@nombres", p.nombres);
                cm.Parameters.AddWithValue("@apellidoPaterno", p.apellidoPaterno);
                cm.Parameters.AddWithValue("@apellidoMaterno", p.apellidoMaterno);
                cm.Parameters.AddWithValue("@correoElectronico", p.correoElectronico);
                cm.Parameters.AddWithValue("@TelefonP", p.TelefonP);


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

        public List<Prospecto> listarProspecto()
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_Prospecto", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idProspecto", ""); //del procedimiento
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidoPaterno", "");
                cm.Parameters.AddWithValue("@apellidoMaterno", "");
                cm.Parameters.AddWithValue("@correoElectronico", "");
                cm.Parameters.AddWithValue("@TelefonP", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProspecto = new List<Prospecto>(); //Lista 
                while (dr.Read()) //Recorrer cada registro
                {
                    Prospecto p = new Prospecto();
                    p.idProspecto = Convert.ToInt32(dr["idProspecto"].ToString());
                    p.cedula = dr["cedula"].ToString();
                    p.nombres = dr["nombres"].ToString();
                    p.apellidoPaterno = dr["apellidoPaterno"].ToString();
                    p.apellidoMaterno = dr["apellidoMaterno"].ToString();
                    p.correoElectronico = dr["correoElectronico"].ToString();
                    p.TelefonP = dr["TelefonoP"].ToString();

                    listaProspecto.Add(p); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProspecto = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaProspecto; //regresa lista 
        }

        public int eliminarProspecto(int idPros)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("Pr_Prospecto", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idProspecto", idPros); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidoPaterno", "");
                cm.Parameters.AddWithValue("@apellidoMaterno", "");
                cm.Parameters.AddWithValue("@correoElectronico", "");
                cm.Parameters.AddWithValue("@TelefonP", "");

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

        public int EditarProspecto(Prospecto pr)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_Prospecto", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idProspecto", ""); //del procedimiento
                cm.Parameters.AddWithValue("@cedula", pr.cedula);
                cm.Parameters.AddWithValue("@nombres",pr.nombres);
                cm.Parameters.AddWithValue("@apellidoPaterno", pr.apellidoPaterno);
                cm.Parameters.AddWithValue("@apellidoMaterno", pr.apellidoMaterno);
                cm.Parameters.AddWithValue("@correoElectronico", pr.correoElectronico);
                cm.Parameters.AddWithValue("@TelefonP", pr.TelefonP);
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

        public List<Prospecto> buscarProspecto(string dato)
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_Prospecto", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idProspecto", ""); //del procedimiento
                cm.Parameters.AddWithValue("@cedula", dato);
                cm.Parameters.AddWithValue("@nombres", dato);
                cm.Parameters.AddWithValue("@apellidoPaterno", dato);
                cm.Parameters.AddWithValue("@apellidoMaterno", dato);
                cm.Parameters.AddWithValue("@correoElectronico", dato);
                cm.Parameters.AddWithValue("@TelefonP", dato);
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProspecto = new List<Prospecto>(); //Lista 
                while (dr.Read()) //Recorrer cada registro
                {
                    Prospecto p = new Prospecto();
                    p.idProspecto = Convert.ToInt32(dr["idProspecto"].ToString());
                    p.cedula = dr["cedula"].ToString();
                    p.nombres = dr["nombres"].ToString();
                    p.apellidoPaterno = dr["apellidoPaterno"].ToString();
                    p.apellidoMaterno = dr["apellidoMaterno"].ToString();
                    p.correoElectronico = dr["correoElectronico"].ToString();
                    p.TelefonP = dr["TelefonoP"].ToString();

                    listaProspecto.Add(p); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProspecto = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaProspecto; //regresa lista 
        }

    }
}
