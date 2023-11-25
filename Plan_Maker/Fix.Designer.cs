namespace Plan_Maker
{
    partial class Fix
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.begin_picker = new System.Windows.Forms.DateTimePicker();
            this.end_picker = new System.Windows.Forms.DateTimePicker();
            this.imp_cbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.Add_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.begin_picker);
            this.panel2.Controls.Add(this.end_picker);
            this.panel2.Controls.Add(this.imp_cbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Ok_btn);
            this.panel2.Controls.Add(this.Add_tbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 214);
            this.panel2.TabIndex = 3;
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
            this.begin_picker.Size = new System.Drawing.Size(229, 22);
            this.begin_picker.TabIndex = 2;
            // 
            // end_picker
            // 
            this.end_picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.end_picker.Location = new System.Drawing.Point(109, 117);
            this.end_picker.Name = "end_picker";
            this.end_picker.Size = new System.Drawing.Size(229, 22);
            this.end_picker.TabIndex = 3;
            // 
            // imp_cbox
            // 
            this.imp_cbox.AutoSize = true;
            this.imp_cbox.Location = new System.Drawing.Point(109, 151);
            this.imp_cbox.Name = "imp_cbox";
            this.imp_cbox.Size = new System.Drawing.Size(18, 17);
            this.imp_cbox.TabIndex = 7;
            this.imp_cbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quan trọng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết thúc:";
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
            // Ok_btn
            // 
            this.Ok_btn.Location = new System.Drawing.Point(232, 151);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(106, 40);
            this.Ok_btn.TabIndex = 1;
            this.Ok_btn.Text = "OK";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // Add_tbox
            // 
            this.Add_tbox.Location = new System.Drawing.Point(109, 41);
            this.Add_tbox.Multiline = true;
            this.Add_tbox.Name = "Add_tbox";
            this.Add_tbox.Size = new System.Drawing.Size(229, 26);
            this.Add_tbox.TabIndex = 1;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(101, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sửa thông tin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Plan_Maker.Properties.Resources.icons8_exit_48;
            this.pictureBox2.Location = new System.Drawing.Point(327, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Fix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(372, 271);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fix";
            this.Load += new System.EventHandler(this.Fix_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker begin_picker;
        private System.Windows.Forms.DateTimePicker end_picker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox imp_cbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.TextBox Add_tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}