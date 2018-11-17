using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject.Quick
{
    public class QuickSort1
    {
        private int[] intarray;

        /// <summary>
        /// QuickSort 
        /// 재귀방식으로 구현
        /// </summary>
        /// <param name="intArray"></param>
        /// /// <param name="left"></param>
        /// <param name="right"></param>
        public void QuickSort(int[] intArray, int left, int right)
        {
            intarray = intArray;

            int pl = left;
            int pr = right;
            int center = (pl + pr) / 2;

            do
            {
                while (intarray[pl] < intarray[center]) pl++;
                while (intarray[pr] > intarray[center]) pr--;
                if (pl <= pr)
                {
                    Swap(ref intarray[pl], ref intarray[pr]);
                    pl++;
                    pr--;
                }
            } while (pl <= pr);

            if (pr > left) QuickSort(intarray, left, pr);
            if (pl < right) QuickSort(intarray, pl, right);
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public int[] GetValue()
        {
            return this.intarray;
        }
    }
}
