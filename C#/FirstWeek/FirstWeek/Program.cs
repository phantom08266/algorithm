﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1. 최대값 : {0}", max4(5, 2, 4, 6));
            Console.WriteLine("==================================");
            Console.WriteLine("Q2. 최소값 : {0}", min3(5, 2, 4));
            Console.WriteLine("==================================");
            Console.WriteLine("Q3. 최소값 : {0}", min4(5, 2, 4, 6));
            Console.WriteLine("==================================");
            Console.WriteLine("Q4. 중간값 : {0}", med3(3, 1, 2));
            Console.WriteLine("==================================");
            Console.WriteLine("Q5. 중간값 : {0}", med3Low(3, 1, 2));
            Console.WriteLine("==================================");
            Console.Write("Q6. "); Routine();
            Console.WriteLine("==================================");
            Console.Write("Q7. "); Routine2();
            Console.WriteLine("==================================");
            Console.Write("Q8. 가우스 덧셈 "); GaussAdd();
            Console.WriteLine("==================================");
            Console.Write("Q9. 가우스 덧셈 "); GaussAdd2(-1, 4);
            Console.WriteLine("==================================");
            Console.Write("Q10. 가우스 덧셈 "); IntCompare();
            Console.WriteLine("==================================");
            Console.Write("Q11. 자릿수 구하기. "); Digit();
            Console.WriteLine("==================================");
            Console.WriteLine("Q12. 곱셈표 출력하기. "); MultiplicationTable();
            Console.WriteLine("==================================");
            Console.WriteLine("Q13. 덧셈표 출력하기. "); AdditionTable();
            Console.WriteLine("==================================");
            Console.WriteLine("Q14. 사각형을 출력합니다. "); SquarePrint();
            Console.WriteLine("==================================");
            Console.WriteLine("Q15. 직사각형을 출력합니다. "); RectanglePrint();
            Console.WriteLine("==================================");
            Console.WriteLine("Q16. 이등변삼각형을 출력합니다. ");
            Console.WriteLine("- 왼쪽 아래가 직각인 이등변삼각형-");
            TriangleLB(5);
            Console.WriteLine("- 왼쪽 위가 직각인 이등변삼각형-");
            TriangleLU(5);
            Console.WriteLine("- 오른쪽 아래가 직각인 이등변삼각형-");
            TriangleRB(5);
            Console.WriteLine("- 오른쪽 위가 직각인 이등변삼각형-");
            TriangleRU(5);
            Console.WriteLine("==================================");
            Console.WriteLine("Q17. n단 피라미드 출력합니다. "); Spira(51);
            Console.WriteLine("==================================");
            Console.WriteLine("Q18. n단 숫자 피라미드 출력합니다. "); nrpira(20);
        }

        static public int max4(int a, int b, int c, int d)
        {
            int max = a;

            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;

            return max;
        }

        static public int min3(int a, int b, int c)
        {
            int min = a;

            if (min > b) min = b;
            if (min > c) min = c;

            return min;
        }

        static public int min4(int a, int b, int c, int d)
        {
            int min = a;

            if (min > b) min = b;
            if (min > c) min = c;
            if (min > d) min = d;

            return min;
        }

        static public int med3(int a, int b, int c)
        {
            if (a >= b)
            {
                if (b >= c) return b;
                else if (a >= c) return c;
                return a;
            }
            else if (a >= c)
            {
                return a;
            }
            else
            {
                if (b >= c) return c;
                return b;
            }
        }

        static public int med3Low(int a, int b, int c)
        {
            /*
             * med3메서드 보단 효율이 낮은 이유는 C를 반환하려면 많은 경우의수를 확인해야 하기때문. 
             */
            if ((b >= a && c <= a) || (b <= a && c >= a))
                return a;
            else if ((a > b && c < b) || (a < b && c > b))
                return b;
            else
                return c;
        }

        static public void Routine()
        {
            int i, n;
            int sum;
            Console.WriteLine("1부터 n까지의 합을 구합니다.");
            Console.Write("n의 값 : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            i = 1;
            while (i <= n)
            {
                sum += i;
                i++;
                Console.WriteLine("증가되는 i 값 확인 : {0}", i);
            }
        }

        static public void Routine2()
        {
            int n, sum;
            Console.WriteLine("1부터 n까지의 합을 구합니다.");
            Console.Write("n의 값 : ");
            sum = 0;
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sum += i;
                if (i.Equals(n)) Console.Write("{0} = ", i);
                else Console.Write("{0} + ", i);
            }
            Console.WriteLine(sum);
        }

        static public void GaussAdd()
        {
            int n, sum, half;
            Console.WriteLine("1부터 n까지의 합을 구합니다.");
            Console.Write("n의 값 : ");
            sum = 0;
            n = Convert.ToInt32(Console.ReadLine());
            half = n / 2;
            if (n % 2 == 0) // 짝수
                sum = (n + 1) * half;
            else // 홀수
                sum = ((n + 1) * half) + (half + 1);

            Console.WriteLine("결과값 : {0}", sum);
        }

        static public void GaussAdd2(int a, int b)
        {
            int n, sum, total;
            Console.WriteLine("{0}부터 {1}까지의 합을 구합니다.", a, b);
            Console.Write("n의 값 : ");
            sum = 0;

            if (a < b) n = b - a + 1; // 갯수
            else n = a - b + 1; // 갯수

            sum = a + b;

            if (n % 2 == 0)//짝수
            {
                total = sum * (n / 2);
            }
            else // 홀수
            {
                total = sum * (n / 2) + (sum / 2);
            }
            Console.WriteLine("결과값 : {0}", total);
        }

        static public void IntCompare()
        {
            int a, b;
            bool check = false;
            Console.Write("a의 값 : ");
            a = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (check) Console.WriteLine("a값보다 큰 값을 입력하세요!");
                Console.Write("b의 값 : ");
                b = Convert.ToInt32(Console.ReadLine());
                check = true;
            } while (a > b);
            Console.WriteLine("b - a 는 {0}입니다.", b - a);
        }

        static public void Digit()
        {
            string a = null;
            Console.Write("a의 값 : ");
            a = Console.ReadLine();

            Console.WriteLine("그 수는 {0}자리입니다.", a.Length);
        }

        static public void MultiplicationTable()
        {
            Console.Write("   ");
            for (int k = 1; k < 10; k++)
            {
                if (k == 1) Console.Write("|");
                Console.Write("{0,3} ", k);
            }
            Console.WriteLine("");
            Console.WriteLine("---+-----------------------------------");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (j == 1)
                    {
                        Console.Write(" {0} |", i);
                    }
                    Console.Write("{0,3} ", i * j);
                }
                Console.WriteLine();
            }
        }

        static public void AdditionTable()
        {
            Console.Write("   ");
            for (int k = 1; k < 10; k++)
            {
                if (k == 1) Console.Write("|");
                Console.Write("{0,3} ", k);
            }
            Console.WriteLine("");
            Console.WriteLine("---+-----------------------------------");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (j == 1)
                    {
                        Console.Write(" {0} |", i);
                    }
                    Console.Write("{0,3} ", i + j);
                }
                Console.WriteLine();
            }
        }

        static public void SquarePrint()
        {
            int inputValue;
            Console.Write("입력할 수 : ");
            inputValue = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < inputValue; i++)
            {
                for (int j = 0; j < inputValue; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static public void RectanglePrint()
        {
            int width, height;

            Console.Write("높이 : ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("너비 : ");
            width = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static public void TriangleLB(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static public void TriangleLU(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static public void TriangleRU(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i <= j)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static public void TriangleRB(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= 1; j--)
                {
                    if (i >= j)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
        }

        static public void Spira(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static public void nrpira(int n)
        {
            int k = 1;
            for (int i = n; i >= 1; i--)
            {
                for (int b = 0; b < k - 1; b++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(k % 10);
                }
                k++;
                Console.WriteLine();
            }
        }

    }
}
