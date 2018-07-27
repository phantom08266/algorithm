using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SecondWeek
{
    class Q10_ArrayShuffle
    {
        public void Start()
        {
            int[] value_arry = new int[10];

            for (int i = 0; i < 10; i++)
            {
                value_arry[i] = i;
            }
            shuffle(ref value_arry, 10);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(value_arry[i]);
            }
        }

        private void shuffle(ref int[] a, int n)
        {
            int[] temp = (int[])a.Clone();
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int index = r.Next(0, temp.Length);
                a[i] = temp[index];
                //temp = Array.
                int removeIndex = Array.IndexOf(temp, temp[index]);
                temp = temp.Where((val, del) => del != removeIndex).ToArray();
            }
        }
    }
}
