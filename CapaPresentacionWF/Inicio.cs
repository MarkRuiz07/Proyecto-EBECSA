using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionWF
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void picBoxInicio_Click(object sender, EventArgs e)
        {
            Inicio1 fm = new Inicio1(); //abre un nuevo formulario y cierra el principal sin terminar la ejecucion 
            this.Hide();
            fm.ShowDialog();
            this.Close();//para cerrar 
            
        }
    }
}
