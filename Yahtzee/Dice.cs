using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Dice : IDice
    {
        public DiceFace Face { get; init; }

        public int CompareTo(IDice other)
        {
            return this.Face.CompareTo(other.Face);
        }
        public override string ToString() => $"{Face}";

    }
}
