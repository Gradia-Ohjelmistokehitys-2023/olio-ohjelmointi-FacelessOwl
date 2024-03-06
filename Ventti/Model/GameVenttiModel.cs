using System.Xml.Schema;
using System.Xml.Serialization;

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
            int aces = 0;
            int acecounter = 0;

            foreach (Card card in inAction.Hand)
            {
                
                if (card.Value == 1)
                {
                    aces++;
                }
                    
                total = total + GetCardValue(card);
                
            }
                


            inAction.HandValue= total;

            if (inAction.HandValue > 21)
            {
                if (aces > acecounter)
                {
                    inAction.HandValue = total - 10;
                    acecounter++;
                    if (inAction.HandValue > 21)
                    {
                        inAction.Busted = true;
                    }
                }
                else
                {
                    inAction.Busted = true;
                }
                
            }
            return drawnCard;
        }

        private int CountHandValue(int total, Card card)
        {
            {
                total += GetCardValue(card);
            }

            return total;
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


