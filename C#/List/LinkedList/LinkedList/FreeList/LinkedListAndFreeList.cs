using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject.FreeList
{
    public class Node
    {
        public char Data;
        public int NextIndex;
        public int FreeListNextNode;
    }
    public class List
    {
        public Node[] ListArray;
        public int Head;
        public int Max;
        public int tail;
        public int FreeNodeHead;
    }

    public class LinkedListAndFreeList
    {
        public LinkedListAndFreeList()
        {

        }

        public void Initialize(List list, int size)
        {
            list.ListArray = new Node[size];
            list.Max = size;
            list.tail = 0;
            list.Head = -1;
            list.FreeNodeHead = -1;
        }

        public bool Search(List list, char data)
        {
            foreach (Node node in list.ListArray)
            {
                if (node.Data == data)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetIndex(List list)
        {
            if(list.FreeNodeHead ==  -1)
            {
                if(list.Max > list.tail)
                {
                    return list.tail++;
                }
                return -1;
            }
            else
            {
                int index = list.FreeNodeHead;
                list.FreeNodeHead = list.ListArray[index].FreeListNextNode;
                return index;
            }
        }

        public Node SetDataNode(char data, int nextIndex)
        {
            Node node = new Node();
            node.Data = data;
            node.NextIndex = nextIndex;
            return node;
        }

        public void InsertFront(List list, char data)
        {
            int ptr = GetIndex(list);
            if (ptr == -1) return;
            
            list.ListArray[ptr] = SetDataNode(data, list.Head);
            list.Head = ptr;
        }

        public void InsertRear(List list, char data)
        {
            if (list.Head == -1) InsertFront(list, data);

            int ptr = 0;
            int tailPtr = 0;
            while (list.ListArray[ptr] != null)
            {
                if (list.ListArray[ptr].NextIndex == -1) tailPtr = ptr;
                ptr++;
            }

            if (ptr >= list.Max) return;
            list.ListArray[ptr] = SetDataNode(data, -1);
            list.ListArray[tailPtr].NextIndex = ptr;
        }

        public void RemoveFront(List list)
        {
            if (list.Head != -1)
            {
                int tempIndex = list.Head;
                list.Head = list.ListArray[tempIndex].NextIndex;
                list.ListArray[tempIndex].FreeListNextNode = list.FreeNodeHead;
                list.FreeNodeHead = tempIndex;
                //list.ListArray[tempIndex] = null;
            }
        }

        public void RemoveRear(List list)
        {
            if (list.Head != -1)
            {
                if(list.ListArray[list.Head].NextIndex ==  -1)
                {
                    RemoveFront(list);
                }
                else
                {
                    int index = list.Head;
                    int postIndex = index;
                    while(list.ListArray[index] != null)
                    {
                        if (list.ListArray[index].NextIndex == -1) break;
                        postIndex = index;
                        index = list.ListArray[index].NextIndex;
                    }

                    list.ListArray[index].FreeListNextNode = list.FreeNodeHead;
                    list.FreeNodeHead = index;

                    list.ListArray[postIndex].NextIndex = -1;
                }

                //int ptr = list.Head;
                //int postPtr = ptr;
                //while (list.ListArray[ptr].NextIndex != -1)
                //{
                //    postPtr = ptr;
                //    ptr = list.ListArray[ptr].NextIndex;
                //}

                //if (ptr == postPtr)
                //{
                //    RemoveFront(list);
                //}
                //else
                //{
                //    list.ListArray[postPtr].NextIndex = -1;
                //    list.ListArray[ptr] = null;
                //}
            }
        }

        public void Print(List list)
        {
            int ptr = list.Head;
            if (ptr == -1) return;
            while (list.ListArray[ptr] != null)
            {
                Console.WriteLine("Data : {0}, Index : {1}, FreeNextNodeIndex : {2}", list.ListArray[ptr].Data, ptr, list.ListArray[ptr].FreeListNextNode);
                ptr = list.ListArray[ptr].NextIndex;
                if (ptr == -1) break;
            }
        }

        public void AllPrint(List list)
        {
            int ptr = 0;
            foreach (Node node in list.ListArray)
            {
                if (node == null) continue;
                Console.WriteLine("Data : {0}, Index : {1}, FreeNextNodeIndex : {2}", list.ListArray[ptr].Data, ptr, list.ListArray[ptr].FreeListNextNode);
                ptr++;
            }
        }
    }
}
