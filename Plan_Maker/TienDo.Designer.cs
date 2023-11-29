using System.Drawing;
namespace Plan_Maker
{
    partial class TienDo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listCVTre = new System.Windows.Forms.ListView();
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Begin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.End = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stateButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chualam_label = new System.Windows.Forms.Label();
            this.danglam_label = new System.Windows.Forms.Label();
            this.hoanthanh_label = new System.Windows.Forms.Label();
            this.congviec = new System.Windows.Forms.Label();
            this.ChartBDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tenDuAn_text = new System.Windows.Forms.Label();
            this.tiendothucte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBar2 = new CircularProgressBar.CircularProgressBar();
            this.pBar1 = new CircularProgressBar.CircularProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBDT)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listCVTre);
            this.panel1.Controls.Add(this.stateButton);
            this.panel1.Controls.Add(this.endButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chualam_label);
            this.panel1.Controls.Add(this.danglam_label);
            this.panel1.Controls.Add(this.hoanthanh_label);
            this.panel1.Controls.Add(this.congviec);
            this.panel1.Controls.Add(this.ChartBDT);
            this.panel1.Controls.Add(this.tenDuAn_text);
            this.panel1.Controls.Add(this.tiendothucte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pBar2);
            this.panel1.Controls.Add(this.pBar1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 527);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Danh sách công việc bị trễ tiến độ";
            // 
            // listCVTre
            // 
            this.listCVTre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Event,
            this.Begin,
            this.End});
            this.listCVTre.HideSelection = false;
            this.listCVTre.Location = new System.Drawing.Point(410, 320);
            this.listCVTre.Name = "listCVTre";
            this.listCVTre.Size = new System.Drawing.Size(572, 187);
            this.listCVTre.TabIndex = 34;
            this.listCVTre.UseCompatibleStateImageBehavior = false;
            this.listCVTre.View = System.Windows.Forms.View.Details;
            // 
            // Event
            // 
            this.Event.Text = "Sự kiện";
            // 
            // Begin
            // 
            this.Begin.Text = "Thời gian bắt đầu";
            // 
            // End
            // 
            this.End.Text = "Thời gian kết thúc";
            // 
            // stateButton
            // 
            this.stateButton.BackColor = System.Drawing.Color.Salmon;
            this.stateButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateButton.ForeColor = System.Drawing.Color.DarkRed;
            this.stateButton.Location = new System.Drawing.Point(296, 118);
            this.stateButton.Name = "stateButton";
            this.stateButton.Size = new System.Drawing.Size(147, 46);
            this.stateButton.TabIndex = 33;
            this.stateButton.Text = "Chậm trễ";
            this.stateButton.UseVisualStyleBackColor = false;
            // 
            // endButton
            // 
            this.endButton.BackColor = System.Drawing.Color.LightSalmon;
            this.endButton.ForeColor = System.Drawing.Color.Brown;
            this.endButton.Location = new System.Drawing.Point(161, 118);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(105, 46);
            this.endButton.TabIndex = 32;
            this.endButton.Text = "21/11/2024";
            this.endButton.UseVisualStyleBackColor = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Aquamarine;
            this.startButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.startButton.Location = new System.Drawing.Point(26, 118);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(105, 46);
            this.startButton.TabIndex = 31;
            this.startButton.Text = "08/04/2023";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // chualam_label
            // 
            this.chualam_label.AutoSize = true;
            this.chualam_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chualam_label.Location = new System.Drawing.Point(460, 253);
            this.chualam_label.Name = "chualam_label";
            this.chualam_label.Size = new System.Drawing.Size(65, 17);
            this.chualam_label.TabIndex = 27;
            this.chualam_label.Text = "Chưa làm";
            // 
            // danglam_label
            // 
            this.danglam_label.AutoSize = true;
            this.danglam_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danglam_label.Location = new System.Drawing.Point(460, 235);
            this.danglam_label.Name = "danglam_label";
            this.danglam_label.Size = new System.Drawing.Size(65, 17);
            this.danglam_label.TabIndex = 26;
            this.danglam_label.Text = "Đang làm";
            // 
            // hoanthanh_label
            // 
            this.hoanthanh_label.AutoSize = true;
            this.hoanthanh_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoanthanh_label.Location = new System.Drawing.Point(460, 218);
            this.hoanthanh_label.Name = "hoanthanh_label";
            this.hoanthanh_label.Size = new System.Drawing.Size(81, 17);
            this.hoanthanh_label.TabIndex = 25;
            this.hoanthanh_label.Text = "Hoàn Thành";
            // 
            // congviec
            // 
            this.congviec.AutoSize = true;
            this.congviec.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congviec.Location = new System.Drawing.Point(215, 349);
            this.congviec.Name = "congviec";
            this.congviec.Size = new System.Drawing.Size(51, 19);
            this.congviec.TabIndex = 24;
            this.congviec.Text = "label4";
            // 
            // ChartBDT
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartBDT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartBDT.Legends.Add(legend1);
            this.ChartBDT.Location = new System.Drawing.Point(26, 207);
            this.ChartBDT.Name = "ChartBDT";
            this.ChartBDT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Aqua;
            series1.Name = "ChartBDT";
            series1.ShadowColor = System.Drawing.Color.White;
            this.ChartBDT.Series.Add(series1);
            this.ChartBDT.Size = new System.Drawing.Size(486, 300);
            this.ChartBDT.TabIndex = 23;
            this.ChartBDT.Text = "chart1";
            // 
            // tenDuAn_text
            // 
            this.tenDuAn_text.AutoSize = true;
            this.tenDuAn_text.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenDuAn_text.Location = new System.Drawing.Point(54, 22);
            this.tenDuAn_text.Name = "tenDuAn_text";
            this.tenDuAn_text.Size = new System.Drawing.Size(173, 37);
            this.tenDuAn_text.TabIndex = 22;
            this.tenDuAn_text.Text = "Tên Dự Án";
            // 
            // tiendothucte
            // 
            this.tiendothucte.AutoSize = true;
            this.tiendothucte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiendothucte.Location = new System.Drawing.Point(817, 22);
            this.tiendothucte.Name = "tiendothucte";
            this.tiendothucte.Size = new System.Drawing.Size(138, 23);
            this.tiendothucte.TabIndex = 21;
            this.tiendothucte.Text = "Tiến độ thực tế";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tiến độ kế hoạch";
            // 
            // pBar2
            // 
            this.pBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pBar2.AnimationSpeed = 500;
            this.pBar2.BackColor = System.Drawing.Color.Transparent;
            this.pBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar2.ForeColor = System.Drawing.Color.Black;
            this.pBar2.InnerColor = System.Drawing.Color.White;
            this.pBar2.InnerMargin = 2;
            this.pBar2.InnerWidth = -1;
            this.pBar2.Location = new System.Drawing.Point(789, 57);
            this.pBar2.MarqueeAnimationSpeed = 2000;
            this.pBar2.Name = "pBar2";
            this.pBar2.OuterColor = System.Drawing.Color.LightGray;
            this.pBar2.OuterMargin = -25;
            this.pBar2.OuterWidth = 26;
            this.pBar2.ProgressColor = System.Drawing.Color.DarkOrange;
            this.pBar2.ProgressWidth = 18;
            this.pBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar2.Size = new System.Drawing.Size(180, 155);
            this.pBar2.StartAngle = 270;
            this.pBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pBar2.SubscriptText = "";
            this.pBar2.SuperscriptColor = System.Drawing.Color.White;
            this.pBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pBar2.SuperscriptText = "";
            this.pBar2.TabIndex = 19;
            this.pBar2.TextMargin = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.pBar2.Value = 68;
            // 
            // pBar1
            // 
            this.pBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pBar1.AnimationSpeed = 500;
            this.pBar1.BackColor = System.Drawing.Color.Transparent;
            this.pBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar1.ForeColor = System.Drawing.Color.Black;
            this.pBar1.InnerColor = System.Drawing.Color.White;
            this.pBar1.InnerMargin = 2;
            this.pBar1.InnerWidth = -1;
            this.pBar1.Location = new System.Drawing.Point(582, 57);
            this.pBar1.MarqueeAnimationSpeed = 2000;
            this.pBar1.Name = "pBar1";
            this.pBar1.OuterColor = System.Drawing.Color.LightGray;
            this.pBar1.OuterMargin = -25;
            this.pBar1.OuterWidth = 26;
            this.pBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pBar1.ProgressWidth = 18;
            this.pBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar1.Size = new System.Drawing.Size(180, 155);
            this.pBar1.StartAngle = 270;
            this.pBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pBar1.SubscriptText = "";
            this.pBar1.SuperscriptColor = System.Drawing.Color.White;
            this.pBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pBar1.SuperscriptText = "";
            this.pBar1.TabIndex = 18;
            this.pBar1.TextMargin = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.pBar1.Value = 68;
            // 
            // TienDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1023, 554);
            this.Controls.Add(this.panel1);
            this.Name = "TienDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TienDo";
            this.Load += new System.EventHandler(this.TienDo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stateButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chualam_label;
        private System.Windows.Forms.Label danglam_label;
        private System.Windows.Forms.Label hoanthanh_label;
        private System.Windows.Forms.Label congviec;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBDT;
        private System.Windows.Forms.Label tenDuAn_text;
        private System.Windows.Forms.Label tiendothucte;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar pBar2;
        private CircularProgressBar.CircularProgressBar pBar1;
        private System.Windows.Forms.ListView listCVTre;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.ColumnHeader Begin;
        private System.Windows.Forms.ColumnHeader End;
        private System.Windows.Forms.Label label3;
    }
}