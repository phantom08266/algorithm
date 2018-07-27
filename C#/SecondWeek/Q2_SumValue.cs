using System;
using System.Collections.Generic;
using System.Text;

namespace SecondWeek
{
    class Q2_SumValue
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
            Console.WriteLine("총 합은 {0}입니다.", Sumof(height, number));
        }

        private int Sumof(int[] a, int n)
        {
            int sum = 0;
            foreach (int value in a)
            {
                sum += value;
            }
            return sum;
        }
    }
}
