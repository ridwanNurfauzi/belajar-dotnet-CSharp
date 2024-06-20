// Perulangan
namespace BelajarDotnetCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i += 2)
            {
                Console.WriteLine($"Perulangan ke-{i}.");
            }

            int n = 10;
            while (n > 0)
            {
                Console.WriteLine($"Hitung mundur {n}.");
                n--;
            }

            Console.Write("Lakukan perulangan do/while (y/t)?");
            var txt = Console.ReadLine();

            if (txt == "y")
                do
                {
                    Console.Write("Ulangi (y/t)?");
                    txt = Console.ReadLine();
                } while (txt == "y");
        }
    }
}
