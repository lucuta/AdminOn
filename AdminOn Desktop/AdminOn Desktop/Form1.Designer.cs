﻿using System;

namespace AdminOn_Desktop
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaOAsociatieNouaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashBoarCentralizatoareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitIesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venituriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaFacturaDeLaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispozitieDeIncasareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheltuieliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaFacturaDeLaFurnizorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispozitieDePlataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatiuniBancareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registruDeBancaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCheltuieliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.venituriToolStripMenuItem,
            this.cheltuieliToolStripMenuItem,
            this.bancaToolStripMenuItem,
            this.listaDeCheltuieliToolStripMenuItem,
            this.rapoarteToolStripMenuItem,
            this.despreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaOAsociatieNouaToolStripMenuItem,
            this.dashBoarCentralizatoareToolStripMenuItem,
            this.exitIesireToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // adaugaOAsociatieNouaToolStripMenuItem
            // 
            this.adaugaOAsociatieNouaToolStripMenuItem.Name = "adaugaOAsociatieNouaToolStripMenuItem";
            this.adaugaOAsociatieNouaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.adaugaOAsociatieNouaToolStripMenuItem.Text = "Adauga o Asociatie Noua";
            // 
            // dashBoarCentralizatoareToolStripMenuItem
            // 
            this.dashBoarCentralizatoareToolStripMenuItem.Name = "dashBoarCentralizatoareToolStripMenuItem";
            this.dashBoarCentralizatoareToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.dashBoarCentralizatoareToolStripMenuItem.Text = "DashBoar / Centralizatoare";
            // 
            // exitIesireToolStripMenuItem
            // 
            this.exitIesireToolStripMenuItem.Name = "exitIesireToolStripMenuItem";
            this.exitIesireToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.exitIesireToolStripMenuItem.Text = "Exit / Iesire";
            this.exitIesireToolStripMenuItem.Click += new System.EventHandler(this.exitIesireToolStripMenuItem_Click);
            // 
            // venituriToolStripMenuItem
            // 
            this.venituriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientiToolStripMenuItem,
            this.adaugaFacturaDeLaClientiToolStripMenuItem,
            this.dispozitieDeIncasareToolStripMenuItem});
            this.venituriToolStripMenuItem.Name = "venituriToolStripMenuItem";
            this.venituriToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.venituriToolStripMenuItem.Text = "Venituri";
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.clientiToolStripMenuItem.Text = "Clienti";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // adaugaFacturaDeLaClientiToolStripMenuItem
            // 
            this.adaugaFacturaDeLaClientiToolStripMenuItem.Name = "adaugaFacturaDeLaClientiToolStripMenuItem";
            this.adaugaFacturaDeLaClientiToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.adaugaFacturaDeLaClientiToolStripMenuItem.Text = "Adauga Factura de la Client";
            // 
            // dispozitieDeIncasareToolStripMenuItem
            // 
            this.dispozitieDeIncasareToolStripMenuItem.Name = "dispozitieDeIncasareToolStripMenuItem";
            this.dispozitieDeIncasareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.dispozitieDeIncasareToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.dispozitieDeIncasareToolStripMenuItem.Text = "Dispozitie de Incasare";
            this.dispozitieDeIncasareToolStripMenuItem.Click += new System.EventHandler(this.dispozitieDeIncasareToolStripMenuItem_Click);
            // 
            // cheltuieliToolStripMenuItem
            // 
            this.cheltuieliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.furnizoriToolStripMenuItem,
            this.adaugaFacturaDeLaFurnizorToolStripMenuItem,
            this.dispozitieDePlataToolStripMenuItem});
            this.cheltuieliToolStripMenuItem.Name = "cheltuieliToolStripMenuItem";
            this.cheltuieliToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cheltuieliToolStripMenuItem.Text = "Cheltuieli";
            // 
            // furnizoriToolStripMenuItem
            // 
            this.furnizoriToolStripMenuItem.Name = "furnizoriToolStripMenuItem";
            this.furnizoriToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.furnizoriToolStripMenuItem.Text = "Furnizori";
            this.furnizoriToolStripMenuItem.Click += new System.EventHandler(this.furnizoriToolStripMenuItem_Click);
            // 
            // adaugaFacturaDeLaFurnizorToolStripMenuItem
            // 
            this.adaugaFacturaDeLaFurnizorToolStripMenuItem.Name = "adaugaFacturaDeLaFurnizorToolStripMenuItem";
            this.adaugaFacturaDeLaFurnizorToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.adaugaFacturaDeLaFurnizorToolStripMenuItem.Text = "Adauga Factura de la Furnizor";
            // 
            // dispozitieDePlataToolStripMenuItem
            // 
            this.dispozitieDePlataToolStripMenuItem.Name = "dispozitieDePlataToolStripMenuItem";
            this.dispozitieDePlataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.dispozitieDePlataToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.dispozitieDePlataToolStripMenuItem.Text = "Dispozitie de Plata";
            this.dispozitieDePlataToolStripMenuItem.Click += new System.EventHandler(this.dispozitieDePlataToolStripMenuItem_Click);
            // 
            // bancaToolStripMenuItem
            // 
            this.bancaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatiuniBancareToolStripMenuItem,
            this.registruDeBancaToolStripMenuItem});
            this.bancaToolStripMenuItem.Name = "bancaToolStripMenuItem";
            this.bancaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.bancaToolStripMenuItem.Text = "Banca";
            // 
            // operatiuniBancareToolStripMenuItem
            // 
            this.operatiuniBancareToolStripMenuItem.Name = "operatiuniBancareToolStripMenuItem";
            this.operatiuniBancareToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.operatiuniBancareToolStripMenuItem.Text = "Operatiuni Bancare";
            // 
            // registruDeBancaToolStripMenuItem
            // 
            this.registruDeBancaToolStripMenuItem.Name = "registruDeBancaToolStripMenuItem";
            this.registruDeBancaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registruDeBancaToolStripMenuItem.Text = "Registru de Banca";
            // 
            // listaDeCheltuieliToolStripMenuItem
            // 
            this.listaDeCheltuieliToolStripMenuItem.Name = "listaDeCheltuieliToolStripMenuItem";
            this.listaDeCheltuieliToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.listaDeCheltuieliToolStripMenuItem.Text = "Lista de Cheltuieli";
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.despreToolStripMenuItem.Text = "Despre";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(68, 26);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 391);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminOn - Desktop - Complet Edition";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaOAsociatieNouaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashBoarCentralizatoareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitIesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venituriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheltuieliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCheltuieliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispozitieDePlataToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispozitieDeIncasareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaFacturaDeLaClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaFacturaDeLaFurnizorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatiuniBancareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registruDeBancaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnizoriToolStripMenuItem;
    }
}

