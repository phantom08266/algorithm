using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject
{
    public class Bubble1
    {
        private int[] intarray;
        /// <summary>
        /// 시간복잡도 O(n^2)
        /// </summary>
        public Bubble1()
        {
        }
        /// <summary>
        /// 버블정렬
        /// 이웃한 두 요소를 크기비교하여 정렬(오름차순)
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="max"></param>
        public void BubbleSort(int[] intArray, int max)
        {
            intarray = intArray;
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max - 1; j++)
                {
                    if(intArray[j] > intArray[j+1])
                    {
                        int swap = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = swap;
                    }
                }
            }
        }

        public int[] GetValue()
        {
            return this.intarray;
        }
    }
}
