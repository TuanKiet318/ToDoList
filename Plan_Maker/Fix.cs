using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_Maker
{
    public partial class Fix : Form
    {
        public Fix()
        {
            InitializeComponent();
        }
        Node_Event node = new Node_Event();

        public Node_Event Node { get => node; set => node = value; }

        public void Info(Node_Event node)
        {
            Node = node;
        }

        private void Fix_Load(object sender, EventArgs e)
        {
            Add_tbox.Text = node.Event;
            begin_picker.Value = node.Begin;
            end_picker.Value = node.End;
            if (node.Imp == 1) imp_cbox.Checked = true;
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            Node_Event copy = new Node_Event(node.Event, node.Begin, node.End, node.Imp, node.Check);
            YourPlan.todolist[node.Begin.Date].Remove(node);
            copy.Event = Add_tbox.Text;
            copy.Begin = begin_picker.Value;
            copy.End = end_picker.Value;
            if (imp_cbox.Checked) copy.Imp = 1; else copy.Imp = 0;
            if (!YourPlan.todolist.ContainsKey(copy.Begin.Date))
                YourPlan.todolist.Add(copy.Begin.Date, new List_Event());
            YourPlan.todolist[copy.Begin.Date].Add(copy);
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
