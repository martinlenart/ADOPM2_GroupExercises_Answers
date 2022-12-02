namespace Yahtzee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a CupOfDices");

            //ICupOfDices cup1 = null;  //for compilation only, before implementation of CupOfDice
            ICupOfDices cup1 = new CupOfDices(5);
            bool Continue = false;
            do
            {
                cup1.Shake();
                Console.WriteLine();
                Console.WriteLine(cup1);

                Console.WriteLine();
                Console.WriteLine($"First dice: {cup1[0]}");
                Console.WriteLine($"Last dice: {cup1[cup1.Count - 1]}");
                Console.WriteLine($"Lowest dice: {cup1.Lowest}");
                Console.WriteLine($"Highest dice: {cup1.Highest}");
                Console.WriteLine($"Is Yahtzee: {cup1.IsYahtzee()}");

                cup1.Sort();
                Console.WriteLine();
                Console.WriteLine("Sorted dices");
                Console.WriteLine(cup1);

                Continue = UserInput.TryReadString("\nPlay again?", out _);
            } while (Continue);
        }
    }
}