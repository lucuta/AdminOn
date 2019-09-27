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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dispozitieDePlataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dispozitie_de_plata form2 = new dispozitie_de_plata();
            form2.Show();
        }

        private void exitIesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
            MessageBox.Show("Sunteti sigur ca doriti sa INCHIDETI aplicatia AdminOn Desktop?", "ATENTIE !!!", MessageBoxButtons.YesNoCancel))
            {
                this.Close();
            }
        }
    }
}
