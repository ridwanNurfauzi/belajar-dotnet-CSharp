// Percabangan
namespace BelajarDotnetCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kondisi = true;

            if (kondisi)
            {
                Console.WriteLine("Kondisi benar.");
            }

            int angka = 7;

            if (angka % 2 == 0)
            {
                Console.WriteLine("Angka genap.");
            }
            else
            {
                Console.WriteLine("Angka ganjil.");
            }

            int nilai = 75;
            char tingkat;

            if (nilai >= 90)
            {
                tingkat = 'A';
                Console.WriteLine($"Nilai {nilai}, Tingkat {tingkat}.");
            }
            else if (nilai >= 80)
            {
                tingkat = 'B';
                Console.WriteLine($"Nilai {nilai}, Tingkat {tingkat}.");
            }
            else if (nilai >= 70)
            {
                tingkat = 'C';
                Console.WriteLine($"Nilai {nilai}, Tingkat {tingkat}.");
            }
            else if (nilai >= 60)
            {
                tingkat = 'D';
                Console.WriteLine($"Nilai {nilai}, Tingkat {tingkat}.");
            }
            else if (nilai >= 40)
            {
                tingkat = 'E';
                Console.WriteLine($"Nilai {nilai}, Tingkat {tingkat}.");
            }
            else
            {
                tingkat = 'F';
                Console.WriteLine($"Nilai {nilai}, Tingkat {tingkat}.");
            }

            switch (tingkat)
            {
                case 'A':
                    Console.WriteLine("Luar biasa");
                    break;
                case 'B':
                    Console.WriteLine("Bagus");
                    break;
                case 'C':
                    Console.WriteLine("Lumayan");
                    break;
                case 'D':
                    Console.WriteLine("Kurang");
                    break;
                case 'E':
                    Console.WriteLine("Buruk");
                    break;
                case 'F':
                    Console.WriteLine("Sangat buruk");
                    break;

                default:
                    Console.WriteLine("Terjadi kesalahan");
                    break;
            }
        }
    }
}
