﻿namespace Mezo
{
    partial class FrmDodajRecenziju
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
            this.lblSifraRecenzije = new System.Windows.Forms.Label();
            this.txtSifraRecenzije = new System.Windows.Forms.TextBox();
            this.lblGlavnoJelo = new System.Windows.Forms.Label();
            this.cboGlavnoJelo = new System.Windows.Forms.ComboBox();
            this.lblOcjenaOkusa = new System.Windows.Forms.Label();
            this.txtOcjenaOkusa = new System.Windows.Forms.TextBox();
            this.txtOcjenaKolicina = new System.Windows.Forms.TextBox();
            this.lblOcjenaKolicina = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.lblDatumRecenzije = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.RichTextBox();
            this.txtDatumRecenzije = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSifraRecenzije
            // 
            this.lblSifraRecenzije.AutoSize = true;
            this.lblSifraRecenzije.Location = new System.Drawing.Point(158, 35);
            this.lblSifraRecenzije.Name = "lblSifraRecenzije";
            this.lblSifraRecenzije.Size = new System.Drawing.Size(79, 13);
            this.lblSifraRecenzije.TabIndex = 0;
            this.lblSifraRecenzije.Text = "Šifra recenzije: ";
            // 
            // txtSifraRecenzije
            // 
            this.txtSifraRecenzije.Location = new System.Drawing.Point(253, 32);
            this.txtSifraRecenzije.Name = "txtSifraRecenzije";
            this.txtSifraRecenzije.Size = new System.Drawing.Size(299, 20);
            this.txtSifraRecenzije.TabIndex = 1;
            // 
            // lblGlavnoJelo
            // 
            this.lblGlavnoJelo.AutoSize = true;
            this.lblGlavnoJelo.Location = new System.Drawing.Point(158, 85);
            this.lblGlavnoJelo.Name = "lblGlavnoJelo";
            this.lblGlavnoJelo.Size = new System.Drawing.Size(66, 13);
            this.lblGlavnoJelo.TabIndex = 2;
            this.lblGlavnoJelo.Text = "Glavno Jelo:";
            // 
            // cboGlavnoJelo
            // 
            this.cboGlavnoJelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGlavnoJelo.FormattingEnabled = true;
            this.cboGlavnoJelo.Location = new System.Drawing.Point(253, 77);
            this.cboGlavnoJelo.Name = "cboGlavnoJelo";
            this.cboGlavnoJelo.Size = new System.Drawing.Size(298, 21);
            this.cboGlavnoJelo.TabIndex = 3;
            // 
            // lblOcjenaOkusa
            // 
            this.lblOcjenaOkusa.AutoSize = true;
            this.lblOcjenaOkusa.Location = new System.Drawing.Point(158, 127);
            this.lblOcjenaOkusa.Name = "lblOcjenaOkusa";
            this.lblOcjenaOkusa.Size = new System.Drawing.Size(76, 13);
            this.lblOcjenaOkusa.TabIndex = 4;
            this.lblOcjenaOkusa.Text = "Ocjena okusa:";
            // 
            // txtOcjenaOkusa
            // 
            this.txtOcjenaOkusa.Location = new System.Drawing.Point(253, 124);
            this.txtOcjenaOkusa.Name = "txtOcjenaOkusa";
            this.txtOcjenaOkusa.Size = new System.Drawing.Size(299, 20);
            this.txtOcjenaOkusa.TabIndex = 5;
            this.txtOcjenaOkusa.TextChanged += new System.EventHandler(this.txtOcjenaOkusa_TextChanged);
            // 
            // txtOcjenaKolicina
            // 
            this.txtOcjenaKolicina.Location = new System.Drawing.Point(253, 175);
            this.txtOcjenaKolicina.Name = "txtOcjenaKolicina";
            this.txtOcjenaKolicina.Size = new System.Drawing.Size(299, 20);
            this.txtOcjenaKolicina.TabIndex = 6;
            this.txtOcjenaKolicina.TextChanged += new System.EventHandler(this.txtOcjenaKolicina_TextChanged);
            // 
            // lblOcjenaKolicina
            // 
            this.lblOcjenaKolicina.AutoSize = true;
            this.lblOcjenaKolicina.Location = new System.Drawing.Point(158, 175);
            this.lblOcjenaKolicina.Name = "lblOcjenaKolicina";
            this.lblOcjenaKolicina.Size = new System.Drawing.Size(83, 13);
            this.lblOcjenaKolicina.TabIndex = 7;
            this.lblOcjenaKolicina.Text = "Ocjena količine:";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(158, 230);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(55, 13);
            this.lblKomentar.TabIndex = 8;
            this.lblKomentar.Text = "Komentar:";
            // 
            // lblDatumRecenzije
            // 
            this.lblDatumRecenzije.AutoSize = true;
            this.lblDatumRecenzije.Location = new System.Drawing.Point(158, 309);
            this.lblDatumRecenzije.Name = "lblDatumRecenzije";
            this.lblDatumRecenzije.Size = new System.Drawing.Size(86, 13);
            this.lblDatumRecenzije.TabIndex = 9;
            this.lblDatumRecenzije.Text = "Datum recenzije:";
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(253, 227);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(298, 63);
            this.txtKomentar.TabIndex = 10;
            this.txtKomentar.Text = "";
            // 
            // txtDatumRecenzije
            // 
            this.txtDatumRecenzije.Location = new System.Drawing.Point(250, 309);
            this.txtDatumRecenzije.Name = "txtDatumRecenzije";
            this.txtDatumRecenzije.ReadOnly = true;
            this.txtDatumRecenzije.Size = new System.Drawing.Size(299, 20);
            this.txtDatumRecenzije.TabIndex = 11;
            this.txtDatumRecenzije.TextChanged += new System.EventHandler(this.txtDatumRecenzije_TextChanged);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(125, 371);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(176, 49);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(414, 371);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(176, 49);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // FrmDodajRecenziju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtDatumRecenzije);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.lblDatumRecenzije);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.lblOcjenaKolicina);
            this.Controls.Add(this.txtOcjenaKolicina);
            this.Controls.Add(this.txtOcjenaOkusa);
            this.Controls.Add(this.lblOcjenaOkusa);
            this.Controls.Add(this.cboGlavnoJelo);
            this.Controls.Add(this.lblGlavnoJelo);
            this.Controls.Add(this.txtSifraRecenzije);
            this.Controls.Add(this.lblSifraRecenzije);
            this.Name = "FrmDodajRecenziju";
            this.Text = "Nova Recenzija";
            this.Load += new System.EventHandler(this.FrmDodajRecenziju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifraRecenzije;
        private System.Windows.Forms.TextBox txtSifraRecenzije;
        private System.Windows.Forms.Label lblGlavnoJelo;
        private System.Windows.Forms.ComboBox cboGlavnoJelo;
        private System.Windows.Forms.Label lblOcjenaOkusa;
        private System.Windows.Forms.TextBox txtOcjenaOkusa;
        private System.Windows.Forms.TextBox txtOcjenaKolicina;
        private System.Windows.Forms.Label lblOcjenaKolicina;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.Label lblDatumRecenzije;
        private System.Windows.Forms.RichTextBox txtKomentar;
        private System.Windows.Forms.TextBox txtDatumRecenzije;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}