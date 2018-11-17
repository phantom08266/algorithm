using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("NoneRecursiveFactorial : {0}", NoneRecursiveFactorial(5));
            //Console.WriteLine("NoneRecursiveGCD : {0}", NoneRecursiveGCD(22, 8)); 
            Console.WriteLine("gcd_array : {0}", gcd_array(new int[3] { 18, 6, 12 }, 3));
            Console.ReadLine();
        }

        /// <summary>
        /// 재귀함수 사용하지 않고 Factorial 구하기
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static public int NoneRecursiveFactorial(int value)
        {
            int total = 1;
            for (int i = 1; i <= value; i++)
            {
                total *= i;
            }
            return total;
        }

        /// <summary>
        /// 재귀함수 사용하지 않고 Greatest Common Divisor(최대공약수) 구하기
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static public int NoneRecursiveGCD(int x, int y)
        {
            int fv = x;
            int sv = y;
            while (true)
            {
                if (sv == 0)
                    return fv;
                int temp = fv % sv;
                fv = sv;
                sv = temp;
            }
        }

        /// <summary>
        /// 배열 a의 모든 요소의 최대공약수 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static public int gcd_array(int[] a, int n)
        {
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                if ((i + 1) >= n) break;
                if (i == 0) temp = a[i];
                temp = NoneRecursiveGCD(temp, a[i]);
            }
            return temp;
        }
    }
}
