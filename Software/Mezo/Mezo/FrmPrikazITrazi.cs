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

namespace Mezo
{
    public partial class FrmPrikazITrazi : Form
    {
        public FrmPrikazITrazi()
        {
            InitializeComponent();
        }

        private void FrmUcitaj_Recenzije(object sender, EventArgs e)
        {
            UcitajRecenzije();
        }

        private void UcitajRecenzije()

        {
            List<Recenzija> recenzije = Repozitoriji.RepozitorijiRecenzija.GetRecenzija();
            dgvPregledRecenzija.DataSource = recenzije;

            dgvPregledRecenzija.Columns["IdRecenzije"].DisplayIndex = 0;
            dgvPregledRecenzija.Columns["DatumRecenzije"].DisplayIndex = 1;
            dgvPregledRecenzija.Columns["IdJelo"].DisplayIndex = 2;
            dgvPregledRecenzija.Columns["OcjenaOkusa"].DisplayIndex = 3;
            dgvPregledRecenzija.Columns["OcjenaKolicina"].DisplayIndex = 4;
            dgvPregledRecenzija.Columns["Komentar"].DisplayIndex = 5;
        }
        private void dgvPregledRecenzija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
