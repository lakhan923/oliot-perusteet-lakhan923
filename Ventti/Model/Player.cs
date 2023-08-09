﻿namespace Ventti.Model
{
    public class Player
    {
        private List<Card> _hand;
        private int _handValue = 0;
        private string _name;
        private bool _busted; 

        public string Name { get => _name; }
        public int HandValue { get => _handValue; set => _handValue = value; } 
                                    
        public bool Busted
        {
            get => _busted;
            set
            {
                _busted = value;
                OnChanged();
            }
        }

        public List<Card> Hand { get => _hand;}

        protected void OnChanged()
         {
            if (_busted)
            {               
                Lost.Invoke(this, EventArgs.Empty);
            }
        }
    
        public Player(string name, int MaxValue)
        {
            _name = name;
            _hand = new List<Card>();
            Busted = false;
            
        }
        public void GetCard(Card newCard)
        {
            Hand.Add(newCard);
        }
        public event EventHandler Lost;

    }
}
