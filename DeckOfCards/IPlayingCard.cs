using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartBAnswers_B2
{
	/// <summary>
	/// Enum type representing a playing card color, also called suit
	/// </summary>
	public enum PlayingCardSuit
	{
		Clubs = 0, Diamonds, Hearts, Spades        
	}

	/// <summary>
	/// Enum type representing a playing card value
	/// </summary>
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace                
	}

	interface IPlayingCard
    {
		/// <summary>
		/// The color or suit of the card
		/// </summary>
		public PlayingCardSuit Suit { get; init; } //init - Suit can only be set during instance creation

		/// <summary>
		/// The value of the card
		/// </summary>
		public PlayingCardValue Value { get; init; } //init - Value can only be set during instance creation

        //Should be overriden and implemented to print out the in short notation
        public string ToString(); 
	}
}
