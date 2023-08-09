namespace Ventti.View
{
    public class ConsoleView : IView
    {
        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("\n\n\n##############################");
            Console.WriteLine(" Welcome to the 21 card game! \n");
            Console.WriteLine("##############################\n\n\n");
        }

        public void DisplayDealingCardsMessage()
        {
            Console.WriteLine("Dealing cards...");
        }

        public void DisplayBustedMessage(string name)
        {
            Console.WriteLine($"{name} busted");
        }
        public void DisplayWinnerMessage(string name)
        {
            if (name == "")
            {
                Console.WriteLine("Draw!");
            }
            else
            {
                Console.WriteLine($"{name} win");
            }

        }

        public void DisplayTotal(int total, string name)
        {
            Console.WriteLine($"{name} current total is: {total}");
        }

        public void AskForHitOrStay()
        {
            Console.WriteLine("Do you want to hit or stay? (Hit/Stay)");
        }

        public void DisplayCard(string card, string name)
        {
            Console.WriteLine($"{name} was dealt: {card}");
        }

        public void DisplayFinalTotals(int playerTotal, int dealerTotal)
        {
            Console.WriteLine("Final Totals:");
            Console.WriteLine($"Your total: {playerTotal}");
            Console.WriteLine($"Dealer's total: {dealerTotal}");
        }

        public string GetHitOrStayInput()
        {
            string input = Console.ReadKey().KeyChar.ToString().ToLower();
            Console.WriteLine();
            return input;
        }
    }
}


