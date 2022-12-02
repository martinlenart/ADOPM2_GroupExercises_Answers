using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public enum DiceFace { One = 1, Two, Three, Four, Five, Six }
    public interface IDice : IComparable<IDice>
    {
        public DiceFace Face { get; init; }
    }
}
