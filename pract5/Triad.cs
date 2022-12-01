using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pract5
{
    internal class Triad
    {
        private int _first;
        private int _second;
        private int _third;
        public int First
        {
            get => _first;

            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException($"{nameof(First)} Число должно быть нечетным");
                }
                _first = value;
            }
        }

        public int Second
        {
            get => _second;

            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException($"{nameof(Second)} Число должно быть нечетным");
                }
                _second = value;
            }
        }

        public int Third
        {
            get => _third;

            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException($"{nameof(Third)} Число должно быть нечетным");
                }
                _third = value;

            }
        }
        public bool Compare(Triad FirstValue, Triad SecondValue)
        {
            return FirstValue.First == SecondValue.First && FirstValue.Second == SecondValue.Second && FirstValue.Third == SecondValue.Third;
        }
       public bool Compare(Triad FirstValue, Triad SecondValue, Triad ThirdValue)
        {
           return First == FirstValue.First && Second == SecondValue.Second && Third == ThirdValue.Third;
        }
        public static bool operator true(Triad triad1)
        {
            return triad1.First %2 != 0 && triad1.Second %2 != 0 && triad1.Third %2 != 0; 
        }
        public static bool operator false(Triad triad1)
        {
            return triad1.First % 2 == 0 && triad1.Second % 2 == 0 && triad1.Third % 2 == 0;
        }
        public static bool operator !=(Triad triad1, Triad triad2)
        {
            return triad1.First != triad2.First && triad1.Second != triad2.Second && triad1.Third != triad2.Third;
        }
        public static bool operator ==(Triad triad1, Triad triad2)
        {
            return triad1.First == triad2.First && triad1.Second == triad2.Second && triad1.Third == triad2.Third;
        }
    }
}
