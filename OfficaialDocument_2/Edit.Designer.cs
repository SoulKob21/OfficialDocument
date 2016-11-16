namespace OfficaialDocument_2
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.tbNote = new System.Windows.Forms.TextBox();
            this.cbbTo = new System.Windows.Forms.ComboBox();
            this.datePickRecieve = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbRecipient = new System.Windows.Forms.ComboBox();
            this.cbbFrom = new System.Windows.Forms.ComboBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDocNo_rtn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDocNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datePickRecordDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(512, 140);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNote.Size = new System.Drawing.Size(344, 72);
            this.tbNote.TabIndex = 27;
            // 
            // cbbTo
            // 
            this.cbbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTo.FormattingEnabled = true;
            this.cbbTo.Items.AddRange(new object[] {
            "เพชร",
            "กำแพง",
            "ชลบุรี"});
            this.cbbTo.Location = new System.Drawing.Point(512, 52);
            this.cbbTo.Name = "cbbTo";
            this.cbbTo.Size = new System.Drawing.Size(344, 21);
            this.cbbTo.TabIndex = 5;
            // 
            // datePickRecieve
            // 
            this.datePickRecieve.Location = new System.Drawing.Point(512, 114);
            this.datePickRecieve.Name = "datePickRecieve";
            this.datePickRecieve.Size = new System.Drawing.Size(173, 20);
            this.datePickRecieve.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "หมายเหตุ";
            // 
            // cbbRecipient
            // 
            this.cbbRecipient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbRecipient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbRecipient.FormattingEnabled = true;
            this.cbbRecipient.Items.AddRange(new object[] {
            "เพชร",
            "กำแพง",
            "ชลบุรี"});
            this.cbbRecipient.Location = new System.Drawing.Point(512, 83);
            this.cbbRecipient.Name = "cbbRecipient";
            this.cbbRecipient.Size = new System.Drawing.Size(344, 21);
            this.cbbRecipient.TabIndex = 25;
            // 
            // cbbFrom
            // 
            this.cbbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFrom.FormattingEnabled = true;
            this.cbbFrom.Items.AddRange(new object[] {
            "เพชร",
            "กำแพง",
            "ชลบุรี"});
            this.cbbFrom.Location = new System.Drawing.Point(512, 23);
            this.cbbFrom.Name = "cbbFrom";
            this.cbbFrom.Size = new System.Drawing.Size(344, 21);
            this.cbbFrom.TabIndex = 4;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(136, 140);
            this.tbSubject.Multiline = true;
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSubject.Size = new System.Drawing.Size(290, 72);
            this.tbSubject.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "วันที่รับ";
            // 
            // tbDocNo_rtn
            // 
            this.tbDocNo_rtn.Location = new System.Drawing.Point(136, 52);
            this.tbDocNo_rtn.MaxLength = 5;
            this.tbDocNo_rtn.Name = "tbDocNo_rtn";
            this.tbDocNo_rtn.Size = new System.Drawing.Size(290, 20);
            this.tbDocNo_rtn.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "เรื่อง";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "ผู้รับ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "เลขทะเบียน ศฝท.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ถึง";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "จาก";
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(136, 114);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(149, 20);
            this.datePick.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ลงวันที่";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(136, 80);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(290, 20);
            this.tbNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ที่";
            // 
            // tbDocNo
            // 
            this.tbDocNo.Location = new System.Drawing.Point(136, 24);
            this.tbDocNo.MaxLength = 5;
            this.tbDocNo.Name = "tbDocNo";
            this.tbDocNo.Size = new System.Drawing.Size(290, 20);
            this.tbDocNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "เลขทะเบียนรับ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "วันที่บันทึก";
            // 
            // backBtn
            // 
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.ImageKey = "back-button.png";
            this.backBtn.ImageList = this.imageList1;
            this.backBtn.Location = new System.Drawing.Point(793, 257);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 46);
            this.backBtn.TabIndex = 26;
            this.backBtn.Text = "กลับ";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "f15.png");
            this.imageList1.Images.SetKeyName(1, "back-button.png");
            // 
            // saveBtn
            // 
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.ImageKey = "f15.png";
            this.saveBtn.ImageList = this.imageList1;
            this.saveBtn.Location = new System.Drawing.Point(698, 257);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 46);
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Text = "บันทึก";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNote);
            this.groupBox1.Controls.Add(this.cbbTo);
            this.groupBox1.Controls.Add(this.datePickRecieve);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbbRecipient);
            this.groupBox1.Controls.Add(this.cbbFrom);
            this.groupBox1.Controls.Add(this.tbSubject);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbDocNo_rtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.datePick);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDocNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 218);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "แก้ไข";
            // 
            // datePickRecordDate
            // 
            this.datePickRecordDate.Location = new System.Drawing.Point(403, 7);
            this.datePickRecordDate.Name = "datePickRecordDate";
            this.datePickRecordDate.Size = new System.Drawing.Size(152, 20);
            this.datePickRecordDate.TabIndex = 27;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 311);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datePickRecordDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(903, 350);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "แก้ไข";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_FormClosed);
            this.Load += new System.EventHandler(this.Edit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.ComboBox cbbTo;
        private System.Windows.Forms.DateTimePicker datePickRecieve;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbRecipient;
        private System.Windows.Forms.ComboBox cbbFrom;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDocNo_rtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDocNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datePickRecordDate;

    }
}