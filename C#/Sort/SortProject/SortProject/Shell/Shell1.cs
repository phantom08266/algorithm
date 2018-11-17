using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject.Shell
{
    public class Shell1
    {
        private int[] intarray;

        public Shell1()
        {

        }
        /// <summary>
        /// 쉘정렬
        /// 증분값이 키포인트이다.
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="max"></param>
        public void ShellSort(int[] intArray, int max)
        {
            intarray = intArray;
            int h = 1;
            while (h < max / 2)
            {
                h = h * 3 + 1;  // 증분값을 설정한다.
            }

            for (; h > 0; h = h / 3) 
            {
                for (int i = 0; h+i < max; i++)
                {
                    int temp = intarray[h+i];
                    for (int j = i; j >= 0 && intarray[j] > temp; j-=h)
                    {
                        intarray[h + j] = intarray[j];
                        intarray[j] = temp;
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
