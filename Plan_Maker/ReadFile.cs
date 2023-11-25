using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Plan_Maker
{
    public class ReadFile
    {
        static public void Read_File()
        {
            string file = PlanList.plan;
            string sf = "";
            int i = file.Length-1;
            while (file[i]!= '\\') 
            {
                sf = file[i] + sf;
                i--;
            }
            file = file + "/" + sf +".txt";
            FileInfo fileInfo = new FileInfo(file);
            if (!fileInfo.Exists)
            {
                StreamWriter sw = new StreamWriter(file);
                sw.Close();
            }
            PlanList.plan = file;
            string[] Data = File.ReadAllLines(file);
            foreach (string s in Data)
            {
                Node_Event node_event = new Node_Event();
                string[] kq = s.Split(' ');
                while (kq[0].IndexOf("_") >= 0) kq[0]=kq[0].Replace("_", " ");
                node_event.Event = kq[0];
                DateTime tempBegin = new DateTime(Int32.Parse(kq[6]), Int32.Parse(kq[5]), Int32.Parse(kq[4]), Int32.Parse(kq[1]), Int32.Parse(kq[2]), Int32.Parse(kq[3]));
                DateTime tempEnd = new DateTime(Int32.Parse(kq[12]), Int32.Parse(kq[11]), Int32.Parse(kq[10]), Int32.Parse(kq[7]), Int32.Parse(kq[8]), Int32.Parse(kq[9]));
                DateTime key = new DateTime(Int32.Parse(kq[6]), Int32.Parse(kq[5]), Int32.Parse(kq[4]));
                node_event.Imp = Int32.Parse(kq[13]);
                node_event.Check = Int32.Parse(kq[14]);
                node_event.Begin = tempBegin;
                node_event.End = tempEnd;
                if (!YourPlan.todolist.ContainsKey(key))
                {
                    YourPlan.todolist.Add(key, new List_Event());
                }
                YourPlan.todolist[key].Add_Sort(node_event);
            }
        }
    }
}
