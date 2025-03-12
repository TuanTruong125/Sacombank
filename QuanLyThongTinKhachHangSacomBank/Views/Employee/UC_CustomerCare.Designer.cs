namespace QuanLyThongTinKhachHangSacomBank.Views.Employee
{
    partial class UC_CustomerCare
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CustomerCare));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupCustomerCare = new GroupBox();
            panel3 = new Panel();
            panelCustomerCare = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            buttonCancel = new Button();
            buttonDone = new Button();
            buttonDetail = new Button();
            buttonChat = new Button();
            panel2 = new Panel();
            groupBoxCustomerCareManagement = new GroupBox();
            dataGridViewCustomerCareManagement = new DataGridView();
            comboBoxCustomerCareFilter = new ComboBox();
            labelCustomerCareFilter = new Label();
            panelAccountSearch = new Panel();
            buttonTransactionSearch = new Button();
            textBoxCustomerCareSearch = new TextBox();
            SupportID = new DataGridViewTextBoxColumn();
            AccountID = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            RequestDate = new DataGridViewTextBoxColumn();
            HandledBy = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            groupCustomerCare.SuspendLayout();
            panelCustomerCare.SuspendLayout();
            groupBoxCustomerCareManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomerCareManagement).BeginInit();
            panelAccountSearch.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(281, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 5);
            panel1.TabIndex = 5;
            // 
            // groupCustomerCare
            // 
            groupCustomerCare.Controls.Add(panel3);
            groupCustomerCare.Controls.Add(panelCustomerCare);
            groupCustomerCare.Font = new Font("Roboto SemiCondensed Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupCustomerCare.ForeColor = SystemColors.HotTrack;
            groupCustomerCare.Location = new Point(0, 3);
            groupCustomerCare.Name = "groupCustomerCare";
            groupCustomerCare.Size = new Size(1124, 263);
            groupCustomerCare.TabIndex = 11;
            groupCustomerCare.TabStop = false;
            groupCustomerCare.Text = "Hỗ trợ khách hàng";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(192, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 5);
            panel3.TabIndex = 4;
            // 
            // panelCustomerCare
            // 
            panelCustomerCare.BackColor = SystemColors.InactiveCaption;
            panelCustomerCare.Controls.Add(panel5);
            panelCustomerCare.Controls.Add(panel4);
            panelCustomerCare.Controls.Add(buttonCancel);
            panelCustomerCare.Controls.Add(buttonDone);
            panelCustomerCare.Controls.Add(buttonDetail);
            panelCustomerCare.Controls.Add(buttonChat);
            panelCustomerCare.Controls.Add(panel2);
            panelCustomerCare.ForeColor = Color.White;
            panelCustomerCare.Location = new Point(7, 32);
            panelCustomerCare.Name = "panelCustomerCare";
            panelCustomerCare.Size = new Size(1108, 216);
            panelCustomerCare.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Location = new Point(827, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 190);
            panel5.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HotTrack;
            panel4.Location = new Point(553, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 190);
            panel4.TabIndex = 4;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Tomato;
            buttonCancel.ForeColor = Color.Black;
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.ImageAlign = ContentAlignment.TopCenter;
            buttonCancel.Location = new Point(908, 25);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(134, 166);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LightGreen;
            buttonDone.ForeColor = Color.Black;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.ImageAlign = ContentAlignment.TopCenter;
            buttonDone.Location = new Point(617, 25);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(134, 166);
            buttonDone.TabIndex = 6;
            buttonDone.Text = "Hoàn thành";
            buttonDone.UseVisualStyleBackColor = false;
            // 
            // buttonDetail
            // 
            buttonDetail.BackColor = Color.Moccasin;
            buttonDetail.ForeColor = Color.Black;
            buttonDetail.Image = (Image)resources.GetObject("buttonDetail.Image");
            buttonDetail.ImageAlign = ContentAlignment.TopCenter;
            buttonDetail.Location = new Point(359, 25);
            buttonDetail.Name = "buttonDetail";
            buttonDetail.Size = new Size(134, 166);
            buttonDetail.TabIndex = 5;
            buttonDetail.Text = "Chi tiết yêu cầu";
            buttonDetail.UseVisualStyleBackColor = false;
            // 
            // buttonChat
            // 
            buttonChat.BackColor = Color.PaleTurquoise;
            buttonChat.ForeColor = Color.Black;
            buttonChat.Image = (Image)resources.GetObject("buttonChat.Image");
            buttonChat.ImageAlign = ContentAlignment.TopCenter;
            buttonChat.Location = new Point(70, 25);
            buttonChat.Name = "buttonChat";
            buttonChat.Size = new Size(134, 166);
            buttonChat.TabIndex = 4;
            buttonChat.Text = "Liên hệ khách hàng";
            buttonChat.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(283, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 190);
            panel2.TabIndex = 3;
            // 
            // groupBoxCustomerCareManagement
            // 
            groupBoxCustomerCareManagement.Controls.Add(panel1);
            groupBoxCustomerCareManagement.Controls.Add(dataGridViewCustomerCareManagement);
            groupBoxCustomerCareManagement.Controls.Add(comboBoxCustomerCareFilter);
            groupBoxCustomerCareManagement.Controls.Add(labelCustomerCareFilter);
            groupBoxCustomerCareManagement.Controls.Add(panelAccountSearch);
            groupBoxCustomerCareManagement.Font = new Font("Roboto SemiCondensed Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxCustomerCareManagement.ForeColor = SystemColors.HotTrack;
            groupBoxCustomerCareManagement.Location = new Point(7, 272);
            groupBoxCustomerCareManagement.Name = "groupBoxCustomerCareManagement";
            groupBoxCustomerCareManagement.Size = new Size(1114, 420);
            groupBoxCustomerCareManagement.TabIndex = 12;
            groupBoxCustomerCareManagement.TabStop = false;
            groupBoxCustomerCareManagement.Text = "Dữ liệu yêu cầu khách hàng";
            // 
            // dataGridViewCustomerCareManagement
            // 
            dataGridViewCustomerCareManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCustomerCareManagement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCustomerCareManagement.BackgroundColor = Color.White;
            dataGridViewCustomerCareManagement.BorderStyle = BorderStyle.None;
            dataGridViewCustomerCareManagement.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCustomerCareManagement.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Roboto SemiCondensed Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewCustomerCareManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCustomerCareManagement.ColumnHeadersHeight = 29;
            dataGridViewCustomerCareManagement.Columns.AddRange(new DataGridViewColumn[] { SupportID, AccountID, CustomerID, FullName, Title, RequestDate, HandledBy, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto SemiCondensed Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCustomerCareManagement.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCustomerCareManagement.EnableHeadersVisualStyles = false;
            dataGridViewCustomerCareManagement.GridColor = Color.White;
            dataGridViewCustomerCareManagement.Location = new Point(10, 82);
            dataGridViewCustomerCareManagement.Name = "dataGridViewCustomerCareManagement";
            dataGridViewCustomerCareManagement.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCustomerCareManagement.RowHeadersVisible = false;
            dataGridViewCustomerCareManagement.RowHeadersWidth = 51;
            dataGridViewCustomerCareManagement.Size = new Size(1098, 332);
            dataGridViewCustomerCareManagement.TabIndex = 27;
            dataGridViewCustomerCareManagement.CellContentClick += dataGridViewCustomerCareManagement_CellContentClick;
            // 
            // comboBoxCustomerCareFilter
            // 
            comboBoxCustomerCareFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomerCareFilter.Font = new Font("Roboto SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCustomerCareFilter.FormattingEnabled = true;
            comboBoxCustomerCareFilter.Items.AddRange(new object[] { "Cá nhân", "Doanh nghiệp" });
            comboBoxCustomerCareFilter.Location = new Point(716, 31);
            comboBoxCustomerCareFilter.Name = "comboBoxCustomerCareFilter";
            comboBoxCustomerCareFilter.Size = new Size(392, 32);
            comboBoxCustomerCareFilter.TabIndex = 26;
            // 
            // labelCustomerCareFilter
            // 
            labelCustomerCareFilter.AutoSize = true;
            labelCustomerCareFilter.BackColor = Color.Transparent;
            labelCustomerCareFilter.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelCustomerCareFilter.ForeColor = Color.Black;
            labelCustomerCareFilter.Location = new Point(604, 37);
            labelCustomerCareFilter.Name = "labelCustomerCareFilter";
            labelCustomerCareFilter.Size = new Size(95, 20);
            labelCustomerCareFilter.TabIndex = 25;
            labelCustomerCareFilter.Text = "Lọc yêu cầu";
            // 
            // panelAccountSearch
            // 
            panelAccountSearch.Controls.Add(buttonTransactionSearch);
            panelAccountSearch.Controls.Add(textBoxCustomerCareSearch);
            panelAccountSearch.Location = new Point(7, 22);
            panelAccountSearch.Name = "panelAccountSearch";
            panelAccountSearch.Size = new Size(561, 51);
            panelAccountSearch.TabIndex = 3;
            // 
            // buttonTransactionSearch
            // 
            buttonTransactionSearch.BackColor = SystemColors.HotTrack;
            buttonTransactionSearch.ForeColor = Color.White;
            buttonTransactionSearch.Image = (Image)resources.GetObject("buttonTransactionSearch.Image");
            buttonTransactionSearch.Location = new Point(507, 7);
            buttonTransactionSearch.Name = "buttonTransactionSearch";
            buttonTransactionSearch.Size = new Size(35, 35);
            buttonTransactionSearch.TabIndex = 4;
            buttonTransactionSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxCustomerCareSearch
            // 
            textBoxCustomerCareSearch.Anchor = AnchorStyles.None;
            textBoxCustomerCareSearch.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCustomerCareSearch.Location = new Point(0, 9);
            textBoxCustomerCareSearch.Name = "textBoxCustomerCareSearch";
            textBoxCustomerCareSearch.PlaceholderText = "Tìm kiếm . . .";
            textBoxCustomerCareSearch.Size = new Size(509, 32);
            textBoxCustomerCareSearch.TabIndex = 0;
            textBoxCustomerCareSearch.WordWrap = false;
            // 
            // SupportID
            // 
            SupportID.HeaderText = "Mã yêu cầu";
            SupportID.MinimumWidth = 6;
            SupportID.Name = "SupportID";
            SupportID.Width = 132;
            // 
            // AccountID
            // 
            AccountID.HeaderText = "Mã tài khoản";
            AccountID.MinimumWidth = 6;
            AccountID.Name = "AccountID";
            AccountID.Width = 146;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Mã khách hàng";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 164;
            // 
            // FullName
            // 
            FullName.HeaderText = "Họ tên khách hàng";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 194;
            // 
            // Title
            // 
            Title.HeaderText = "Tiêu đề";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 99;
            // 
            // RequestDate
            // 
            RequestDate.HeaderText = "Ngày gửi";
            RequestDate.MinimumWidth = 6;
            RequestDate.Name = "RequestDate";
            RequestDate.Width = 112;
            // 
            // HandledBy
            // 
            HandledBy.HeaderText = "Nhân viên tiếp nhận";
            HandledBy.MinimumWidth = 6;
            HandledBy.Name = "HandledBy";
            HandledBy.Width = 202;
            // 
            // Status
            // 
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 122;
            // 
            // UC_CustomerCare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupCustomerCare);
            Controls.Add(groupBoxCustomerCareManagement);
            Name = "UC_CustomerCare";
            Size = new Size(1124, 695);
            groupCustomerCare.ResumeLayout(false);
            panelCustomerCare.ResumeLayout(false);
            groupBoxCustomerCareManagement.ResumeLayout(false);
            groupBoxCustomerCareManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomerCareManagement).EndInit();
            panelAccountSearch.ResumeLayout(false);
            panelAccountSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupCustomerCare;
        private Panel panel3;
        private Panel panelCustomerCare;
        private Panel panel5;
        private Panel panel4;
        private Button buttonCancel;
        private Button buttonDone;
        private Button buttonDetail;
        private Button buttonChat;
        private Panel panel2;
        private GroupBox groupBoxCustomerCareManagement;
        private DataGridView dataGridViewCustomerCareManagement;
        private ComboBox comboBoxCustomerCareFilter;
        private Label labelCustomerCareFilter;
        private Panel panelAccountSearch;
        private Button buttonTransactionSearch;
        private TextBox textBoxCustomerCareSearch;
        private DataGridViewTextBoxColumn SupportID;
        private DataGridViewTextBoxColumn AccountID;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn RequestDate;
        private DataGridViewTextBoxColumn HandledBy;
        private DataGridViewTextBoxColumn Status;
    }
}
