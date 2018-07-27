using System;
using System.Collections.Generic;
using System.Text;

namespace SecondWeek
{
    class Q4_Rand
    {
        private int[] height;

        public void Start()
        {
            Random random = new Random();

            Console.Write("사람 수 : ");
            int number = random.Next(5, 20);

            Console.WriteLine("{0} 사람의 키를입력하세요.", number);
            height = new int[number];

            for (int i = 0; i < number; i++)
            {
                height[i] = random.Next(100, 189);
                Console.WriteLine("height[{0}] : {1}", i, height[i]);
            }
            Console.WriteLine("최대값 {0}입니다.", Maxof(height, number));
        }

        private int Maxof(int[] a, int n)
        {
            int max = a[0];
            foreach (int value in a)
            {
                if (max < value)
                    max = value;
            }
            return max;
        }
    }
}
