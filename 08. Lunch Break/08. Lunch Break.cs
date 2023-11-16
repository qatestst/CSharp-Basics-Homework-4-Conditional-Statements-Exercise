namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesTitle = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            double totalTime = double.Parse(Console.ReadLine());

            double lunch = totalTime/ 8;
            double rest = totalTime/ 4;

            double timeLeftAfterLunch = totalTime - (lunch+ rest);
           
            if (timeLeftAfterLunch >= episodeLength)
            {
                Console.WriteLine($"You have enough time to watch {seriesTitle}" +
                    $" and left with {Math.Ceiling(timeLeftAfterLunch - episodeLength)} minutes free time.");
            }
            else 
            {
                Console.WriteLine($"You don't have enough time to watch {seriesTitle}," +
                    $" you need {Math.Ceiling(episodeLength- timeLeftAfterLunch)} more minutes.");
            }
            
            
        }
    }
}