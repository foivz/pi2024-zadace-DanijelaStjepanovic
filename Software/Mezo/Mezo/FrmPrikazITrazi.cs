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
        private void dgvPregledRecenzija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPrikazITrazi_Load(object sender, EventArgs e)
        {

        }
    }
}
