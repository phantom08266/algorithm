using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 패스(pass) : n개인 배열에서 n-1회 비교할때 1회씩을 하나의 패스로 본다.
 * 패스를 진행하면서 변경된 값이 없으면 더이상 진행 안함.
 */
namespace SortProject
{
    public class Bubble2
    {
        private int[] intarray;

        public Bubble2()
        {

        }

        public void BubbleSort(int[] intArray, int max)
        {
            intarray = intArray;
            int pass = 0;
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max - 1; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int swap = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = swap;
                        pass += 1;
                    }
                }
                if (pass == 0) break;
            }
        }

        public int[] GetValue()
        {
            return this.intarray;
        }

    }
}
