using Mezo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using Mezo.Repozitoriji;

namespace Mezo
{
    public partial class FrmPrikazITrazi : Form
    {
        public FrmPrikazITrazi()
        {
            InitializeComponent();
            
            UcitajRecenzije();
            
        }

        

        private void UcitajRecenzije()

        {
            
            var recenzija = RepozitorijiRecenzija.GetRecenzija();
            
            dgvPregledRecenzija.DataSource = recenzija;
            
           dgvPregledRecenzija.AutoGenerateColumns = true;
        }

        private void UcitajTrazeneRecenzije()
        {
            List<Recenzija> recenzije = RepozitorijiRecenzija.SearchRecenzije(txtTrazi.Text);
            dgvPregledRecenzija.DataSource = recenzije;

            dgvPregledRecenzija.AutoGenerateColumns = true;

        }
        private void dgvPregledRecenzija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPrikazITrazi_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajRecenziju frmDodajRecenziju = new FrmDodajRecenziju();
            Hide();
            frmDodajRecenziju.ShowDialog();
            Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Recenzija selectedRecenzija = dgvPregledRecenzija.CurrentRow.DataBoundItem as Recenzija;
            if (selectedRecenzija != null)
            {
                FrmAzurirajRecenziju frmAzurirajRecenziju = new FrmAzurirajRecenziju();
                Hide();
                frmAzurirajRecenziju.ShowDialog();
                Close();
            }
        }


        private void btnBrisi_Click(object sender, EventArgs e)
        {
            Recenzija selectedRecenzija = dgvPregledRecenzija.CurrentRow.DataBoundItem as Recenzija;
            if (selectedRecenzija != null)
            {
                int idRecenzija = selectedRecenzija.Id_Recenzija;
                string sql = $"DELETE FROM dbo.Recenzija WHERE Id_Recenzija={idRecenzija}";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                UcitajRecenzije();
            }
        }


        private void btnPretrazi_Click(object sender, EventArgs e)
        {

            string pretrazivanje = txtTrazi.Text;
            if (pretrazivanje != null)
            {
                UcitajTrazeneRecenzije();
            }

        }
    }
}
