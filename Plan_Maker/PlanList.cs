using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Plan_Maker
{
    public partial class PlanList : Form
    {
        public PlanList()
        {
            InitializeComponent();
        }
        public static string temp = String.Empty;
        string path = "D:/" + temp;
        string[] list;
        int i;

        private void PlanList_Load(object sender, EventArgs e)
        {
            list = new string[100];
            i = 1;
            SetUp(path);
        }

        public void SetUp(string path)
        {
            DirectoryInfo dirPath = new DirectoryInfo(path);
            foreach (var dir in dirPath.GetDirectories())
            {
                if (dir.GetFiles().Any() == true)
                {
                    list[i] = dir.FullName;
                    ListViewItem Item = new ListViewItem();
                    Item.Text = i++.ToString();
                    Item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dir.Name });
                    Item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dir.FullName });
                    listView1.Items.Add(Item);
                }
                SetUp(dir.FullName);
            }
        }

        public static string plan = string.Empty;


        private void Home_btn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void Thembutton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
            listView1.Items.Clear();
            i = 1;
            SetUp(path);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string s= listView1.SelectedItems[0].Text;
            int k = Int32.Parse(s);
            plan = list[k];
            YourPlan yourPlan = new YourPlan();
            yourPlan.ShowDialog();
        }
        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }
        private void Xoabutton_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("File sẽ bị xóa vĩnh viễn, bạn chắc chắn muốn xóa!", "Cảnh báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.No) return;
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                string s = list[Int32.Parse(listView1.SelectedItems[i].Text)];
                DeleteDirectory(s);
            }
            listView1.Items.Clear();
            list = new string[100];
            i = 1;
            PlanList_Load(sender, e);
        }

        private void Timkiem_textbox_KeyUp(object sender, KeyEventArgs e)
        {
            listView1.Items.Clear();
            i = 1;
            if (Timkiem_textbox.Text==String.Empty) SetUp(path);
            else
            { 
                SetUpSearch(path);
            }
        }

        public void SetUpSearch(string path)
        {
            DirectoryInfo dirPath = new DirectoryInfo(path);
            foreach (var dir in dirPath.GetDirectories())
            {
                if (dir.GetFiles().Any()==true && KMPAlgorithm.KMPSearch(dir.Name.ToLower(), Timkiem_textbox.Text.ToLower()) == true)
                {
                    list[i] = dir.FullName;
                    ListViewItem Item = new ListViewItem();
                    Item.Text = i++.ToString();
                    Item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dir.Name });
                    Item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dir.FullName });
                    listView1.Items.Add(Item);
                }
                else
                    SetUpSearch(dir.FullName);
            }   
        }

        private void Thoatbutton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}


