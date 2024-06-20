namespace BelajarDotnetCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = [1, 2, 3, 4, 5];
            string[] stringArr = ["teks 1", "teks 2", "teks 3"];

            Console.WriteLine(stringArr[0]); // output: teks 1

            // Contoh perulangan pada array
            foreach (var val in intArr)
            {
                Console.WriteLine($"val = {val}");
            }

            // Contoh array 2 dimensi
            int[][] matriks = [
                [1, 2, 3],
                [4, 5, 6],
                [7, 8, 9]
            ];

            Console.WriteLine(matriks[2][1]); // output: 8
        }
    }
}
