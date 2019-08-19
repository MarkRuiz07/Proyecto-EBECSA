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
    public partial class Inicio1 : Form
    {
        public Inicio1()
        {
            InitializeComponent();
        }

        private void Inicio1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fProspecto fp = new fProspecto();
            fp.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fProspecto fp = new fProspecto();
            fp.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fProspecto fp = new fProspecto();
            fp.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            fProspecto fp = new fProspecto();
            fp.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
