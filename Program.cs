// method
namespace BelajarDotnetCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contoh pemanggilan method
            ContohMethod();

            KatakanHalo("Kk Ridwn");

            Perkenalan("Kk");

            // Contoh pemangilan method dengan argumen bernama
            Perkenalan(salam: "Hi",nama: "Ridwan");

            Console.WriteLine(Penjumlahan(1, 2)); // output: 3
        }

        static void ContohMethod()
        {
            Console.WriteLine("Ini adalah contoh method.");
        }

        // Contoh method dengan parameter
        static void KatakanHalo(string nama)
        {
            Console.WriteLine($"Halo, {nama}.");
        }

        // Contoh method dengan nilai parameter default
        static void Perkenalan(string nama, string salam = "Assalaamu'alaikum" /* Parameter salam tidak wajib diisi saat pemanggilan */)
        {
            Console.WriteLine($"{salam},");
            Console.WriteLine($"Perkenalkan, nama saya {nama}.");
        }

        // Contoh method dengan pengembalian nilai
        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }
    }
}
