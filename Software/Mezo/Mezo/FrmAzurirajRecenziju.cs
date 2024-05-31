using DBLayer;
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
        public FrmAzurirajRecenziju()
        {
            InitializeComponent();
            UcitajKonzumiranaJela();
            txtDatumRecenzije.Text = DateTime.Now.ToString("dd.MM.yyyy.");
        }

        private void FrmAzurirajRecenziju_Load(object sender, EventArgs e)
        {

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
    }
}
