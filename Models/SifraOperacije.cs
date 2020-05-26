using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovezavaBaza.Models
{
    public class SifraOperacije
    {
        string SIFRA { get; set; }
        string opis { get; set; }
        string stroj { get; set; }
        bool IzpisMatNaTPDN { get; set; }
        string DM { get; set; }
        bool IzpisiTabelo { get; set; }

        public string FullInfro
        {
            get
            {
                // "14, Novak Tomas"
                return $"{SIFRA}. {opis}";
            }
        }
    }
}
