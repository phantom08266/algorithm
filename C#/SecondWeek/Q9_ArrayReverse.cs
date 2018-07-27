using System;
using System.Collections.Generic;
using System.Text;

namespace SecondWeek
{
    class Q9_ArrayReverse
    {
        public void Start()
        {
            int[] value_arry = new int[10];
            int[] temp_arry = new int[10];

            for (int i = 0; i < 10; i++)
            {
                value_arry[i] = i;
            }
            Ary_copy(ref temp_arry, ref value_arry, 10);
        }

        private void Ary_copy(ref int[] a, ref int[] b, int n)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = b[n-i-1];
                Console.WriteLine(a[i]);
            }
        }
    }
}
