using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovezavaBaza.Models
{
    public class TehnoloskiPostopki
    {
        public string STEVILKA { get; set; } // 1 2 3 ..
        public DateTime DATUM { get; set; } // 09.11.2018
        public bool AKTIVEN { get; set; } // True
        public string varianta { get; set; } // prazno
        public string artikel { get; set; } // 588
        public string opomba { get; set; } // prazno
        public string ZUPOR { get; set; } // prazno
        public string DATSP { get; set; } // prazno

        public string FullInfro
        {
            get
            {
                return $"{ZUPOR}, {DATSP}";
            }
        }
    }
}
