using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Plan_Maker
{
    internal class UpdateFile
    {
        static public void Update_File(Dictionary<DateTime, List_Event> todolist) 
        {
            StreamWriter sw;
            sw = new StreamWriter(PlanList.plan);
            foreach (var item in todolist)
            {
                Node_Event node = item.Value.Head;
                while (node != null)
                {
                    string s = "";
                    while (node.Event.IndexOf(" ") >= 0) node.Event = node.Event.Replace(" ", "_");
                    s = s + node.Event + " " + node.Begin.Hour + " " + node.Begin.Minute + " " + node.Begin.Second + " " + node.Begin.Day + " " + node.Begin.Month + " " + node.Begin.Year
                        + " " +node.End.Hour + " " + node.End.Minute + " " + node.End.Second + " " + node.End.Day + " " + node.End.Month + " " + node.End.Year
                        + " " +node.Imp + " " +node.Check;
                    sw.WriteLine(s);
                    node = node.Next;
                }
            }
            sw.Close();
        }

    }
}
