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
            dgvPregledRecenzija.Columns["Id_Jelo"].Visible = false;
        }

        private void UcitajTrazeneRecenzije1()
        {
            List<Recenzija> recenzije1 = RepozitorijiRecenzija.SearchRecenzije1(txtTrazi.Text);
            dgvPregledRecenzija.DataSource = recenzije1;

            dgvPregledRecenzija.AutoGenerateColumns = true;

        }

        private void UcitajTrazeneRecenzije2()
        {
            List<Recenzija> recenzije2 = RepozitorijiRecenzija.SearchRecenzije2(txtTraziKolicina.Text);
            dgvPregledRecenzija.DataSource = recenzije2;

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
                FrmAzurirajRecenziju frmAzurirajRecenziju = new FrmAzurirajRecenziju(selectedRecenzija);
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

            
            string pretrazivanje2 = txtTraziKolicina.Text;
           
            if (pretrazivanje2 != null)
            {
                UcitajTrazeneRecenzije2();
            }

        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTrazi.Text, out int value))
            {
                if (value < 1 || value > 5)
                {
                    MessageBox.Show("Unos nije valjan! Probaj unijeti broj između 1 i 5!");
                    txtTrazi.Text = string.Empty;
                }
            }
            else if (!string.IsNullOrWhiteSpace(txtTrazi.Text))
            {
                MessageBox.Show("Unos nije valjan! Probaj unijeti broj između 1 i 5!");
                txtTrazi.Text = string.Empty;
            }
        }

        private void txtTraziKolicina_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTraziKolicina.Text, out int value))
            {
                if (value < 1 || value > 5)
                {
                    MessageBox.Show("Unos nije valjan! Probaj unijeti broj između 1 i 5!");
                    txtTraziKolicina.Text = string.Empty;
                }
            }
            else if (!string.IsNullOrWhiteSpace(txtTraziKolicina.Text))
            {
                MessageBox.Show("Unos nije valjan! Probaj unijeti broj između 1 i 5!");
                txtTraziKolicina.Text = string.Empty;
            }
        }

        private void btnTraziOkus_Click(object sender, EventArgs e)
        {
            string pretrazivanje1 = txtTrazi.Text;
            if (pretrazivanje1 != null)
            {
                UcitajTrazeneRecenzije1();

            }
        }
    }
}
