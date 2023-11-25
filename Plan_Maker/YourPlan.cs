using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Plan_Maker
{
    public partial class YourPlan : Form
    {
        public YourPlan()
        {
            InitializeComponent();
            Reset();
            ReadFile.Read_File();
            LoadMatrix();
        }

        DateTime present = DateTime.Now;
        public static Dictionary<DateTime, List_Event> todolist = new Dictionary<DateTime, List_Event>();
        DateTime new_time = DateTime.Now;
        int imp = 0;

        Stack_State redo_Stack = new Stack_State();
        Stack_State undo_Stack = new Stack_State();
        Stack<DateTime> undo_T = new Stack<DateTime>();
        Stack<DateTime> redo_T = new Stack<DateTime>();

        private List<string> dateOfWeek = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        private List<List<CheckedListBox>> matrix;
        private List<List<Label>> lbl_mtx;
        public List<List<CheckedListBox>> Matrix { get; private set; }
        public CheckedListBox CheckedListBox { get; private set; }
        public List<List<Label>> Lbl_mtx { get => lbl_mtx; set => lbl_mtx = value; }

        void Reset()
        {
            todolist = new Dictionary<DateTime, List_Event>();
            redo_Stack = new Stack_State();
            undo_Stack = new Stack_State();
            undo_T = new Stack<DateTime>();
            redo_T = new Stack<DateTime>();
        }
        void showListView(Node_Event new_node)
        {
            ListViewItem item = new ListViewItem();
            item.Text = new_node.Event;
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = new_node.Begin.ToString() });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = new_node.End.ToString() });
            listCV.Items.Add(item);
        }
        void run(DateTime choosetime)
        {
            listCV.Items.Clear();
            if (todolist.ContainsKey(choosetime.Date))
            {
                Node_Event new_node = todolist[choosetime.Date].Head;
                while (new_node != null)
                {
                    showListView(new_node);
                    new_node = new_node.Next;
                }
            }
            AddNumberIntoMatrixByDate(choosetime);
        }
        void LoadMatrix()
        {
            pnlMatrix.BorderStyle = BorderStyle.FixedSingle;
            Matrix = new List<List<CheckedListBox>>();
            Lbl_mtx = new List<List<Label>>();
            CheckedListBox oldobj = new CheckedListBox() { Width = 0, Height = 0, Location = new Point(0, 15) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<CheckedListBox>());
                Lbl_mtx.Add(new List<Label>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    CheckedListBox obj = new CheckedListBox() { Width = Cons.dateCheckedListBoxWidth, Height = Cons.dateCheckedListBoxHeight };
                    obj.BorderStyle = BorderStyle.None;
                    obj.Location = new Point(oldobj.Location.X + oldobj.Width + 3, oldobj.Location.Y);
                    obj.Click += obj_Click;
                    obj.ItemCheck += obj_ItemChecked;
                    pnlMatrix.Controls.Add(obj);
                    Matrix[i].Add(obj);
                    Label lbl = new Label() { Width = obj.Width, Height = obj.Height, Location = new Point(obj.Location.X, obj.Location.Y - 15) };
                    lbl.BackColor = Color.White;
                    pnlMatrix.Controls.Add(lbl);
                    Lbl_mtx[i].Add(lbl);
                    obj.Enabled = false;
                    oldobj = obj;
                }
                oldobj = new CheckedListBox() { Width = 0, Height = 0, Location = new Point(0, oldobj.Location.Y + Cons.dateCheckedListBoxHeight + 8) };
            }
            run(present);
        }
        void SetDefaultDate()
        {
            //dateTimePicker1.Value = DateTime.Now;
        }
        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Label lbl = Lbl_mtx[i][j];
                    lbl.BackColor = Color.White;
                    lbl.Text = "";
                    CheckedListBox obj = Matrix[i][j];
                    obj.Items.Clear();
                }
            }
        }
        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
        }
        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(useDate.Month);
            LBDATE.Text = monthname + " " + useDate.Year;
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                CheckedListBox obj = Matrix[line][column];
                Label lbl = Lbl_mtx[line][column];
                lbl.Text = i.ToString();
                obj.Tag = i;
                lbl.Font = new Font("Times New Roman", 10);
                obj.Enabled = true;
                obj.BackColor = Color.White;
                if (isEqualDate(useDate, DateTime.Now))
                {
                    lbl.BackColor = Color.LightBlue;
                }
                if (isEqualDate(useDate, date))
                {
                    lbl.BackColor = Color.LightGreen;
                }
                if (todolist.ContainsKey(useDate))
                {
                    obj.Items.Clear();
                    Node_Event node = todolist[useDate].Head;
                    while (node != null)
                    {
                        obj.Items.Add(node.Event, node.Check == 1);
                        node = node.Next;
                    }
                }
                if (column >= 6)
                    line++;
                useDate = useDate.AddDays(1);
            }


        }
        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }
        private void obj_Click(object sender, EventArgs e)
        {
            CheckedListBox obj = sender as CheckedListBox;
            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month,(int) obj.Tag);
        }

        private void obj_ItemChecked(object sender, EventArgs e)
        {
            CheckedListBox obj = sender as CheckedListBox;
            if (obj.SelectedIndex >= 0)
            {
                int i = 0;
                Node_Event node = todolist[new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, Int32.Parse(obj.Tag.ToString()))].Head;
                while (i != obj.SelectedIndex)
                {
                    node = node.Next;
                    i++;
                }
                if (node.Check == 0) node.Check = 1; else node.Check = 0;
            }
            //run(dateTimePicker1.Value);
        }
        //
        // List
        //

        private Dictionary<DateTime, List_Event> copy(Dictionary<DateTime, List_Event> list)
        {
            Dictionary<DateTime, List_Event> newTodoList = new Dictionary<DateTime, List_Event>();
            foreach (var item in list)
            {
                Node_Event p = item.Value.Head;
                newTodoList.Add(item.Key, new List_Event());
                while (p != null)
                {
                    Node_Event k = new Node_Event(p.Event, p.Begin, p.End, p.Imp, p.Check);
                    newTodoList[item.Key].Add(k);
                    p = p.Next;
                }
            }
            return newTodoList;
        }

        private void update_Stack(Stack_State stack, Dictionary<DateTime, List_Event> list)
        {
            Node_State new_stack = new Node_State(copy(list));
            stack.Push(new_stack);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Doc File
            //Undo_btn.Enabled = false;
            //Redo_btn.Enabled = false;
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_Stack(undo_Stack, todolist);
            undo_T.Push(dateTimePicker1.Value);
            undoToolStripMenuItem.Enabled = true;
            Add_Event newform = new Add_Event();
            newform.ShowDialog();
            run(present);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undo_Stack.Head != null)
            {
                Node_State new_node = new Node_State(todolist);
                redo_Stack.Push(new_node);
                redoToolStripMenuItem.Enabled = true;
                todolist = copy(undo_Stack.Head.State);
                DateTime time = undo_T.Pop();
                redo_T.Push(time);
                undo_Stack.Pop();
                if (undo_Stack.Head == null) undoToolStripMenuItem.Enabled = false;
                run(time);
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redo_Stack.Head != null)
            {
                Node_State new_node = new Node_State(todolist);
                undo_Stack.Push(new_node);
                undoToolStripMenuItem.Enabled = true;
                todolist = copy(redo_Stack.Head.State);
                DateTime time = redo_T.Pop();
                undo_T.Push(time);
                redo_Stack.Pop();
                if (redo_Stack.Head == null) redoToolStripMenuItem.Enabled = false;
                run(time);
            }
        }
        private void prev_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(-1);
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
        }

        private void quanTrọngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listCV.Items.Clear();
            if (todolist.ContainsKey(dateTimePicker1.Value.Date))
            {
                for (Node_Event node = todolist[dateTimePicker1.Value.Date].Head; node != null; node = node.Next)
                {
                    if (node.Imp == 1)
                        showListView(node);
                }
            }
        }

        private void khôngQuanTrọngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listCV.Items.Clear();
            if (todolist.ContainsKey(dateTimePicker1.Value.Date))
            {
                for (Node_Event node = todolist[dateTimePicker1.Value.Date].Head; node != null; node = node.Next)
                {
                    if (node.Imp == 0)
                        showListView(node);
                }
            }
        }
        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todolist[dateTimePicker1.Value.Date].SortAZ();
            run(dateTimePicker1.Value);
        }

        private void zAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todolist[dateTimePicker1.Value.Date].SortZA();
            run(dateTimePicker1.Value);
        }

        private void gầnNhấtXaNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todolist[dateTimePicker1.Value.Date].SortBE();
            run(dateTimePicker1.Value);
        }

        private void xaNhấtGầnNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todolist[dateTimePicker1.Value.Date].SortEB();
            run(dateTimePicker1.Value);
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            present = dateTimePicker1.Value;
            AddNumberIntoMatrixByDate(present);
            run(present);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UpdateFile.Update_File(todolist);
            this.Close();
        }

        private void Search_tb_KeyUp(object sender, KeyEventArgs e)
        {
            Show_lb.Visible = true;
            Show_lb.Items.Clear();
            Show_lb.Height = 0;
            if (Search_tb.Text != String.Empty)
                foreach (var item in todolist)
                    for (Node_Event node=item.Value.Head; node!=null; node=node.Next)
                    {
                        if (KMPAlgorithm.KMPSearch(node.Event, Search_tb.Text))
                        {
                            Show_lb.Items.Add(node);
                            Show_lb.Height = Show_lb.Items.Count * 16;
                        }
                    }
        }

        private void YourPlan_FormClosed(object sender, FormClosedEventArgs e)
        {
            //UpdateFile.Update_File(todolist);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = listCV.SelectedItems[0].Text;
            if (s!=null)
            {
                Node_Event node = todolist[dateTimePicker1.Value.Date].Head;
                while (node.Event!=s)
                {
                    node = node.Next;
                }
                update_Stack(undo_Stack, todolist);
                undo_T.Push(dateTimePicker1.Value);
                undoToolStripMenuItem.Enabled = true;
                todolist[dateTimePicker1.Value.Date].Remove(node);
                run(dateTimePicker1.Value);
            }
            
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = listCV.SelectedItems[0].Text;
            if (s != null)
            {
                Node_Event node = todolist[dateTimePicker1.Value.Date].Head;
                while (node.Event != s)
                {
                    node = node.Next;
                }
                update_Stack(undo_Stack, todolist);
                undo_T.Push(dateTimePicker1.Value);
                undoToolStripMenuItem.Enabled = true;
                Fix fix = new Fix();
                fix.Info(node);
                fix.ShowDialog();
                run(present);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            TienDo td = new TienDo();
            td.ShowDialog();
        }
    }
}
