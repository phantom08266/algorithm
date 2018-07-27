using System;
using System.Collections.Generic;
using System.Text;

namespace SecondWeek
{
    class Q7_CardinalNumeral
    {
        public void Start()
        {
            int value;
            int jinsu;
            int check=1;
            char[] card = new char[100];

            while(check == 1)
            {
                Array.Clear(card, 0, card.Length);
                Console.WriteLine("10진수를 기수 변환합니다.");
                Console.Write("변화하는 음이 아닌 정수 : ");
                value = Convert.ToInt32(Console.ReadLine());
                do
                {
                    Console.Write("어떤 진수로 변환할까요?(2-36) : ");
                    jinsu = Convert.ToInt32(Console.ReadLine());
                } while (jinsu < 2 || jinsu > 36);

                Card_conv(value, jinsu, ref card);
                Console.WriteLine("{0}진수로 {1}입니다.", jinsu, new string(card).Replace("\0", ""));
                Console.Write("한번 더 할까요?(1---예 / 0---아니오) : ");
                check =  Convert.ToInt32(Console.ReadLine());
            }
        }

        private int Card_conv(int x, int n, ref char[] d)
        {
            char[] arr = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            int digits = 0;
            do
            {
                int index = x % n;
                d[digits++] = arr[index];
                
                if(x == 0)
                {
                    Console.WriteLine("        0");
                }
                else
                {
                    Console.WriteLine("{0} |     {1} ---{2}", n, x, d[digits - 1]);
                    Console.WriteLine("  +----------");
                }
                x /= n;
            } while (x != 0);

            Array.Reverse(d);
            
            return digits;
        }
    }
}
