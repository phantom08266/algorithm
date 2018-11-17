using LinkedListProject.FreeList;
using LinkedListProject.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class Program
    {

        static LinkedList linkedList = new LinkedList();
        static LinkedListAndFreeList linkedList2 = new LinkedListAndFreeList();

        static void Main(string[] args)
        {
            //LinkedListProject.List.List list = new LinkedListProject.List.List();

            //linkedList.Initialize(list);


            //linkedList.InsertRear(list, 1);
            //linkedList.InsertRear(list, 2);
            //linkedList.InsertRear(list, 3);
            //linkedList.InsertRear(list, 4);
            //linkedList.InsertRear(list, 5);

            //linkedList.RemoveFront(list);
            //linkedList.RemoveRear(list);

            //linkedList.Print(list);


            LinkedListProject.FreeList.List list = new FreeList.List();
            linkedList2.Initialize(list, 8);
            linkedList2.InsertFront(list, 'A');
            linkedList2.InsertFront(list, 'B');
            linkedList2.InsertFront(list, 'C');
            linkedList2.InsertFront(list, 'D');
            linkedList2.Print(list);
            //Console.WriteLine("=====");
            //linkedList2.InsertRear(list, 'E');
            //linkedList2.InsertRear(list, 'F');
            //linkedList2.Print(list);
            Console.WriteLine("=====");
            linkedList2.RemoveRear(list);
            linkedList2.Print(list);
            Console.WriteLine("=====");
            linkedList2.InsertFront(list, 'H');
            linkedList2.Print(list);
            ////linkedList2.Print(list);
            Console.WriteLine("=====");
            linkedList2.AllPrint(list);
            Console.ReadLine();
        }
    }
}
