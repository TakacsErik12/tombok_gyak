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

        static Random r = new Random();
        static void F13()
        {
            int[] tomb = new int[20];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-100, 100);
            }
            foreach (int item in tomb)
            {
                Console.Write(item + ", ");
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine($"{i+1,3} {tomb[i],5} {(tomb[i] < 0 ? "-" : "+"),5}");
            }
            for (int i = 0; i < tomb.Length; i += 2)
            {
                Console.WriteLine(tomb[i] + 1);
            }
        }

        static void Main(string[] args)
        {
            //F05();
            F13();
        }
    }
}
