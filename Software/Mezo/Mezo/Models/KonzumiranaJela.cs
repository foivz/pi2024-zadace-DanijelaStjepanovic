using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mezo.Models
{
    public class KonzumiranaJela
    {
        public int Id_Jelo { get; set; }
        public string GlavnoJelo { get; set;}
        public DateTime VrijemeNarudzbe {  get; set; }

        public DateTime VrijemeUrucivanja { get; set; }

        public override string ToString()
        {
            return GlavnoJelo;
        }

    }


}
