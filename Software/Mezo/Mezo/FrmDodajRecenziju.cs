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
    public partial class FrmDodajRecenziju : Form
    {
        public FrmDodajRecenziju()
        {
            InitializeComponent();
            UcitajKonzumiranaJela();
            txtDatumRecenzije.Text = DateTime.Now.ToString("dd.MM.yyyy.");
        }

        private void FrmDodajRecenziju_Load(object sender, EventArgs e)
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

        private void txtOcjenaOkusa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOcjenaOkusa_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtOcjenaOkusa.Text, out int value))
            {
                if (value < 1 || value > 5)
                {
                    
                    txtOcjenaOkusa.Text = string.Empty;
                }
            }
            else
            {
               
                txtOcjenaOkusa.Text = string.Empty;
            }
        }
        private void txtOcjenaKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtOcjenaKolicina_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtOcjenaKolicina.Text, out int value))
            {
                if (value < 1 || value > 5)
                {

                    txtOcjenaKolicina.Text = string.Empty;
                }
            }
            else
            {

                txtOcjenaKolicina.Text = string.Empty;
            }

        }

        private void txtDatumRecenzije_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
