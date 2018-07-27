using System;
using System.Collections.Generic;
using System.Text;

namespace SecondWeek
{
    /*
     * 정수 x값을 n 진수로 변환하여 배열 d에 위자리부터 저장
    */
    class Q6_CardConvert
    {
        public void Start()
        {
            int value = 15621523;
            int jinsu = 16;
            char[] card = new char[10];
            Card_conv(value, jinsu, ref card);

            Console.WriteLine(card);
        }

        private int Card_conv(int x, int n, ref char[] d)
        {
            char[] arr = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            int digits = 0;
            do
            {
                int index = x % n;
                d[digits++] = arr[index];
                x /= n;
            } while (x != 0);

            Array.Reverse(d);
            return digits;
        }
    }
}
