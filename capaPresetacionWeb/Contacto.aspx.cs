using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidades;

namespace capaPresetacionWeb
{
    public partial class Contacto : System.Web.UI.Page
    {
        Comentarios CE = new Comentarios();
        log
        logicaNegocioCometarios CN = new LogicaNegocioCometarios();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btcontacto_Click(object sender, EventArgs e)
        {try
            {
                //asignando valores de los cuadros de texto
                CE.nombres = txtnombres.Value;
                CE.correo = txtcorreo.Value;
                CE.telefono = txttelefono.Value;
                CE.mensaje = txtmensaje.Value;

                //llama al metodo insertar con el objeto comentarios como parametro

                if (CN.insertarComentarios(CE)==1)
                {
                    indicador.Text = "Enviado!!!";
                    indicador.CssClass = "label label-success";

                    txtnombres.Value = "";
                    txtcorreo.Value = "";
                    txtmensaje.Value = "";
                    txttelefono.Value = "";
                }
                else
                {
                    //Etiqueta
                    indicador.Text = "Error al enviar";
                    indicador.CssClass="label label-danger";
                }

                catch (Exception ex)
                {
                //muestra en la etiqueta la excepcion ocurrida
                    indicador.Text=ex.Message.ToString();
                }

            }
        }
    }
}