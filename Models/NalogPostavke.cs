using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovezavaBaza.Models
{
    public class NalogPostavke
    {
        public string STEVILKA { get; set; } // 2019G000000001
        public Int32 zap_st { get; set; } // 1
        public string sifrablaga { get; set; } // 462
        public string opis { get; set; } // Labyrinthring K112.01
        public string opisenota { get; set; } // /
        public Decimal kolicina { get; set; } // 30,0000000
        public string sklad1 { get; set; } // 30

        public string FullInfro
        {
            get
            {
                return $"{sifrablaga}, {kolicina}";
            }
        }

    }
}
