namespace QuanLyThongTinKhachHangSacomBank.Views.Employee
{
    partial class UC_AccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AccountManagement));
            groupBoxDataAccountManagement = new GroupBox();
            dataGridViewAccountManagement = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            AccountID = new DataGridViewTextBoxColumn();
            AccountType = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            PINCode = new DataGridViewTextBoxColumn();
            AccountOpenDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            comboBoxAccountFilter = new ComboBox();
            labelAccountFilter = new Label();
            panelAccountSearch = new Panel();
            buttonAccountSearch = new Button();
            textBoxAccountSearch = new TextBox();
            panel1 = new Panel();
            labelAccountOpenDate = new Label();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            comboBoxAccountType = new ComboBox();
            textBoxBalance = new TextBox();
            groupAccountInfo = new GroupBox();
            groupBoxSensitiveActions = new GroupBox();
            buttonResetPINCode = new Button();
            buttonResetPassword = new Button();
            buttonCancelAccount = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            buttonSaveAccount = new Button();
            buttonEditAccount = new Button();
            buttonDeleteAccount = new Button();
            buttonAddAccount = new Button();
            panelAccountInfo = new Panel();
            comboBoxAccountStatus = new ComboBox();
            labelAccountStatus = new Label();
            dateTimePickerAccountOpenDate = new DateTimePicker();
            labelBalance = new Label();
            labelAccountType = new Label();
            textBoxAccountID = new TextBox();
            labelAccountID = new Label();
            textBoxCustomerID = new TextBox();
            labelCustomerID = new Label();
            groupBoxDataAccountManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccountManagement).BeginInit();
            panelAccountSearch.SuspendLayout();
            groupAccountInfo.SuspendLayout();
            groupBoxSensitiveActions.SuspendLayout();
            panelAccountInfo.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDataAccountManagement
            // 
            groupBoxDataAccountManagement.Controls.Add(dataGridViewAccountManagement);
            groupBoxDataAccountManagement.Controls.Add(comboBoxAccountFilter);
            groupBoxDataAccountManagement.Controls.Add(labelAccountFilter);
            groupBoxDataAccountManagement.Controls.Add(panelAccountSearch);
            groupBoxDataAccountManagement.Controls.Add(panel1);
            groupBoxDataAccountManagement.Font = new Font("Roboto SemiCondensed Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDataAccountManagement.ForeColor = SystemColors.HotTrack;
            groupBoxDataAccountManagement.Location = new Point(7, 299);
            groupBoxDataAccountManagement.Name = "groupBoxDataAccountManagement";
            groupBoxDataAccountManagement.Size = new Size(1114, 393);
            groupBoxDataAccountManagement.TabIndex = 6;
            groupBoxDataAccountManagement.TabStop = false;
            groupBoxDataAccountManagement.Text = "Dữ liệu tài khoản khách hàng";
            // 
            // dataGridViewAccountManagement
            // 
            dataGridViewAccountManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAccountManagement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAccountManagement.BackgroundColor = Color.White;
            dataGridViewAccountManagement.BorderStyle = BorderStyle.None;
            dataGridViewAccountManagement.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewAccountManagement.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewAccountManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAccountManagement.ColumnHeadersHeight = 29;
            dataGridViewAccountManagement.Columns.AddRange(new DataGridViewColumn[] { CustomerID, AccountID, AccountType, Balance, Username, Password, PINCode, AccountOpenDate, Status });
            dataGridViewAccountManagement.EnableHeadersVisualStyles = false;
            dataGridViewAccountManagement.GridColor = Color.White;
            dataGridViewAccountManagement.Location = new Point(10, 82);
            dataGridViewAccountManagement.Name = "dataGridViewAccountManagement";
            dataGridViewAccountManagement.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAccountManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAccountManagement.RowHeadersVisible = false;
            dataGridViewAccountManagement.RowHeadersWidth = 51;
            dataGridViewAccountManagement.Size = new Size(1098, 314);
            dataGridViewAccountManagement.TabIndex = 27;
            dataGridViewAccountManagement.CellContentClick += DataGridViewAccountManagement_CellContentClick;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Mã khách hàng";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 147;
            // 
            // AccountID
            // 
            AccountID.HeaderText = "Mã tài khoản";
            AccountID.MinimumWidth = 6;
            AccountID.Name = "AccountID";
            AccountID.Width = 130;
            // 
            // AccountType
            // 
            AccountType.HeaderText = "Loại tài khoản";
            AccountType.MinimumWidth = 6;
            AccountType.Name = "AccountType";
            AccountType.Width = 138;
            // 
            // Balance
            // 
            Balance.HeaderText = "Số dư";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.Width = 78;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.Width = 110;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Visible = false;
            Password.Width = 107;
            // 
            // PINCode
            // 
            PINCode.HeaderText = "PIN";
            PINCode.MinimumWidth = 6;
            PINCode.Name = "PINCode";
            PINCode.Visible = false;
            PINCode.Width = 62;
            // 
            // AccountOpenDate
            // 
            AccountOpenDate.HeaderText = "Ngày mở";
            AccountOpenDate.MinimumWidth = 6;
            AccountOpenDate.Name = "AccountOpenDate";
            // 
            // Status
            // 
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 109;
            // 
            // comboBoxAccountFilter
            // 
            comboBoxAccountFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAccountFilter.Font = new Font("Roboto SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAccountFilter.FormattingEnabled = true;
            comboBoxAccountFilter.Items.AddRange(new object[] { "Cá nhân", "Doanh nghiệp" });
            comboBoxAccountFilter.Location = new Point(716, 31);
            comboBoxAccountFilter.Name = "comboBoxAccountFilter";
            comboBoxAccountFilter.Size = new Size(392, 32);
            comboBoxAccountFilter.TabIndex = 26;
            comboBoxAccountFilter.SelectedIndexChanged += ComboBoxAccountFilter_SelectedIndexChanged;
            // 
            // labelAccountFilter
            // 
            labelAccountFilter.AutoSize = true;
            labelAccountFilter.BackColor = Color.Transparent;
            labelAccountFilter.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelAccountFilter.ForeColor = Color.Black;
            labelAccountFilter.Location = new Point(604, 37);
            labelAccountFilter.Name = "labelAccountFilter";
            labelAccountFilter.Size = new Size(106, 20);
            labelAccountFilter.TabIndex = 25;
            labelAccountFilter.Text = "Lọc tài khoản";
            // 
            // panelAccountSearch
            // 
            panelAccountSearch.Controls.Add(buttonAccountSearch);
            panelAccountSearch.Controls.Add(textBoxAccountSearch);
            panelAccountSearch.Location = new Point(7, 22);
            panelAccountSearch.Name = "panelAccountSearch";
            panelAccountSearch.Size = new Size(561, 51);
            panelAccountSearch.TabIndex = 3;
            // 
            // buttonAccountSearch
            // 
            buttonAccountSearch.BackColor = SystemColors.HotTrack;
            buttonAccountSearch.ForeColor = Color.White;
            buttonAccountSearch.Image = (Image)resources.GetObject("buttonAccountSearch.Image");
            buttonAccountSearch.Location = new Point(477, 7);
            buttonAccountSearch.Name = "buttonAccountSearch";
            buttonAccountSearch.Size = new Size(35, 35);
            buttonAccountSearch.TabIndex = 4;
            buttonAccountSearch.UseVisualStyleBackColor = false;
            buttonAccountSearch.Click += ButtonAccountSearch_Click;
            // 
            // textBoxAccountSearch
            // 
            textBoxAccountSearch.Anchor = AnchorStyles.None;
            textBoxAccountSearch.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAccountSearch.Location = new Point(0, 9);
            textBoxAccountSearch.Name = "textBoxAccountSearch";
            textBoxAccountSearch.PlaceholderText = "Tìm kiếm . . .";
            textBoxAccountSearch.Size = new Size(487, 32);
            textBoxAccountSearch.TabIndex = 0;
            textBoxAccountSearch.WordWrap = false;
            textBoxAccountSearch.TextChanged += TextBoxAccountSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(281, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 5);
            panel1.TabIndex = 2;
            // 
            // labelAccountOpenDate
            // 
            labelAccountOpenDate.AutoSize = true;
            labelAccountOpenDate.BackColor = SystemColors.InactiveCaption;
            labelAccountOpenDate.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelAccountOpenDate.ForeColor = Color.Black;
            labelAccountOpenDate.Location = new Point(9, 149);
            labelAccountOpenDate.Name = "labelAccountOpenDate";
            labelAccountOpenDate.Size = new Size(144, 20);
            labelAccountOpenDate.TabIndex = 19;
            labelAccountOpenDate.Text = "Ngày mở tài khoản";
            labelAccountOpenDate.Click += LabelAccountOpenDate_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(484, 55);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(274, 32);
            textBoxUsername.TabIndex = 12;
            textBoxUsername.TextChanged += TextBoxUsername_TextChanged;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = SystemColors.InactiveCaption;
            labelUsername.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelUsername.ForeColor = Color.Black;
            labelUsername.Location = new Point(383, 61);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(83, 20);
            labelUsername.TabIndex = 11;
            labelUsername.Text = "Username";
            labelUsername.Click += LabelUsername_Click;
            // 
            // comboBoxAccountType
            // 
            comboBoxAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAccountType.Font = new Font("Roboto SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAccountType.FormattingEnabled = true;
            comboBoxAccountType.Items.AddRange(new object[] { "Cá nhân", "Doanh nghiệp" });
            comboBoxAccountType.Location = new Point(136, 55);
            comboBoxAccountType.Name = "comboBoxAccountType";
            comboBoxAccountType.Size = new Size(220, 32);
            comboBoxAccountType.TabIndex = 10;
            comboBoxAccountType.SelectedIndexChanged += ComboBoxAccountType_SelectedIndexChanged;
            // 
            // textBoxBalance
            // 
            textBoxBalance.Location = new Point(484, 13);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(274, 32);
            textBoxBalance.TabIndex = 9;
            textBoxBalance.TextChanged += TextBoxBalance_TextChanged;
            // 
            // groupAccountInfo
            // 
            groupAccountInfo.Controls.Add(groupBoxSensitiveActions);
            groupAccountInfo.Controls.Add(buttonCancelAccount);
            groupAccountInfo.Controls.Add(panel3);
            groupAccountInfo.Controls.Add(panel2);
            groupAccountInfo.Controls.Add(buttonSaveAccount);
            groupAccountInfo.Controls.Add(buttonEditAccount);
            groupAccountInfo.Controls.Add(buttonDeleteAccount);
            groupAccountInfo.Controls.Add(buttonAddAccount);
            groupAccountInfo.Controls.Add(panelAccountInfo);
            groupAccountInfo.Font = new Font("Roboto SemiCondensed Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupAccountInfo.ForeColor = SystemColors.HotTrack;
            groupAccountInfo.Location = new Point(0, 3);
            groupAccountInfo.Name = "groupAccountInfo";
            groupAccountInfo.Size = new Size(1124, 290);
            groupAccountInfo.TabIndex = 5;
            groupAccountInfo.TabStop = false;
            groupAccountInfo.Text = "Thông tin tài khoản";
            // 
            // groupBoxSensitiveActions
            // 
            groupBoxSensitiveActions.Controls.Add(buttonResetPINCode);
            groupBoxSensitiveActions.Controls.Add(buttonResetPassword);
            groupBoxSensitiveActions.Font = new Font("Roboto SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxSensitiveActions.ForeColor = Color.OrangeRed;
            groupBoxSensitiveActions.Location = new Point(927, 31);
            groupBoxSensitiveActions.Name = "groupBoxSensitiveActions";
            groupBoxSensitiveActions.Size = new Size(188, 243);
            groupBoxSensitiveActions.TabIndex = 28;
            groupBoxSensitiveActions.TabStop = false;
            groupBoxSensitiveActions.Text = "Thao tác đặc biệt";
            // 
            // buttonResetPINCode
            // 
            buttonResetPINCode.BackColor = Color.LightCoral;
            buttonResetPINCode.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonResetPINCode.ForeColor = Color.White;
            buttonResetPINCode.Image = (Image)resources.GetObject("buttonResetPINCode.Image");
            buttonResetPINCode.ImageAlign = ContentAlignment.MiddleLeft;
            buttonResetPINCode.Location = new Point(8, 134);
            buttonResetPINCode.Name = "buttonResetPINCode";
            buttonResetPINCode.Size = new Size(174, 36);
            buttonResetPINCode.TabIndex = 8;
            buttonResetPINCode.Text = "   Đặt lại mã PIN";
            buttonResetPINCode.UseVisualStyleBackColor = false;
            buttonResetPINCode.Click += ButtonResetPINCode_Click;
            // 
            // buttonResetPassword
            // 
            buttonResetPassword.BackColor = Color.LightCoral;
            buttonResetPassword.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonResetPassword.ForeColor = Color.White;
            buttonResetPassword.Image = (Image)resources.GetObject("buttonResetPassword.Image");
            buttonResetPassword.ImageAlign = ContentAlignment.MiddleLeft;
            buttonResetPassword.Location = new Point(8, 62);
            buttonResetPassword.Name = "buttonResetPassword";
            buttonResetPassword.Size = new Size(174, 36);
            buttonResetPassword.TabIndex = 7;
            buttonResetPassword.Text = "   Đặt lại mật khẩu";
            buttonResetPassword.UseVisualStyleBackColor = false;
            buttonResetPassword.Click += ButtonResetPassword_Click;
            // 
            // buttonCancelAccount
            // 
            buttonCancelAccount.BackColor = Color.DeepSkyBlue;
            buttonCancelAccount.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelAccount.ForeColor = Color.White;
            buttonCancelAccount.Image = (Image)resources.GetObject("buttonCancelAccount.Image");
            buttonCancelAccount.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelAccount.Location = new Point(792, 157);
            buttonCancelAccount.Name = "buttonCancelAccount";
            buttonCancelAccount.Size = new Size(104, 36);
            buttonCancelAccount.TabIndex = 6;
            buttonCancelAccount.Text = "   Hủy";
            buttonCancelAccount.UseVisualStyleBackColor = false;
            buttonCancelAccount.Click += ButtonCancelAccount_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(197, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 5);
            panel3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(916, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 200);
            panel2.TabIndex = 3;
            // 
            // buttonSaveAccount
            // 
            buttonSaveAccount.BackColor = Color.DeepSkyBlue;
            buttonSaveAccount.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSaveAccount.ForeColor = Color.White;
            buttonSaveAccount.Image = (Image)resources.GetObject("buttonSaveAccount.Image");
            buttonSaveAccount.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveAccount.Location = new Point(792, 241);
            buttonSaveAccount.Name = "buttonSaveAccount";
            buttonSaveAccount.Size = new Size(107, 36);
            buttonSaveAccount.TabIndex = 5;
            buttonSaveAccount.Text = "   Lưu";
            buttonSaveAccount.UseVisualStyleBackColor = false;
            buttonSaveAccount.Click += ButtonSaveAccount_Click;
            // 
            // buttonEditAccount
            // 
            buttonEditAccount.BackColor = Color.DeepSkyBlue;
            buttonEditAccount.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditAccount.ForeColor = Color.White;
            buttonEditAccount.Image = (Image)resources.GetObject("buttonEditAccount.Image");
            buttonEditAccount.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditAccount.Location = new Point(792, 115);
            buttonEditAccount.Name = "buttonEditAccount";
            buttonEditAccount.Size = new Size(104, 36);
            buttonEditAccount.TabIndex = 3;
            buttonEditAccount.Text = "   Sửa";
            buttonEditAccount.UseVisualStyleBackColor = false;
            buttonEditAccount.Click += ButtonEditAccount_Click;
            // 
            // buttonDeleteAccount
            // 
            buttonDeleteAccount.BackColor = Color.DeepSkyBlue;
            buttonDeleteAccount.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteAccount.ForeColor = Color.White;
            buttonDeleteAccount.Image = (Image)resources.GetObject("buttonDeleteAccount.Image");
            buttonDeleteAccount.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDeleteAccount.Location = new Point(792, 73);
            buttonDeleteAccount.Name = "buttonDeleteAccount";
            buttonDeleteAccount.Size = new Size(104, 36);
            buttonDeleteAccount.TabIndex = 2;
            buttonDeleteAccount.Text = "   Xóa";
            buttonDeleteAccount.UseVisualStyleBackColor = false;
            buttonDeleteAccount.Click += ButtonDeleteAccount_Click;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.BackColor = Color.DeepSkyBlue;
            buttonAddAccount.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddAccount.ForeColor = Color.White;
            buttonAddAccount.Image = (Image)resources.GetObject("buttonAddAccount.Image");
            buttonAddAccount.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddAccount.Location = new Point(792, 31);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(104, 36);
            buttonAddAccount.TabIndex = 1;
            buttonAddAccount.Text = "   Thêm";
            buttonAddAccount.UseVisualStyleBackColor = false;
            buttonAddAccount.Click += ButtonAddAccount_Click;
            // 
            // panelAccountInfo
            // 
            panelAccountInfo.BackColor = SystemColors.InactiveCaption;
            panelAccountInfo.Controls.Add(comboBoxAccountStatus);
            panelAccountInfo.Controls.Add(labelAccountStatus);
            panelAccountInfo.Controls.Add(dateTimePickerAccountOpenDate);
            panelAccountInfo.Controls.Add(labelAccountOpenDate);
            panelAccountInfo.Controls.Add(textBoxUsername);
            panelAccountInfo.Controls.Add(labelUsername);
            panelAccountInfo.Controls.Add(comboBoxAccountType);
            panelAccountInfo.Controls.Add(textBoxBalance);
            panelAccountInfo.Controls.Add(labelBalance);
            panelAccountInfo.Controls.Add(labelAccountType);
            panelAccountInfo.Controls.Add(textBoxAccountID);
            panelAccountInfo.Controls.Add(labelAccountID);
            panelAccountInfo.Controls.Add(textBoxCustomerID);
            panelAccountInfo.Controls.Add(labelCustomerID);
            panelAccountInfo.ForeColor = Color.White;
            panelAccountInfo.Location = new Point(7, 32);
            panelAccountInfo.Name = "panelAccountInfo";
            panelAccountInfo.Size = new Size(761, 242);
            panelAccountInfo.TabIndex = 0;
            // 
            // comboBoxAccountStatus
            // 
            comboBoxAccountStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAccountStatus.Font = new Font("Roboto SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAccountStatus.FormattingEnabled = true;
            comboBoxAccountStatus.Items.AddRange(new object[] { "Hoạt động", "Tạm khóa" });
            comboBoxAccountStatus.Location = new Point(484, 93);
            comboBoxAccountStatus.Name = "comboBoxAccountStatus";
            comboBoxAccountStatus.Size = new Size(274, 32);
            comboBoxAccountStatus.TabIndex = 24;
            comboBoxAccountStatus.SelectedIndexChanged += ComboBoxAccountStatus_SelectedIndexChanged;
            // 
            // labelAccountStatus
            // 
            labelAccountStatus.AutoSize = true;
            labelAccountStatus.BackColor = SystemColors.InactiveCaption;
            labelAccountStatus.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelAccountStatus.ForeColor = Color.Black;
            labelAccountStatus.Location = new Point(383, 99);
            labelAccountStatus.Name = "labelAccountStatus";
            labelAccountStatus.Size = new Size(82, 20);
            labelAccountStatus.TabIndex = 23;
            labelAccountStatus.Text = "Trạng thái";
            labelAccountStatus.Click += LabelAccountStatus_Click;
            // 
            // dateTimePickerAccountOpenDate
            // 
            dateTimePickerAccountOpenDate.CalendarFont = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerAccountOpenDate.Font = new Font("Roboto SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerAccountOpenDate.Location = new Point(159, 143);
            dateTimePickerAccountOpenDate.Name = "dateTimePickerAccountOpenDate";
            dateTimePickerAccountOpenDate.Size = new Size(390, 29);
            dateTimePickerAccountOpenDate.TabIndex = 20;
            dateTimePickerAccountOpenDate.ValueChanged += DateTimePickerAccountOpenDate_ValueChanged;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.BackColor = SystemColors.InactiveCaption;
            labelBalance.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelBalance.ForeColor = Color.Black;
            labelBalance.Location = new Point(383, 25);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(51, 20);
            labelBalance.TabIndex = 8;
            labelBalance.Text = "Số dư";
            labelBalance.Click += LabelBalance_Click;
            // 
            // labelAccountType
            // 
            labelAccountType.AutoSize = true;
            labelAccountType.BackColor = SystemColors.InactiveCaption;
            labelAccountType.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelAccountType.ForeColor = Color.Black;
            labelAccountType.Location = new Point(10, 63);
            labelAccountType.Name = "labelAccountType";
            labelAccountType.Size = new Size(111, 20);
            labelAccountType.TabIndex = 6;
            labelAccountType.Text = "Loại tài khoản";
            labelAccountType.Click += LabelAccountType_Click;
            // 
            // textBoxAccountID
            // 
            textBoxAccountID.Location = new Point(136, 93);
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
            labelAccountID.Location = new Point(10, 101);
            labelAccountID.Name = "labelAccountID";
            labelAccountID.Size = new Size(103, 20);
            labelAccountID.TabIndex = 2;
            labelAccountID.Text = "Mã tài khoản";
            labelAccountID.Click += LabelAccountID_Click;
            // 
            // textBoxCustomerID
            // 
            textBoxCustomerID.Location = new Point(136, 17);
            textBoxCustomerID.Name = "textBoxCustomerID";
            textBoxCustomerID.Size = new Size(220, 32);
            textBoxCustomerID.TabIndex = 1;
            textBoxCustomerID.TextChanged += TextBoxCustomerID_TextChanged;
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
            // UC_AccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxDataAccountManagement);
            Controls.Add(groupAccountInfo);
            Name = "UC_AccountManagement";
            Size = new Size(1124, 695);
            groupBoxDataAccountManagement.ResumeLayout(false);
            groupBoxDataAccountManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccountManagement).EndInit();
            panelAccountSearch.ResumeLayout(false);
            panelAccountSearch.PerformLayout();
            groupAccountInfo.ResumeLayout(false);
            groupBoxSensitiveActions.ResumeLayout(false);
            panelAccountInfo.ResumeLayout(false);
            panelAccountInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDataAccountManagement;
        private Panel panelAccountSearch;
        private Button buttonAccountSearch;
        private TextBox textBoxAccountSearch;
        private Panel panel1;
        private Label labelAccountOpenDate;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private ComboBox comboBoxAccountType;
        private TextBox textBoxBalance;
        private GroupBox groupAccountInfo;
        private Button buttonCancelAccount;
        private Panel panel3;
        private Panel panel2;
        private Button buttonSaveAccount;
        private Button buttonEditAccount;
        private Button buttonDeleteAccount;
        private Button buttonAddAccount;
        private Panel panelAccountInfo;
        private Label labelBalance;
        private Label labelAccountType;
        private TextBox textBoxAccountID;
        private Label labelAccountID;
        private TextBox textBoxCustomerID;
        private Label labelCustomerID;
        private DateTimePicker dateTimePickerAccountOpenDate;
        private Label labelAccountStatus;
        private ComboBox comboBoxAccountStatus;
        private ComboBox comboBoxAccountFilter;
        private Label labelAccountFilter;
        private DataGridView dataGridViewAccountManagement;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn AccountID;
        private DataGridViewTextBoxColumn AccountType;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn PINCode;
        private DataGridViewTextBoxColumn AccountOpenDate;
        private DataGridViewTextBoxColumn Status;
        private Button buttonResetPassword;
        private Button buttonResetPINCode;
        private GroupBox groupBoxSensitiveActions;
    }
}
