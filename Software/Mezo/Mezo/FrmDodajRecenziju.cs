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
    }
}
