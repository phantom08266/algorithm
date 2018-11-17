using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacklib
{
    public unsafe struct IntStack
    {
        public int max;
        public int ptr;
        public int* stk;
    }

    public class CommonStack : IDisposable
    {
        ///<summary> 스택 초기화 </summary>
        public unsafe int Initialize(out IntStack stack, int max)
        {
            stack = new IntStack();
            stack.max = max;
            stack.ptr = 0;
            try
            {
                int[] intStackArray = new int[max];
                fixed (int* ptr = intStackArray)
                {
                    stack.stk = ptr;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
            return 0;
        }

        public unsafe int Push(ref IntStack stack, int x)
        {
            if (stack.max <= stack.ptr)
                return -1;
            stack.stk[stack.ptr++] = x;
            return 0;
        }

        public unsafe int Pop(ref IntStack stack, ref int x)
        {
            if (stack.ptr <= 0)
                return -1;
            x = stack.stk[--stack.ptr];
            return 0;
        }

        /// <summary>
        /// 스택 꼭대기의 데이터를 알려주는 함수
        /// </summary>
        /// <param name="stack">스택 배열</param>
        /// <param name="x">스택 꼭대기 값 반환</param>
        /// <returns></returns>
        public unsafe int Seek(ref IntStack stack, ref int x)
        {
            if (stack.ptr <= 0)
                return -1;
            x = stack.stk[stack.ptr - 1];
            return 0;
        }

        public unsafe int Clear(ref IntStack stack)
        {
            stack.stk = null;
            return 0;
        }

        /// <summary>
        /// 스택 용량
        /// </summary>
        /// <param name="stack">스택 배열</param>
        /// <returns></returns>
        public int Capacity(ref IntStack stack)
        {
            return stack.max;
        }

        /// <summary>
        /// 스택에 쌓여있는 데이터 수
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        public int Size(ref IntStack stack)
        {
            return stack.ptr;
        }

        public int IsEmpty(ref IntStack stack)
        {
            return stack.ptr == 0 ? 1 : 0;
        }

        public int IsFull(ref IntStack stack)
        {
            return stack.max <= stack.ptr ? 1 : 0;
        }
        /// <summary>
        /// 스택에 있으면 해당 인덱스 반환
        /// </summary>
        /// <param name="stack"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public unsafe int Search(ref IntStack stack, int x)
        {
            for (int i = 0; i < stack.max; i++)
            {
                if (stack.stk[i].Equals(x))
                {
                    return i;
                }
            }
            return -1;
        }

        public unsafe void Print(ref IntStack stack)
        {
            for (int i = 0; i < stack.max; i++)
            {
                Console.WriteLine(stack.stk[i]);
            }
        }

        /// <summary>
        /// 스택 종료
        /// </summary>
        /// <param name="stack"></param>
        public unsafe void Terminate(ref IntStack stack)
        {
            stack.max = 0;
            stack.ptr = 0;
            stack.stk = null;
            Dispose();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
