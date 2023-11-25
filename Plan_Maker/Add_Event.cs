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
    public partial class Add_Event : Form
    {
        public Add_Event()
        {
            InitializeComponent();
        }
        int impt(bool input)
        {
            if (input) return 1;
            return 0;
        }
        private void Ok_btn_Click(object sender, EventArgs e)
        {
            if (begin_picker.Value <= end_picker.Value)
            {
                Node_Event new_node = new Node_Event(Add_tbox.Text, begin_picker.Value, end_picker.Value, impt(imp_cbox.Checked), 0);
                if (!YourPlan.todolist.ContainsKey(begin_picker.Value.Date))
                {
                    YourPlan.todolist.Add(begin_picker.Value.Date, new List_Event());
                }
                YourPlan.todolist[begin_picker.Value.Date].Add_Sort(new_node);
                ListViewItem item = new ListViewItem();
                item.Text = new_node.Event;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = new_node.Begin.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = new_node.End.ToString() });
                listView1.Items.Add(item);
            }
            else MessageBox.Show("Thời gian bắt đầu không được sau thời gian kết thúc!");
        }

        private void rjDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Event_Load(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void begin_picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
