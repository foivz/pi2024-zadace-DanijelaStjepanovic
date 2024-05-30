using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mezo.Models
{
    public class Recenzija
    {
        public int Id_Recenzija { get; set; }
        public DateTime DatumRecenzije { get; set; }
        public int OcjenaOkusa { get; set; }
        public int OcjenaKolicina { get; set; }
        public string Komentar { get; set; }

        public int Id_Jelo { get; set; }
    }
}
