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
    public class accesoDatosSeguros
    {
        SqlConnection cnx; //Conexion 
        Seguros s = new Seguros(); //Capa Entidades 
        Conexion cn = new Conexion(); //Conexion
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar CRUD
        //Para cargar datos
        SqlDataReader dr = null;
        List<Seguros> listaSeguros = null;
        public int insertarSeguros(Seguros s)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion

                cm = new SqlCommand("Pr_seguros", cnx); //Nombre del procedimiento 
                cm.Parameters.AddWithValue("@b", 1); //Valores que toman los parametros
                cm.Parameters.AddWithValue("@idseguros", ""); //del procedimiento
                cm.Parameters.AddWithValue("@MontoSeguro", s.MontoSeguro);
                cm.Parameters.AddWithValue("@tipo",s.tipo );


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

        public List<Seguros> listarSeguros()
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_seguros", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idseguros", "");
                cm.Parameters.AddWithValue("@MontoSeguro", "");
                cm.Parameters.AddWithValue("@tipo", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaSeguros = new List<Seguros>(); //Lista de cuentas
                while (dr.Read()) //Recorrer cada registro
                {
                    Seguros s = new Seguros();
                    s.idseguros = Convert.ToInt32(dr["idseguros"].ToString());
                    s.MontoSeguro = Convert.ToInt32( dr["MontoSeguro"].ToString());
                    s.MontoSeguro = Convert.ToInt32(dr["tipo"].ToString());


                    listaSeguros.Add(s); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaSeguros = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaSeguros; //regresa lista de registros



        }

        public List<Seguros> selectVehiculo() //listar los datos de categoria
        {

            SqlConnection cnn = cn.conectar();

            try
            {
                SqlCommand cmd = new SqlCommand("Pr_seguros", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@b", 3);             //valores de la tabla
                cmd.Parameters.AddWithValue("@idseguros", 0);
                cmd.Parameters.AddWithValue("@tipo", "");
                cmd.Parameters.AddWithValue("@MontoSeguro","");
                cnn.Open();
                SqlDataReader lector = cmd.ExecuteReader(); //leer los datos tabla sql

                List<Seguros> listado = new List<Seguros>(); //se agrega en una lista atraves de un siclo
                while (lector.Read())
                {
                    listado.Add(new Seguros()
                    {
                        idseguros = int.Parse(lector[0].ToString()),
                        tipo = lector[1].ToString()
                    });
                }

                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }


        }

        public int eliminarSeguros(int idseg)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("Pr_seguros", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idseguros", idseg); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@MontoSeguros", "");
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

        public int EditarSeguro(Seguros s)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_seguros", cnx);
                cm.Parameters.AddWithValue("b", 4);
                cm.Parameters.AddWithValue("@idseguros", ""); 
                cm.Parameters.AddWithValue("@MontoSeguro", s);
                cm.Parameters.AddWithValue("@tipo",s);

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

        public List<Seguros> buscarSeguro(string dato)
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("Pr_seguros", cnx);
                cm.Parameters.AddWithValue("b", 5);
                cm.Parameters.AddWithValue("@idseguros", ""); 
                cm.Parameters.AddWithValue("@MontoSeguro", dato);
                cm.Parameters.AddWithValue("@tipo", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaSeguros = new List<Seguros>(); //Lista 
                while (dr.Read()) //Recorrer cada registro
                {

                    Seguros s = new Seguros();
                    s.idseguros = Convert.ToInt32(dr["idseguros"].ToString());
                    s.MontoSeguro = Convert.ToInt32(dr["MontoSeguro"].ToString());
                    s.MontoSeguro = Convert.ToInt32(dr["tipo"].ToString());

                    listaSeguros.Add(s); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaSeguros = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaSeguros; //regresa lista 
        }

    }
}
