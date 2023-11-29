namespace Plan_Maker
{
    partial class Add_Event
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.listView1 = new System.Windows.Forms.ListView();
            this.Event_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Begin_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.End_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_tbox = new System.Windows.Forms.TextBox();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imp_cbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.end_picker = new System.Windows.Forms.DateTimePicker();
            this.begin_picker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Event_col,
            this.Begin_col,
            this.End_col});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup1.Tag = "";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(378, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(741, 471);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Event_col
            // 
            this.Event_col.Text = "Event";
            this.Event_col.Width = 218;
            // 
            // Begin_col
            // 
            this.Begin_col.Text = "Begin";
            this.Begin_col.Width = 168;
            // 
            // End_col
            // 
            this.End_col.Text = "End";
            this.End_col.Width = 177;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 73);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Plan_Maker.Properties.Resources.icons8_exit_48;
            this.pictureBox2.Location = new System.Drawing.Point(1063, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Plan_Maker.Properties.Resources.icons8_menu_48;
            this.pictureBox1.Location = new System.Drawing.Point(7, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên công việc:";
            // 
            // Add_tbox
            // 
            this.Add_tbox.Location = new System.Drawing.Point(109, 41);
            this.Add_tbox.Multiline = true;
            this.Add_tbox.Name = "Add_tbox";
            this.Add_tbox.Size = new System.Drawing.Size(229, 26);
            this.Add_tbox.TabIndex = 1;
            // 
            // Ok_btn
            // 
            this.Ok_btn.Location = new System.Drawing.Point(11, 213);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(106, 40);
            this.Ok_btn.TabIndex = 1;
            this.Ok_btn.Text = "OK";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quan trọng:";
            // 
            // imp_cbox
            // 
            this.imp_cbox.AutoSize = true;
            this.imp_cbox.Location = new System.Drawing.Point(109, 180);
            this.imp_cbox.Name = "imp_cbox";
            this.imp_cbox.Size = new System.Drawing.Size(18, 17);
            this.imp_cbox.TabIndex = 7;
            this.imp_cbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thêm công việc";
            // 
            // end_picker
            // 
            this.end_picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.end_picker.Location = new System.Drawing.Point(109, 137);
            this.end_picker.Name = "end_picker";
            this.end_picker.Size = new System.Drawing.Size(176, 22);
            this.end_picker.TabIndex = 3;
            // 
            // begin_picker
            // 
            this.begin_picker.CalendarForeColor = System.Drawing.Color.Teal;
            this.begin_picker.CalendarMonthBackground = System.Drawing.Color.Teal;
            this.begin_picker.CalendarTitleBackColor = System.Drawing.Color.Teal;
            this.begin_picker.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.begin_picker.CalendarTrailingForeColor = System.Drawing.Color.Teal;
            this.begin_picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.begin_picker.Location = new System.Drawing.Point(109, 89);
            this.begin_picker.Name = "begin_picker";
            this.begin_picker.Size = new System.Drawing.Size(176, 22);
            this.begin_picker.TabIndex = 2;
            this.begin_picker.ValueChanged += new System.EventHandler(this.begin_picker_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.begin_picker);
            this.panel2.Controls.Add(this.end_picker);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.imp_cbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Ok_btn);
            this.panel2.Controls.Add(this.Add_tbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 471);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Add_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1124, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Event";
            this.Load += new System.EventHandler(this.Add_Event_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Event_col;
        private System.Windows.Forms.ColumnHeader Begin_col;
        private System.Windows.Forms.ColumnHeader End_col;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Add_tbox;
        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox imp_cbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker end_picker;
        private System.Windows.Forms.DateTimePicker begin_picker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}