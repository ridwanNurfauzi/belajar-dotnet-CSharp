class Bentuk
{
    protected double luas;
    protected double keliling;

    public double Luas
    {
        get { return luas; }
        set { luas = value; }
    }
    public double Keliling
    {
        get { return keliling; }
        set { keliling = value; }
    }
}

class Segitiga : Bentuk
{
    public Segitiga(double alas, double tinggi)
    {
        this.alas = alas;
        this.tinggi = tinggi;

        luas = alas * tinggi / 2;
        keliling = Math.Sqrt(Math.Pow(alas, 2) + Math.Pow(tinggi, 2));
    }

    private double alas, tinggi;
}

class Lingkaran : Bentuk
{
    public Lingkaran(double r)
    {
        this.r = r;

        luas = Math.PI * Math.Pow(r, 2);
        keliling = Math.PI * r * 2;
    }

    private double r;
}

namespace BelajarDotnetCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var segitiga_1 = new Segitiga(4, 3);
            Console.WriteLine($"Keliling segitiga = {segitiga_1.Keliling}");
            Console.WriteLine($"Luas segitiga = {segitiga_1.Luas}");

            var lingkaran_1 = new Lingkaran(7);
            Console.WriteLine($"Luas lingkaran = {lingkaran_1.Luas}");
            Console.WriteLine($"Keliling lingkaran = {lingkaran_1.Keliling}");
        }
    }
}
