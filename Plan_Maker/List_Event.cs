using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan_Maker
{
    public class List_Event
    {
        Node_Event head = new Node_Event();
        Node_Event tail = new Node_Event();
        public Node_Event Head { get => head; set => head = value; }
        public Node_Event Tail { get => tail; set => tail = value; }

        public List_Event()
        {
            Head = null;
            Tail = null;
        }
        public void Add(Node_Event p)
        {
            if (Head == null)
            {
                Head = p;
                Tail = p;
                return;
            }
            tail.Next = p;
            tail = p;
        }
        public void Add_Sort(Node_Event p)
        {
            if (Head == null)
            {
                Head = p;
                Tail = p;
                //return;
            }
            else
            if (Head == Tail)
            {
                if (Head.Begin < p.Begin)
                {
                    Tail.Next = p;
                    Tail = p;
                }
                else
                {
                    p.Next = Head;
                    Head = p;
                }
                //return;
            }
            else
            {
                Node_Event q = Head;
                while (q.Next != null && q.Next.Begin < p.Begin) q = q.Next;
                if (q == Head && q.Begin > p.Begin)
                {
                    p.Next = q;
                    Head = p;
                }
                else
                {
                    p.Next = q.Next;
                    q.Next = p;
                }
            }
            //beginToEvent.Add(p.Event, p);
        }
        public void Remove(Node_Event p)
        {
            if (Head == null)
                return;
            if (Head == p)
            {
                if (Head == Tail)
                {
                    Head = null;
                    Tail = null;
                    return;
                }
                else
                {
                    Head = Head.Next;
                }
                
            }
            Node_Event q = Head;
            while (q!=null)
            {
                if (q.Next == p)
                {
                    if (q.Next == Tail) Tail = q;
                    q.Next = p.Next;
                    return;
                }
                q = q.Next;
            }
        }

        public void SortAZ()
        {
            for (Node_Event p = Head; p.Next != null; p = p.Next)
            {
                for(Node_Event q = p.Next; q != null; q = q.Next)
                {
                    if (p.Event.CompareTo(q.Event) > 0)
                    {
                        Node_Event temp = new Node_Event(q);
                        q.reInfo(p);
                        p.reInfo(temp);
                    }
                }
            }
        }
        public void SortZA()
        {
            for (Node_Event p = Head; p.Next != null; p = p.Next)
            {
                for (Node_Event q = p.Next; q != null; q = q.Next)
                {
                    if (p.Event.CompareTo(q.Event) < 0)
                    {
                        Node_Event temp = new Node_Event(q);
                        q.reInfo(p);
                        p.reInfo(temp);
                    }
                }
            }
        }
        public void SortBE()
        {
            for (Node_Event p = Head; p.Next != null; p = p.Next)
            {
                for (Node_Event q = p.Next; q != null; q = q.Next)
                {
                    if (p.Begin > q.Begin)
                    {
                        Node_Event temp = new Node_Event(q);
                        q.reInfo(p);
                        p.reInfo(temp);
                    }
                }
            }
        }
        public void SortEB()
        {
            for (Node_Event p = Head; p.Next != null; p = p.Next)
            {
                for (Node_Event q = p.Next; q != null; q = q.Next)
                {
                    if (p.Begin < q.Begin)
                    {
                        Node_Event temp = new Node_Event(q);
                        q.reInfo(p);
                        p.reInfo(temp);
                    }
                }
            }
        }
    }
}
