namespace OfficaialDocument_2
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRecieve = new System.Windows.Forms.CheckBox();
            this.cbDateBook = new System.Windows.Forms.CheckBox();
            this.datePickRecieve = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbRecipient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbFrom = new System.Windows.Forms.ComboBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbs = new System.Windows.Forms.CheckBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDocNo_rtn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDocNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(987, 408);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รายการเอกสาร";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(987, 383);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.cbRecieve);
            this.groupBox1.Controls.Add(this.cbDateBook);
            this.groupBox1.Controls.Add(this.datePickRecieve);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbbRecipient);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbTo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbFrom);
            this.groupBox1.Controls.Add(this.tbSubject);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbs);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.datePick);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbDocNo_rtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDocNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "1";
            this.groupBox1.Text = "ค้นหาเอกสาร";
            // 
            // cbRecieve
            // 
            this.cbRecieve.AutoSize = true;
            this.cbRecieve.Location = new System.Drawing.Point(399, 48);
            this.cbRecieve.Name = "cbRecieve";
            this.cbRecieve.Size = new System.Drawing.Size(60, 17);
            this.cbRecieve.TabIndex = 20;
            this.cbRecieve.Text = "วันที่รับ";
            this.cbRecieve.UseVisualStyleBackColor = true;
            this.cbRecieve.CheckedChanged += new System.EventHandler(this.cbRecieve_CheckedChanged);
            // 
            // cbDateBook
            // 
            this.cbDateBook.AutoSize = true;
            this.cbDateBook.Location = new System.Drawing.Point(399, 16);
            this.cbDateBook.Name = "cbDateBook";
            this.cbDateBook.Size = new System.Drawing.Size(79, 17);
            this.cbDateBook.TabIndex = 19;
            this.cbDateBook.Text = "วันที่หนังสือ";
            this.cbDateBook.UseVisualStyleBackColor = true;
            this.cbDateBook.CheckedChanged += new System.EventHandler(this.cbDateBook_CheckedChanged);
            // 
            // datePickRecieve
            // 
            this.datePickRecieve.Enabled = false;
            this.datePickRecieve.Location = new System.Drawing.Point(484, 47);
            this.datePickRecieve.Name = "datePickRecieve";
            this.datePickRecieve.Size = new System.Drawing.Size(141, 20);
            this.datePickRecieve.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(484, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 17;
            // 
            // cbbRecipient
            // 
            this.cbbRecipient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbRecipient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbRecipient.FormattingEnabled = true;
            this.cbbRecipient.Location = new System.Drawing.Point(668, 46);
            this.cbbRecipient.Name = "cbbRecipient";
            this.cbbRecipient.Size = new System.Drawing.Size(131, 21);
            this.cbbRecipient.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ผู้รับ";
            // 
            // cbbTo
            // 
            this.cbbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTo.FormattingEnabled = true;
            this.cbbTo.Location = new System.Drawing.Point(234, 46);
            this.cbbTo.Name = "cbbTo";
            this.cbbTo.Size = new System.Drawing.Size(154, 21);
            this.cbbTo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ถึง";
            // 
            // cbbFrom
            // 
            this.cbbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFrom.FormattingEnabled = true;
            this.cbbFrom.Location = new System.Drawing.Point(234, 13);
            this.cbbFrom.Name = "cbbFrom";
            this.cbbFrom.Size = new System.Drawing.Size(154, 21);
            this.cbbFrom.TabIndex = 3;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(668, 12);
            this.tbSubject.MaxLength = 0;
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(131, 20);
            this.tbSubject.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(636, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "เรื่อง";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "จาก";
            // 
            // cbs
            // 
            this.cbs.AutoSize = true;
            this.cbs.Location = new System.Drawing.Point(814, 31);
            this.cbs.Name = "cbs";
            this.cbs.Size = new System.Drawing.Size(86, 17);
            this.cbs.TabIndex = 6;
            this.cbs.Text = "ค้นหาทั้งหมด";
            this.cbs.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.ImageKey = "search-icon2.png";
            this.searchBtn.ImageList = this.imageList1;
            this.searchBtn.Location = new System.Drawing.Point(906, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 52);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "ค้นหา";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "images.png");
            this.imageList1.Images.SetKeyName(1, "edit-xxl.png");
            this.imageList1.Images.SetKeyName(2, "print.png");
            this.imageList1.Images.SetKeyName(3, "searchicon.png");
            this.imageList1.Images.SetKeyName(4, "search-icon2.png");
            // 
            // datePick
            // 
            this.datePick.Enabled = false;
            this.datePick.Location = new System.Drawing.Point(484, 13);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(141, 20);
            this.datePick.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // tbDocNo_rtn
            // 
            this.tbDocNo_rtn.Location = new System.Drawing.Point(98, 46);
            this.tbDocNo_rtn.MaxLength = 5;
            this.tbDocNo_rtn.Name = "tbDocNo_rtn";
            this.tbDocNo_rtn.Size = new System.Drawing.Size(96, 20);
            this.tbDocNo_rtn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ทะเบียนรับ ศฝท.";
            // 
            // tbDocNo
            // 
            this.tbDocNo.Location = new System.Drawing.Point(98, 16);
            this.tbDocNo.MaxLength = 5;
            this.tbDocNo.Name = "tbDocNo";
            this.tbDocNo.Size = new System.Drawing.Size(96, 20);
            this.tbDocNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ทะเบียนรับ กพ.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSearch,
            this.menuRecord,
            this.menuReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSearch
            // 
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.Size = new System.Drawing.Size(45, 20);
            this.menuSearch.Text = "ค้นหา";
            this.menuSearch.Click += new System.EventHandler(this.menuSearch_Click);
            // 
            // menuRecord
            // 
            this.menuRecord.Name = "menuRecord";
            this.menuRecord.Size = new System.Drawing.Size(63, 20);
            this.menuRecord.Text = "เพิ่มข้อมูล";
            this.menuRecord.Click += new System.EventHandler(this.menuRecord_Click);
            // 
            // menuReport
            // 
            this.menuReport.Name = "menuReport";
            this.menuReport.Size = new System.Drawing.Size(52, 20);
            this.menuReport.Text = "รายงาน";
            this.menuReport.Click += new System.EventHandler(this.menuReport_Click);
            // 
            // editBtn
            // 
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBtn.Font = new System.Drawing.Font("FreesiaUPC", 15.75F, System.Drawing.FontStyle.Bold);
            this.editBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.ImageKey = "edit-xxl.png";
            this.editBtn.ImageList = this.imageList1;
            this.editBtn.Location = new System.Drawing.Point(791, 527);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(87, 46);
            this.editBtn.TabIndex = 15;
            this.editBtn.Text = "แก้ไข";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("FreesiaUPC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.ImageKey = "images.png";
            this.deleteBtn.ImageList = this.imageList1;
            this.deleteBtn.Location = new System.Drawing.Point(901, 527);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(74, 46);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "ลบ";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printBtn.Font = new System.Drawing.Font("FreesiaUPC", 15.75F, System.Drawing.FontStyle.Bold);
            this.printBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printBtn.ImageKey = "print.png";
            this.printBtn.ImageList = this.imageList1;
            this.printBtn.Location = new System.Drawing.Point(680, 527);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(87, 46);
            this.printBtn.TabIndex = 14;
            this.printBtn.Text = "พิมพ์";
            this.printBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // Search
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(987, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.printBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1003, 616);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ค้นหา";
            this.Load += new System.EventHandler(this.Search_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRecieve;
        private System.Windows.Forms.CheckBox cbDateBook;
        private System.Windows.Forms.DateTimePicker datePickRecieve;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbRecipient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbFrom;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbs;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDocNo_rtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDocNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSearch;
        private System.Windows.Forms.ToolStripMenuItem menuRecord;
        private System.Windows.Forms.ToolStripMenuItem menuReport;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button printBtn;
    }
}