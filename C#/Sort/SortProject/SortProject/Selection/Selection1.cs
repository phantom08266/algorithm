using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject.Selection
{
    public class Selection1
    {
        private int[] intarray;
        /// <summary>
        /// 시간복잡도 O(n^2)
        /// </summary>
        public Selection1()
        {

        }

        /// <summary>
        /// 선택정렬
        /// 가장 작은 요소를 선택해 정렬(오름차순)
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="max"></param>
        public void SelectionSort(int[] intArray, int max)
        {
            intarray = intArray;
            int min = 0;
            for (int i = 0; i < max; i++)
            {
                min = i;
                for (int j = i + 1; j < max; j++)
                {
                    if (intarray[i] > intarray[j])
                        min = j; 
                }
                int swap = intarray[i];
                intarray[i] = intarray[min];
                intarray[min] = swap;
            }
        }

        public int[] GetValue()
        {
            return this.intarray;
        }
    }
}
