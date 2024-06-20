namespace BelajarDotnetCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value atau nilai pada variabel dengan const tidak dapat diubah
            const string namaDepan = "M. Ridwan";
            string namaBelakang = "Nurfauzi";
            int umur = 17;
            double beratBadan = 59.5;
            char jk = 'l';
            bool sudahLulus = true;

            // Pengubahan nilai pada variabel
            umur = 18;

            Console.WriteLine("==============Biodata==============\n");

            // Menampilkan nilai dari variabel
            Console.WriteLine($"Nama Lengkap : {namaDepan} {namaBelakang}");
            Console.WriteLine($"Umur : {umur} tahun");
            Console.WriteLine("Jenis Kelamin : " + jk);
            Console.WriteLine($"Berat Badan : {beratBadan} kg");
            Console.WriteLine("Sudah Lulus : " + sudahLulus);
        }
    }
}
