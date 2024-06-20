abstract class Bentuk
{
    public abstract void TulisKeliling();
    public abstract void TulisLuas();
}

class Persegi : Bentuk
{
    public Persegi(double sisi)
    {
        this.sisi = sisi;
        luas = sisi * sisi;
    }

    private double sisi;

    private double luas;

    public override void TulisLuas()
    {
        Console.WriteLine($"Luas perseginya adalah {luas}");
    }

    public override void TulisKeliling()
    {
        throw new NotImplementedException();
    }
}

namespace BelajarDotnetCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var persegi_1 = new Persegi(4);
            persegi_1.TulisLuas();
            persegi_1.TulisKeliling(); // Ini akan error
        }
    }
}
