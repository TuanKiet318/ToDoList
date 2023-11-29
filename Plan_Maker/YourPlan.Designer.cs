using System.Drawing;

namespace Plan_Maker
{
    partial class YourPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listCV = new System.Windows.Forms.ListView();
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Begin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.End = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Prev_btn = new System.Windows.Forms.Button();
            this.Next_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new Plan_Maker.RJControls.RjDatePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sắpXếpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gầnNhấtXaNhấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xaNhấtGầnNhấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanTrọngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khôngQuanTrọngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBDATE = new System.Windows.Forms.Label();
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.Show_lb = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listCV
            // 
            this.listCV.CheckBoxes = true;
            this.listCV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Event,
            this.Begin,
            this.End});
            this.listCV.ContextMenuStrip = this.contextMenuStrip1;
            this.listCV.FullRowSelect = true;
            this.listCV.HideSelection = false;
            this.listCV.Location = new System.Drawing.Point(0, 1);
            this.listCV.Name = "listCV";
            this.listCV.Size = new System.Drawing.Size(569, 786);
            this.listCV.TabIndex = 0;
            this.listCV.UseCompatibleStateImageBehavior = false;
            this.listCV.View = System.Windows.Forms.View.Details;
            // 
            // Event
            // 
            this.Event.Text = "Sự kiện";
            this.Event.Width = 151;
            // 
            // Begin
            // 
            this.Begin.Text = "Thời gian bắt đầu";
            this.Begin.Width = 211;
            // 
            // End
            // 
            this.End.Text = "Thời gian kết thúc";
            this.End.Width = 198;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.chiTiếtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // chiTiếtToolStripMenuItem
            // 
            this.chiTiếtToolStripMenuItem.Name = "chiTiếtToolStripMenuItem";
            this.chiTiếtToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.chiTiếtToolStripMenuItem.Text = "Chi tiết";
            this.chiTiếtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtToolStripMenuItem_Click);
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.Location = new System.Drawing.Point(587, 85);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(1255, 785);
            this.pnlMatrix.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listCV);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 786);
            this.panel1.TabIndex = 2;
            // 
            // Prev_btn
            // 
            this.Prev_btn.BackColor = System.Drawing.Color.Teal;
            this.Prev_btn.ForeColor = System.Drawing.Color.White;
            this.Prev_btn.Location = new System.Drawing.Point(3, 39);
            this.Prev_btn.Name = "Prev_btn";
            this.Prev_btn.Size = new System.Drawing.Size(76, 41);
            this.Prev_btn.TabIndex = 3;
            this.Prev_btn.Text = "Prev";
            this.Prev_btn.UseVisualStyleBackColor = false;
            this.Prev_btn.Click += new System.EventHandler(this.prev_Click);
            // 
            // Next_btn
            // 
            this.Next_btn.BackColor = System.Drawing.Color.Teal;
            this.Next_btn.ForeColor = System.Drawing.Color.White;
            this.Next_btn.Location = new System.Drawing.Point(495, 39);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(76, 39);
            this.Next_btn.TabIndex = 4;
            this.Next_btn.Text = "Next";
            this.Next_btn.UseVisualStyleBackColor = false;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.Next_btn);
            this.panel2.Controls.Add(this.Prev_btn);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(12, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 86);
            this.panel2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BorderColor = System.Drawing.Color.Teal;
            this.dateTimePicker1.BorderSize = 0;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 39);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(407, 35);
            this.dateTimePicker1.SkinColor = System.Drawing.Color.Thistle;
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.TextColor = System.Drawing.Color.White;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.ThêmToolStripMenuItem,
            this.sắpXếpToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // ThêmToolStripMenuItem
            // 
            this.ThêmToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ThêmToolStripMenuItem.Name = "ThêmToolStripMenuItem";
            this.ThêmToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ThêmToolStripMenuItem.Text = "Thêm";
            this.ThêmToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // sắpXếpToolStripMenuItem
            // 
            this.sắpXếpToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.sắpXếpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.zAToolStripMenuItem,
            this.gầnNhấtXaNhấtToolStripMenuItem,
            this.xaNhấtGầnNhấtToolStripMenuItem});
            this.sắpXếpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sắpXếpToolStripMenuItem.Name = "sắpXếpToolStripMenuItem";
            this.sắpXếpToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.sắpXếpToolStripMenuItem.Text = "Sắp xếp";
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.aZToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aZToolStripMenuItem.Text = "A - Z";
            this.aZToolStripMenuItem.Click += new System.EventHandler(this.aZToolStripMenuItem_Click);
            // 
            // zAToolStripMenuItem
            // 
            this.zAToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.zAToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            this.zAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zAToolStripMenuItem.Text = "Z - A";
            this.zAToolStripMenuItem.Click += new System.EventHandler(this.zAToolStripMenuItem_Click);
            // 
            // gầnNhấtXaNhấtToolStripMenuItem
            // 
            this.gầnNhấtXaNhấtToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.gầnNhấtXaNhấtToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gầnNhấtXaNhấtToolStripMenuItem.Name = "gầnNhấtXaNhấtToolStripMenuItem";
            this.gầnNhấtXaNhấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gầnNhấtXaNhấtToolStripMenuItem.Text = "Gần nhất - Xa nhất";
            this.gầnNhấtXaNhấtToolStripMenuItem.Click += new System.EventHandler(this.gầnNhấtXaNhấtToolStripMenuItem_Click);
            // 
            // xaNhấtGầnNhấtToolStripMenuItem
            // 
            this.xaNhấtGầnNhấtToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.xaNhấtGầnNhấtToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xaNhấtGầnNhấtToolStripMenuItem.Name = "xaNhấtGầnNhấtToolStripMenuItem";
            this.xaNhấtGầnNhấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xaNhấtGầnNhấtToolStripMenuItem.Text = "Xa nhất - Gần nhất";
            this.xaNhấtGầnNhấtToolStripMenuItem.Click += new System.EventHandler(this.xaNhấtGầnNhấtToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanTrọngToolStripMenuItem,
            this.khôngQuanTrọngToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.tìmKiếmToolStripMenuItem.Text = "Lọc";
            // 
            // quanTrọngToolStripMenuItem
            // 
            this.quanTrọngToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.quanTrọngToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quanTrọngToolStripMenuItem.Name = "quanTrọngToolStripMenuItem";
            this.quanTrọngToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.quanTrọngToolStripMenuItem.Text = "Quan trọng";
            this.quanTrọngToolStripMenuItem.Click += new System.EventHandler(this.quanTrọngToolStripMenuItem_Click);
            // 
            // khôngQuanTrọngToolStripMenuItem
            // 
            this.khôngQuanTrọngToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.khôngQuanTrọngToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.khôngQuanTrọngToolStripMenuItem.Name = "khôngQuanTrọngToolStripMenuItem";
            this.khôngQuanTrọngToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.khôngQuanTrọngToolStripMenuItem.Text = "Không quan trọng";
            this.khôngQuanTrọngToolStripMenuItem.Click += new System.EventHandler(this.khôngQuanTrọngToolStripMenuItem_Click);
            // 
            // LBDATE
            // 
            this.LBDATE.AutoSize = true;
            this.LBDATE.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDATE.ForeColor = System.Drawing.Color.White;
            this.LBDATE.Location = new System.Drawing.Point(1084, 9);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(246, 34);
            this.LBDATE.TabIndex = 12;
            this.LBDATE.Text = "MONTH YEAR";
            // 
            // Search_tb
            // 
            this.Search_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_tb.Location = new System.Drawing.Point(590, 50);
            this.Search_tb.Multiline = true;
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(1242, 30);
            this.Search_tb.TabIndex = 13;
            this.Search_tb.Text = "Search";
            this.Search_tb.Click += new System.EventHandler(this.Search_tb_Click);
            this.Search_tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_tb_KeyUp);
            // 
            // Show_lb
            // 
            this.Show_lb.BackColor = System.Drawing.Color.LightGray;
            this.Show_lb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Show_lb.FormattingEnabled = true;
            this.Show_lb.ItemHeight = 16;
            this.Show_lb.Location = new System.Drawing.Point(591, 80);
            this.Show_lb.Name = "Show_lb";
            this.Show_lb.Size = new System.Drawing.Size(1235, 0);
            this.Show_lb.TabIndex = 0;
            this.Show_lb.Visible = false;
            this.Show_lb.Click += new System.EventHandler(this.Show_lb_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(591, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "Tiến độ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Plan_Maker.Properties.Resources.icons8_exit_48;
            this.pictureBox2.Location = new System.Drawing.Point(1798, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // YourPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1920, 929);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Search_tb);
            this.Controls.Add(this.Show_lb);
            this.Controls.Add(this.LBDATE);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMatrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YourPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.YourPlan_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Prev_btn;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ThêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.ColumnHeader Begin;
        private System.Windows.Forms.ColumnHeader End;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gầnNhấtXaNhấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xaNhấtGầnNhấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanTrọngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khôngQuanTrọngToolStripMenuItem;
        public System.Windows.Forms.ListView listCV;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private RJControls.RjDatePicker dateTimePicker1;
        private System.Windows.Forms.Label LBDATE;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.ListBox Show_lb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtToolStripMenuItem;
    }
}

