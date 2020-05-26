using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovezavaBaza.Models
{
    public class Sestavnica
    { 
        int ID { get; set; }
        string SIFRABLAGA { get; set; }
        string PODSIFRA { get; set; }
        decimal KOLICINA { get; set; }
        decimal KALO { get; set; }
        decimal FAKTOR { get; set; }
        string FORMULA { get; set; }
        string VARIANTAK { get; set; }
        string NAZIVN { get; set; }
        string ENOTAN { get; set; }
        string OPOMBAN { get; set; }
        string STNDARDN { get; set; }
        Int32 ZAPSTN { get; set; }
        decimal KOLICINA2 { get; set; }
        bool KONCAN { get; set; }
        Int32 DAN { get; set; }
        Int32 DAN2 { get; set; }
        string STROSEK1 { get; set; }
        string STROSEK2 { get; set; }
        decimal KALKCENA { get; set; }
        string SKLADN { get; set; }

        public string FullInfro
        {
            get
            {
                // "14, Novak Tomas"
                return $"{ID}, {SIFRABLAGA}, {PODSIFRA} \n" +
                    $"{KOLICINA}, {KALO}, {FAKTOR} \n" +
                    $"{FORMULA}, {VARIANTAK}, {NAZIVN} \n" +
                    $"{ENOTAN}, {OPOMBAN}, {STNDARDN} \n" +
                    $"{ZAPSTN}, {KOLICINA2}, {KONCAN} \n" +
                    $"{DAN}, {DAN2}, {STROSEK1} \n" +
                    $"{STROSEK2}, {KALKCENA}, {SKLADN}\n\n";
            }
        }
    }
}
