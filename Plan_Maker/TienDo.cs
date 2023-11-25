using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Plan_Maker
{
    public partial class TienDo : Form
    {
        int succecfuldukien = 0;
        int tongcongviec = 0;
        int succecfulthucte = 0;
        int danglam = 0;
        int chualam = 0;
        SortedDictionary<DateTime, List_Event> sortedDictionary = new SortedDictionary<DateTime, List_Event>();
        public TienDo()
        {
            InitializeComponent();
            sapxep();
            uoctinh();
        }
        void uoctinh()
        {
            foreach (var item in sortedDictionary)
            {
                for (Node_Event p = item.Value.Head; p != null; p = p.Next)
                {
                    if (p.End <= DateTime.Now)
                    {
                        succecfuldukien++;
                    }
                    if(p.Check==1) 
                    {
                        succecfulthucte++;
                    }
                    if(p.Check==0)
                    {
                        if(p.End < DateTime.Now) 
                        {
                            showlistviewtretiendo(p);
                        }
                        if (p.Begin <= DateTime.Now)
                        {
                            danglam++;
                        }
                        if(p.Begin > DateTime.Now)
                        {
                            chualam++;
                        }
                    }
                    tongcongviec++;
                }
            }
            float a2 = (float)((float)succecfulthucte / (float)tongcongviec) * 100;
        }
        void sapxep()
        {
            foreach (var item in YourPlan.todolist)
            {
                sortedDictionary.Add(item.Key, item.Value);
            }
        }
        public SortedDictionary<DateTime, List_Event> SortedDictionary { get => sortedDictionary; set => sortedDictionary = value; }
        public int Succecfuldukien { get => succecfuldukien; set => succecfuldukien = value; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float a1 = (float)((float)succecfuldukien / (float)tongcongviec) * 100;
            if (pBar1.Value == (int)a1)
            {
                pBar1.Text = pBar1.Value.ToString() + "%";
                timer1.Enabled = false;
            }
            else
            {
                pBar1.Value += 1;
                pBar1.Text = pBar1.Value.ToString() + "%";
            }
        }
        string Project_name (string project)
        {
            int i = project.Length-5;
            string kq = "";
            while (project[i] != '/')
            {
                kq = project[i] + kq;
                i--;
            }
            return kq;
        }
        private void TienDo_Load(object sender, EventArgs e)
        {
            pBar1.Value = 0;
            pBar2.Value = 0;
            startButton.Text = string.Format("{0:dd/MM/yyyy}", sortedDictionary.First().Key);
            endButton.Text = string.Format("{0:dd/MM/yyyy}", sortedDictionary.Last().Value.Tail.End);
            tenDuAn_text.Text = Project_name(PlanList.plan);
            hoanthanh_label.Text += "    " + succecfulthucte + " (" + (int)(((float)succecfulthucte / (float)tongcongviec) * 100)+" %)";
            danglam_label.Text+= "         " + danglam + " (" + (int)(((float)danglam / (float)tongcongviec) * 100) + " %)";
            chualam_label.Text+= "         " + chualam + " (" + (100- (int)(((float)succecfulthucte / (float)tongcongviec) * 100)- (int)(((float)danglam / (float)tongcongviec) * 100)) + " %)";
            if (succecfuldukien <= succecfulthucte)
            {
                stateButton.Text = "Đúng tiến độ";
                stateButton.BackColor = Color.PaleGreen;
                stateButton.ForeColor = Color.LimeGreen;
            }
            congviec.Text=tongcongviec.ToString();
            ChartBDT.Series["ChartBDT"].Points.AddXY(" ",succecfulthucte);
            ChartBDT.Series["ChartBDT"].Points.AddXY("  ", danglam);
            ChartBDT.Series["ChartBDT"].Points.AddXY("   ", chualam);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            float a2 = (float)((float)succecfulthucte / (float)tongcongviec) * 100;
            if (pBar2.Value == (int)a2)
            {
                pBar2.Text = pBar2.Value.ToString() + "%";
                timer2.Enabled = false;
            }
            else
            {
                pBar2.Value += 1;
                pBar2.Text = pBar2.Value.ToString() + "%";
            }

        }
        void showlistviewtretiendo(Node_Event new_node)
        {
            ListViewItem item = new ListViewItem();
            item.Text = new_node.Event;
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = new_node.Begin.ToString() });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = new_node.End.ToString() });
            listCVTre.Items.Add(item);
        }
    }
}
