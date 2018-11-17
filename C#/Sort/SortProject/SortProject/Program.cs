using SortProject.Insert;
using SortProject.Quick;
using SortProject.Selection;
using SortProject.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject
{
    public class Program
    {
        ////static int[] array = { 22, 5, 11, 32, 120, 65, 485, 25 };
        static int[] array = { 6, 5, 4, 2, 7, 3, 1, 8 }; //나니?? 이건 왜 안됨??
        ////static int[] array = { 5, 8, 4, 2, 6, 1, 3, 9, 7 };
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void quick(int[] a, int left, int right)
        {
            int pl = left;            /* 왼쪽 커서 */
            int pr = right;            /* 오른쪽 커서 */
            int x = a[(pl + pr) / 2];   /* 피벗(가운데 요소 선택) */

            do
            {
                while (a[pl] < x) pl++;
                while (a[pr] > x) pr--;
                if (pl <= pr)
                {
                    Swap(ref a[pl],ref a[pr]);
                    pl++;
                    pr--;
                }
            } while (pl <= pr);

            if (left < pr) quick(a, left, pr);
            if (pl < right) quick(a, pl, right);
        }

        void quick_sort(int[] a, int n)
        {
            quick(a, 0, n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("원본 값 : ");
            Print();

            //QuickSort1 sort = new QuickSort1();
            //sort.QuickSort(array, 0, array.Length - 1);
            //array = sort.GetValue();
            quick(array, 0, array.Length - 1);

            Console.Write("정렬 값 : ");
            Print();
            Console.ReadLine();

           

        }

        public static void Print()
        {
            foreach (int a in array)
            {
                Console.Write(a + ", ");
            }
            Console.WriteLine();
        }
    }
}
