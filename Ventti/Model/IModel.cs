namespace Ventti.Model
{
    public interface IModel
    {
        Player Player { get; }
        Player Dealer { get; }
        Deck Deck { get; }
        Card DealCard(Player currentPlayer);    
        string CheckWinner();
        void ResetGame();

    }
}


