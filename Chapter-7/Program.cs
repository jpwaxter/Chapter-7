using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7
{
    class Program
    {
        static List<string> singers = new List<string>();
        static List<string> dancers = new List<string>();
        static List<string> musicians = new List<string>();
        static List<string> other = new List<string>();

        static void Main(string[] args)
        {
            // Gather and validate contestants
            string thisYear = "this";            
            int contestantsNow = GetValidContestants(thisYear);
            string lastYear = "last";
            int contestantsLast = GetValidContestants(lastYear);

            // Compare contestants and annouce tagline
            string comparison = CompareContestants(contestantsNow, contestantsLast);
            Console.WriteLine(comparison);

            for (int i = 0; i < contestantsNow; i++)
                EnterContestant();

            Console.WriteLine("Number of contestants by type.");
            Console.WriteLine("Singer: {0}", singers.Count);
            Console.WriteLine("Dancers: {0}", dancers.Count);
            Console.WriteLine("Musicians: {0}", musicians.Count);
            Console.WriteLine("Other: {0}", other.Count);

            while (true)
                RequestTalentDisplay();
        }

        public static void EnterContestant()
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

        public static int GetValidContestants(string year)
        {
            int contestants;
            string contestantsInput;

            Console.Write("How many contestants entered "+ year +" year? [0-30]: ");
            contestantsInput = Console.ReadLine();
            contestants = int.Parse(contestantsInput);

            while (contestants < 0 || contestants > 30)
            {
                Console.WriteLine();
                Console.WriteLine("That number isn't between 0 and 30.");
                Console.Write("How many contestants entered "+ year +" year? [0-30]: ");
                contestantsInput = Console.ReadLine();
                contestants = int.Parse(contestantsInput);
                Console.WriteLine();
            }
            return contestants;
        }

        public static string CompareContestants(int now, int last)
        {
            string tagline = "";

            if (now > 2 * last)
                tagline = "The competition is more than twice as big this year!";            
            else if (now > last && now <= last * 2)
                tagline = "The competition is bigger than ever!";            
            else if (now < last)
                tagline = "A tighter race this year! Come out and cast your vote!";

            return tagline;
        }

        public static void RequestTalentDisplay()
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
