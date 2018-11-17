using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject.List
{
    public class Node
    {
        public int Data;
        public Node NextNode;
    }

    public class List
    {
        public Node Head;
        public Node CurrentNode;
    }

    public class LinkedList
    {
        public LinkedList()
        {
        }
        /// <summary>
        /// 초기화
        /// </summary>
        /// <param name="parent"></param>
        public void Initialize(List parent)
        {
            parent.Head = null;
            parent.CurrentNode = null;
        }
        /// <summary>
        /// data값을 갖는 노드 검색
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node Search(List parent, int data)
        {
            Node node = parent.Head;
            while (node != null)
            {
                if (node.Data == data)
                {
                    parent.CurrentNode = node;
                    return node;
                }
                else
                {
                    node = node.NextNode;
                }
            }
            return null;
        }
        /// <summary>
        /// 머리에 노드삽입
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="data"></param>
        public void InsertFront(List parent, int data)
        {
            Node node = parent.Head;
            Node newNode = new Node();
            newNode.Data = data;

            if (node == null)
            {
                parent.Head = newNode;
                parent.CurrentNode = newNode;
                newNode.NextNode = null;
            }
            else
            {
                newNode.NextNode = node;
                parent.Head = newNode;
            }
        }

        public void InsertRear(List parent, int data)
        {
            Node node = parent.Head;
            Node newnode = new Node();
            newnode.Data = data;
            newnode.NextNode = null;
            if (node == null)
            {
                parent.Head = newnode;
                parent.CurrentNode = newnode;
            }
            else
            {
                while(node != null)
                {
                    if(node.NextNode == null)
                    {
                        node.NextNode = newnode;
                        parent.CurrentNode = newnode;
                        return;
                    }
                    node = node.NextNode;
                }
            }
        }

        public void RemoveFront(List parent)
        {
            Node node = parent.Head;
            if (node != null)
            {
                Node removeNode = node;
                parent.Head = node.NextNode;
                parent.CurrentNode = parent.Head;
                removeNode = null;
            }
            else
            {
                parent.CurrentNode = null;
            }
        }

        public void RemoveRear(List parent)
        {
            Node node = parent.Head;
            
            while(node != null)
            {
                if (node.NextNode == null)
                {
                    parent.Head = null;
                    parent.CurrentNode = null;
                    return;
                }
                else if (node.NextNode.NextNode == null)
                {
                    node.NextNode = null;
                    parent.CurrentNode = node;
                    return;
                }
                node = node.NextNode;
            }
            //node 가 null일때
            parent.Head = null;
            parent.CurrentNode = null;
        }

        public void Clear(List parent)
        {
            while (parent.Head != null)
                RemoveFront(parent);
            parent.CurrentNode = null;
        }

        public void Print(List parent)
        {
            Node node = parent.Head;
            while(node != null)
            {
                Console.WriteLine("노드 값 : {0}", node.Data);
                node = node.NextNode;
            }
        }
    }
}
