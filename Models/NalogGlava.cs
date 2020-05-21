using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovezavaBaza.Models
{
    public class NalogGlava
    {
        public string STEVILKA { get; set; } //2019G00000001
        public string sTRANKA { get; set; } //67
        public string NAZIVST { get; set; } //Podjetje GmbH
        public string  NAROCILO { get; set; } // 161486
        public DateTime DATUM { get; set; } // 03.01.2019 00:00:00
        public bool vobdelavi { get; set; } // True
        public bool BKonecOperac { get; set; } // False
        public bool RAZKNJIZEN { get; set; } // False
        public DateTime ZAKLJUCEN { get; set; } // 03.01.2019

        public string FullInfro
        {
            get
            {
                // "14, Novak Tomas"
                return $"{STEVILKA}, {sTRANKA}, {NAZIVST}";
            }
        }

    }
}
