using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int contestantsNow = 0;
            string contestantsNowInput;

            Console.Write("How many contestants entered this year? [0-30]: ");
            contestantsNowInput = Console.ReadLine();
            contestantsNow = int.Parse(contestantsNowInput);

            while (contestantsNow < 0 || contestantsNow > 30)
            {
                Console.WriteLine();
                Console.WriteLine("That number isn't between 0 and 30.");
                Console.Write("How many contestants entered this year? [0-30]: ");
                contestantsNowInput = Console.ReadLine();
                contestantsNow = int.Parse(contestantsNowInput);
                Console.WriteLine();
            }

            List<string> singers = new List<string>();
            List<string> dancers = new List<string>();
            List<string> musicians = new List<string>();
            List<string> other = new List<string>();

            for (int i = 0; i < contestantsNow; i++)
            {
                Console.Write("Enter a contestant's name: ");
                string name = Console.ReadLine();
                Console.Write("What type of talent are they performing? [s - Singing, d - Dancing, m - Music, o - Other]: ");
                char talent = Console.ReadKey().KeyChar;
                Console.WriteLine();
                while (talent != 's' && talent != 'd' && talent != 'm' && talent != 'o')
                {
                    Console.WriteLine("That isn't a valid talent.");
                    Console.Write("What type of talent are they performing? [s - Singing, d - Dancing, m - Music, o - Other]: ");
                    talent = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }

                if (talent == 's')
                    singers.Add(name);
                else if (talent == 'd')
                    dancers.Add(name);
                else if (talent == 'm')
                    musicians.Add(name);
                else if (talent == 'o')
                    other.Add(name);
            }

            Console.WriteLine("Number of contestants by type.");
            Console.WriteLine("Singer: {0}", singers.Count);
            Console.WriteLine("Dancers: {0}", dancers.Count);
            Console.WriteLine("Musicians: {0}", musicians.Count);
            Console.WriteLine("Other: {0}", other.Count);

            while (true)
            {
                Console.Write("Choose a talent to see a list of names. [s, d, m, o]: ");
                char talent = Console.ReadKey().KeyChar;
                Console.WriteLine();
                while (talent != 's' && talent != 'd' && talent != 'm' && talent != 'o')
                {
                    Console.WriteLine("That isn't a valid talent.");
                    Console.Write("Choose a talent to see a list of names. [s - Singing, d - Dancing, m - Music, o - Other]: ");
                    talent = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }

                if (talent == 's')
                {
                    for (int i = 0; i < singers.Count; i++)
                    {
                        Console.WriteLine(singers[i]);
                    }
                }
                else if (talent == 'd')
                {
                    for (int i = 0; i < dancers.Count; i++)
                    {
                        Console.WriteLine(dancers[i]);
                    }
                }
                else if (talent == 'm')
                {
                    for (int i = 0; i < musicians.Count; i++)
                    {
                        Console.WriteLine(musicians[i]);
                    }
                }
                else if (talent == 'o')
                {
                    for (int i = 0; i < other.Count; i++)
                    {
                        Console.WriteLine(other[i]);
                    }
                }

            }
        }
    }
}
