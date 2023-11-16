namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            

            if(points <= 100 )
            {
                bonusPoints = 5;
            }
            else if (points >100 && points <=1000)
            {
                bonusPoints = points * 0.2;

            }
            else if (points >1000)
            {
                bonusPoints = points * 0.10;
            }
            
            if (points % 2 == 0) 
            {
                bonusPoints = bonusPoints + 1;
            }

            if (points % 10 == 5)
            {
                bonusPoints += 2;            
            }
            
            
            
            double totalPoints = bonusPoints + points;
            
            Console.WriteLine(bonusPoints);
            Console.WriteLine(totalPoints);
        }
    }
}