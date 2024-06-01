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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAzurirajRecenziju));
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
            this.lblOcjenaOkusa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOcjenaOkusa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcjenaOkusa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOcjenaOkusa.Location = new System.Drawing.Point(145, 122);
            this.lblOcjenaOkusa.Name = "lblOcjenaOkusa";
            this.lblOcjenaOkusa.Size = new System.Drawing.Size(107, 21);
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
            this.lblGlavnoJelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGlavnoJelo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlavnoJelo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGlavnoJelo.Location = new System.Drawing.Point(149, 80);
            this.lblGlavnoJelo.Name = "lblGlavnoJelo";
            this.lblGlavnoJelo.Size = new System.Drawing.Size(96, 21);
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
            this.lblSifraRecenzije.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSifraRecenzije.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifraRecenzije.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSifraRecenzije.Location = new System.Drawing.Point(145, 34);
            this.lblSifraRecenzije.Name = "lblSifraRecenzije";
            this.lblSifraRecenzije.Size = new System.Drawing.Size(115, 21);
            this.lblSifraRecenzije.TabIndex = 5;
            this.lblSifraRecenzije.Text = "Šifra recenzije: ";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(456, 370);
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
            this.lblDatumRecenzije.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDatumRecenzije.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRecenzije.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDatumRecenzije.Location = new System.Drawing.Point(137, 307);
            this.lblDatumRecenzije.Name = "lblDatumRecenzije";
            this.lblDatumRecenzije.Size = new System.Drawing.Size(124, 21);
            this.lblDatumRecenzije.TabIndex = 19;
            this.lblDatumRecenzije.Text = "Datum recenzije:";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKomentar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKomentar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKomentar.Location = new System.Drawing.Point(173, 225);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(83, 21);
            this.lblKomentar.TabIndex = 18;
            this.lblKomentar.Text = "Komentar:";
            // 
            // lblOcjenaKolicina
            // 
            this.lblOcjenaKolicina.AutoSize = true;
            this.lblOcjenaKolicina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOcjenaKolicina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcjenaKolicina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOcjenaKolicina.Location = new System.Drawing.Point(140, 173);
            this.lblOcjenaKolicina.Name = "lblOcjenaKolicina";
            this.lblOcjenaKolicina.Size = new System.Drawing.Size(119, 21);
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
            this.BackColor = System.Drawing.Color.Teal;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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