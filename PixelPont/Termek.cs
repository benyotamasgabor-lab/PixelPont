abstract class Termek : IComparable<Termek>
{
    public string Cikkszam { get; }
    public string Nev { get; }
    public decimal Ar { get; }

    protected Termek(string cikkszam, string nev, decimal ar)
    {
        Cikkszam = cikkszam;
        Nev = nev;
        Ar = ar;
    }

    public abstract string Kategoria();

    public virtual decimal EladasiAr()
    {
        return Ar;
    }

    public override string ToString()
    {
        return $"{Cikkszam} {Nev} ({Kategoria()}) {EladasiAr():N0} Ft";
    }

    public int CompareTo(Termek? masik)
    {
        if (masik is null) return 1;
        int arComp = EladasiAr().CompareTo(masik.EladasiAr());
        if (arComp != 0) return arComp;
        return Cikkszam.CompareTo(masik.Cikkszam);
    }
}