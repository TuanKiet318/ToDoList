using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_Maker
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        //TreeNode root = new TreeNode() { Text = PlanList.temp };
        ToolStripMenuItem subMenu = new ToolStripMenuItem() {Text = PlanList.temp };
        Tree root = new Tree();
        ToolStripMenuItem Item_temp = new ToolStripMenuItem();
        ContextMenuStrip right_click = new ContextMenuStrip();
        
        string path = "D:/";

        private void Add_Load(object sender, EventArgs e)
        {
            menu.Items.AddRange(new ToolStripMenuItem[] {subMenu});
            right_click.Items.AddRange(new ToolStripItem[]
            {
                new ToolStripMenuItem() {Text = "Delete"},
                new ToolStripMenuItem() {Text = "Rename"} }
            );
            flowLayoutPanel1.Controls.Add(menu);
            menu.ContextMenuStrip = right_click;
            root.Name = PlanList.temp;
            root.FullName = path + PlanList.temp;
            SetUp(subMenu, path, root);
        }
        
        private void SetUp(ToolStripMenuItem menu, string path, Tree node)
        {
            menu.Click += path_Click;
            menu.Tag = node;
            DirectoryInfo dirPath = new DirectoryInfo(path + "/" + menu.Text);
            if (dirPath.Exists)
            {
                ToolStripMenuItem[] subMenu = new ToolStripMenuItem[dirPath.GetDirectories().Length];
                int i = 0;
                foreach (var dir in dirPath.GetDirectories())
                {
                    subMenu[i] = new ToolStripMenuItem();
                    subMenu[i].Text = dir.Name;
                    Tree new_node = new Tree();
                    new_node.Name = dir.Name;
                    new_node.FullName = dir.FullName;
                    node.Add_Node(new_node);
                    SetUp(subMenu[i++], dirPath.FullName, new_node);
                }
                menu.DropDownItems.AddRange(subMenu);
            }
        }
        void path_Click(object sender, EventArgs e)
        {
            Item_temp = sender as ToolStripMenuItem;
            Tree node = Item_temp.Tag as Tree;
            Location_tbox.Text = node.FullName;
        }

        private void NewPlan_OK_btn_Click(object sender, EventArgs e)
        {
            if (Location_tbox.Text == String.Empty) 
            {
                MessageBox.Show("Chua co vi tri luu");
                return; 
            }
            string path = Location_tbox.Text + "/" + NewPlan_tb.Text;
            if (!Directory.Exists(path))
            {
                Tree new_node = new Tree();
                Tree temp = root.FindFullName(Location_tbox.Text);
                new_node.Name = NewPlan_tb.Text;
                new_node.FullName = path;
                temp.Add_Node(new_node);
                ToolStripMenuItem new_tool = new ToolStripMenuItem();
                new_tool.Text = NewPlan_tb.Text;
                new_tool.Tag = new_node;
                new_tool.Click += path_Click;
                Item_temp.DropDownItems.Add(new_tool);
                NewPlan_tb.Text = "";
                Location_tbox.Text = "";
                Directory.CreateDirectory(path);
                File.Create(path + "/" + NewPlan_tb.Text + ".txt");
                MessageBox.Show("Đã lưu.");
            }
            else
            {
                MessageBox.Show("Thu muc da ton tai.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
