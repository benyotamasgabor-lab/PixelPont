using PixelPont;
using System;
using System.Collections.Generic;
using System.IO;

string[] sorok = File.ReadAllLines("termekek.txt");
Console.WriteLine($"1. lepes: {sorok.Length} sor a fajlban");

List<Termek> kinalat = Beolvas("termekek.txt");
Console.WriteLine($"4. lepes: {kinalat.Count} termek beolvasva");
foreach (Termek t in kinalat)
{
    Console.WriteLine("   " + t);
}

int szallithatoDb = 0;
foreach (Termek t in kinalat)
{
    if (t is ISzallithato)
    {
        szallithatoDb++;
    }
}
Console.WriteLine($"Ebbol postazhato: {szallithatoDb} db");

kinalat.Sort();
Console.WriteLine("5. lepes: Ar szerint rendezve");
foreach (Termek t in kinalat)
{
    Console.WriteLine($"   {t.Cikkszam} {t.EladasiAr(),7:N0} Ft   {t.Nev}");
}

Kosar kosar = new Kosar();
kosar.Hozzaad(kinalat[0]);
kosar.Hozzaad(kinalat[1]);
kosar.Hozzaad(kinalat[8]);

Console.WriteLine($"6. lepes: Kosar elemek szama: {kosar.Darab}");
Console.WriteLine($"   Reszosszeg: {kosar.Reszosszeg():N0} Ft");
Console.WriteLine($"   Ossztomeg: {kosar.OssztomegGramm()} g");
Console.WriteLine($"   Szallitasi dij: {kosar.SzallitasiDij():N0} Ft");
Console.WriteLine($"   Vegosszeg: {kosar.Vegosszeg():N0} Ft");

static List<Termek> Beolvas(string fajlnev)
{
    List<Termek> lista = new List<Termek>();
    foreach (string sor in File.ReadAllLines(fajlnev))
    {
        string[] m = sor.Split(';');
        decimal ar = decimal.Parse(m[3]);
        if (m[0] == "J")
        {
            lista.Add(new Jatek(m[1], m[2], ar, m[4], m[5] == "H"));
        }
        else if (m[0] == "K")
        {
            lista.Add(new Kiegeszito(m[1], m[2], ar, int.Parse(m[4])));
        }
        else if (m[0] == "D")
        {
            lista.Add(new DigitalisKod(m[1], m[2], ar));
        }
    }
    return lista;
}

