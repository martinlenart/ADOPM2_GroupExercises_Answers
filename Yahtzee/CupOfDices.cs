using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class CupOfDices : ICupOfDices
    {
        #region Dice List related
        protected int _nrOfDices = 0;
        protected List<IDice> dices = new List<IDice>();

        public IDice this[int idx]
        {
            get
            {
                return dices[idx];
            }
        }
        #endregion
        public int Count => dices.Count;

        public IDice Highest
        {
            get
            {
                DiceFace high = DiceFace.One;
                int hiIdx = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (dices[i].Face > high)
                    {
                        high = dices[i].Face;
                        hiIdx = i;
                    }

                }
                
                return dices[hiIdx];
            }
        }

        public IDice Lowest
        {
            get
            {
                //Same algorithm as Highest but using foreach loop
                IDice lowDice = new Dice { Face= DiceFace.Six };
                foreach (var item in dices)
                {
                    if (item.Face < lowDice.Face)
                    {
                        lowDice= item;
                    }
                }
                return lowDice;
            }
        }

        public bool IsYahtzee()
        {
            //All are equal if all look like the first dice
            for (int i = 1; i < _nrOfDices; i++)
            {
                if (dices[i].Face != dices[0].Face)
                    return false;
            }
            return true;
        }

        public void Shake()
        {
            var rnd = new Random();
            dices.Clear();
            for (int i = 0; i < _nrOfDices; i++)
            {
                dices.Add(new Dice { Face = (DiceFace)rnd.Next((int)DiceFace.One, (int)DiceFace.Six + 1) });
            }
        }

        public void Sort() => dices.Sort();

        #region ToString() related
        public override string ToString()
        {
            string sRet = $"Cup contains {Count} dices\n";
            for (int i = 0; i < Count; i++)
            {
                sRet += $"{this[i],8},";
                if ((i + 1) % 10 == 0)
                    sRet += "\n";
            }
            return sRet;
        }
        #endregion

        public CupOfDices(int NrOfDices)
        {
            if (NrOfDices < 0 || NrOfDices > 100)
                throw new IndexOutOfRangeException("Wrong number of Dices");

            _nrOfDices = NrOfDices;
            Shake();
        }
    }
}
