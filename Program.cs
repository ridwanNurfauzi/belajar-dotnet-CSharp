class Mobil
{
    // Contoh konstruktor pada class
    public Mobil(string warna, int kecepatan)
    { 
        this.warna = warna;
        this.kecepatan = kecepatan;
    }

    // Ini adalah property
    int kecepatan;
    string warna;

    // Ini adalah method
    void Maju()
    {
        Console.WriteLine("Mobil maju");
    }
    void Mundur()
    {
        Console.WriteLine("Mobil mundur");
    }
}

namespace BelajarDotnetCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil("Merah", 200);
        }
    }
}
