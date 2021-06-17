using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    public class DoubleNode
    {
        private string info;
        private DoubleNode next;
        private DoubleNode prev;
        public string Info
        {
            get { return info; }
            set { info = value; }
        }
        public DoubleNode Next
        {
            get { return next; }
            set { next = value; }
        }
        public DoubleNode Prev
        {
            get { return prev; }
            set { prev = value; }
        }
        public DoubleNode() { }
        public DoubleNode(string info)
        {
            Info = info;
        }
        public DoubleNode(string info, DoubleNode next, DoubleNode prev)
        {
            Info = info;
            Next = next;
            Prev = prev;
        }
    }

    class CycleDoubleLinkedList
    {
        private DoubleNode head;
        public CycleDoubleLinkedList()
        {
            head = new DoubleNode();
            head.Next = head;
            head.Prev = head;
        }

        public int Count()
        {
            int count;

            if (head != null)
            {
                count = 0;
                DoubleNode p = head.Next;
                while (p != head)
                {
                    p = p.Next;
                    count++;
                }

                return count;
            }
            else
                throw new ArgumentNullException();
        }

        public bool isCreated() => head != null ? true : false; // показывает существует ли список

        public bool isEmpty() => head.Next == head & head.Prev == head ? true : false; // показывает пуст ли список


        public void AddFirst(string value)
        {
            DoubleNode node = new DoubleNode(value, head.Next, head);
            head.Next.Prev = node;
            head.Next = node;
        }

        public void AddLast(string value)
        {
            DoubleNode node = new DoubleNode(value, head, head.Prev);
            head.Prev.Next = node;
            head.Prev = node;
        }

        public void Add(string value, int index)
        {
            if (index > Count() - 1 | index < 0)
                throw new IndexOutOfRangeException();

            else if (index == 0)
                AddFirst(value);

            else if (index == Count() - 1)
                AddLast(value);

            else
            {
                DoubleNode q = head;

                int i = 0;
                while (i < index)
                {
                    q = q.Next;
                    i++;
                }

                DoubleNode p = new DoubleNode(value, q, q.Prev);
                q.Prev.Next = p;
                q.Prev = p;
            }
        }

        public void RemoveFirst()
        {
            if (head != null && head.Next != head && head.Prev != head)
            {
                DoubleNode p = head.Next;
                p.Next.Prev = head;
                head.Next = p.Next;
            }
            else
                throw new ArgumentNullException();
        }

        public void RemoveLast()
        {
            if (head != null && head.Next != head && head.Prev != head)
            {
                DoubleNode p = head.Next;
                p.Next.Prev = head;
                head.Next = p.Next;
            }
            else
                throw new ArgumentNullException();
        }

        public void Remove(DoubleNode node)
        {
            if (node != null && node != head)
            {
                node.Prev.Next = node.Next;
                node.Next.Prev = node.Prev;
            }

            node = null;
        }

        public void Clear()
        {
            head = null;
        }

        public IEnumerator<string> GetEnumerator()
        {
            DoubleNode p = head.Next;

            while (p != head)
            {
                yield return p.Info;
                p = p.Next;
            }
        }

        public DoubleNode Find(string value)
        {
            DoubleNode node = head.Next;

            while (node != head && node.Info != value)
                node = node.Next;

            if (node == head)
                node = null;

            return node;
        }

        public CycleDoubleLinkedList GetStartsWithList(string comb)
        {
            CycleDoubleLinkedList startsWithList = new CycleDoubleLinkedList();
            DoubleNode p = head.Next;

            while (p != head)
            {
                if (p.Info.StartsWith(comb))
                    startsWithList.AddLast(p.Info);

                p = p.Next;
            }

            return startsWithList;
        }

        public CycleDoubleLinkedList GetEndsWithList(string comb)
        {
            CycleDoubleLinkedList endsWithList = new CycleDoubleLinkedList();
            DoubleNode p = head.Next;

            while (p != head)
            {
                if (p.Info.EndsWith(comb))
                    endsWithList.AddLast(p.Info);

                p = p.Next;
            }

            return endsWithList;
        }
    }
}
