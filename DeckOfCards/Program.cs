using DeckOfCards;

namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notice on how I use IDeckOfCards and IPlayingCard

            //Start with testing PlayingCard
            //IPlayingCard card1 = null;  //Allows compilation
            //IPlayingCard card2 = null;  //Allows compilation

            //Once PlayingCard is implemented, create an instance instead of null
            IPlayingCard card1 = new PlayingCard { Suit = PlayingCardSuit.Clubs, Value = PlayingCardValue.Ace };
            IPlayingCard card2 = new PlayingCard { Suit = PlayingCardSuit.Hearts, Value = PlayingCardValue.Ten };
            Console.WriteLine("Two playing cards:");
            Console.WriteLine(card1);
            Console.WriteLine(card2);


            //Now test DeckOfCards
            //IDeckOfCards myDeck = null; //Allows compilation

            //Once DeckOfCards is implemented, create an instance instead of null
            IDeckOfCards myDeck = new DeckOfCards();  
            Console.WriteLine($"\nFreshly created deck:");
            Console.WriteLine(myDeck);

            Console.WriteLine($"\nSorted deck:");
            myDeck.Sort();        //OK once implemented
            Console.WriteLine(myDeck);

            Console.WriteLine($"\nShuffled deck:");
            myDeck.Shuffle();     //OK once implemented
            Console.WriteLine(myDeck);

            Console.WriteLine($"\nCreate a hand of cards:");
            IHandOfCards aHand = new HandOfCards();       //IHandOfCards aHands is fine
            //HandOfCards aHand = new HandOfCards();          //HandOfCards aHand is also fine
            aHand.Add(myDeck.DealOne());
            aHand.Add(myDeck.DealOne());
            aHand.Add(myDeck.DealOne());
            aHand.Add(myDeck.DealOne());
            aHand.Add(myDeck.DealOne());
            Console.WriteLine(aHand);

            Console.WriteLine($"\nSorted hand of cards:");
            aHand.Sort();        //OK once implemented
            Console.WriteLine(aHand);

            Console.WriteLine($"\nShuffled hand of cards:");
            aHand.Shuffle();        //OK once implemented
            Console.WriteLine(aHand);

            Console.WriteLine($"\nDeck after dealing 5 cards:");
            Console.WriteLine(myDeck);
        }
    }
}