namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int speakingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int lorries = int.Parse(Console.ReadLine());

            int numberOfToys = puzzles + speakingDolls + teddyBears + minions + lorries;

            // total prices

            double puzzlesMoney = puzzles * 2.6;
            double speakingDollsMoney = speakingDolls * 3;
            double teddyBearsMoney = teddyBears * 4.10;
            double minionsMoney = minions * 8.20;
            double lorriesMoney = lorries * 2;

            double totalPrice = puzzlesMoney + speakingDollsMoney + teddyBearsMoney + minionsMoney + lorriesMoney;
            if (numberOfToys >= 50)
            {
                totalPrice = totalPrice * 0.75;
            }

            double rent = totalPrice * 0.10;

            double finalMoney = totalPrice - rent;

            double leftMoneyAfterTrip = finalMoney - tripPrice;

            if (finalMoney >= tripPrice)
            {
                Console.WriteLine($"Yes! {leftMoneyAfterTrip:F2} lv left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money! {Math.Abs(tripPrice - finalMoney):F2} lv needed.");
            }
        }
    }
}