namespace Mezo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajRecenziju));
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
            this.lblSifraRecenzije.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifraRecenzije.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSifraRecenzije.Location = new System.Drawing.Point(136, 33);
            this.lblSifraRecenzije.Name = "lblSifraRecenzije";
            this.lblSifraRecenzije.Size = new System.Drawing.Size(113, 19);
            this.lblSifraRecenzije.TabIndex = 0;
            this.lblSifraRecenzije.Text = "Šifra recenzije: ";
            // 
            // txtSifraRecenzije
            // 
            this.txtSifraRecenzije.Location = new System.Drawing.Point(253, 32);
            this.txtSifraRecenzije.Name = "txtSifraRecenzije";
            this.txtSifraRecenzije.Size = new System.Drawing.Size(299, 20);
            this.txtSifraRecenzije.TabIndex = 1;
            this.txtSifraRecenzije.TextChanged += new System.EventHandler(this.txtSifraRecenzije_TextChanged);
            // 
            // lblGlavnoJelo
            // 
            this.lblGlavnoJelo.AutoSize = true;
            this.lblGlavnoJelo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlavnoJelo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGlavnoJelo.Location = new System.Drawing.Point(136, 83);
            this.lblGlavnoJelo.Name = "lblGlavnoJelo";
            this.lblGlavnoJelo.Size = new System.Drawing.Size(94, 19);
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
            this.lblOcjenaOkusa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcjenaOkusa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOcjenaOkusa.Location = new System.Drawing.Point(136, 125);
            this.lblOcjenaOkusa.Name = "lblOcjenaOkusa";
            this.lblOcjenaOkusa.Size = new System.Drawing.Size(105, 19);
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
            this.lblOcjenaKolicina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcjenaKolicina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOcjenaKolicina.Location = new System.Drawing.Point(136, 173);
            this.lblOcjenaKolicina.Name = "lblOcjenaKolicina";
            this.lblOcjenaKolicina.Size = new System.Drawing.Size(117, 19);
            this.lblOcjenaKolicina.TabIndex = 7;
            this.lblOcjenaKolicina.Text = "Ocjena količine:";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKomentar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKomentar.Location = new System.Drawing.Point(136, 228);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(81, 19);
            this.lblKomentar.TabIndex = 8;
            this.lblKomentar.Text = "Komentar:";
            // 
            // lblDatumRecenzije
            // 
            this.lblDatumRecenzije.AutoSize = true;
            this.lblDatumRecenzije.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRecenzije.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDatumRecenzije.Location = new System.Drawing.Point(136, 307);
            this.lblDatumRecenzije.Name = "lblDatumRecenzije";
            this.lblDatumRecenzije.Size = new System.Drawing.Size(122, 19);
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
            this.btnSpremi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSpremi.Location = new System.Drawing.Point(125, 371);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(176, 49);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnOdustani.Location = new System.Drawing.Point(431, 371);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(176, 49);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmDodajRecenziju
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
            this.Controls.Add(this.txtSifraRecenzije);
            this.Controls.Add(this.lblSifraRecenzije);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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