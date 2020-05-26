using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovezavaBaza.Models
{
    public class TehnoloskiPostopkiPOS
    {
        public string STEVILKA { get; set; } // 2
        public Int32 ZAP_ST { get; set; } // 1
        public string SIFRAOPERACIJE { get; set; } // 30
        public string OPIS { get; set; } // REZKANJE 5 osn 1
        public string DM { get; set; } // 2
        public Decimal CASOBDELAVE { get; set; } // 0,16700000
        public string SIFRASTROJA { get; set; } // /
        public Decimal CASTROJA { get; set; } // /
        public string ORODJA { get; set; } // /
        public string PREDHODNIDM { get; set; } // /
        public string NASLEDNJIDM { get; set; } // /
        public Decimal CASPRIPRAVE { get; set; } // /
        public Decimal TEZAMETERIAL { get; set; } // 0 ZA VSE
        public Int32 dan { get; set; } // 0 ZA VSE

        public string FullInfro
        {
            get
            {
                return $"{STEVILKA}: {SIFRAOPERACIJE} => {OPIS}";
            }
        }

    }
}
