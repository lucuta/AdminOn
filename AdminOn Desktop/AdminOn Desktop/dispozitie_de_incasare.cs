﻿using System;
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
        public dispozitie_de_incasare()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
            MessageBox.Show("Sunteti sigur ca doriti sa ANULATI emiterea unei DISPOZITII de INCASARE?", "ATENTIE !!!", MessageBoxButtons.YesNoCancel))
            {
                this.Close();
            }
        }
    }
}
