using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_Maker
{
    public class Node_Event
    {
        string _event;
        DateTime begin;
        DateTime end;
        Node_Event next;
        int imp = 0;
        int check = 0;
        public Node_Event() 
        {
        }
        public Node_Event(string event_value, DateTime begin, DateTime end, int imp, int check)
        {
            Event = event_value;
            Begin = begin;
            End = end;
            Imp = imp;
            Check = check;
        }
        public Node_Event(Node_Event new_node)
        {
            this.Event = new_node.Event;
            this.Begin = new_node.Begin;
            this.End = new_node.End;
            this.Imp = new_node.Imp;
            this.Check = new_node.Check;
        }
        public void reInfo(Node_Event new_node)
        {
            this.Event = new_node.Event;
            this.Begin = new_node.Begin;
            this.End = new_node.End;
            this.Imp = new_node.Imp;
            this.Check = new_node.Check;
        }
        public string Event { get => _event; set => _event = value; }
        public Node_Event Next { get => next; set => next = value; }
        public int Imp { get => imp; set => imp = value; }
        public int Check { get => check; set => check = value; }
        public DateTime Begin { get => begin; set => begin = value; }
        public DateTime End { get => end; set => end = value; }

        public override string ToString()
        {
            return Event + " " +Begin.ToString();
        }
        public void Display()
        {
            string output = "";
            output += "Sự kiện: " + Event + "\n"
            + "Bắt đầu: " + Begin.ToString() + "\n"
            + "Kết thúc: " + End.ToString() + "\n"
            + "Quan trọng: ";
            if (Imp == 1) output += "Yes"; else output += "No";
            MessageBox.Show(output, "Chi tiết");
        }
    }
}
