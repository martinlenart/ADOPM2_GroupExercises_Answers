using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartBAnswers_B2
{
	public class PlayingCard:IComparable<PlayingCard>, IPlayingCard
	{
		public PlayingCardSuit Suit { get; init; }
		public PlayingCardValue Value { get; init; }

		#region IComparable Implementation
		//Need to compare not only Value but also Color if value is the same
		public int CompareTo(PlayingCard other)
        {
			if (this.Value != other.Value)
				return this.Value.CompareTo(other.Value);
			else
				return this.Suit.CompareTo(other.Suit);
        }
		#endregion

        #region ToString() related
		string ShortDescription
		{
			//Use switch statment or switch expression
			//https://en.wikipedia.org/wiki/Playing_cards_in_Unicode
			get
			{
                char c = Suit switch
				{
					PlayingCardSuit.Clubs => '\x2663',
					PlayingCardSuit.Diamonds => '\x2666',
					PlayingCardSuit.Hearts => '\x2665',
					_ => '\x2660', // Spades
				};
				return $"{c} {Value.ToString()}";
			}
		}

		public override string ToString() => $"{ShortDescription}";
        #endregion
    }
}
