using Program;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tablica wielowymiarowa
            int[,] tab = new int[2, 4];
            Console.WriteLine(tab.Length);  //8
            Console.WriteLine(tab.GetLength(0));    //2
            Console.WriteLine(tab.GetLength(1));    //4

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write($"tab[{i},{j}] ");
                }
                Console.WriteLine();
            }

            Person[] persons = new Person[2];
            Person[] p1 = new Person("Janusz");
            Person[] p2 = new Person("Anna");

            persons[0] = p1;
            persons[1] = p2;

            foreach (Person p in persons)
            {
                Console.WriteLine($"imię: {p.firstname} ");
            }
        }
    }
}