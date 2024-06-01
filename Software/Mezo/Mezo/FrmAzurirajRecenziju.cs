using DBLayer;
using Mezo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mezo
{
    public partial class FrmAzurirajRecenziju : Form
    {
        private Recenzija recenzija;
        public Recenzija SelectedRecenzija { get => recenzija; set => recenzija = value; }
        public FrmAzurirajRecenziju(Recenzija selectedRecenzija)
        {
            InitializeComponent();
            
            UcitajKonzumiranaJela();
            txtDatumRecenzije.Text = DateTime.Now.ToString("dd.MM.yyyy.");
            SelectedRecenzija = selectedRecenzija;

        }
        
       
       
        
        private void FrmAzurirajRecenziju_Load(object sender, EventArgs e)
        {
            if (SelectedRecenzija != null)
            {
                int idRecenzija = SelectedRecenzija.Id_Recenzija;
                int ocjenaOkusa = SelectedRecenzija.OcjenaOkusa;
                int ocjenaKolicina = SelectedRecenzija.OcjenaKolicina;
                string komentar = SelectedRecenzija.Komentar;
                string glavnoJelo = cboGlavnoJelo.SelectedValue.ToString();


                textBox1.Text = idRecenzija.ToString();
                cboGlavnoJelo.Text = glavnoJelo.ToString();
                txtOcjenaOkusa.Text = ocjenaOkusa.ToString();
                txtOcjenaKolicina.Text = ocjenaKolicina.ToString();
                txtKomentar.Text = komentar;
            }
            

        }
        private void UcitajKonzumiranaJela()
        {
            DB.OpenConnection();
            string sql = "SELECT Id_Jelo, GlavnoJelo FROM dbo.KonzumiranoJelo";
            SqlDataReader reader = DB.GetDataReader(sql);

            DataTable dt = new DataTable();
            dt.Load(reader);

            cboGlavnoJelo.DisplayMember = "GlavnoJelo";
            cboGlavnoJelo.ValueMember = "Id_Jelo";
            cboGlavnoJelo.DataSource = dt;

            reader.Close();

            DB.CloseConnection();
        }
       

        private void txtOcjenaOkusa_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtOcjenaOkusa.Text, out int value))
            {
                if (value < 1 || value > 5)
                {
                    MessageBox.Show("Unos nije valjan! Probaj unijeti broj između 1 i 5!");
                    txtOcjenaOkusa.Text = string.Empty;
                }
            }
            else if(!string.IsNullOrWhiteSpace(txtOcjenaOkusa.Text))
            {
                MessageBox.Show("Unos nije valjan! Probaj unijeti broj između 1 i 5!");
                txtOcjenaOkusa.Text = string.Empty;
            }


        }

        private void txtOcjenaKolicina_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtOcjenaKolicina.Text, out int value))
            {
                if (value < 1 || value > 5)
                {
                    MessageBox.Show("Unos nije valjan! Probaj unijeti broj između 1 i 5!");
                    txtOcjenaKolicina.Text = string.Empty;
                }
            }
            else if (!string.IsNullOrWhiteSpace(txtOcjenaKolicina.Text))
            {
                MessageBox.Show("Unos nije valjan! Probaj unijeti broj između 1 i 5!");
                txtOcjenaKolicina.Text = string.Empty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            int idRecenzija = int.Parse(textBox1.Text);
            string datumRecenzije = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string glavnoJelo = cboGlavnoJelo.SelectedValue.ToString();
            int ocjenaOkusa = int.Parse(txtOcjenaOkusa.Text);
            int ocjenaKolicina = int.Parse(txtOcjenaKolicina.Text);
            string komentar = txtKomentar.Text;

            string sql = $"INSERT INTO dbo.Recenzija (Id_Recenzija, DatumRecenzije, Id_Jelo, OcjenaOkusa, OcjenaKolicina, Komentar) VALUES ('{idRecenzija}', '{datumRecenzije}', '{glavnoJelo}', '{ocjenaOkusa}', '{ocjenaKolicina}', '{komentar}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            FrmPrikazITrazi frmPrikazITrazi = new FrmPrikazITrazi();
            Hide();
            frmPrikazITrazi.ShowDialog();
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FrmPrikazITrazi frmPrikazITrazi = new FrmPrikazITrazi();
            Hide();
            frmPrikazITrazi.ShowDialog();
            Close();
        }
    }
}
