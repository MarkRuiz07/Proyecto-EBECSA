using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacionWF
{
    public partial class fProspecto : Form
    {
        LogicaNegocioProspecto logicaNP = new LogicaNegocioProspecto();
        public fProspecto()
        {
            InitializeComponent();
        }

        private void fProspecto_Load(object sender, EventArgs e)
        {
            dataGridViewProspecto.DataSource = logicaNP.listarProspecto();
            textBoxID.Visible = false;
            lblid.Visible = false;
            
        }

       
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Text == "Guardar")
                {
                    Prospecto objProspecto = new Prospecto();
                    objProspecto.nombres = textBoxNombre.Text;
                    objProspecto.cedula = textBoxCedula.Text;
                    objProspecto.apellidoPaterno = textBoxApellido1.Text;
                    objProspecto.apellidoMaterno = textBoxApellido2.Text;
                    objProspecto.correoElectronico = textBoxCorreoE.Text;
                    objProspecto.TelefonP = textBoxTelefono.Text;

                    if (logicaNP.insertarProspecto(objProspecto) > 0)
                    {
                        MessageBox.Show("Agregado");
                        dataGridViewProspecto.DataSource = logicaNP.listarProspecto();
                        textBoxNombre.Text = "";
                        textBoxCedula.Text = "";
                        textBoxApellido1.Text = "";
                        textBoxApellido2.Text = "";
                        textBoxCorreoE.Text = "";
                        textBoxTelefono.Text = "";
                    }
                    else { MessageBox.Show("Error al Agregar"); }

                }

                if (btnGuardar.Text == "Actualizar")
                {

                    Prospecto objProspecto = new Prospecto();

                    objProspecto.idProspecto = Convert.ToInt32(textBoxID.Text);
                    objProspecto.nombres = textBoxNombre.Text;
                    objProspecto.apellidoPaterno = textBoxApellido1.Text;
                    objProspecto.apellidoMaterno = textBoxApellido2.Text;
                    objProspecto.cedula = textBoxCedula.Text;
                    objProspecto.correoElectronico = textBoxCorreoE.Text;
                    objProspecto.TelefonP = textBoxTelefono.Text;

                    if (logicaNP.EditarProspecto(objProspecto) > 0)
                    {
                        MessageBox.Show("Actualizado");

                        dataGridViewProspecto.DataSource = logicaNP.listarProspecto();

                        textBoxCedula.Text = "";
                        textBoxNombre.Text = "";
                        textBoxApellido1.Text = "";
                        textBoxApellido2.Text = "";
                        textBoxCorreoE.Text = "";
                        textBoxTelefono.Text = "";

                        tabconProspecto.SelectedTab = tabPageDetalleProspecto;

                    }
                    else
                    {
                        MessageBox.Show("Error al Actualizar Prospecto");
                    }

                    btnGuardar.Text = ("Guardar");
                }

            }
            catch
            {
                MessageBox.Show("ERROR");
            }

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Prospecto> listaProspecto = logicaNP.BuscarProspecto(textBoxBuscar.Text);
            dataGridViewProspecto.DataSource = listaProspecto;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            textBoxID.Visible = true;
            textBoxID.Enabled = false;
            lblid.Visible = true;

            //asigna datos seleccionados del data grid view a la caja de tx
            textBoxID.Text = dataGridViewProspecto.CurrentRow.Cells["idProspecto"].Value.ToString();
            textBoxCedula.Text = dataGridViewProspecto.CurrentRow.Cells["cedula"].Value.ToString();
            textBoxNombre.Text = dataGridViewProspecto.CurrentRow.Cells["nombres"].Value.ToString();
            textBoxApellido1.Text = dataGridViewProspecto.CurrentRow.Cells["apellidoPaterno"].Value.ToString();
            textBoxApellido2.Text = dataGridViewProspecto.CurrentRow.Cells["apellidoMaterno"].Value.ToString();
            textBoxCorreoE.Text = dataGridViewProspecto.CurrentRow.Cells["correoElectronico"].Value.ToString();
            textBoxTelefono.Text = dataGridViewProspecto.CurrentRow.Cells["TelefonP"].Value.ToString();

            tabconProspecto.SelectedTab = tabPageProspecto;
            btnGuardar.Text = "Actualizar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigoP = Convert.ToInt32(dataGridViewProspecto.CurrentRow.Cells["idProspecto"].Value.ToString());

            try
            {
                if (logicaNP.eliminarProspecto(codigoP) > 0)
                {
                    MessageBox.Show("Eliminado");
                    dataGridViewProspecto.DataSource = logicaNP.listarProspecto();
                }
            }
            catch
            {
                MessageBox.Show("Error al Eliminar");

            }
        }

        private void tabPageProspecto_Click(object sender, EventArgs e)
        {

        }

        private void textBoxApellido1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApellido1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewProspecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
