namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabint = { 1, 2, 3, -4, 5, 60, 7, 8, 9, 10, };
            for (int i = 0; i < tabint.Length; i++)
            {
                Console.Write($"{tabint[i]} ");
            }
            Console.WriteLine();
            foreach (int x in tabint)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();

            for (int i = 0; i < tabint.Length; i++)
            {
                tabint[i] *= 2;
                Console.Write($"{tabint[i]} ");
            }

            Console.WriteLine();
            foreach (int x in tabint)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Min: {tabint.Min()}");
            Console.WriteLine($"Max: {tabint.Max()}");

            Array.Reverse( tabint );

            foreach(int x in tabint)
            {
                Console.Write($" {x}");
            }
            //2 4 6 -8 10 120 14 16 18 20
            Console.WriteLine();

            Array.Reverse(tabint, 3, 4);

            foreach (int x in tabint)
            {
                Console.Write($" {x}");
            }
            //20 18 16 14 120 10 -8 6 4 2
            //20 18 16 -8 10 120 14 6 4 2
            Console.WriteLine();

            Console.WriteLine(Array.BinarySearch(tabint, 16));  //-11
            Array.Sort(tabint);

            foreach (int x in tabint)
            {
                Console.Write($" {x}");
            }

            Console.WriteLine();

            Console.WriteLine(Array.BinarySearch(tabint, 16));
        }
    }
}