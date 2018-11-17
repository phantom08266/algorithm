using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject.Insert
{
    public class Insert1
    {
        private int[] intarray;
        /// <summary>
        /// 시간복잡도 O(n^2)
        /// </summary>
        public Insert1() { }

        /// <summary>
        /// 삽입정렬
        /// 선택한 요소보다 앞쪽의 알맞는 위치에 삽입하는 정렬(오름차순)
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="max"></param>
        public void InsertSort(int[] intArray, int max)
        {
            if (max < 1) return;
            intarray = intArray;

            for (int i = 1; i < max; i++)
            {
                int temp = intarray[i];
                int index = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (temp < intarray[j])
                    {
                        intarray[j + 1] = intarray[j];
                        index = j;
                    }
                }
                intarray[index] = temp;
            }
        }

        public int[] GetValue()
        {
            return this.intarray;
        }
    }
}
