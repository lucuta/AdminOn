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
            this.ActiveControl = serie_disp_plata;
            serie_disp_plata.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                }
            }
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                }
            }

        }

        private void serie_disp_plata_TextChanged(object sender, EventArgs e)
        {

        }

        private void nr_act_id_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                cnp_disp_plata.Focus();

            }
        }

        private void serie_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                nr_disp_plata.Focus();

            }
        }

        private void nr_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                cifre_disp_incasare.Focus();

            }
            
        }

        private void scop_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                data_disp_plata.Focus();

            }
            
        }

        private void data_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                nume_disp_plata.Focus();

            }
        }

        private void nume_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                functia_disp_plata.Focus();

            }
        }

        private void functia_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                tip_act_disp_plata.Focus();

            }
        }

        private void tip_act_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                serie_act_id_disp_plata.Focus();

            }
        }

        private void serie_act_id_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                nr_act_id_disp_plata.Focus();

            }
        }

        private void nr_act_id_disp_plata_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cnp_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                adresa_disp_plata.Focus();

            }
        }

        private void adresa_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            button_emitereplata.Focus();
        }

        private void cifre_disp_incasare_KeyDown(object sender, KeyEventArgs e)
        {
            scop_disp_plata.Focus();
        }
    }
}
