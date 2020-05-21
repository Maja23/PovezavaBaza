using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovezavaBaza.Models
{
    public class SifraArtikli
    {
        public string SIFRABLAGA { get; set; } // 1
        public string KODA { get; set; } // 000
        public string EANKODA { get; set; } // /
        public string NAZIV { get; set; } // Stroj za krivljenje in brusenje
        public string ME { get; set; } // KOS
        public string SIFRADAVKA { get; set; } // 22
        public string TIPBLAGA { get; set; } // I
        public string GRUPA { get; set; } // /
        public string PODGRUPA { get; set; } // / [npr. IR] 
        public string PODPODGRUPA { get; set; } // /
        public Decimal ZALOGA { get; set; } // 0

        public string FullInfro
        {
            get
            {
                return $"{ZALOGA}, {GRUPA}, {PODGRUPA}";
            }
        }
    }
}
