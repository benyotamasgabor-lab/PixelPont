using PixelPont;
using System;
using System.Collections.Generic;

class Kosar
{
    private List<Termek> elemek = new List<Termek>();

    public void Hozzaad(Termek termek)
    {
        elemek.Add(termek);
    }

    public int Darab => elemek.Count;

    public decimal Reszosszeg()
    {
        decimal osszeg = 0;
        foreach (var t in elemek)
        {
            osszeg += t.EladasiAr();
        }
        return osszeg;
    }

    public int OssztomegGramm()
    {
        int osszTomeg = 0;
        foreach (var t in elemek)
        {
            if (t is ISzallithato sz)
            {
                osszTomeg += sz.TomegGramm;
            }
        }
        return osszTomeg;
    }

    public decimal SzallitasiDij()
    {
        if (Darab == 0 || Reszosszeg() >= 30000m)
        {
            return 0m;
        }
        return 1990m;
    }
    public decimal Vegosszeg()
    {
        return Reszosszeg() + SzallitasiDij();
    }
}