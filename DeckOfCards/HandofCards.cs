using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class HandOfCards : DeckOfCards, IHandOfCards
    {
        public void Add(IPlayingCard card)
        {
            cards.Add(card);
        }
        public void Clear()
        {
            cards.Clear();
        }
        public HandOfCards()
        {
            Clear();
        }
    }
}
