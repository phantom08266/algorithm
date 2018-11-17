using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject.Quick
{
    public class QuickSort2
    {
        private int[] intarray;
        /// <summary>
        /// QuickSort
        /// 비재귀형식으로 정렬.
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public void QuickSort(int[] intArray, int left, int right)
        {
            intarray = intArray;

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
