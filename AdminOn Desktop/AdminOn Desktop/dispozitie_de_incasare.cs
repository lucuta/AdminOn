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
    public partial class dispozitie_de_incasare : Form
    {
        String numereincuvinte = "";
        numarincuvinte nrincv = new numarincuvinte();
        public dispozitie_de_incasare()
        {
            InitializeComponent();
            cifre_disp_incasare.MaxLength = 9;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelnrincv_Click(object sender, EventArgs e)
        {

        }

        private void cifre_disp_incasare_TextChanged(object sender, EventArgs e)
        {

        }



        // Aceasta functie activeaza butonul de ANULARE disp incasare si inchide fereastra

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
            MessageBox.Show("Sunteti sigur ca doriti sa ANULATI emiterea unei DISPOZITII de INCASARE?", "ATENTIE !!!", MessageBoxButtons.YesNoCancel))
            {
                this.Close();
            }
        }

        private void text_disp_plata_din_data_de_Click(object sender, EventArgs e)
        {

        }



        private void cifre_disp_incasare_TextChanged_1(object sender, EventArgs e)
        {
            numereincuvinte = cifre_disp_incasare.Text;
            if (numereincuvinte != "")
            {
                labelnrincv.Text = numarincuvinte.NumberToWords(Convert.ToInt32(numereincuvinte));

            }
            else
                labelnrincv.Text = "- - -";
        }

        private void scop_disp_plata_TextChanged(object sender, EventArgs e)
        {

        }

        private void cifre_disp_incasare_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!char.IsNumber(e.KeyChar) && chr != 8)
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
