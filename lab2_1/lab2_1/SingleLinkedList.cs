using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    public class Node
    {
        private string info;
        private Node link;

        public string Info
        {
            set
            {
                info = value;
            }

            get
            {
                return info;
            }
        }

        public Node Link
        {
            set
            {
                link = value;
            }

            get
            {
                return link;
            }
        }

        public Node () { }

        public Node (string info)
        {
            Info = info;
        }

        public Node (string info, Node link)
        {
            Info = info;
            Link = link;
        }
    }
    public class SingleLinkedList
    {
        private Node first;
        private int count;

        public SingleLinkedList ()
        {
            first = null; // создание списка
            count = 0;
        }

        public Node First
        {
            get { return first; }
            set { first = value; }
        }

        public int Count
        {
            // возвращает количество узлов в списке

            get { return count; }
        }

        public void AddFirst(string value)
        {
            // добавляет узел с заданным значение в начало списка

            Node p = new Node(value, first);
            first = p;

            count++;
        }

        public void AddLast(string value)
        {
            // добавляет узел с заданным значение в конец списка

            Node p = new Node(value, null);

            if (first != null)
            {
                Node last = first;
                while (last.Link != null)
                    last = last.Link;

                last.Link = p;
            }
            else
                first = p;

            count++;
        }

        public void AddValue(string value, int index)
        {
            // добавляет узел с заданным значением перед элементом индекс которого указан

            if (index > Count - 1 | index < 0)
                throw new IndexOutOfRangeException();

            else if (index == 0)
                AddFirst(value);

            else if (index == Count - 1)
                AddLast(value);

            else
            {
                Node p = new Node(value);
                Node q = first;

                for (int i = 0; i < index - 1; i++)
                    q = q.Link;

                p.Link = q.Link;
                q.Link = p;

                count++;
            }

        }

        public void RemoveFirst ()
        {
            // удаляет первый узел в списке

            if (first != null)
                first = first.Link;

            else
                throw new ArgumentNullException();

            count--;
        }

        public void RemoveLast ()
        {
            // удаляет последний узел в списке

            if (first != null && first.Link != null)
            {
                Node p = first;
                while (p.Link.Link != null)
                    p = p.Link;

                p.Link = null;
            }

            count--;
        }

        public void Remove (Node p)
        {
            // удаляет заданный узел в списке

            if (p != null)
            {
                Node q = first;
                while (q != null && q.Link != p)
                    q = q.Link;

                if (q != null)
                    q.Link = p.Link;
                else
                    first = first.Link;
            }

            p = null;

            count--;
        }

        public Node Find (string value)
        {
            // находит первый встретившийся узел в списке со значением value
            
            Node p = first;
            while (p != null && p.Info != value)
                p = p.Link;

            return p;
        }

        public void Clear()
        {
            first = null;
        }

        public IEnumerator<string> GetEnumerator()
        {
            Node p = first;

            while (p != null)
            {
                yield return p.Info;
                p = p.Link;
            }
        }

        public SingleLinkedList GetStartsWithList(string comb)
        {
            SingleLinkedList startsWithList = new SingleLinkedList();
            Node p = first;

            while (p != null)
            {
                if (p.Info.StartsWith(comb))
                    startsWithList.AddLast(p.Info);

                p = p.Link;
            }
            
            return startsWithList;
        }

        public SingleLinkedList GetEndsWithList(string comb)
        {
            SingleLinkedList endsWithList = new SingleLinkedList();
            Node p = first;

            while (p != null)
            {
                if (p.Info.EndsWith(comb))
                    endsWithList.AddLast(p.Info);

                p = p.Link;
            }

            return endsWithList;
        }
    }
}
