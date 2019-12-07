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
        String numereincuvinte = "";
        numarincuvinte nrincv = new numarincuvinte();
        
        public dispozitie_de_plata()
        {
            InitializeComponent();
            cifre_disp_plata.MaxLength = 9;
            this.ActiveControl = serie_disp_plata;
            serie_disp_plata.Focus();
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

        // Aceasta functie activeaza butonul de ANULARE disp plata si inchide fereastra

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
            MessageBox.Show("Sunteti sigur ca doriti sa ANULATI emiterea unei DISPOZITII de PLATA?", "ATENTIE !!!", MessageBoxButtons.YesNoCancel))
            {
                this.Close();
            }
        }
        //


        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            numereincuvinte = cifre_disp_plata.Text;
            if (numereincuvinte != "")
            {
                labelnrincv.Text = numarincuvinte.NumberToWords(Convert.ToInt32(numereincuvinte));

            }
            else
                labelnrincv.Text = "- - -";
        }

        private void dispozitie_de_plata_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            Char chr = e.KeyChar;
           
            if (!char.IsNumber(e.KeyChar)&&chr!=8)
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
                
            }
         

           





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
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

        private void serie_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter==e.KeyCode||Keys.Tab==e.KeyCode)
            {
                nr_disp_plata.Focus();

            }
        }

        private void nr_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                cifre_disp_plata.Focus();

            }
            
        }

        private void scop_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                data_disp_plata.Focus();
            }
        }

        private void data_disp_plata_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nume_disp_plata_TextChanged(object sender, EventArgs e)
        {

        }

        private void nume_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {

            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                functia_disp_plata.Focus();

            }

        }

        private void cifre_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                scop_disp_plata.Focus();

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

        private void cnp_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                adresa_disp_plata.Focus();

            }
        }

        private void serie_act_id_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                nr_act_id_disp_plata.Focus();

            }
        }

        private void nr_act_id_disp_plata_TextChanged(object sender, EventArgs e)
        {

        }

        private void nr_act_id_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                cnp_disp_plata.Focus();

            }
        }

        private void adresa_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                button_emitere_dplata.Focus();

            }
            
        }

        private void data_disp_plata_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Tab == e.KeyCode)
            {
                nume_disp_plata.Focus();

            }
            
        }

        private void button_emitere_dplata_Click(object sender, EventArgs e)
        {

        }
    }
}
