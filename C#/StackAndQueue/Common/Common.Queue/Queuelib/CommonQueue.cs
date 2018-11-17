using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuelib
{
    public unsafe struct IntQueue
    {
        public int max;
        public int num; //현재 데이터 수
        public int* que;
    }

    public class CommonQueue
    {
        /// <summary> 큐 초기화 </summary>
        public unsafe int Initialize(out IntQueue queue, int max)
        {
            queue = new IntQueue();
            queue.max = max;
            queue.num = 0;
            try
            {
                int[] queueArray = new int[max];
                fixed (int* ptr = queueArray)
                {
                    queue.que = ptr;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
            return 0;
        }

        public unsafe int Enqueue(ref IntQueue queue, int x)
        {
            if (queue.num >= queue.max)
                return -1;
            queue.que[queue.num++] = x;
            return 0;
        }

        public unsafe int Dequeue(ref IntQueue queue, ref int x)
        {
            if (queue.max <= 0)
                return -1;
            x = queue.que[0];
            for (int i = 0; i < queue.num; i++)
            {
                if ((i + 1) >= queue.max) break;
                queue.que[i] = queue.que[i + 1];
            }
            queue.num--;
            return 0;
        }

        public unsafe void Print(ref IntQueue queue)
        {
            for (int i = 0; i < queue.num; i++)
            {
                Console.WriteLine("Queue[{0}] = {1}", i, queue.que[i]);
            }
        }
    }
}
