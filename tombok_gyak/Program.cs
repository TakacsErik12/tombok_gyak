using System.Threading.Channels;

namespace tombok_gyak
{
    internal class Program
    {
        
        static void F01()
        {
            Random rnd = new Random();
            int[] tomb = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(5, 11);
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
        }
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

        static void Karneval()
        {
            int[] tombolak = new int[100];
            for (int i = 0; i < tombolak.Length; i++)
            {
                tombolak[i] = i + 1;
            }
            string[] nyeremenyek = {
            "Élményhajózás a helyi tavon",
            "Vacsora egy exkluzív étteremben",
            "Fülhallgató + hangszóró",
            "Elektromos grill",
            "10 000 Ft decathlon utalvány",
            "Wellness hétvége",
            };
            int[] nyertesek = new int[6];
            for (int i = 0; i < nyertesek.Length; i++)
            {
                nyertesek[i] = r.Next(1, 101);

                for (int nyertes = 0; nyertes < i; nyertes++)
                {
                    if (nyertesek[i] == nyertesek[nyertes])
                    {
                        i--;
                    }
                }
            }
            Console.WriteLine("A tombola nyertesei:");
            for (int i = 0; i < nyeremenyek.Length; i++)
            {
                Console.WriteLine(nyertesek[i] + ". sorsjegy! Nyereménye: " + nyeremenyek[i]);
            }
        }
        static void Main(string[] args)
        {
            //F01();
            //F05();
            //F13();
            Karneval();
        }
    }
}
