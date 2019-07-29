using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Agregar
using CapaEntidades; //Referencias
using System.Data; //Agregar 

namespace CapaDatos
{
   public class accesoDatosComentarios
    {
        SqlConnection cnx; //Conexion 
        Comentarios s = new Comentarios(); //Capa Entidades 
        Conexion cn = new Conexion(); //Conexion
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar CRUD
        //Para cargar datos
        SqlDataReader dr = null;
        List<Comentarios> listaComentarios = null;
        public int insertarComentarios(Comentarios co)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion

                cm = new SqlCommand("comentar", cnx); //Nombre del procedimiento 
                cm.Parameters.AddWithValue("@b", 1); //Valores que toman los parametros
                cm.Parameters.AddWithValue("@idcomentario", ""); //del procedimiento
                cm.Parameters.AddWithValue("@nombres", co.nombres);
                cm.Parameters.AddWithValue("@correo", co.correo);
                cm.Parameters.AddWithValue("@telefono", co.telefono);
                cm.Parameters.AddWithValue("@mensaje", co.mensaje);

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

        public List<Comentarios> listarComentarios()
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("b", 3);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaComentarios = new List<Comentarios>(); //Lista de comentarios
                while (dr.Read()) //Recorrer cada registro
                {
                    Comentarios c = new Comentarios();
                    c.idcomentario = Convert.ToInt32(dr["idcomentario"].ToString());
                    c.nombres = dr["nombre"].ToString();
                    c.correo = dr["correo"].ToString();
                    c.telefono = dr["telefono"].ToString();
                    c.mensaje = dr["mensaje"].ToString();
                    listaComentarios.Add(c); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaComentarios = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaComentarios; //regresa lista de registros



        }

        public int eliminarComentarios(int idcoment)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idcomentario", idcoment); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", "");

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
        //Editar Comentarios
        public int EditarComentarios(Comentarios co)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("idcomentario", co.idcomentario); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("nombres", "");
                cm.Parameters.AddWithValue("correo", "");
                cm.Parameters.AddWithValue("telefono", "");
                cm.Parameters.AddWithValue("@mensaje", co.mensaje);

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

        //Buscar comentarios

        public List<Comentarios> BuscarComentarios(String dato)
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("b", 5);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", dato);
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaComentarios = new List<Comentarios>(); //Lista de comentarios
                while (dr.Read()) //Recorrer cada registro
                {
                    Comentarios c = new Comentarios();
                    c.idcomentario = Convert.ToInt32(dr["idcomentario"].ToString());
                    c.nombres = dr["nombre"].ToString();
                    c.correo = dr["correo"].ToString();
                    c.telefono = dr["telefono"].ToString();
                    c.mensaje = dr["mensaje"].ToString();
                    listaComentarios.Add(c); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaComentarios = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaComentarios; //regresa lista de registros

        }
    }
}
