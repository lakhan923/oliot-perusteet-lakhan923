namespace Ventti.Model
{
    public class GameVenttiModel : IModel
    {
        private Deck _deck = new Deck();
        private Player _player = new Player("You",21);
        private Player _dealer = new Player("Dealer",21);
        public Player Player => _player;
        public Player Dealer => _dealer;
        public Deck Deck => _deck;

        
        public Card DealCard(Player inAction)
        {
            Card drawnCard = Deck.DealTopCard();
            inAction.GetCard(drawnCard);
            inAction.HandValue += GetCardValue(drawnCard);
            if (inAction.HandValue > 21)
            {
                inAction.HandValue = 0;
                inAction.Busted = true;
            }
            return drawnCard;
        }

        private int GetCardValue(Card card)
        {
            if (card.Value == 1)
            {
                return 11;
            }
            else if (card.Value > 9 && card.Value < 14)
            {
                return 10;
            }
            else
            {
                return card.Value;
            }
        }

        public string CheckWinner()
        {
            string winner = "";

            if (Dealer.HandValue > Player.HandValue)
            {
                winner = Dealer.Name;
            }
            else if (Dealer.HandValue < Player.HandValue)
            {
                winner = Player.Name;
            }
            return winner;
        }

        public void ResetGame()
        {
            Deck.CollectHand(Player.Hand);
            Player.HandValue=0;
            Player.Busted=false;
            Deck.CollectHand(Dealer.Hand);
            Dealer.HandValue=0;
            Dealer.Busted = false;
        }

 

    }
}


