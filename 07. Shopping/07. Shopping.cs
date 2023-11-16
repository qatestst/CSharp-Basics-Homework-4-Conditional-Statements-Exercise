namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double videoCardsNumber = double.Parse(Console.ReadLine());
            double cpuNumber = double.Parse(Console.ReadLine());
            double ramNumber = double.Parse(Console.ReadLine());

            double videoCardsPice = 250 * videoCardsNumber;
            double cpuPrice = cpuNumber * videoCardsPice * 0.35;
            double ramPrice = ramNumber * videoCardsPice * 0.10;

            double totalPrice = videoCardsPice + cpuPrice + ramPrice;

            if (videoCardsNumber > cpuNumber) 
            {
                totalPrice = totalPrice * 0.85;
            }

            if (totalPrice <= budget) 
            {
                Console.WriteLine($"You have {budget-totalPrice:F2} leva left!");

            }
            else
            { Console.WriteLine($"Not enough money! You need {Math.Abs(totalPrice-budget):F2} leva more!"); }

        }
    }
}