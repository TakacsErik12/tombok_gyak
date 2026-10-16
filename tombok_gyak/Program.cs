using System.Threading.Channels;

namespace tombok_gyak
{
    internal class Program
    {

        static void F05()
        { 
            int[] tomb = new int[5];
            int i = 0;
            for (i = 0; i < tomb.Length; i++)
            {
                Console.Write("Kérek egy számot: ");
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in tomb)
            {
                Console.Write(item + ", "); 
            }

            Console.WriteLine();
            for (i = tomb.Length - 1; i >= 0; i--)
            {
                Console.Write(tomb[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine($"A második elemek: {tomb[1]}, {tomb[3]}");

            Console.Write("Kérek egy számot 1 és 5 között: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int szam2 = szam - 1;
            Console.WriteLine(tomb[szam2]);
        }



        static void Main(string[] args)
        {
            F05();

        }
    }
}
