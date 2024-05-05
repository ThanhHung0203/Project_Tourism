﻿namespace ProjectTourism
{
    partial class FormQuanLyLichTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyLichTrinh));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_title = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dt_AddTour = new System.Windows.Forms.DateTimePicker();
            this.cbb_AddTours = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Tours = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_NotEligible = new System.Windows.Forms.CheckBox();
            this.cbb_FindGuides = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numeric_Quantity = new System.Windows.Forms.NumericUpDown();
            this.cbb_FindTours = new System.Windows.Forms.ComboBox();
            this.btn_FindTour = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dt_InfoTour = new System.Windows.Forms.DateTimePicker();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_NameTour = new System.Windows.Forms.Label();
            this.lbl_IDTour = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tours)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Quantity)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_title.Location = new System.Drawing.Point(486, 19);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(572, 38);
            this.lb_title.TabIndex = 6;
            this.lb_title.Text = "QUẢN LÝ LỊCH TRÌNH CHUYẾN ĐI";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_reload);
            this.panel1.Controls.Add(this.monthCalendar);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btn_Find);
            this.panel1.Location = new System.Drawing.Point(12, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 326);
            this.panel1.TabIndex = 22;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.Location = new System.Drawing.Point(23, 52);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.label15.Location = new System.Drawing.Point(76, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 31);
            this.label15.TabIndex = 25;
            this.label15.Text = "TUẦN LÀM VIỆC";
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_Find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ForeColor = System.Drawing.Color.White;
            this.btn_Find.Location = new System.Drawing.Point(95, 271);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(138, 45);
            this.btn_Find.TabIndex = 33;
            this.btn_Find.Text = "Tìm kiếm";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.dt_AddTour);
            this.panel2.Controls.Add(this.cbb_AddTours);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 563);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 237);
            this.panel2.TabIndex = 23;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(106, 183);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 46);
            this.btn_Add.TabIndex = 24;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dt_AddTour
            // 
            this.dt_AddTour.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.dt_AddTour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_AddTour.Location = new System.Drawing.Point(42, 125);
            this.dt_AddTour.Name = "dt_AddTour";
            this.dt_AddTour.Size = new System.Drawing.Size(246, 27);
            this.dt_AddTour.TabIndex = 24;
            // 
            // cbb_AddTours
            // 
            this.cbb_AddTours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.cbb_AddTours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_AddTours.FormattingEnabled = true;
            this.cbb_AddTours.Location = new System.Drawing.Point(42, 64);
            this.cbb_AddTours.Name = "cbb_AddTours";
            this.cbb_AddTours.Size = new System.Drawing.Size(246, 36);
            this.cbb_AddTours.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "THÊM LỊCH TRÌNH";
            // 
            // dgv_Tours
            // 
            this.dgv_Tours.AllowUserToAddRows = false;
            this.dgv_Tours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tours.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Tours.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Tours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Tours.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Tours.Location = new System.Drawing.Point(361, 62);
            this.dgv_Tours.Name = "dgv_Tours";
            this.dgv_Tours.RowHeadersWidth = 51;
            this.dgv_Tours.RowTemplate.Height = 24;
            this.dgv_Tours.Size = new System.Drawing.Size(953, 441);
            this.dgv_Tours.TabIndex = 24;
            this.dgv_Tours.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Tours_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cb_NotEligible);
            this.panel3.Controls.Add(this.cbb_FindGuides);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.numeric_Quantity);
            this.panel3.Controls.Add(this.cbb_FindTours);
            this.panel3.Controls.Add(this.btn_FindTour);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(363, 509);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 291);
            this.panel3.TabIndex = 23;
            // 
            // cb_NotEligible
            // 
            this.cb_NotEligible.AutoSize = true;
            this.cb_NotEligible.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_NotEligible.Location = new System.Drawing.Point(20, 200);
            this.cb_NotEligible.Name = "cb_NotEligible";
            this.cb_NotEligible.Size = new System.Drawing.Size(297, 32);
            this.cb_NotEligible.TabIndex = 25;
            this.cb_NotEligible.Text = "Chuyến đi không đủ yêu cầu";
            this.cb_NotEligible.UseVisualStyleBackColor = true;
            // 
            // cbb_FindGuides
            // 
            this.cbb_FindGuides.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.cbb_FindGuides.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_FindGuides.FormattingEnabled = true;
            this.cbb_FindGuides.Location = new System.Drawing.Point(171, 118);
            this.cbb_FindGuides.Name = "cbb_FindGuides";
            this.cbb_FindGuides.Size = new System.Drawing.Size(240, 36);
            this.cbb_FindGuides.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mã HDV:";
            // 
            // numeric_Quantity
            // 
            this.numeric_Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.numeric_Quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_Quantity.Location = new System.Drawing.Point(236, 160);
            this.numeric_Quantity.Name = "numeric_Quantity";
            this.numeric_Quantity.Size = new System.Drawing.Size(175, 34);
            this.numeric_Quantity.TabIndex = 32;
            // 
            // cbb_FindTours
            // 
            this.cbb_FindTours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.cbb_FindTours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_FindTours.FormattingEnabled = true;
            this.cbb_FindTours.Location = new System.Drawing.Point(171, 76);
            this.cbb_FindTours.Name = "cbb_FindTours";
            this.cbb_FindTours.Size = new System.Drawing.Size(240, 36);
            this.cbb_FindTours.TabIndex = 31;
            // 
            // btn_FindTour
            // 
            this.btn_FindTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_FindTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindTour.ForeColor = System.Drawing.Color.White;
            this.btn_FindTour.Location = new System.Drawing.Point(171, 237);
            this.btn_FindTour.Name = "btn_FindTour";
            this.btn_FindTour.Size = new System.Drawing.Size(110, 46);
            this.btn_FindTour.TabIndex = 25;
            this.btn_FindTour.Text = "Tìm";
            this.btn_FindTour.UseVisualStyleBackColor = false;
            this.btn_FindTour.Click += new System.EventHandler(this.btn_FindTour_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Số khách tối đa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã chuyến đi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.label2.Location = new System.Drawing.Point(136, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "TÌM CHUYẾN ĐI";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dt_InfoTour);
            this.panel4.Controls.Add(this.lbl_Quantity);
            this.panel4.Controls.Add(this.lbl_Type);
            this.panel4.Controls.Add(this.lbl_NameTour);
            this.panel4.Controls.Add(this.lbl_IDTour);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btn_Cancel);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(799, 509);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(516, 291);
            this.panel4.TabIndex = 24;
            // 
            // dt_InfoTour
            // 
            this.dt_InfoTour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_InfoTour.Location = new System.Drawing.Point(131, 144);
            this.dt_InfoTour.Name = "dt_InfoTour";
            this.dt_InfoTour.Size = new System.Drawing.Size(291, 30);
            this.dt_InfoTour.TabIndex = 33;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(238, 188);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(0, 28);
            this.lbl_Quantity.TabIndex = 41;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.Location = new System.Drawing.Point(153, 109);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(0, 28);
            this.lbl_Type.TabIndex = 40;
            // 
            // lbl_NameTour
            // 
            this.lbl_NameTour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameTour.Location = new System.Drawing.Point(59, 61);
            this.lbl_NameTour.Name = "lbl_NameTour";
            this.lbl_NameTour.Size = new System.Drawing.Size(421, 48);
            this.lbl_NameTour.TabIndex = 39;
            // 
            // lbl_IDTour
            // 
            this.lbl_IDTour.AutoSize = true;
            this.lbl_IDTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDTour.Location = new System.Drawing.Point(153, 21);
            this.lbl_IDTour.Name = "lbl_IDTour";
            this.lbl_IDTour.Size = new System.Drawing.Size(0, 28);
            this.lbl_IDTour.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 28);
            this.label10.TabIndex = 37;
            this.label10.Text = "Mã chuyến đi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 28);
            this.label9.TabIndex = 36;
            this.label9.Text = "Loại hình:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(63, 237);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(396, 46);
            this.btn_Cancel.TabIndex = 33;
            this.btn_Cancel.Text = "Hủy chuyến đi và gửi thông báo";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 28);
            this.label6.TabIndex = 35;
            this.label6.Text = "Số lượng khách tối đa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 28);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 28);
            this.label7.TabIndex = 34;
            this.label7.Text = "Ngày đi:";
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.Color.White;
            this.btn_reload.BackgroundImage = global::ProjectTourism.Properties.Resources.reload;
            this.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reload.Location = new System.Drawing.Point(245, 273);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(40, 40);
            this.btn_reload.TabIndex = 59;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // FormQuanLyLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1327, 812);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_Tours);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb_title);
            this.Name = "FormQuanLyLichTrinh";
            this.Text = "FormQuanLyLichTrinh";
            this.Load += new System.EventHandler(this.FormQuanLyLichTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tours)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Quantity)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dt_AddTour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cbb_AddTours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Tours;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numeric_Quantity;
        private System.Windows.Forms.ComboBox cbb_FindTours;
        private System.Windows.Forms.Button btn_FindTour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_InfoTour;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_NameTour;
        private System.Windows.Forms.Label lbl_IDTour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_FindGuides;
        private System.Windows.Forms.CheckBox cb_NotEligible;
        private System.Windows.Forms.Button btn_reload;
    }
}