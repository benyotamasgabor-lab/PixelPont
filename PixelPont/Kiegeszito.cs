using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPont
{
    class Kiegeszito : Termek, ISzallithato
    {
        public int TomegGramm { get; }

        public Kiegeszito(string cikkszam, string nev, decimal ar, int tomegGramm)
            : base(cikkszam, nev, ar)
        {
            TomegGramm = tomegGramm;
        }

        public override string Kategoria()
        {
            return "kiegeszito";
        }
    }
}
