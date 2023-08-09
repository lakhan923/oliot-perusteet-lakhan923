namespace Ventti.View
{
    public interface IView
    {
        void DisplayWelcomeMessage();
        void DisplayDealingCardsMessage();
        void DisplayWinnerMessage(string name);
        void DisplayBustedMessage(string name);
        void DisplayCard(string card, string name);
        void DisplayTotal(int total, string name);
        void AskForHitOrStay();
        void DisplayFinalTotals(int playerTotal, int dealerTotal);
        string GetHitOrStayInput();
    }
}


