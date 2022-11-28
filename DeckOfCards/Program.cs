using ProjectPartBAnswers_B2;

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
            IDeckOfCards myDeck = new ProjectPartBAnswers_B2.DeckOfCards();  
            Console.WriteLine($"\nFreshly created deck:");
            Console.WriteLine(myDeck);

            Console.WriteLine($"\nShuffled deck:");
            myDeck.Shuffle();     //OK once implemented
            Console.WriteLine(myDeck);

            Console.WriteLine($"\nSorted deck:");
            myDeck.Sort();        //OK once implemented
            Console.WriteLine(myDeck);



            //Appendix - only to show how to loop through enum types, you can use in DeckOfCards
            for (PlayingCardSuit s = PlayingCardSuit.Clubs; s <= PlayingCardSuit.Spades; s++)
            {
                for (PlayingCardValue v = PlayingCardValue.Two; v <= PlayingCardValue.Ace; v++)
                {
                    Console.WriteLine($"Color = {s}, Value = {v}");
                }
            }
        }
    }
}