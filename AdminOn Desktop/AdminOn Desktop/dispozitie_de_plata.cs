using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminOn_Desktop
{
    public partial class dispozitie_de_plata : Form
    {
        public dispozitie_de_plata()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
            MessageBox.Show("Sunteti sigur ca doriti sa ANULATI emiterea unei DISPOZITII de PLATA?", "ATENTIE !!!", MessageBoxButtons.YesNoCancel))
            {
                this.Close();
            }
        }
    }
}
