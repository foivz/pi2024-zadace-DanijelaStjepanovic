using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mezo.Models
{
    public class Recenzija
    {
        public string Id_Recenzija { get; set; }
        public string DatumRecenzije { get; set; }
        public string OcjenaOkusa { get; set; }
        public string OcjenaKolicina { get; set; }
        public string Komentar { get; set; }

        public string Id_Jelo { get; set; }
    }
}
