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
    public class accesoDatosAseguradora
    {
        SqlConnection cnx; //Conexion 
        Aseguradora p = new Aseguradora(); //Capa Entidades 
        Conexion cn = new Conexion(); //Conexion
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar CRUD
        //Para cargar datos
        SqlDataReader dr = null;
        List<Aseguradora> listaAseguradora = null;

        public int insertarAseguradora(Aseguradora a)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion

                cm = new SqlCommand("Pr_Aseguradora", cnx); //Nombre del procedimiento 
                cm.Parameters.AddWithValue("@b", 1); //Valores que toman los parametros
                cm.Parameters.AddWithValue("@idAseguradora", ""); //del procedimiento
                cm.Parameters.AddWithValue("@nombreAs", a.nombreAs);
                cm.Parameters.AddWithValue("@idseguros", a.idseguros);
                cm.Parameters.AddWithValue("@idProveedor", a.idProveedor);
              
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

        public List<Aseguradora> listarAseguradora()
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_Aseguradora", cnx);
                cm.Parameters.AddWithValue("b", 3);
                cm.Parameters.AddWithValue("@idAseguradora", "");
                cm.Parameters.AddWithValue("@nombreAs", "");
                cm.Parameters.AddWithValue("@idseguros", "");
                cm.Parameters.AddWithValue("@idProveedor", "");
               
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaAseguradora = new List<Aseguradora>(); //Lista de cuentas
                while (dr.Read()) //Recorrer cada registro
                {
                    Aseguradora a = new Aseguradora();
                    a.idAseguradora = Convert.ToInt32(dr["idAseguradora"].ToString());
                    a.nombreAs = dr["nombreAs"].ToString();
                    a.idseguros = Convert.ToInt32(dr["idseguros"].ToString());
                    a.idProveedor = Convert.ToInt32(dr["idsProveedor"].ToString());

                    listaAseguradora.Add(a); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaAseguradora = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaAseguradora; //regresa lista de registros



        }

        public int eliminarAseguradora(int idaseg)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("Pr_Aseguradora", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idAseguradora", idaseg); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@nombreAS", "");
                cm.Parameters.AddWithValue("@idseguros", "");
                cm.Parameters.AddWithValue("@idProveedor", "");

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
        
       
        public int EditarAseguradora(Aseguradora AS)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Aseguradora", cnx);
                cm.Parameters.AddWithValue("b",4 );
                cm.Parameters.AddWithValue("@idAseguradora", "");
                cm.Parameters.AddWithValue("@nombreAs",AS );
                cm.Parameters.AddWithValue("@idseguros", "");
                cm.Parameters.AddWithValue("@idProveedor", "");

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

        public List<Aseguradora> buscarAseguradora(string dato)
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Aseguradora", cnx);
                cm.Parameters.AddWithValue("b", 5);
                cm.Parameters.AddWithValue("@idAseguradora", "");
                cm.Parameters.AddWithValue("@nombreAs", dato);
                cm.Parameters.AddWithValue("@idseguros", "");
                cm.Parameters.AddWithValue("@idProveedor", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaAseguradora = new List<Aseguradora>(); //Lista de cuentas
                while (dr.Read()) //Recorrer cada registro
                {
                    Aseguradora a = new Aseguradora();
                    a.idAseguradora = Convert.ToInt32(dr["idAseguradora"].ToString());
                    a.nombreAs = dr["nombreAs"].ToString();
                    a.idseguros = Convert.ToInt32(dr["idseguros"].ToString());
                    a.idProveedor = Convert.ToInt32(dr["idProveedor"].ToString());

                    listaAseguradora.Add(a); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaAseguradora = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaAseguradora; //regresa lista de registros



        }
    }
}
