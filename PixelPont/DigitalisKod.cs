using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPont
{
    class DigitalisKod : Termek
    {
        public DigitalisKod(string cikkszam, string nev, decimal ar) : base(cikkszam, nev, ar)
        {
        }

        public override string Kategoria()
        {
            return "digitalis kod";
        }
    }
}