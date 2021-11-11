using System;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PracticeLinq!");

            var videoGameList = new string[] { "Call of Duty", "Mario Brothers", "Spiderman","Minecraft","Grand Theft Auto","Fortnite" };
            var sortedList = videoGameList.OrderBy(x => x.Length);
            
            foreach (var title in sortedList)
            {
                Console.WriteLine($"{title.Length} - {title}");
            }

        }
    }
}
