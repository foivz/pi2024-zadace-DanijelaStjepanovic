namespace Mezo
{
    partial class FrmPrikazITrazi
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
            this.lblTraziNaTemelju = new System.Windows.Forms.Label();
            this.txtTraziOkus = new System.Windows.Forms.TextBox();
            this.dgvPregledRecenzija = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtTraziKolicina = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledRecenzija)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTraziNaTemelju
            // 
            this.lblTraziNaTemelju.AutoSize = true;
            this.lblTraziNaTemelju.Location = new System.Drawing.Point(23, 39);
            this.lblTraziNaTemelju.Name = "lblTraziNaTemelju";
            this.lblTraziNaTemelju.Size = new System.Drawing.Size(84, 13);
            this.lblTraziNaTemelju.TabIndex = 0;
            this.lblTraziNaTemelju.Text = "Trazi na temelju:";
            // 
            // txtTraziOkus
            // 
            this.txtTraziOkus.ForeColor = System.Drawing.Color.Gray;
            this.txtTraziOkus.Location = new System.Drawing.Point(26, 90);
            this.txtTraziOkus.Name = "txtTraziOkus";
            this.txtTraziOkus.Size = new System.Drawing.Size(111, 20);
            this.txtTraziOkus.TabIndex = 1;
            this.txtTraziOkus.Text = "Ocjena okusa";
            this.txtTraziOkus.TextChanged += new System.EventHandler(this.txtTrazi_TextChanged);
            // 
            // dgvPregledRecenzija
            // 
            this.dgvPregledRecenzija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledRecenzija.Location = new System.Drawing.Point(264, 24);
            this.dgvPregledRecenzija.Name = "dgvPregledRecenzija";
            this.dgvPregledRecenzija.ReadOnly = true;
            this.dgvPregledRecenzija.Size = new System.Drawing.Size(508, 255);
            this.dgvPregledRecenzija.TabIndex = 2;
            this.dgvPregledRecenzija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPregledRecenzija_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(264, 324);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(99, 42);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(473, 325);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(99, 41);
            this.btnAzuriraj.TabIndex = 4;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(673, 324);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(99, 40);
            this.btnBrisi.TabIndex = 5;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(150, 121);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(99, 34);
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtTraziKolicina
            // 
            this.txtTraziKolicina.ForeColor = System.Drawing.Color.Gray;
            this.txtTraziKolicina.Location = new System.Drawing.Point(26, 152);
            this.txtTraziKolicina.Name = "txtTraziKolicina";
            this.txtTraziKolicina.Size = new System.Drawing.Size(111, 20);
            this.txtTraziKolicina.TabIndex = 7;
            this.txtTraziKolicina.Text = "Ocjena kolicine";
            // 
            // FrmPrikazITrazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTraziKolicina);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPregledRecenzija);
            this.Controls.Add(this.txtTraziOkus);
            this.Controls.Add(this.lblTraziNaTemelju);
            this.Name = "FrmPrikazITrazi";
            this.Text = "Recenzije";
            this.Load += new System.EventHandler(this.FrmPrikazITrazi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledRecenzija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTraziNaTemelju;
        private System.Windows.Forms.TextBox txtTraziOkus;
        private System.Windows.Forms.DataGridView dgvPregledRecenzija;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtTraziKolicina;
    }
}