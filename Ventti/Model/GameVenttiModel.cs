namespace Ventti.Model
{
    public class GameVenttiModel : IModel
    {
        private Deck _deck = new Deck();
        private Player _player = new Player("You");
        private Player _dealer = new Player("Dealer");
        public Player Player => _player;
        public Player Dealer => _dealer;
        public Deck Deck => _deck;

        
        public Card DealCard(Player inAction)
        {
            Card drawnCard = Deck.DealTopCard();           
            inAction.GetCard(drawnCard);
            int total = 0;
            foreach(Card card in inAction.Hand)
            {
                 total+= GetCardValue(card);
            }
            inAction.HandValue= total;

            if (inAction.HandValue > 21)
            {          
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

            if (Dealer.HandValue >= Player.HandValue && !Dealer.Busted)
            {
                winner = Dealer.Name;
            }
            else if (!Player.Busted)
            {
                winner = Player.Name;
            }
        
            return winner;
        }

        public void ResetGame()
        {
            Deck.CollectHand(Player.Hand);
            Player.Init();
            
            Deck.CollectHand(Dealer.Hand);
            Dealer.Init();
        }

 

    }
}


