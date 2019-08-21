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
    public partial class DetallesCotizacion : Form
    {
        LogicaNegocioProspecto logicaNP = new LogicaNegocioProspecto();
        LogicaNegocioVehiculo logicaNV = new LogicaNegocioVehiculo();
        LogicaNegocioCobertura logicaNC = new LogicaNegocioCobertura();
        LogicaNegocioSeguros logicaNS = new LogicaNegocioSeguros();
        public DetallesCotizacion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Cotización enviada con éxito", "Envío de cotización", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void DetallesCotizacion_Load(object sender, EventArgs e)
        {

            try
            {
                dataGridViewCotizar.DataSource = logicaNP.mostrarDetalles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void txtTipoVeh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCirc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelef_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio1 fm = new Inicio1(); //abre un nuevo formulario y cierra el principal sin terminar la ejecucion 
            this.Hide();
            fm.ShowDialog();
            this.Close();//para cerrar 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

        
    

