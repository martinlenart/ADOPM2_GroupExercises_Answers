using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    //IHandOfCards also has to implement IDeckOfCards, to ensure a variable of type IHandOfCards can reach all members of
    //IDeckOfCards -> You show the inheritance also in the interface
    public interface IHandOfCards : IDeckOfCards
    {
        /// <summary>
        /// Adds a card into the hand
        /// </summary>
        /// <param name="card"></param>
        public void Add(IPlayingCard card);

        /// <summary>
        /// Epmties the hand, i.e. all cards removed
        /// </summary>
        public void Clear();
    }
}
