using Plan_Maker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Plan_Maker
{
    public partial class Login : Form
    {
        private string account;

        public Login()
        {
            InitializeComponent();
        }
        string filePath = "D:\\Đồ án DASA\\Plan_Maker\\Account\\Account.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string password = password_text.Text;

            if (CheckLogin(filePath, username, password))
            {
                account = username;
                PlanList.temp = account;
                PlanList planList = new PlanList();
                planList.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
        }
        bool CheckLogin(string filePath, string username, string password)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 2 && parts[0].Trim() == username && parts[1].Trim() == password)
                    {
                        return true; 
                    }
                }

                return false; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc tệp tin: {ex.Message}");
                return false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string password = password_text.Text;
            if (username == String.Empty || password == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập thông tin ");
            }
            else if (CheckLogin(filePath, username))
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }
            else
            {

                string combinedString = $"{username},{password}";

                File.AppendAllText(filePath, combinedString + Environment.NewLine);
                string directoryPath = "D:\\" + username;

                CreateDirectory(directoryPath);

                Console.WriteLine("Đã tạo thư mục thành công.");
                Console.WriteLine("Đã lưu vào tệp tin.");
                MessageBox.Show("Bạn đã đăng kí thành công.\nVui lòng đăng nhập.");
            }
        }
        static void CreateDirectory(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    Console.WriteLine("Thư mục đã tồn tại.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tạo thư mục: {ex.Message}");
            }
        }
        bool CheckLogin(string filePath, string username)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 2 && parts[0].Trim() == username)
                    {
                        return true; 
                    }
                }

                return false; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc tệp tin: {ex.Message}");
                return false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string password = password_text.Text;

            if (CheckLogin(filePath, username, password))
            {
                account = username;
                PlanList.temp = account;
                PlanList planList = new PlanList();
                this.Hide();
                planList.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string password = password_text.Text;
            if (username == String.Empty || password == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập thông tin ");
            }
            else if (CheckLogin(filePath, username))
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }
            else
            {

                string combinedString = $"{username},{password}";

                File.AppendAllText(filePath, combinedString + Environment.NewLine);
                string directoryPath = "D:\\" + username;

                CreateDirectory(directoryPath);

                MessageBox.Show("Bạn đã đăng kí thành công.\nVui lòng đăng nhập.");
            }
        }
    }
}
