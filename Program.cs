class Mobil
{
    // Contoh konstruktor pada class
    public Mobil(string warna, int kecepatan)
    { 
        this.warna = warna;
        this.kecepatan = kecepatan;
    }

    protected int kecepatan;
    public string warna;

    // Ini adalah method
    public void Maju()
    {
        Console.WriteLine("Mobil maju");
    }
    public void Mundur()
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
