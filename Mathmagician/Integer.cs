using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        public int Max { get; private set; }



        public Integer()
        {
            Max = 50;
        }

        public int GetFirst()
        {
            return 0;
        }

        public int GetNext(int current)
        {
            return current + 1;
        }

        public int[] GetSequence(int how_many)
        {
            if (how_many > Max)
            {
                throw new Exception();
            }
            int[] seq_array = new int[how_many];
            /*
            for (int i = 0; i < how_many; i++)
            {
                seq_array[i] = i;
            }*/
            int counter = 0;
            seq_array[counter] = GetFirst();
            while (counter < how_many -1)
            {
                counter++;
                seq_array[counter] = GetNext(seq_array[counter - 1]);   
            }
            return seq_array;
        }
    }
}
