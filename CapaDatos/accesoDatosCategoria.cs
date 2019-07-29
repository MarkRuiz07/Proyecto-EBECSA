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
    public class accesoDatosCategoria
    {
        SqlConnection cnx; //Conexion 
        Categoria ct = new Categoria(); //Capa Entidades 
        Conexion cn = new Conexion(); //Conexion
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar CRUD
        //Para cargar datos
        SqlDataReader dr = null;
        List<Categoria> listaCategoria = null;
        public int insertarCategoria(Categoria ct)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion

                cm = new SqlCommand("Pr_Categoria", cnx); //Nombre del procedimiento 
                cm.Parameters.AddWithValue("@b", 1); //Valores que toman los parametros
                cm.Parameters.AddWithValue("@idacategoria", ""); //del procedimiento
                cm.Parameters.AddWithValue("@tipo", ct.tipo);
               


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

        public List<Categoria> listarCategoria()
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_Categoria", cnx);
                cm.Parameters.AddWithValue("b", 3);
                cm.Parameters.AddWithValue("@idcategoria", "");
                cm.Parameters.AddWithValue("@tipo", "");
                

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCategoria = new List<Categoria>(); //Lista de cuentas
                while (dr.Read()) //Recorrer cada registro
                {
                    Categoria ct = new Categoria();
                    ct.idcategoria = Convert.ToInt32(dr["idcategoria"].ToString());
                    ct.tipo = dr["tipo"].ToString();                  
                    
                    listaCategoria.Add(ct); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCategoria = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaCategoria; //regresa lista de registros



        }

        public int eliminarCategoria(int idcat)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("Pr_Categoria", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idProspecto", idcat); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@tipo", "");
             
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

        public int EditarCategoria(Categoria cat)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Aseguradora", cnx);
                cm.Parameters.AddWithValue("b", 4);
                cm.Parameters.AddWithValue("@idcategoria", "");
                cm.Parameters.AddWithValue("@tipo", cat);

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

        public List<Categoria> buscarCategoria(string dato)
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Aseguradora", cnx);
                cm.Parameters.AddWithValue("b", 5);
                cm.Parameters.AddWithValue("@idcategoria", "");
                cm.Parameters.AddWithValue("@tipo", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCategoria = new List<Categoria>(); 
                while (dr.Read()) //Recorrer cada registro
                {
                    Aseguradora a = new Aseguradora();
                    a.idAseguradora = Convert.ToInt32(dr["idcategoria"].ToString());
                    a.nombreAs = dr["tipo"].ToString();
                    

                    listaCategoria.Add(ct); 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCategoria = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaCategoria; //regresa lista 



        }
    }
}
