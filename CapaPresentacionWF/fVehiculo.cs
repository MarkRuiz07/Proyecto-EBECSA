using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacionWF
{
    public partial class FVehiculo : Form
    {
        LogicaNegocioVehiculo logicaNV = new LogicaNegocioVehiculo();
        public FVehiculo()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Registrar")
                {
                    Vehiculo objetoVehiculo = new Vehiculo();
                    objetoVehiculo.marca = textBoxMarca.Text;
                    objetoVehiculo.modelo = textBoxModelo.Text;
                    objetoVehiculo.color = textBoxColor.Text;
                    objetoVehiculo.colorSecundario = textBoxColorSecun.Text;
                    objetoVehiculo.añoFabricacion = Convert.ToInt32(textBoxAñoFab.Text);
                    objetoVehiculo.VersionCaracteristicas = textBoxVersionCar.Text;
                    objetoVehiculo.NumeroPasajeros = Convert.ToInt32(textBoxNumPas.Text);
                    objetoVehiculo.NumeroCirculacion = textBoxCirculacion.Text;
                    objetoVehiculo.idProspecto = Convert.ToInt32(comboBoxidProspecto.Text);
                    objetoVehiculo.idcategoria = Convert.ToInt32(comboBoxidCategoria.Text);
                    objetoVehiculo.idseguros = Convert.ToInt32(comboBoxidSeguros.Text);

                    if (logicaNV.insertarVehiculo(objetoVehiculo) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewVehiculo.DataSource = logicaNV.listarVehiculo();
                        textBoxMarca.Text = "";
                        textBoxModelo.Text = "";
                        textBoxColor.Text = "";
                        textBoxColorSecun.Text = "";
                        textBoxAñoFab.Text = "";
                        textBoxVersionCar.Text = "";
                        textBoxNumPas.Text = "";
                        textBoxCirculacion.Text = "";
                        comboBoxidProspecto.Text = "";
                        comboBoxidCategoria.Text = "";
                        comboBoxidSeguros.Text = "";
                        tabControlVehiculo.SelectedTab = tabPage2;

                    }
                    else
                    {
                        MessageBox.Show("Error al agregar dato");
                    }


                }

                if (buttonGuardar.Text== "Actualizar")
                {
                    Vehiculo objetoVehiculo = new Vehiculo();
                    objetoVehiculo.idVehiculo = Convert.ToInt32(textBoxID.Text);
                    objetoVehiculo.marca = textBoxMarca.Text;
                    objetoVehiculo.modelo = textBoxModelo.Text;
                    objetoVehiculo.color = textBoxColor.Text;
                    objetoVehiculo.colorSecundario = textBoxColorSecun.Text;
                    objetoVehiculo.añoFabricacion = Convert.ToInt32(textBoxAñoFab.Text);
                    objetoVehiculo.VersionCaracteristicas = textBoxVersionCar.Text;
                    objetoVehiculo.NumeroPasajeros = Convert.ToInt32(textBoxNumPas.Text);
                    objetoVehiculo.NumeroCirculacion = textBoxCirculacion.Text;

                    if (logicaNV.EditarVehiculo(objetoVehiculo)>0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewVehiculo.DataSource = logicaNV.listarVehiculo();
                        textBoxMarca.Text = "";
                        textBoxModelo.Text = "";
                        textBoxColor.Text = "";
                        textBoxColorSecun.Text = "";
                        textBoxAñoFab.Text = "";
                        textBoxVersionCar.Text = "";
                        textBoxNumPas.Text = "";
                        textBoxCirculacion.Text = "";
                        tabControlVehiculo.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar dato");
                    }
                    buttonGuardar.Text = "Registrar";
                }
               
            }
            catch 
            {
                MessageBox.Show("ERROR");
            }

        }

        private void FVehiculo_Load(object sender, EventArgs e)
        {
            textBoxID.Visible = false;
            labelID.Visible = false;
            dataGridViewVehiculo.DataSource = logicaNV.listarVehiculo();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoR = Convert.ToInt32(dataGridViewVehiculo.CurrentRow.Cells["idVehiculo"].Value.ToString());
            try
            {
                if (logicaNV.eliminarVehiculo(codigoR)>0)
                {
                    MessageBox.Show("Eliminado con éxito!");
                    dataGridViewVehiculo.DataSource = logicaNV.listarVehiculo();
                }

            }
            catch 
            {

                MessageBox.Show("ERROR al eliminar dato");
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxID.Visible = true;
            textBoxID.Enabled = false;
            labelID.Visible = true;

            textBoxID.Text = dataGridViewVehiculo.CurrentRow.Cells["idVehiculo"].Value.ToString();
            textBoxMarca.Text = dataGridViewVehiculo.CurrentRow.Cells["marca"].Value.ToString();
            textBoxModelo.Text = dataGridViewVehiculo.CurrentRow.Cells["modelo"].Value.ToString();
            textBoxColor.Text = dataGridViewVehiculo.CurrentRow.Cells["color"].Value.ToString();
            textBoxColorSecun.Text = dataGridViewVehiculo.CurrentRow.Cells["colorSecundario"].Value.ToString();
            textBoxAñoFab.Text = dataGridViewVehiculo.CurrentRow.Cells["añoFabricacion"].Value.ToString();
            textBoxVersionCar.Text = dataGridViewVehiculo.CurrentRow.Cells["VersionCaracteristicas"].Value.ToString();
            textBoxNumPas.Text = dataGridViewVehiculo.CurrentRow.Cells["NumeroPasajeros"].Value.ToString();
            textBoxCirculacion.Text = dataGridViewVehiculo.CurrentRow.Cells["NumeroCirculacion"].Value.ToString();
            tabControlVehiculo.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Vehiculo> listaVehiculo = logicaNV.BuscarVehiculo(textBoxBuscar.Text);
            dataGridViewVehiculo.DataSource = listaVehiculo;
        }

        private void dataGridViewVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelCircu_Click(object sender, EventArgs e)
        {

        }
    }
}
