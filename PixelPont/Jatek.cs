using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPont
{
    class Jatek : Termek, ISzallithato
    {
        public string Platform { get; }
        public bool Hasznalt { get; }

        public Jatek(string cikkszam, string nev, decimal ar, string platform, bool hasznalt)
            : base(cikkszam, nev, ar)
        {
            Platform = platform;
            Hasznalt = hasznalt;
        }

        public int TomegGramm => 150;

        public override string Kategoria()
        {
            return Hasznalt ? "hasznalt jatek" : "jatek";
        }

        public override decimal EladasiAr()
        {
            decimal alap = base.EladasiAr();
            return Hasznalt ? alap * 0.7m : alap;
        }

        public override string ToString()
        {
            return base.ToString() + $" [{Platform}]";
        }
    }
}