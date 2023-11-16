namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = (hours * 60) + minutes;

            int finalMinutes = totalMinutes + 15;

            int newHours = finalMinutes / 60;
            if (newHours == 24)
            { newHours = 0; }

            int newMinutes = finalMinutes % 60;

            if (newMinutes < 10)
            { Console.WriteLine($"{newHours}:0{newMinutes}"); }
            else
            {
                Console.WriteLine($"{newHours}:{newMinutes}");
            }


        }
    }
}