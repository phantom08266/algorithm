using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject
{
    public class Bubble3
    {
        private int[] intarray;

        public Bubble3()
        {

        }
        /// <summary>
        /// 정렬된 이전값은 정렬하지 않도록 최근 Swap한 마지막 index를 저장.
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="max"></param>
        public void BubbleSort(int[] intArray, int max)
        {
            intarray = intArray;
            int lastIndex = max - 1;
            int index = 0;
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < lastIndex; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int swap = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = swap;
                        index = j + 1;
                        Console.WriteLine("Swap");
                    }
                    Console.WriteLine("Compare");
                }
                Console.WriteLine("Pass");
                lastIndex = index;
                if (lastIndex == 0) break;
            }
        }

        public int[] GetValue()
        {
            return this.intarray;
        }
    }
}
