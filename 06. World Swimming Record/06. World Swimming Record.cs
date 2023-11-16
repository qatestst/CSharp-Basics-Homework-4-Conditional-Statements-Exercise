namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());
            double totalTime = timeForOneMeter * distance;
            double additionalTime = 0;

            if (distance >= 15)
            {
                double multiplier = Math.Floor(distance / 15);
                totalTime = timeForOneMeter*distance + ( 12.5 * multiplier);
            }

            if (totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else 
            {
                Console.WriteLine($"No, he failed! He was {totalTime-record:F2} seconds slower.");
            }

        }
    }
}