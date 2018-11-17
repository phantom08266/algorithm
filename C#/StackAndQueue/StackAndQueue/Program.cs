using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stacklib;
using Queuelib;

namespace StackAndQueue
{
    public enum Satatus
    {
        Success = 0, Error = -1
    }

    class Program
    {
        static void Main(string[] args)
        {
#if stack
            CommonStack stack = new CommonStack();
            IntStack stackItem;
            int max = 5;
            
            int status = stack.Initialize(out stackItem, max);
            if (StackAndQueue.Satatus.Error.Equals(status))
                Console.WriteLine("Stack error");

            stack.Push(ref stackItem, 1);
            stack.Push(ref stackItem, 2);
            stack.Push(ref stackItem, 3);
            stack.Push(ref stackItem, 4);
            stack.Push(ref stackItem, 5);

            int seekValue = 0;
            stack.Seek(ref stackItem, ref seekValue);
            Console.WriteLine(seekValue);
#endif
            CommonQueue queue = new CommonQueue();
            IntQueue queueItem;
            int max = 5;

            int status = queue.Initialize(out queueItem, max);
            queue.Enqueue(ref queueItem, 1);
            queue.Enqueue(ref queueItem, 2);
            queue.Enqueue(ref queueItem, 3);
            queue.Enqueue(ref queueItem, 4);
            queue.Enqueue(ref queueItem, 5);

            queue.Print(ref queueItem);

            int x = 0;
            queue.Dequeue(ref queueItem, ref x); Console.WriteLine("Dequeue = {0}", x);
            queue.Dequeue(ref queueItem, ref x); Console.WriteLine("Dequeue = {0}", x);
            queue.Dequeue(ref queueItem, ref x); Console.WriteLine("Dequeue = {0}", x);

            queue.Enqueue(ref queueItem, 1);
            queue.Print(ref queueItem);
            Console.ReadLine();

        }
    }
}
