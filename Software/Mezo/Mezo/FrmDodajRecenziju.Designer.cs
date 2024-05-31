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
            this.lblSifraRecenzije = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblGlavnoJelo = new System.Windows.Forms.Label();
            this.cboGlavnoJelo = new System.Windows.Forms.ComboBox();
            this.lblOcjenaOkusa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSifraRecenzije
            // 
            this.lblSifraRecenzije.AutoSize = true;
            this.lblSifraRecenzije.Location = new System.Drawing.Point(93, 55);
            this.lblSifraRecenzije.Name = "lblSifraRecenzije";
            this.lblSifraRecenzije.Size = new System.Drawing.Size(79, 13);
            this.lblSifraRecenzije.TabIndex = 0;
            this.lblSifraRecenzije.Text = "Šifra recenzije: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblGlavnoJelo
            // 
            this.lblGlavnoJelo.AutoSize = true;
            this.lblGlavnoJelo.Location = new System.Drawing.Point(93, 105);
            this.lblGlavnoJelo.Name = "lblGlavnoJelo";
            this.lblGlavnoJelo.Size = new System.Drawing.Size(66, 13);
            this.lblGlavnoJelo.TabIndex = 2;
            this.lblGlavnoJelo.Text = "Glavno Jelo:";
            // 
            // cboGlavnoJelo
            // 
            this.cboGlavnoJelo.FormattingEnabled = true;
            this.cboGlavnoJelo.Location = new System.Drawing.Point(188, 97);
            this.cboGlavnoJelo.Name = "cboGlavnoJelo";
            this.cboGlavnoJelo.Size = new System.Drawing.Size(298, 21);
            this.cboGlavnoJelo.TabIndex = 3;
            // 
            // lblOcjenaOkusa
            // 
            this.lblOcjenaOkusa.AutoSize = true;
            this.lblOcjenaOkusa.Location = new System.Drawing.Point(93, 147);
            this.lblOcjenaOkusa.Name = "lblOcjenaOkusa";
            this.lblOcjenaOkusa.Size = new System.Drawing.Size(76, 13);
            this.lblOcjenaOkusa.TabIndex = 4;
            this.lblOcjenaOkusa.Text = "Ocjena okusa:";
            // 
            // FrmDodajRecenziju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOcjenaOkusa);
            this.Controls.Add(this.cboGlavnoJelo);
            this.Controls.Add(this.lblGlavnoJelo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSifraRecenzije);
            this.Name = "FrmDodajRecenziju";
            this.Text = "Nova Recenzija";
            this.Load += new System.EventHandler(this.FrmDodajRecenziju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifraRecenzije;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblGlavnoJelo;
        private System.Windows.Forms.ComboBox cboGlavnoJelo;
        private System.Windows.Forms.Label lblOcjenaOkusa;
    }
}