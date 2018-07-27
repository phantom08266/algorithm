using System;
using System.Collections.Generic;
using System.Text;

namespace SecondWeek
{
    class Q5_Swap
    {
        private int[] height;

        public void Start()
        {
            Random random = new Random();

            Console.Write("요소 개수 : ");
            int number = random.Next(1, 20);

            Console.WriteLine("{0} 정수를 입력하세요.", number);
            height = new int[number];

            GetRandomValue(ref height, number);
            Ary_reverse(ref height, number);
        }

        private void Ary_reverse(ref int[] a, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", a[j]);
                }
                Console.WriteLine();
                Swap(ref a, i, n - i - 1);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
            Console.WriteLine("역순 정렬을 종료합니다.");
        }

        private void Swap(ref int[] a, int x, int y)
        {
            Console.WriteLine("a[{0}]과 a[{1}]을 교환합니다.", x, y);
            int swap = a[x];
            a[x] = a[y];
            a[y] = swap;
        }

        private void GetRandomValue(ref int[] a, int n)
        {
            var rand = System.Security.Cryptography.RandomNumberGenerator.Create();
            byte[] randValue = new byte[n];
            rand.GetBytes(randValue);
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(randValue[i]);
            }
        }
    }
}
