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
    public class accesoDatosProveedor
    {
        SqlConnection cnx; //Conexion 
        Proveedor pr = new Proveedor(); //Capa Entidades 
        Conexion cn = new Conexion(); //Conexion
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar CRUD
        //Para cargar datos
        SqlDataReader dr = null;
        List<Proveedor> listaProveedor = null;
        public int insertarProveedor(Proveedor pr)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion

                cm = new SqlCommand("Pr_Proveedor", cnx); //Nombre del procedimiento 
                cm.Parameters.AddWithValue("@b", 1); //Valores que toman los parametros
                cm.Parameters.AddWithValue("@idProveedor", ""); //del procedimiento
                cm.Parameters.AddWithValue("@nombreprov", pr.nombreprov);
                cm.Parameters.AddWithValue("@email", pr.email);
                cm.Parameters.AddWithValue("@telefonoprov", pr.telefonoprov);
                cm.Parameters.AddWithValue("@acargo", pr.cargo);

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

        public List<Proveedor> listarProveedor()
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_Proveedor", cnx);
                cm.Parameters.AddWithValue("b", 3);
                cm.Parameters.AddWithValue("@idProveedor", "");
                cm.Parameters.AddWithValue("@nombreprov", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefonoprov", "");
                cm.Parameters.AddWithValue("@cargo", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaProveedor = new List<Proveedor>(); //Lista de cuentas
                while (dr.Read()) //Recorrer cada registro
                {
                    Proveedor pr = new Proveedor();
                    pr.idProveedor = Convert.ToInt32(dr["idProspecto"].ToString());
                    pr.email = dr["email"].ToString();
                    pr.telefonoprov = Convert.ToInt32(dr["nombres"].ToString());
                    pr.cargo = dr["cargo"].ToString();
                    

                    listaProveedor.Add(pr); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaProveedor = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaProveedor; //regresa lista de registros



        }

        public int eliminarProveedor(int idprov)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("Pr_Proveedor", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idProveedor", idprov); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@nombreprov", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefonoprov", "");
                cm.Parameters.AddWithValue("@cargo", "");

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
       public int EditarProveedor(Proveedor prov)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Proveedor", cnx);
                cm.Parameters.AddWithValue("b", 4);
                cm.Parameters.AddWithValue("@idProveedor", "");
                cm.Parameters.AddWithValue("@nombreprov", prov);
                cm.Parameters.AddWithValue("@email", prov);
                cm.Parameters.AddWithValue("@telefonoprov", "");
                cm.Parameters.AddWithValue("@cargo", "");

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

       public List<Proveedor> buscarProveedor(string dato)
       {
           try
           {

               SqlConnection cnx = cn.conectar(); //Conexion
               cm = new SqlCommand("Proveedor", cnx);
               cm.Parameters.AddWithValue("b", 5);
               cm.Parameters.AddWithValue("@idProveedor", "");
               cm.Parameters.AddWithValue("@nombreprov", dato);
               cm.Parameters.AddWithValue("@email", dato);
               cm.Parameters.AddWithValue("@telefonoprov", "");
               cm.Parameters.AddWithValue("@cargo", "");


               cm.CommandType = CommandType.StoredProcedure;
               cnx.Open();
               dr = cm.ExecuteReader();
               listaProveedor = new List<Proveedor>(); //Lista 
               while (dr.Read()) //Recorrer cada registro
               {

                   Proveedor pr = new Proveedor();
                   pr.idProveedor = Convert.ToInt32(dr["idProspecto"].ToString());
                   pr.email = dr["email"].ToString();
                   pr.telefonoprov = Convert.ToInt32(dr["nombres"].ToString());
                   pr.cargo = dr["cargo"].ToString();

                   listaProveedor.Add(pr); //Agregar registros encontrados a lista 
               }
           }
           catch (Exception e)
           {
               e.Message.ToString();
               listaProveedor = null;

           }
           finally
           { cm.Connection.Close(); }
           return listaProveedor; //regresa lista 
       }

    }
}
