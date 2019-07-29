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
    public class accesoDatosCobertura
    {
        SqlConnection cnx; //Conexion 
        Cobertura c = new Cobertura(); //Capa Entidades 
        Conexion cn = new Conexion(); //Conexion
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar CRUD
        //Para cargar datos
        SqlDataReader dr = null;
        List<Cobertura> listaCobertura = null;
        public int insertarCobertura(Cobertura cobr)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion

                cm = new SqlCommand("Pr_Cobertura", cnx); //Nombre del procedimiento 
                cm.Parameters.AddWithValue("@b", 1); //Valores que toman los parametros
                cm.Parameters.AddWithValue("@idcobertura", ""); //del procedimiento
                cm.Parameters.AddWithValue("@descripcion", c.descripcion);
                cm.Parameters.AddWithValue("@sumaAsegurada", c.sumaAseguradora);
                cm.Parameters.AddWithValue("@idseguros", c.idseguros);
               


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

        public List<Cobertura> listarCobertura()
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_Cobertura", cnx);
                cm.Parameters.AddWithValue("b", 3);
                cm.Parameters.AddWithValue("@idCobertura", "");
                cm.Parameters.AddWithValue("@descripcion", "");
                cm.Parameters.AddWithValue("@sumaAsegurada", "");
                cm.Parameters.AddWithValue("@idseguros", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCobertura = new List<Cobertura>(); //Lista de cuentas
                while (dr.Read()) //Recorrer cada registro
                {
                    Cobertura c = new Cobertura();
                    c.idcobertura = Convert.ToInt32(dr["idcobertura"].ToString());
                    c.descripcion = dr["descripcion"].ToString();
                    c.sumaAseguradora = Convert.ToInt32(dr["sumaAseguradora"].ToString());
                    c.idseguros = Convert.ToInt32(dr["idseguros"].ToString());
             

                    listaCobertura.Add(c); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCobertura = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaCobertura; //regresa lista de registros



        }

        public int eliminarCobertura(int idcob)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("Pr_Cobertura", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idcobertura", idcob); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@descripcion", "");
                cm.Parameters.AddWithValue("@sumaAsegurada", "");
                cm.Parameters.AddWithValue("@idseguros", "");

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

        public int EditarCobertura(Cobertura cob)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Cobertura", cnx);
                cm.Parameters.AddWithValue("b", 4);
                cm.Parameters.AddWithValue("@idcobertura", ""); //del procedimiento
                cm.Parameters.AddWithValue("@descripcion", cob);
                cm.Parameters.AddWithValue("@sumaAsegurada", cob);
                cm.Parameters.AddWithValue("@idseguros","");

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

        public List<Cobertura> buscarCobertura(string dato)
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Cobertura", cnx);
                cm.Parameters.AddWithValue("b", 5);
                cm.Parameters.AddWithValue("@idcobertura", ""); //del procedimiento
                cm.Parameters.AddWithValue("@descripcion", dato);
                cm.Parameters.AddWithValue("@sumaAsegurada", dato);
                cm.Parameters.AddWithValue("@idseguros", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCobertura = new List<Cobertura>(); //Lista de cobertura
                while (dr.Read()) //Recorrer cada registro
                {
                    Cobertura c = new Cobertura();
                    c.idcobertura = Convert.ToInt32(dr["idcobertura"].ToString());
                    c.descripcion = dr["descripcion"].ToString();
                    c.sumaAseguradora = Convert.ToInt32(dr["sumaAseguradora"].ToString());
                    c.idseguros = Convert.ToInt32(dr["idseguros"].ToString());

                    listaCobertura.Add(c); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCobertura = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaCobertura; //regresa lista de registros



        }
    }
}
