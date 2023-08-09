namespace Ventti.Model
{
    public class Deck
    {
        private List<Card> _cards;

        public Deck()
        {
        
            _cards = new List<Card>();
            for (int s = 0; s < 4; s++)
            {
                int suit =s;
                for (int i = 1; i < 14; i++)
                {
                    Card kortti = new Card(i, suit);
                    _cards.Add(kortti);
                }
            }
        }
        public Card DealTopCard()
        {
            Card dealed = _cards[0];
            _cards.RemoveAt(0);
            return dealed;
        }

        public void CollectHand(List<Card> hand)
        {
            foreach (Card card in hand)
            {
                _cards.Add(card);            
            }
           hand.Clear();
        }
        public void Suffle()
        {
            Random rnd = new Random();
            // en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
            int n = _cards.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card value = _cards[k];
                _cards[k] = _cards[n];
                _cards[n] = value;
            }
        }
    }
}
