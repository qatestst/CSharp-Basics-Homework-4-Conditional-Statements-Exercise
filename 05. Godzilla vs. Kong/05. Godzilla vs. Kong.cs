namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double budget = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double outfitPricePerStatist = double.Parse(Console.ReadLine());
            double decor = budget * 0.1;

            if (statisti > 150)
            {
                outfitPricePerStatist = outfitPricePerStatist * 0.9;
            }

            double expenses = decor + (outfitPricePerStatist*statisti);

            if (expenses > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {expenses - budget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-expenses:F2} leva left.");
            }






        }
    }
}