namespace QuanLyThongTinKhachHangSacomBank.Views.Employee
{
    partial class UC_TransactionManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TransactionManagement));
            dataGridViewTransactionManagement = new DataGridView();
            buttonTransactionSearch = new Button();
            textBoxTransactionSearch = new TextBox();
            labelTransactionFilter = new Label();
            panelAccountSearch = new Panel();
            comboBoxTransactionFilter = new ComboBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panelTransaction = new Panel();
            groupTransaction = new GroupBox();
            groupBoxTransactionManagement = new GroupBox();
            panel1 = new Panel();
            buttonDeposit = new Button();
            buttonWithdraw = new Button();
            buttonTransfer = new Button();
            buttonPay = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            CustomerID = new DataGridViewTextBoxColumn();
            AccountID = new DataGridViewTextBoxColumn();
            TransactionType = new DataGridViewTextBoxColumn();
            TransactionID = new DataGridViewTextBoxColumn();
            DestinationAccountID = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            TransactionDate = new DataGridViewTextBoxColumn();
            HandledBy = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionManagement).BeginInit();
            panelAccountSearch.SuspendLayout();
            panelTransaction.SuspendLayout();
            groupTransaction.SuspendLayout();
            groupBoxTransactionManagement.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTransactionManagement
            // 
            dataGridViewTransactionManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTransactionManagement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTransactionManagement.BackgroundColor = Color.White;
            dataGridViewTransactionManagement.BorderStyle = BorderStyle.None;
            dataGridViewTransactionManagement.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewTransactionManagement.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Roboto SemiCondensed Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewTransactionManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTransactionManagement.ColumnHeadersHeight = 29;
            dataGridViewTransactionManagement.Columns.AddRange(new DataGridViewColumn[] { CustomerID, AccountID, TransactionType, TransactionID, DestinationAccountID, Amount, Description, TransactionDate, HandledBy, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto SemiCondensed Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTransactionManagement.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTransactionManagement.EnableHeadersVisualStyles = false;
            dataGridViewTransactionManagement.GridColor = Color.White;
            dataGridViewTransactionManagement.Location = new Point(10, 82);
            dataGridViewTransactionManagement.Name = "dataGridViewTransactionManagement";
            dataGridViewTransactionManagement.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewTransactionManagement.RowHeadersVisible = false;
            dataGridViewTransactionManagement.RowHeadersWidth = 51;
            dataGridViewTransactionManagement.Size = new Size(1098, 332);
            dataGridViewTransactionManagement.TabIndex = 27;
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
            // textBoxTransactionSearch
            // 
            textBoxTransactionSearch.Anchor = AnchorStyles.None;
            textBoxTransactionSearch.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTransactionSearch.Location = new Point(3, 9);
            textBoxTransactionSearch.Name = "textBoxTransactionSearch";
            textBoxTransactionSearch.PlaceholderText = "Tìm kiếm . . .";
            textBoxTransactionSearch.Size = new Size(509, 32);
            textBoxTransactionSearch.TabIndex = 0;
            textBoxTransactionSearch.WordWrap = false;
            // 
            // labelTransactionFilter
            // 
            labelTransactionFilter.AutoSize = true;
            labelTransactionFilter.BackColor = Color.Transparent;
            labelTransactionFilter.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelTransactionFilter.ForeColor = Color.Black;
            labelTransactionFilter.Location = new Point(604, 37);
            labelTransactionFilter.Name = "labelTransactionFilter";
            labelTransactionFilter.Size = new Size(104, 20);
            labelTransactionFilter.TabIndex = 25;
            labelTransactionFilter.Text = "Lọc giao dịch";
            // 
            // panelAccountSearch
            // 
            panelAccountSearch.Controls.Add(buttonTransactionSearch);
            panelAccountSearch.Controls.Add(textBoxTransactionSearch);
            panelAccountSearch.Location = new Point(7, 22);
            panelAccountSearch.Name = "panelAccountSearch";
            panelAccountSearch.Size = new Size(561, 51);
            panelAccountSearch.TabIndex = 3;
            // 
            // comboBoxTransactionFilter
            // 
            comboBoxTransactionFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransactionFilter.Font = new Font("Roboto SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTransactionFilter.FormattingEnabled = true;
            comboBoxTransactionFilter.Items.AddRange(new object[] { "Cá nhân", "Doanh nghiệp" });
            comboBoxTransactionFilter.Location = new Point(716, 31);
            comboBoxTransactionFilter.Name = "comboBoxTransactionFilter";
            comboBoxTransactionFilter.Size = new Size(392, 32);
            comboBoxTransactionFilter.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(106, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 5);
            panel3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(283, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 190);
            panel2.TabIndex = 3;
            // 
            // panelTransaction
            // 
            panelTransaction.BackColor = SystemColors.InactiveCaption;
            panelTransaction.Controls.Add(panel5);
            panelTransaction.Controls.Add(panel4);
            panelTransaction.Controls.Add(buttonPay);
            panelTransaction.Controls.Add(buttonTransfer);
            panelTransaction.Controls.Add(buttonWithdraw);
            panelTransaction.Controls.Add(buttonDeposit);
            panelTransaction.Controls.Add(panel2);
            panelTransaction.ForeColor = Color.White;
            panelTransaction.Location = new Point(7, 32);
            panelTransaction.Name = "panelTransaction";
            panelTransaction.Size = new Size(1108, 216);
            panelTransaction.TabIndex = 0;
            // 
            // groupTransaction
            // 
            groupTransaction.Controls.Add(panel3);
            groupTransaction.Controls.Add(panelTransaction);
            groupTransaction.Font = new Font("Roboto SemiCondensed Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupTransaction.ForeColor = SystemColors.HotTrack;
            groupTransaction.Location = new Point(0, 3);
            groupTransaction.Name = "groupTransaction";
            groupTransaction.Size = new Size(1124, 263);
            groupTransaction.TabIndex = 9;
            groupTransaction.TabStop = false;
            groupTransaction.Text = "Giao dịch";
            // 
            // groupBoxTransactionManagement
            // 
            groupBoxTransactionManagement.Controls.Add(panel1);
            groupBoxTransactionManagement.Controls.Add(dataGridViewTransactionManagement);
            groupBoxTransactionManagement.Controls.Add(comboBoxTransactionFilter);
            groupBoxTransactionManagement.Controls.Add(labelTransactionFilter);
            groupBoxTransactionManagement.Controls.Add(panelAccountSearch);
            groupBoxTransactionManagement.Font = new Font("Roboto SemiCondensed Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxTransactionManagement.ForeColor = SystemColors.HotTrack;
            groupBoxTransactionManagement.Location = new Point(7, 272);
            groupBoxTransactionManagement.Name = "groupBoxTransactionManagement";
            groupBoxTransactionManagement.Size = new Size(1114, 420);
            groupBoxTransactionManagement.TabIndex = 10;
            groupBoxTransactionManagement.TabStop = false;
            groupBoxTransactionManagement.Text = "Dữ liệu giao dịch khách hàng";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(283, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 5);
            panel1.TabIndex = 5;
            // 
            // buttonDeposit
            // 
            buttonDeposit.BackColor = Color.LightGreen;
            buttonDeposit.ForeColor = Color.Black;
            buttonDeposit.Image = (Image)resources.GetObject("buttonDeposit.Image");
            buttonDeposit.ImageAlign = ContentAlignment.TopCenter;
            buttonDeposit.Location = new Point(70, 25);
            buttonDeposit.Name = "buttonDeposit";
            buttonDeposit.Size = new Size(134, 166);
            buttonDeposit.TabIndex = 4;
            buttonDeposit.Text = "Nạp tiền";
            buttonDeposit.UseVisualStyleBackColor = false;
            // 
            // buttonWithdraw
            // 
            buttonWithdraw.BackColor = Color.Coral;
            buttonWithdraw.ForeColor = Color.Black;
            buttonWithdraw.Image = (Image)resources.GetObject("buttonWithdraw.Image");
            buttonWithdraw.ImageAlign = ContentAlignment.TopCenter;
            buttonWithdraw.Location = new Point(359, 25);
            buttonWithdraw.Name = "buttonWithdraw";
            buttonWithdraw.Size = new Size(134, 166);
            buttonWithdraw.TabIndex = 5;
            buttonWithdraw.Text = "Rút tiền";
            buttonWithdraw.UseVisualStyleBackColor = false;
            // 
            // buttonTransfer
            // 
            buttonTransfer.BackColor = Color.RoyalBlue;
            buttonTransfer.ForeColor = Color.Black;
            buttonTransfer.Image = (Image)resources.GetObject("buttonTransfer.Image");
            buttonTransfer.ImageAlign = ContentAlignment.TopCenter;
            buttonTransfer.Location = new Point(617, 25);
            buttonTransfer.Name = "buttonTransfer";
            buttonTransfer.Size = new Size(134, 166);
            buttonTransfer.TabIndex = 6;
            buttonTransfer.Text = "Chuyển tiền";
            buttonTransfer.UseVisualStyleBackColor = false;
            // 
            // buttonPay
            // 
            buttonPay.BackColor = Color.Gold;
            buttonPay.ForeColor = Color.Black;
            buttonPay.Image = (Image)resources.GetObject("buttonPay.Image");
            buttonPay.ImageAlign = ContentAlignment.TopCenter;
            buttonPay.Location = new Point(908, 25);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(134, 166);
            buttonPay.TabIndex = 7;
            buttonPay.Text = "Thanh toán";
            buttonPay.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HotTrack;
            panel4.Location = new Point(553, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 190);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Location = new Point(827, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 190);
            panel5.TabIndex = 5;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Mã khách hàng";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 164;
            // 
            // AccountID
            // 
            AccountID.HeaderText = "Mã tài khoản";
            AccountID.MinimumWidth = 6;
            AccountID.Name = "AccountID";
            AccountID.Width = 146;
            // 
            // TransactionType
            // 
            TransactionType.HeaderText = "Loại giao dịch";
            TransactionType.MinimumWidth = 6;
            TransactionType.Name = "TransactionType";
            TransactionType.Width = 156;
            // 
            // TransactionID
            // 
            TransactionID.HeaderText = "Mã giao dịch";
            TransactionID.MinimumWidth = 6;
            TransactionID.Name = "TransactionID";
            TransactionID.Width = 146;
            // 
            // DestinationAccountID
            // 
            DestinationAccountID.HeaderText = "Tài khoản người nhận";
            DestinationAccountID.MinimumWidth = 6;
            DestinationAccountID.Name = "DestinationAccountID";
            DestinationAccountID.Width = 216;
            // 
            // Amount
            // 
            Amount.HeaderText = "Số tiền";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 96;
            // 
            // Description
            // 
            Description.HeaderText = "Nội dung";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 113;
            // 
            // TransactionDate
            // 
            TransactionDate.HeaderText = "Ngày giao dịch";
            TransactionDate.MinimumWidth = 6;
            TransactionDate.Name = "TransactionDate";
            TransactionDate.Width = 163;
            // 
            // HandledBy
            // 
            HandledBy.HeaderText = "Nhân viên xử lý";
            HandledBy.MinimumWidth = 6;
            HandledBy.Name = "HandledBy";
            HandledBy.Width = 164;
            // 
            // Status
            // 
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 122;
            // 
            // UC_TransactionManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupTransaction);
            Controls.Add(groupBoxTransactionManagement);
            Name = "UC_TransactionManagement";
            Size = new Size(1124, 695);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionManagement).EndInit();
            panelAccountSearch.ResumeLayout(false);
            panelAccountSearch.PerformLayout();
            panelTransaction.ResumeLayout(false);
            groupTransaction.ResumeLayout(false);
            groupBoxTransactionManagement.ResumeLayout(false);
            groupBoxTransactionManagement.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTransactionManagement;
        private Button buttonCancelService;
        private Button buttonTransactionSearch;
        private TextBox textBoxTransactionSearch;
        private Label labelTransactionFilter;
        private Panel panelAccountSearch;
        private ComboBox comboBoxTransactionFilter;
        private Panel panel3;
        private Panel panel2;
        private Button buttonSaveService;
        private Button buttonEditService;
        private Button buttonDeleteService;
        private Panel panelTransaction;
        private GroupBox groupTransaction;
        private Button buttonAddService;
        private GroupBox groupBoxTransactionManagement;
        private Panel panel1;
        private Button buttonDeposit;
        private Button buttonPay;
        private Button buttonTransfer;
        private Button buttonWithdraw;
        private Panel panel5;
        private Panel panel4;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn AccountID;
        private DataGridViewTextBoxColumn TransactionType;
        private DataGridViewTextBoxColumn TransactionID;
        private DataGridViewTextBoxColumn DestinationAccountID;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn TransactionDate;
        private DataGridViewTextBoxColumn HandledBy;
        private DataGridViewTextBoxColumn Status;
    }
}
