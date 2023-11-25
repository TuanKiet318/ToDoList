using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan_Maker
{
    public class Node_State
    {
        Dictionary<DateTime, List_Event> state = new Dictionary<DateTime, List_Event>();
        DateTime time = new DateTime();
        Node_State next;

        public Node_State()
        {

        }
        public Node_State(Dictionary<DateTime, List_Event> new_list)
        {
            //Time = new_time;
            State = new_list;
        }
        public Node_State Next { get => next; set => next = value; }
        public Dictionary<DateTime, List_Event> State { get => state; set => state = value; }
        public DateTime Time { get => time; set => time = value; }
    }
}
