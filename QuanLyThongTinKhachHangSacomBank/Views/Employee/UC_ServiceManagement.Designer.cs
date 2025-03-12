namespace QuanLyThongTinKhachHangSacomBank.Views.Employee
{
    partial class UC_ServiceManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ServiceManagement));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelDuration = new Label();
            textBoxAmount = new TextBox();
            labelAmount = new Label();
            comboBoxServiceType = new ComboBox();
            panel3 = new Panel();
            panel2 = new Panel();
            buttonSaveService = new Button();
            textBoxCustomerID = new TextBox();
            buttonEditService = new Button();
            buttonAddService = new Button();
            panelAccountInfo = new Panel();
            groupBoxStatus = new GroupBox();
            textBoxStatus = new TextBox();
            textBoxApprovalStatus = new TextBox();
            labelApprovalStatus = new Label();
            textBoxHandledBy = new TextBox();
            labelHandledBy = new Label();
            dateTimePickerCreatedDate = new DateTimePicker();
            labelCreatedDate = new Label();
            comboDuration = new ComboBox();
            comboBoxInterestRate = new ComboBox();
            labelInterestRate = new Label();
            textBoxServiceID = new TextBox();
            labelServiceID = new Label();
            labelServiceType = new Label();
            textBoxAccountID = new TextBox();
            labelAccountID = new Label();
            labelCustomerID = new Label();
            buttonDeleteService = new Button();
            groupBoxDataServiceManagement = new GroupBox();
            dataGridViewServiceManagement = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            AccountID = new DataGridViewTextBoxColumn();
            ServiceType = new DataGridViewTextBoxColumn();
            ServiceID = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            InterestRate = new DataGridViewTextBoxColumn();
            Duration = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            HandledBy = new DataGridViewTextBoxColumn();
            ApprovalStatus = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            comboBoxServiceFilter = new ComboBox();
            labelServiceFilter = new Label();
            panelAccountSearch = new Panel();
            buttonServiceSearch = new Button();
            textBoxServiceSearch = new TextBox();
            panel1 = new Panel();
            groupServiceInfo = new GroupBox();
            buttonCancelService = new Button();
            panelAccountInfo.SuspendLayout();
            groupBoxStatus.SuspendLayout();
            groupBoxDataServiceManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServiceManagement).BeginInit();
            panelAccountSearch.SuspendLayout();
            groupServiceInfo.SuspendLayout();
            SuspendLayout();
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.BackColor = SystemColors.InactiveCaption;
            labelDuration.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelDuration.ForeColor = Color.Black;
            labelDuration.Location = new Point(383, 101);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(55, 20);
            labelDuration.TabIndex = 19;
            labelDuration.Text = "Kì hạn";
            labelDuration.Click += LabelDuration_Click;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(455, 17);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(323, 32);
            textBoxAmount.TabIndex = 12;
            textBoxAmount.TextChanged += TextBoxAmount_TextChanged;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.BackColor = SystemColors.InactiveCaption;
            labelAmount.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelAmount.ForeColor = Color.Black;
            labelAmount.Location = new Point(383, 23);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(59, 20);
            labelAmount.TabIndex = 11;
            labelAmount.Text = "Số tiền";
            labelAmount.Click += LabelAmount_Click;
            // 
            // comboBoxServiceType
            // 
            comboBoxServiceType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServiceType.Font = new Font("Roboto SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxServiceType.FormattingEnabled = true;
            comboBoxServiceType.Items.AddRange(new object[] { "Cá nhân", "Doanh nghiệp" });
            comboBoxServiceType.Location = new Point(136, 93);
            comboBoxServiceType.Name = "comboBoxServiceType";
            comboBoxServiceType.Size = new Size(220, 32);
            comboBoxServiceType.TabIndex = 10;
            comboBoxServiceType.SelectedIndexChanged += ComboBoxServiceType_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(181, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 5);
            panel3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(1000, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 200);
            panel2.TabIndex = 3;
            // 
            // buttonSaveService
            // 
            buttonSaveService.BackColor = Color.DeepSkyBlue;
            buttonSaveService.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSaveService.ForeColor = Color.White;
            buttonSaveService.Image = (Image)resources.GetObject("buttonSaveService.Image");
            buttonSaveService.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveService.Location = new Point(1011, 241);
            buttonSaveService.Name = "buttonSaveService";
            buttonSaveService.Size = new Size(107, 36);
            buttonSaveService.TabIndex = 5;
            buttonSaveService.Text = "   Lưu";
            buttonSaveService.UseVisualStyleBackColor = false;
            buttonSaveService.Click += ButtonSaveService_Click;
            // 
            // textBoxCustomerID
            // 
            textBoxCustomerID.Location = new Point(136, 17);
            textBoxCustomerID.Name = "textBoxCustomerID";
            textBoxCustomerID.Size = new Size(220, 32);
            textBoxCustomerID.TabIndex = 1;
            textBoxCustomerID.TextChanged += TextBoxCustomerID_TextChanged;
            // 
            // buttonEditService
            // 
            buttonEditService.BackColor = Color.DeepSkyBlue;
            buttonEditService.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditService.ForeColor = Color.White;
            buttonEditService.Image = (Image)resources.GetObject("buttonEditService.Image");
            buttonEditService.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditService.Location = new Point(1011, 115);
            buttonEditService.Name = "buttonEditService";
            buttonEditService.Size = new Size(104, 36);
            buttonEditService.TabIndex = 3;
            buttonEditService.Text = "   Sửa";
            buttonEditService.UseVisualStyleBackColor = false;
            buttonEditService.Click += ButtonEditService_Click;
            // 
            // buttonAddService
            // 
            buttonAddService.BackColor = Color.DeepSkyBlue;
            buttonAddService.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddService.ForeColor = Color.White;
            buttonAddService.Image = (Image)resources.GetObject("buttonAddService.Image");
            buttonAddService.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddService.Location = new Point(1011, 31);
            buttonAddService.Name = "buttonAddService";
            buttonAddService.Size = new Size(104, 36);
            buttonAddService.TabIndex = 1;
            buttonAddService.Text = "   Thêm";
            buttonAddService.UseVisualStyleBackColor = false;
            buttonAddService.Click += ButtonAddService_Click;
            // 
            // panelAccountInfo
            // 
            panelAccountInfo.BackColor = SystemColors.InactiveCaption;
            panelAccountInfo.Controls.Add(groupBoxStatus);
            panelAccountInfo.Controls.Add(textBoxApprovalStatus);
            panelAccountInfo.Controls.Add(labelApprovalStatus);
            panelAccountInfo.Controls.Add(textBoxHandledBy);
            panelAccountInfo.Controls.Add(labelHandledBy);
            panelAccountInfo.Controls.Add(dateTimePickerCreatedDate);
            panelAccountInfo.Controls.Add(labelCreatedDate);
            panelAccountInfo.Controls.Add(comboDuration);
            panelAccountInfo.Controls.Add(comboBoxInterestRate);
            panelAccountInfo.Controls.Add(labelInterestRate);
            panelAccountInfo.Controls.Add(labelDuration);
            panelAccountInfo.Controls.Add(textBoxAmount);
            panelAccountInfo.Controls.Add(labelAmount);
            panelAccountInfo.Controls.Add(comboBoxServiceType);
            panelAccountInfo.Controls.Add(textBoxServiceID);
            panelAccountInfo.Controls.Add(labelServiceID);
            panelAccountInfo.Controls.Add(labelServiceType);
            panelAccountInfo.Controls.Add(textBoxAccountID);
            panelAccountInfo.Controls.Add(labelAccountID);
            panelAccountInfo.Controls.Add(textBoxCustomerID);
            panelAccountInfo.Controls.Add(labelCustomerID);
            panelAccountInfo.ForeColor = Color.White;
            panelAccountInfo.Location = new Point(7, 32);
            panelAccountInfo.Name = "panelAccountInfo";
            panelAccountInfo.Size = new Size(987, 242);
            panelAccountInfo.TabIndex = 0;
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Controls.Add(textBoxStatus);
            groupBoxStatus.Font = new Font("Roboto SemiCondensed Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxStatus.Location = new Point(791, 17);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Size = new Size(187, 150);
            groupBoxStatus.TabIndex = 32;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Trạng thái";
            groupBoxStatus.Enter += GroupBoxStatus_Enter;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(6, 66);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(175, 29);
            textBoxStatus.TabIndex = 33;
            textBoxStatus.TextChanged += TextBoxStatus_TextChanged;
            // 
            // textBoxApprovalStatus
            // 
            textBoxApprovalStatus.Location = new Point(637, 185);
            textBoxApprovalStatus.Name = "textBoxApprovalStatus";
            textBoxApprovalStatus.Size = new Size(347, 32);
            textBoxApprovalStatus.TabIndex = 31;
            textBoxApprovalStatus.TextChanged += TextBoxApprovalStatus_TextChanged;
            // 
            // labelApprovalStatus
            // 
            labelApprovalStatus.AutoSize = true;
            labelApprovalStatus.BackColor = SystemColors.InactiveCaption;
            labelApprovalStatus.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelApprovalStatus.ForeColor = Color.Black;
            labelApprovalStatus.Location = new Point(505, 191);
            labelApprovalStatus.Name = "labelApprovalStatus";
            labelApprovalStatus.Size = new Size(126, 20);
            labelApprovalStatus.TabIndex = 30;
            labelApprovalStatus.Text = "Trạng thái duyệt";
            labelApprovalStatus.Click += LabelApprovalStatus_Click;
            // 
            // textBoxHandledBy
            // 
            textBoxHandledBy.Location = new Point(136, 185);
            textBoxHandledBy.Name = "textBoxHandledBy";
            textBoxHandledBy.Size = new Size(363, 32);
            textBoxHandledBy.TabIndex = 29;
            textBoxHandledBy.TextChanged += TextBoxHandledBy_TextChanged;
            // 
            // labelHandledBy
            // 
            labelHandledBy.AutoSize = true;
            labelHandledBy.BackColor = SystemColors.InactiveCaption;
            labelHandledBy.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelHandledBy.ForeColor = Color.Black;
            labelHandledBy.Location = new Point(10, 191);
            labelHandledBy.Name = "labelHandledBy";
            labelHandledBy.Size = new Size(119, 20);
            labelHandledBy.TabIndex = 28;
            labelHandledBy.Text = "Nhân viên xử lý";
            labelHandledBy.Click += LabelHandledBy_Click;
            // 
            // dateTimePickerCreatedDate
            // 
            dateTimePickerCreatedDate.CalendarFont = new Font("Roboto SemiCondensed Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerCreatedDate.Font = new Font("Roboto SemiCondensed Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerCreatedDate.Location = new Point(455, 137);
            dateTimePickerCreatedDate.Name = "dateTimePickerCreatedDate";
            dateTimePickerCreatedDate.Size = new Size(323, 28);
            dateTimePickerCreatedDate.TabIndex = 27;
            dateTimePickerCreatedDate.ValueChanged += DateTimePickerCreatedDate_ValueChanged;
            // 
            // labelCreatedDate
            // 
            labelCreatedDate.AutoSize = true;
            labelCreatedDate.BackColor = SystemColors.InactiveCaption;
            labelCreatedDate.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelCreatedDate.ForeColor = Color.Black;
            labelCreatedDate.Location = new Point(383, 139);
            labelCreatedDate.Name = "labelCreatedDate";
            labelCreatedDate.Size = new Size(73, 20);
            labelCreatedDate.TabIndex = 26;
            labelCreatedDate.Text = "Ngày tạo";
            labelCreatedDate.Click += LabelCreatedDate_Click;
            // 
            // comboDuration
            // 
            comboDuration.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDuration.Font = new Font("Roboto SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboDuration.FormattingEnabled = true;
            comboDuration.Items.AddRange(new object[] { "Hoạt động", "Tạm khóa" });
            comboDuration.Location = new Point(455, 95);
            comboDuration.Name = "comboDuration";
            comboDuration.Size = new Size(323, 32);
            comboDuration.TabIndex = 25;
            comboDuration.SelectedIndexChanged += ComboDuration_SelectedIndexChanged;
            // 
            // comboBoxInterestRate
            // 
            comboBoxInterestRate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxInterestRate.Font = new Font("Roboto SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxInterestRate.FormattingEnabled = true;
            comboBoxInterestRate.Items.AddRange(new object[] { "Hoạt động", "Tạm khóa" });
            comboBoxInterestRate.Location = new Point(455, 55);
            comboBoxInterestRate.Name = "comboBoxInterestRate";
            comboBoxInterestRate.Size = new Size(323, 32);
            comboBoxInterestRate.TabIndex = 24;
            comboBoxInterestRate.SelectedIndexChanged += ComboBoxInterestRate_SelectedIndexChanged;
            // 
            // labelInterestRate
            // 
            labelInterestRate.AutoSize = true;
            labelInterestRate.BackColor = SystemColors.InactiveCaption;
            labelInterestRate.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelInterestRate.ForeColor = Color.Black;
            labelInterestRate.Location = new Point(383, 63);
            labelInterestRate.Name = "labelInterestRate";
            labelInterestRate.Size = new Size(66, 20);
            labelInterestRate.TabIndex = 23;
            labelInterestRate.Text = "Lãi suất";
            labelInterestRate.Click += LabelInterestRate_Click;
            // 
            // textBoxServiceID
            // 
            textBoxServiceID.Location = new Point(136, 131);
            textBoxServiceID.Name = "textBoxServiceID";
            textBoxServiceID.Size = new Size(220, 32);
            textBoxServiceID.TabIndex = 9;
            textBoxServiceID.TextChanged += TextBoxServiceID_TextChanged;
            // 
            // labelServiceID
            // 
            labelServiceID.AutoSize = true;
            labelServiceID.BackColor = SystemColors.InactiveCaption;
            labelServiceID.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelServiceID.ForeColor = Color.Black;
            labelServiceID.Location = new Point(10, 137);
            labelServiceID.Name = "labelServiceID";
            labelServiceID.Size = new Size(87, 20);
            labelServiceID.TabIndex = 8;
            labelServiceID.Text = "Mã dịch vụ";
            labelServiceID.Click += LabelServiceID_Click;
            // 
            // labelServiceType
            // 
            labelServiceType.AutoSize = true;
            labelServiceType.BackColor = SystemColors.InactiveCaption;
            labelServiceType.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelServiceType.ForeColor = Color.Black;
            labelServiceType.Location = new Point(10, 101);
            labelServiceType.Name = "labelServiceType";
            labelServiceType.Size = new Size(95, 20);
            labelServiceType.TabIndex = 6;
            labelServiceType.Text = "Loại dịch vụ";
            labelServiceType.Click += LabelServiceType_Click;
            // 
            // textBoxAccountID
            // 
            textBoxAccountID.Location = new Point(136, 55);
            textBoxAccountID.Name = "textBoxAccountID";
            textBoxAccountID.Size = new Size(220, 32);
            textBoxAccountID.TabIndex = 3;
            textBoxAccountID.TextChanged += TextBoxAccountID_TextChanged;
            // 
            // labelAccountID
            // 
            labelAccountID.AutoSize = true;
            labelAccountID.BackColor = SystemColors.InactiveCaption;
            labelAccountID.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelAccountID.ForeColor = Color.Black;
            labelAccountID.Location = new Point(10, 63);
            labelAccountID.Name = "labelAccountID";
            labelAccountID.Size = new Size(103, 20);
            labelAccountID.TabIndex = 2;
            labelAccountID.Text = "Mã tài khoản";
            labelAccountID.Click += LabelAccountID_Click;
            // 
            // labelCustomerID
            // 
            labelCustomerID.AutoSize = true;
            labelCustomerID.BackColor = SystemColors.InactiveCaption;
            labelCustomerID.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelCustomerID.ForeColor = Color.Black;
            labelCustomerID.Location = new Point(10, 25);
            labelCustomerID.Name = "labelCustomerID";
            labelCustomerID.Size = new Size(120, 20);
            labelCustomerID.TabIndex = 0;
            labelCustomerID.Text = "Mã khách hàng";
            labelCustomerID.Click += LabelCustomerID_Click;
            // 
            // buttonDeleteService
            // 
            buttonDeleteService.BackColor = Color.DeepSkyBlue;
            buttonDeleteService.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteService.ForeColor = Color.White;
            buttonDeleteService.Image = (Image)resources.GetObject("buttonDeleteService.Image");
            buttonDeleteService.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDeleteService.Location = new Point(1011, 73);
            buttonDeleteService.Name = "buttonDeleteService";
            buttonDeleteService.Size = new Size(104, 36);
            buttonDeleteService.TabIndex = 2;
            buttonDeleteService.Text = "   Xóa";
            buttonDeleteService.UseVisualStyleBackColor = false;
            buttonDeleteService.Click += ButtonDeleteService_Click;
            // 
            // groupBoxDataServiceManagement
            // 
            groupBoxDataServiceManagement.Controls.Add(dataGridViewServiceManagement);
            groupBoxDataServiceManagement.Controls.Add(comboBoxServiceFilter);
            groupBoxDataServiceManagement.Controls.Add(labelServiceFilter);
            groupBoxDataServiceManagement.Controls.Add(panelAccountSearch);
            groupBoxDataServiceManagement.Controls.Add(panel1);
            groupBoxDataServiceManagement.Font = new Font("Roboto SemiCondensed Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDataServiceManagement.ForeColor = SystemColors.HotTrack;
            groupBoxDataServiceManagement.Location = new Point(7, 299);
            groupBoxDataServiceManagement.Name = "groupBoxDataServiceManagement";
            groupBoxDataServiceManagement.Size = new Size(1114, 393);
            groupBoxDataServiceManagement.TabIndex = 8;
            groupBoxDataServiceManagement.TabStop = false;
            groupBoxDataServiceManagement.Text = "Dữ liệu dịch vụ khách hàng";
            // 
            // dataGridViewServiceManagement
            // 
            dataGridViewServiceManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewServiceManagement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewServiceManagement.BackgroundColor = Color.White;
            dataGridViewServiceManagement.BorderStyle = BorderStyle.None;
            dataGridViewServiceManagement.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewServiceManagement.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Roboto SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewServiceManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewServiceManagement.ColumnHeadersHeight = 29;
            dataGridViewServiceManagement.Columns.AddRange(new DataGridViewColumn[] { CustomerID, AccountID, ServiceType, ServiceID, Amount, InterestRate, Duration, CreatedDate, HandledBy, ApprovalStatus, Status });
            dataGridViewServiceManagement.EnableHeadersVisualStyles = false;
            dataGridViewServiceManagement.GridColor = Color.White;
            dataGridViewServiceManagement.Location = new Point(10, 82);
            dataGridViewServiceManagement.Name = "dataGridViewServiceManagement";
            dataGridViewServiceManagement.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewServiceManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewServiceManagement.RowHeadersVisible = false;
            dataGridViewServiceManagement.RowHeadersWidth = 51;
            dataGridViewServiceManagement.Size = new Size(1098, 314);
            dataGridViewServiceManagement.TabIndex = 27;
            dataGridViewServiceManagement.CellContentClick += DataGridViewServiceManagement_CellContentClick;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Mã khách hàng";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 151;
            // 
            // AccountID
            // 
            AccountID.HeaderText = "Mã tài khoản";
            AccountID.MinimumWidth = 6;
            AccountID.Name = "AccountID";
            AccountID.Width = 135;
            // 
            // ServiceType
            // 
            ServiceType.HeaderText = "Loại dịch vụ";
            ServiceType.MinimumWidth = 6;
            ServiceType.Name = "ServiceType";
            ServiceType.Width = 129;
            // 
            // ServiceID
            // 
            ServiceID.HeaderText = "Mã dịch vụ";
            ServiceID.MinimumWidth = 6;
            ServiceID.Name = "ServiceID";
            ServiceID.Width = 120;
            // 
            // Amount
            // 
            Amount.HeaderText = "Số tiền";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 90;
            // 
            // InterestRate
            // 
            InterestRate.HeaderText = "Lãi suất";
            InterestRate.MinimumWidth = 6;
            InterestRate.Name = "InterestRate";
            InterestRate.Width = 97;
            // 
            // Duration
            // 
            Duration.HeaderText = "Kỳ hạn";
            Duration.MinimumWidth = 6;
            Duration.Name = "Duration";
            Duration.Width = 88;
            // 
            // CreatedDate
            // 
            CreatedDate.HeaderText = "Ngày tạo";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            CreatedDate.Width = 106;
            // 
            // HandledBy
            // 
            HandledBy.HeaderText = "Nhân viên xử lý";
            HandledBy.MinimumWidth = 6;
            HandledBy.Name = "HandledBy";
            HandledBy.Width = 153;
            // 
            // ApprovalStatus
            // 
            ApprovalStatus.HeaderText = "Trạng thái duyệt";
            ApprovalStatus.MinimumWidth = 6;
            ApprovalStatus.Name = "ApprovalStatus";
            ApprovalStatus.Width = 160;
            // 
            // Status
            // 
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 113;
            // 
            // comboBoxServiceFilter
            // 
            comboBoxServiceFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServiceFilter.Font = new Font("Roboto SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxServiceFilter.FormattingEnabled = true;
            comboBoxServiceFilter.Items.AddRange(new object[] { "Cá nhân", "Doanh nghiệp" });
            comboBoxServiceFilter.Location = new Point(716, 31);
            comboBoxServiceFilter.Name = "comboBoxServiceFilter";
            comboBoxServiceFilter.Size = new Size(392, 32);
            comboBoxServiceFilter.TabIndex = 26;
            comboBoxServiceFilter.SelectedIndexChanged += ComboBoxServiceFilter_SelectedIndexChanged;
            // 
            // labelServiceFilter
            // 
            labelServiceFilter.AutoSize = true;
            labelServiceFilter.BackColor = Color.Transparent;
            labelServiceFilter.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelServiceFilter.ForeColor = Color.Black;
            labelServiceFilter.Location = new Point(604, 37);
            labelServiceFilter.Name = "labelServiceFilter";
            labelServiceFilter.Size = new Size(90, 20);
            labelServiceFilter.TabIndex = 25;
            labelServiceFilter.Text = "Lọc dịch vụ";
            // 
            // panelAccountSearch
            // 
            panelAccountSearch.Controls.Add(buttonServiceSearch);
            panelAccountSearch.Controls.Add(textBoxServiceSearch);
            panelAccountSearch.Location = new Point(7, 22);
            panelAccountSearch.Name = "panelAccountSearch";
            panelAccountSearch.Size = new Size(561, 51);
            panelAccountSearch.TabIndex = 3;
            // 
            // buttonServiceSearch
            // 
            buttonServiceSearch.BackColor = SystemColors.HotTrack;
            buttonServiceSearch.ForeColor = Color.White;
            buttonServiceSearch.Image = (Image)resources.GetObject("buttonServiceSearch.Image");
            buttonServiceSearch.Location = new Point(507, 7);
            buttonServiceSearch.Name = "buttonServiceSearch";
            buttonServiceSearch.Size = new Size(35, 35);
            buttonServiceSearch.TabIndex = 4;
            buttonServiceSearch.UseVisualStyleBackColor = false;
            buttonServiceSearch.Click += ButtonServiceSearch_Click;
            // 
            // textBoxServiceSearch
            // 
            textBoxServiceSearch.Anchor = AnchorStyles.None;
            textBoxServiceSearch.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxServiceSearch.Location = new Point(3, 9);
            textBoxServiceSearch.Name = "textBoxServiceSearch";
            textBoxServiceSearch.PlaceholderText = "Tìm kiếm . . .";
            textBoxServiceSearch.Size = new Size(509, 32);
            textBoxServiceSearch.TabIndex = 0;
            textBoxServiceSearch.WordWrap = false;
            textBoxServiceSearch.TextChanged += TextBoxServiceSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(266, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 5);
            panel1.TabIndex = 2;
            // 
            // groupServiceInfo
            // 
            groupServiceInfo.Controls.Add(buttonCancelService);
            groupServiceInfo.Controls.Add(panel3);
            groupServiceInfo.Controls.Add(panel2);
            groupServiceInfo.Controls.Add(buttonSaveService);
            groupServiceInfo.Controls.Add(buttonEditService);
            groupServiceInfo.Controls.Add(buttonDeleteService);
            groupServiceInfo.Controls.Add(buttonAddService);
            groupServiceInfo.Controls.Add(panelAccountInfo);
            groupServiceInfo.Font = new Font("Roboto SemiCondensed Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupServiceInfo.ForeColor = SystemColors.HotTrack;
            groupServiceInfo.Location = new Point(0, 3);
            groupServiceInfo.Name = "groupServiceInfo";
            groupServiceInfo.Size = new Size(1124, 290);
            groupServiceInfo.TabIndex = 7;
            groupServiceInfo.TabStop = false;
            groupServiceInfo.Text = "Thông tin dịch vụ";
            // 
            // buttonCancelService
            // 
            buttonCancelService.BackColor = Color.DeepSkyBlue;
            buttonCancelService.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelService.ForeColor = Color.White;
            buttonCancelService.Image = (Image)resources.GetObject("buttonCancelService.Image");
            buttonCancelService.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelService.Location = new Point(1011, 157);
            buttonCancelService.Name = "buttonCancelService";
            buttonCancelService.Size = new Size(104, 36);
            buttonCancelService.TabIndex = 6;
            buttonCancelService.Text = "   Hủy";
            buttonCancelService.UseVisualStyleBackColor = false;
            buttonCancelService.Click += ButtonCancelService_Click;
            // 
            // UC_ServiceManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxDataServiceManagement);
            Controls.Add(groupServiceInfo);
            Name = "UC_ServiceManagement";
            Size = new Size(1124, 695);
            panelAccountInfo.ResumeLayout(false);
            panelAccountInfo.PerformLayout();
            groupBoxStatus.ResumeLayout(false);
            groupBoxStatus.PerformLayout();
            groupBoxDataServiceManagement.ResumeLayout(false);
            groupBoxDataServiceManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServiceManagement).EndInit();
            panelAccountSearch.ResumeLayout(false);
            panelAccountSearch.PerformLayout();
            groupServiceInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label labelDuration;
        private TextBox textBoxAmount;
        private Label labelAmount;
        private ComboBox comboBoxServiceType;
        private Panel panel3;
        private Panel panel2;
        private Button buttonSaveService;
        private TextBox textBoxCustomerID;
        private Button buttonEditService;
        private Button buttonAddService;
        private Panel panelAccountInfo;
        private ComboBox comboBoxInterestRate;
        private Label labelInterestRate;
        private TextBox textBoxServiceID;
        private Label labelServiceID;
        private Label labelServiceType;
        private TextBox textBoxAccountID;
        private Label labelAccountID;
        private Label labelCustomerID;
        private Button buttonDeleteService;
        private GroupBox groupBoxDataServiceManagement;
        private DataGridView dataGridViewServiceManagement;
        private ComboBox comboBoxServiceFilter;
        private Label labelServiceFilter;
        private Panel panelAccountSearch;
        private Button buttonServiceSearch;
        private TextBox textBoxServiceSearch;
        private Panel panel1;
        private GroupBox groupServiceInfo;
        private ComboBox comboDuration;
        private Button buttonCancelService;
        private DateTimePicker dateTimePickerCreatedDate;
        private Label labelCreatedDate;
        private Label labelApprovalStatus;
        private TextBox textBoxHandledBy;
        private Label labelHandledBy;
        private TextBox textBoxApprovalStatus;
        private GroupBox groupBoxStatus;
        private TextBox textBoxStatus;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn AccountID;
        private DataGridViewTextBoxColumn ServiceType;
        private DataGridViewTextBoxColumn ServiceID;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn InterestRate;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn HandledBy;
        private DataGridViewTextBoxColumn ApprovalStatus;
        private DataGridViewTextBoxColumn Status;
    }
}
