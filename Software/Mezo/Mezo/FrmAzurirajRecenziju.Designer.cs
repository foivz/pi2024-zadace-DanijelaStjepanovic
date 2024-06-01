namespace Mezo
{
    partial class FrmAzurirajRecenziju
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
            this.lblOcjenaOkusa = new System.Windows.Forms.Label();
            this.cboGlavnoJelo = new System.Windows.Forms.ComboBox();
            this.lblGlavnoJelo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSifraRecenzije = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtDatumRecenzije = new System.Windows.Forms.TextBox();
            this.txtKomentar = new System.Windows.Forms.RichTextBox();
            this.lblDatumRecenzije = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.lblOcjenaKolicina = new System.Windows.Forms.Label();
            this.txtOcjenaKolicina = new System.Windows.Forms.TextBox();
            this.txtOcjenaOkusa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOcjenaOkusa
            // 
            this.lblOcjenaOkusa.AutoSize = true;
            this.lblOcjenaOkusa.Location = new System.Drawing.Point(159, 130);
            this.lblOcjenaOkusa.Name = "lblOcjenaOkusa";
            this.lblOcjenaOkusa.Size = new System.Drawing.Size(76, 13);
            this.lblOcjenaOkusa.TabIndex = 9;
            this.lblOcjenaOkusa.Text = "Ocjena okusa:";
            // 
            // cboGlavnoJelo
            // 
            this.cboGlavnoJelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGlavnoJelo.FormattingEnabled = true;
            this.cboGlavnoJelo.Location = new System.Drawing.Point(254, 80);
            this.cboGlavnoJelo.Name = "cboGlavnoJelo";
            this.cboGlavnoJelo.Size = new System.Drawing.Size(298, 21);
            this.cboGlavnoJelo.TabIndex = 8;
            // 
            // lblGlavnoJelo
            // 
            this.lblGlavnoJelo.AutoSize = true;
            this.lblGlavnoJelo.Location = new System.Drawing.Point(159, 88);
            this.lblGlavnoJelo.Name = "lblGlavnoJelo";
            this.lblGlavnoJelo.Size = new System.Drawing.Size(66, 13);
            this.lblGlavnoJelo.TabIndex = 7;
            this.lblGlavnoJelo.Text = "Glavno Jelo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSifraRecenzije
            // 
            this.lblSifraRecenzije.AutoSize = true;
            this.lblSifraRecenzije.Location = new System.Drawing.Point(159, 38);
            this.lblSifraRecenzije.Name = "lblSifraRecenzije";
            this.lblSifraRecenzije.Size = new System.Drawing.Size(79, 13);
            this.lblSifraRecenzije.TabIndex = 5;
            this.lblSifraRecenzije.Text = "Šifra recenzije: ";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(415, 370);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(176, 49);
            this.btnOdustani.TabIndex = 23;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(126, 370);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(176, 49);
            this.btnSpremi.TabIndex = 22;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtDatumRecenzije
            // 
            this.txtDatumRecenzije.Location = new System.Drawing.Point(251, 308);
            this.txtDatumRecenzije.Name = "txtDatumRecenzije";
            this.txtDatumRecenzije.ReadOnly = true;
            this.txtDatumRecenzije.Size = new System.Drawing.Size(299, 20);
            this.txtDatumRecenzije.TabIndex = 21;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(254, 226);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(298, 63);
            this.txtKomentar.TabIndex = 20;
            this.txtKomentar.Text = "";
            // 
            // lblDatumRecenzije
            // 
            this.lblDatumRecenzije.AutoSize = true;
            this.lblDatumRecenzije.Location = new System.Drawing.Point(159, 308);
            this.lblDatumRecenzije.Name = "lblDatumRecenzije";
            this.lblDatumRecenzije.Size = new System.Drawing.Size(86, 13);
            this.lblDatumRecenzije.TabIndex = 19;
            this.lblDatumRecenzije.Text = "Datum recenzije:";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(159, 229);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(55, 13);
            this.lblKomentar.TabIndex = 18;
            this.lblKomentar.Text = "Komentar:";
            // 
            // lblOcjenaKolicina
            // 
            this.lblOcjenaKolicina.AutoSize = true;
            this.lblOcjenaKolicina.Location = new System.Drawing.Point(159, 174);
            this.lblOcjenaKolicina.Name = "lblOcjenaKolicina";
            this.lblOcjenaKolicina.Size = new System.Drawing.Size(83, 13);
            this.lblOcjenaKolicina.TabIndex = 17;
            this.lblOcjenaKolicina.Text = "Ocjena količine:";
            // 
            // txtOcjenaKolicina
            // 
            this.txtOcjenaKolicina.Location = new System.Drawing.Point(254, 174);
            this.txtOcjenaKolicina.Name = "txtOcjenaKolicina";
            this.txtOcjenaKolicina.Size = new System.Drawing.Size(299, 20);
            this.txtOcjenaKolicina.TabIndex = 16;
            this.txtOcjenaKolicina.TextChanged += new System.EventHandler(this.txtOcjenaKolicina_TextChanged);
            // 
            // txtOcjenaOkusa
            // 
            this.txtOcjenaOkusa.Location = new System.Drawing.Point(254, 123);
            this.txtOcjenaOkusa.Name = "txtOcjenaOkusa";
            this.txtOcjenaOkusa.Size = new System.Drawing.Size(299, 20);
            this.txtOcjenaOkusa.TabIndex = 15;
            this.txtOcjenaOkusa.TextChanged += new System.EventHandler(this.txtOcjenaOkusa_TextChanged);
            // 
            // FrmAzurirajRecenziju
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSifraRecenzije);
            this.Name = "FrmAzurirajRecenziju";
            this.Text = "Ažuriraj postojeću recenziju";
            this.Load += new System.EventHandler(this.FrmAzurirajRecenziju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOcjenaOkusa;
        private System.Windows.Forms.ComboBox cboGlavnoJelo;
        private System.Windows.Forms.Label lblGlavnoJelo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSifraRecenzije;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtDatumRecenzije;
        private System.Windows.Forms.RichTextBox txtKomentar;
        private System.Windows.Forms.Label lblDatumRecenzije;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.Label lblOcjenaKolicina;
        private System.Windows.Forms.TextBox txtOcjenaKolicina;
        private System.Windows.Forms.TextBox txtOcjenaOkusa;
    }
}