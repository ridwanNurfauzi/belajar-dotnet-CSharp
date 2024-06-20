namespace BelajarDotnetCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nama Anda : ");

            // Gunakan fungsi ReadLine() untuk mengambil masukan data dari console
            var nama = Console.ReadLine();

            Console.WriteLine($"Halo, {nama}.");
        }
    }
}
