namespace AdminOn_Desktop
{
    partial class dispozitie_de_plata
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.text_disp_plata_nr = new System.Windows.Forms.Label();
            this.data_dispozitie_plata = new System.Windows.Forms.DateTimePicker();
            this.text_disp_plata_din_data_de = new System.Windows.Forms.Label();
            this.nr_dispozitie_plata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dispozitie de PLATA catre Caserie";
            // 
            // text_disp_plata_nr
            // 
            this.text_disp_plata_nr.AutoSize = true;
            this.text_disp_plata_nr.Location = new System.Drawing.Point(251, 72);
            this.text_disp_plata_nr.Name = "text_disp_plata_nr";
            this.text_disp_plata_nr.Size = new System.Drawing.Size(21, 13);
            this.text_disp_plata_nr.TabIndex = 1;
            this.text_disp_plata_nr.Text = "Nr.";
            // 
            // data_dispozitie_plata
            // 
            this.data_dispozitie_plata.Location = new System.Drawing.Point(492, 66);
            this.data_dispozitie_plata.Name = "data_dispozitie_plata";
            this.data_dispozitie_plata.Size = new System.Drawing.Size(200, 20);
            this.data_dispozitie_plata.TabIndex = 2;
            // 
            // text_disp_plata_din_data_de
            // 
            this.text_disp_plata_din_data_de.AutoSize = true;
            this.text_disp_plata_din_data_de.Location = new System.Drawing.Point(420, 72);
            this.text_disp_plata_din_data_de.Name = "text_disp_plata_din_data_de";
            this.text_disp_plata_din_data_de.Size = new System.Drawing.Size(66, 13);
            this.text_disp_plata_din_data_de.TabIndex = 3;
            this.text_disp_plata_din_data_de.Text = "din data de :";
            // 
            // nr_dispozitie_plata
            // 
            this.nr_dispozitie_plata.Location = new System.Drawing.Point(278, 65);
            this.nr_dispozitie_plata.Name = "nr_dispozitie_plata";
            this.nr_dispozitie_plata.Size = new System.Drawing.Size(136, 20);
            this.nr_dispozitie_plata.TabIndex = 4;
            // 
            // dispozitie_de_plata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 413);
            this.Controls.Add(this.nr_dispozitie_plata);
            this.Controls.Add(this.text_disp_plata_din_data_de);
            this.Controls.Add(this.data_dispozitie_plata);
            this.Controls.Add(this.text_disp_plata_nr);
            this.Controls.Add(this.label1);
            this.Name = "dispozitie_de_plata";
            this.Text = "dispozitie_de_plata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text_disp_plata_nr;
        private System.Windows.Forms.DateTimePicker data_dispozitie_plata;
        private System.Windows.Forms.Label text_disp_plata_din_data_de;
        private System.Windows.Forms.TextBox nr_dispozitie_plata;
    }
}