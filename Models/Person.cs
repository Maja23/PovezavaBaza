using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovezavaBaza
{
    public class Person
    {
        public string sifdel { get; set; }
        public string nazdel { get; set; }
        public string FullInfro
        {
            get 
            {
                // "14, Novak Tomas"
                return $"{sifdel}. {nazdel}";
            }
        }
    }
}
