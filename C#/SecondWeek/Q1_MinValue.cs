using System;
using System.Collections.Generic;
using System.Text;

namespace SecondWeek
{
    class Q1_MinValue
    {
        private int[] height;

        public void Start()
        {
            Console.Write("사람 수 : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} 사람의 키를입력하세요.", number);
            height = new int[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write("height[{0}] : ", i);
                height[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("최소값은 {0}입니다.", minof(height, number));
        }

        private int minof(int[] a, int n)
        {
            int min = a[0];
            foreach (int value in a)
            {
                if (min > value)
                    min = value;
            }
            return min;
        }
    }
}
