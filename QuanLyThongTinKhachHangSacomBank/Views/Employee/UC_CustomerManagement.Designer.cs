namespace QuanLyThongTinKhachHangSacomBank.Views.Employee
{
    partial class UC_CustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CustomerManagement));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupCustomerInfo = new GroupBox();
            buttonCancelCustomer = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            buttonSaveCustomer = new Button();
            buttonEditCustomer = new Button();
            buttonDeleteCustomer = new Button();
            buttonAddCustomer = new Button();
            panelCustomerInfo = new Panel();
            comboBoxCustomerType = new ComboBox();
            labelCustomerType = new Label();
            dateTimePickerRegistrationDate = new DateTimePicker();
            labelRegistrationDate = new Label();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelPhone = new Label();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            textBoxCitizenID = new TextBox();
            labelCitizenID = new Label();
            comboBoxGender = new ComboBox();
            textBoxNationality = new TextBox();
            labelNationality = new Label();
            labelGender = new Label();
            dateTimePickerDateOfBirth = new DateTimePicker();
            labelDateOfBirth = new Label();
            textBoxFullName = new TextBox();
            labelFullName = new Label();
            textBoxCustomerID = new TextBox();
            labelCustomerID = new Label();
            groupBoxDataCustomerManagement = new GroupBox();
            comboBoxCustomerFilter = new ComboBox();
            labelCustomerFilter = new Label();
            panelCustomerSearch = new Panel();
            buttonCustomerSearch = new Button();
            textBoxCustomerSearch = new TextBox();
            dataCustomerManagement = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            CustomerType = new DataGridViewTextBoxColumn();
            Nationality = new DataGridViewTextBoxColumn();
            CitizenID = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            RegistrationDate = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            groupCustomerInfo.SuspendLayout();
            panelCustomerInfo.SuspendLayout();
            groupBoxDataCustomerManagement.SuspendLayout();
            panelCustomerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataCustomerManagement).BeginInit();
            SuspendLayout();
            // 
            // groupCustomerInfo
            // 
            groupCustomerInfo.Controls.Add(buttonCancelCustomer);
            groupCustomerInfo.Controls.Add(panel3);
            groupCustomerInfo.Controls.Add(panel2);
            groupCustomerInfo.Controls.Add(buttonSaveCustomer);
            groupCustomerInfo.Controls.Add(buttonEditCustomer);
            groupCustomerInfo.Controls.Add(buttonDeleteCustomer);
            groupCustomerInfo.Controls.Add(buttonAddCustomer);
            groupCustomerInfo.Controls.Add(panelCustomerInfo);
            groupCustomerInfo.Font = new Font("Roboto SemiCondensed Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupCustomerInfo.ForeColor = SystemColors.HotTrack;
            groupCustomerInfo.Location = new Point(3, 3);
            groupCustomerInfo.Name = "groupCustomerInfo";
            groupCustomerInfo.Size = new Size(1124, 290);
            groupCustomerInfo.TabIndex = 3;
            groupCustomerInfo.TabStop = false;
            groupCustomerInfo.Text = "Thông tin khách hàng";
            // 
            // buttonCancelCustomer
            // 
            buttonCancelCustomer.BackColor = Color.DeepSkyBlue;
            buttonCancelCustomer.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelCustomer.ForeColor = Color.White;
            buttonCancelCustomer.Image = (Image)resources.GetObject("buttonCancelCustomer.Image");
            buttonCancelCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelCustomer.Location = new Point(1014, 154);
            buttonCancelCustomer.Name = "buttonCancelCustomer";
            buttonCancelCustomer.Size = new Size(104, 36);
            buttonCancelCustomer.TabIndex = 6;
            buttonCancelCustomer.Text = "   Hủy";
            buttonCancelCustomer.UseVisualStyleBackColor = false;
            buttonCancelCustomer.Click += ButtonCancelCustomer_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(211, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 5);
            panel3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(1003, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 200);
            panel2.TabIndex = 3;
            // 
            // buttonSaveCustomer
            // 
            buttonSaveCustomer.BackColor = Color.DeepSkyBlue;
            buttonSaveCustomer.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSaveCustomer.ForeColor = Color.White;
            buttonSaveCustomer.Image = (Image)resources.GetObject("buttonSaveCustomer.Image");
            buttonSaveCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveCustomer.Location = new Point(1014, 238);
            buttonSaveCustomer.Name = "buttonSaveCustomer";
            buttonSaveCustomer.Size = new Size(107, 36);
            buttonSaveCustomer.TabIndex = 5;
            buttonSaveCustomer.Text = "   Lưu";
            buttonSaveCustomer.UseVisualStyleBackColor = false;
            buttonSaveCustomer.Click += ButtonSaveCustomer_Click;
            // 
            // buttonEditCustomer
            // 
            buttonEditCustomer.BackColor = Color.DeepSkyBlue;
            buttonEditCustomer.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditCustomer.ForeColor = Color.White;
            buttonEditCustomer.Image = (Image)resources.GetObject("buttonEditCustomer.Image");
            buttonEditCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditCustomer.Location = new Point(1014, 112);
            buttonEditCustomer.Name = "buttonEditCustomer";
            buttonEditCustomer.Size = new Size(104, 36);
            buttonEditCustomer.TabIndex = 3;
            buttonEditCustomer.Text = "   Sửa";
            buttonEditCustomer.UseVisualStyleBackColor = false;
            buttonEditCustomer.Click += ButtonEditCustomer_Click;
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.BackColor = Color.DeepSkyBlue;
            buttonDeleteCustomer.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteCustomer.ForeColor = Color.White;
            buttonDeleteCustomer.Image = (Image)resources.GetObject("buttonDeleteCustomer.Image");
            buttonDeleteCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDeleteCustomer.Location = new Point(1014, 70);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(104, 36);
            buttonDeleteCustomer.TabIndex = 2;
            buttonDeleteCustomer.Text = "   Xóa";
            buttonDeleteCustomer.UseVisualStyleBackColor = false;
            buttonDeleteCustomer.Click += ButtonDeleteCustomer_Click;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.BackColor = Color.DeepSkyBlue;
            buttonAddCustomer.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddCustomer.ForeColor = Color.White;
            buttonAddCustomer.Image = (Image)resources.GetObject("buttonAddCustomer.Image");
            buttonAddCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCustomer.Location = new Point(1014, 28);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(104, 36);
            buttonAddCustomer.TabIndex = 1;
            buttonAddCustomer.Text = "   Thêm";
            buttonAddCustomer.UseVisualStyleBackColor = false;
            buttonAddCustomer.Click += ButtonAddCustomer_Click;
            // 
            // panelCustomerInfo
            // 
            panelCustomerInfo.BackColor = SystemColors.InactiveCaption;
            panelCustomerInfo.Controls.Add(comboBoxCustomerType);
            panelCustomerInfo.Controls.Add(labelCustomerType);
            panelCustomerInfo.Controls.Add(dateTimePickerRegistrationDate);
            panelCustomerInfo.Controls.Add(labelRegistrationDate);
            panelCustomerInfo.Controls.Add(textBoxPhone);
            panelCustomerInfo.Controls.Add(textBoxEmail);
            panelCustomerInfo.Controls.Add(labelEmail);
            panelCustomerInfo.Controls.Add(labelPhone);
            panelCustomerInfo.Controls.Add(textBoxAddress);
            panelCustomerInfo.Controls.Add(labelAddress);
            panelCustomerInfo.Controls.Add(textBoxCitizenID);
            panelCustomerInfo.Controls.Add(labelCitizenID);
            panelCustomerInfo.Controls.Add(comboBoxGender);
            panelCustomerInfo.Controls.Add(textBoxNationality);
            panelCustomerInfo.Controls.Add(labelNationality);
            panelCustomerInfo.Controls.Add(labelGender);
            panelCustomerInfo.Controls.Add(dateTimePickerDateOfBirth);
            panelCustomerInfo.Controls.Add(labelDateOfBirth);
            panelCustomerInfo.Controls.Add(textBoxFullName);
            panelCustomerInfo.Controls.Add(labelFullName);
            panelCustomerInfo.Controls.Add(textBoxCustomerID);
            panelCustomerInfo.Controls.Add(labelCustomerID);
            panelCustomerInfo.ForeColor = Color.White;
            panelCustomerInfo.Location = new Point(7, 32);
            panelCustomerInfo.Name = "panelCustomerInfo";
            panelCustomerInfo.Size = new Size(990, 242);
            panelCustomerInfo.TabIndex = 0;
            // 
            // comboBoxCustomerType
            // 
            comboBoxCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomerType.Font = new Font("Roboto SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCustomerType.FormattingEnabled = true;
            comboBoxCustomerType.Items.AddRange(new object[] { "Cá nhân", "Doanh nghiệp" });
            comboBoxCustomerType.Location = new Point(324, 93);
            comboBoxCustomerType.Name = "comboBoxCustomerType";
            comboBoxCustomerType.Size = new Size(149, 32);
            comboBoxCustomerType.TabIndex = 22;
            comboBoxCustomerType.SelectedIndexChanged += ComboBoxCustomerType_SelectedIndexChanged;
            // 
            // labelCustomerType
            // 
            labelCustomerType.AutoSize = true;
            labelCustomerType.BackColor = SystemColors.InactiveCaption;
            labelCustomerType.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelCustomerType.ForeColor = Color.Black;
            labelCustomerType.Location = new Point(198, 101);
            labelCustomerType.Name = "labelCustomerType";
            labelCustomerType.Size = new Size(128, 20);
            labelCustomerType.TabIndex = 21;
            labelCustomerType.Text = "Loại khách hàng";
            // 
            // dateTimePickerRegistrationDate
            // 
            dateTimePickerRegistrationDate.CalendarFont = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerRegistrationDate.Font = new Font("Roboto SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerRegistrationDate.Location = new Point(597, 191);
            dateTimePickerRegistrationDate.Name = "dateTimePickerRegistrationDate";
            dateTimePickerRegistrationDate.Size = new Size(390, 29);
            dateTimePickerRegistrationDate.TabIndex = 20;
            dateTimePickerRegistrationDate.ValueChanged += DateTimePickerRegistrationDate_ValueChanged;
            // 
            // labelRegistrationDate
            // 
            labelRegistrationDate.AutoSize = true;
            labelRegistrationDate.BackColor = SystemColors.InactiveCaption;
            labelRegistrationDate.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelRegistrationDate.ForeColor = Color.Black;
            labelRegistrationDate.Location = new Point(479, 197);
            labelRegistrationDate.Name = "labelRegistrationDate";
            labelRegistrationDate.Size = new Size(105, 20);
            labelRegistrationDate.TabIndex = 19;
            labelRegistrationDate.Text = "Ngày đăng kí";
            labelRegistrationDate.Click += LabelRegistrationDate_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(597, 95);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(390, 32);
            textBoxPhone.TabIndex = 18;
            textBoxPhone.TextChanged += TextBoxPhone_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(597, 133);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(390, 32);
            textBoxEmail.TabIndex = 17;
            textBoxEmail.TextChanged += TextBoxEmail_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = SystemColors.InactiveCaption;
            labelEmail.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelEmail.ForeColor = Color.Black;
            labelEmail.Location = new Point(479, 139);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Email";
            labelEmail.Click += LabelEmail_Click;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.BackColor = SystemColors.InactiveCaption;
            labelPhone.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelPhone.ForeColor = Color.Black;
            labelPhone.Location = new Point(479, 101);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(39, 20);
            labelPhone.TabIndex = 15;
            labelPhone.Text = "SĐT";
            labelPhone.Click += LabelPhone_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(597, 57);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(390, 32);
            textBoxAddress.TabIndex = 14;
            textBoxAddress.TextChanged += TextBoxAddress_TextChanged;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = SystemColors.InactiveCaption;
            labelAddress.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelAddress.ForeColor = Color.Black;
            labelAddress.Location = new Point(479, 63);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(59, 20);
            labelAddress.TabIndex = 13;
            labelAddress.Text = "Địa chỉ";
            labelAddress.Click += LabelAddress_Click;
            // 
            // textBoxCitizenID
            // 
            textBoxCitizenID.Location = new Point(597, 19);
            textBoxCitizenID.Name = "textBoxCitizenID";
            textBoxCitizenID.Size = new Size(390, 32);
            textBoxCitizenID.TabIndex = 12;
            textBoxCitizenID.TextChanged += TextBoxCitizenID_TextChanged;
            // 
            // labelCitizenID
            // 
            labelCitizenID.AutoSize = true;
            labelCitizenID.BackColor = SystemColors.InactiveCaption;
            labelCitizenID.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelCitizenID.ForeColor = Color.Black;
            labelCitizenID.Location = new Point(479, 25);
            labelCitizenID.Name = "labelCitizenID";
            labelCitizenID.Size = new Size(119, 20);
            labelCitizenID.TabIndex = 11;
            labelCitizenID.Text = "CCCD/Passport";
            labelCitizenID.Click += LabelCitizenID_Click;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Font = new Font("Roboto SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBoxGender.Location = new Point(129, 93);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(66, 32);
            comboBoxGender.TabIndex = 10;
            comboBoxGender.SelectedIndexChanged += ComboBoxGender_SelectedIndexChanged;
            // 
            // textBoxNationality
            // 
            textBoxNationality.Location = new Point(129, 131);
            textBoxNationality.Name = "textBoxNationality";
            textBoxNationality.Size = new Size(344, 32);
            textBoxNationality.TabIndex = 9;
            textBoxNationality.TextChanged += TextBoxNationality_TextChanged;
            // 
            // labelNationality
            // 
            labelNationality.AutoSize = true;
            labelNationality.BackColor = SystemColors.InactiveCaption;
            labelNationality.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelNationality.ForeColor = Color.Black;
            labelNationality.Location = new Point(10, 139);
            labelNationality.Name = "labelNationality";
            labelNationality.Size = new Size(76, 20);
            labelNationality.TabIndex = 8;
            labelNationality.Text = "Quốc tịch";
            labelNationality.Click += LabelNationality_Click;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.BackColor = SystemColors.InactiveCaption;
            labelGender.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelGender.ForeColor = Color.Black;
            labelGender.Location = new Point(10, 101);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(69, 20);
            labelGender.TabIndex = 6;
            labelGender.Text = "Giới tính";
            labelGender.Click += LabelGender_Click;
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.CalendarFont = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerDateOfBirth.Font = new Font("Roboto SemiCondensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerDateOfBirth.Location = new Point(136, 189);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(337, 29);
            dateTimePickerDateOfBirth.TabIndex = 5;
            dateTimePickerDateOfBirth.ValueChanged += DateTimePickerDateOfBirth_ValueChanged;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.BackColor = SystemColors.InactiveCaption;
            labelDateOfBirth.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelDateOfBirth.ForeColor = Color.Black;
            labelDateOfBirth.Location = new Point(10, 197);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(80, 20);
            labelDateOfBirth.TabIndex = 4;
            labelDateOfBirth.Text = "Ngày sinh";
            labelDateOfBirth.Click += LabelDateOfBirth_Click;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(129, 55);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(344, 32);
            textBoxFullName.TabIndex = 3;
            textBoxFullName.TextChanged += TextBoxFullName_TextChanged;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.BackColor = SystemColors.InactiveCaption;
            labelFullName.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelFullName.ForeColor = Color.Black;
            labelFullName.Location = new Point(10, 63);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(56, 20);
            labelFullName.TabIndex = 2;
            labelFullName.Text = "Họ tên";
            labelFullName.Click += LabelFullName_Click;
            // 
            // textBoxCustomerID
            // 
            textBoxCustomerID.Location = new Point(129, 17);
            textBoxCustomerID.Name = "textBoxCustomerID";
            textBoxCustomerID.Size = new Size(344, 32);
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
            // groupBoxDataCustomerManagement
            // 
            groupBoxDataCustomerManagement.Controls.Add(comboBoxCustomerFilter);
            groupBoxDataCustomerManagement.Controls.Add(labelCustomerFilter);
            groupBoxDataCustomerManagement.Controls.Add(panelCustomerSearch);
            groupBoxDataCustomerManagement.Controls.Add(dataCustomerManagement);
            groupBoxDataCustomerManagement.Controls.Add(panel1);
            groupBoxDataCustomerManagement.Font = new Font("Roboto SemiCondensed Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDataCustomerManagement.ForeColor = SystemColors.HotTrack;
            groupBoxDataCustomerManagement.Location = new Point(3, 299);
            groupBoxDataCustomerManagement.Name = "groupBoxDataCustomerManagement";
            groupBoxDataCustomerManagement.Size = new Size(1121, 393);
            groupBoxDataCustomerManagement.TabIndex = 4;
            groupBoxDataCustomerManagement.TabStop = false;
            groupBoxDataCustomerManagement.Text = "Dữ liệu thông tin khách hàng";
            // 
            // comboBoxCustomerFilter
            // 
            comboBoxCustomerFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomerFilter.Font = new Font("Roboto SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCustomerFilter.FormattingEnabled = true;
            comboBoxCustomerFilter.Items.AddRange(new object[] { "Cá nhân", "Doanh nghiệp", "VIP Cá nhân", "VIP Doanh nghiệp" });
            comboBoxCustomerFilter.Location = new Point(733, 31);
            comboBoxCustomerFilter.Name = "comboBoxCustomerFilter";
            comboBoxCustomerFilter.Size = new Size(382, 32);
            comboBoxCustomerFilter.TabIndex = 24;
            comboBoxCustomerFilter.SelectedIndexChanged += ComboBoxCustomerFilter_SelectedIndexChanged;
            // 
            // labelCustomerFilter
            // 
            labelCustomerFilter.AutoSize = true;
            labelCustomerFilter.BackColor = Color.Transparent;
            labelCustomerFilter.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold);
            labelCustomerFilter.ForeColor = Color.Black;
            labelCustomerFilter.Location = new Point(604, 37);
            labelCustomerFilter.Name = "labelCustomerFilter";
            labelCustomerFilter.Size = new Size(123, 20);
            labelCustomerFilter.TabIndex = 23;
            labelCustomerFilter.Text = "Lọc khách hàng";
            labelCustomerFilter.Click += LabelCustomerFilter_Click_1;
            // 
            // panelCustomerSearch
            // 
            panelCustomerSearch.Controls.Add(buttonCustomerSearch);
            panelCustomerSearch.Controls.Add(textBoxCustomerSearch);
            panelCustomerSearch.Location = new Point(7, 22);
            panelCustomerSearch.Name = "panelCustomerSearch";
            panelCustomerSearch.Size = new Size(561, 51);
            panelCustomerSearch.TabIndex = 3;
            // 
            // buttonCustomerSearch
            // 
            buttonCustomerSearch.BackColor = SystemColors.HotTrack;
            buttonCustomerSearch.ForeColor = Color.White;
            buttonCustomerSearch.Image = (Image)resources.GetObject("buttonCustomerSearch.Image");
            buttonCustomerSearch.Location = new Point(477, 7);
            buttonCustomerSearch.Name = "buttonCustomerSearch";
            buttonCustomerSearch.Size = new Size(35, 35);
            buttonCustomerSearch.TabIndex = 4;
            buttonCustomerSearch.UseVisualStyleBackColor = false;
            buttonCustomerSearch.Click += ButtonCustomerSearch_Click;
            // 
            // textBoxCustomerSearch
            // 
            textBoxCustomerSearch.Anchor = AnchorStyles.None;
            textBoxCustomerSearch.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCustomerSearch.Location = new Point(0, 9);
            textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            textBoxCustomerSearch.PlaceholderText = "Tìm kiếm . . .";
            textBoxCustomerSearch.Size = new Size(487, 32);
            textBoxCustomerSearch.TabIndex = 0;
            textBoxCustomerSearch.WordWrap = false;
            textBoxCustomerSearch.TextChanged += TextBoxCustomerSearch_TextChanged;
            // 
            // dataCustomerManagement
            // 
            dataCustomerManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataCustomerManagement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataCustomerManagement.BackgroundColor = Color.White;
            dataCustomerManagement.BorderStyle = BorderStyle.None;
            dataCustomerManagement.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataCustomerManagement.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Roboto SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataCustomerManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataCustomerManagement.ColumnHeadersHeight = 29;
            dataCustomerManagement.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FullName, Gender, CustomerType, Nationality, CitizenID, Address, Phone, Email, DateOfBirth, RegistrationDate });
            dataCustomerManagement.EnableHeadersVisualStyles = false;
            dataCustomerManagement.GridColor = Color.White;
            dataCustomerManagement.Location = new Point(7, 79);
            dataCustomerManagement.Name = "dataCustomerManagement";
            dataCustomerManagement.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataCustomerManagement.RowHeadersVisible = false;
            dataCustomerManagement.RowHeadersWidth = 51;
            dataCustomerManagement.Size = new Size(1108, 314);
            dataCustomerManagement.TabIndex = 0;
            dataCustomerManagement.CellContentClick += DataCustomerManagement_CellContentClick;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Mã khách hàng";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 147;
            // 
            // FullName
            // 
            FullName.HeaderText = "Họ tên";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 83;
            // 
            // Gender
            // 
            Gender.HeaderText = "Giới tính";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 96;
            // 
            // CustomerType
            // 
            CustomerType.HeaderText = "Loại khách hàng";
            CustomerType.MinimumWidth = 6;
            CustomerType.Name = "CustomerType";
            CustomerType.Width = 155;
            // 
            // Nationality
            // 
            Nationality.HeaderText = "Quốc tịch";
            Nationality.MinimumWidth = 6;
            Nationality.Name = "Nationality";
            Nationality.Width = 103;
            // 
            // CitizenID
            // 
            CitizenID.HeaderText = "CCCD/Passport";
            CitizenID.MinimumWidth = 6;
            CitizenID.Name = "CitizenID";
            CitizenID.Width = 146;
            // 
            // Address
            // 
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 86;
            // 
            // Phone
            // 
            Phone.HeaderText = "SĐT";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 66;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 76;
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "Ngày sinh";
            DateOfBirth.MinimumWidth = 6;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Width = 107;
            // 
            // RegistrationDate
            // 
            RegistrationDate.HeaderText = "Ngày đăng kí";
            RegistrationDate.MinimumWidth = 6;
            RegistrationDate.Name = "RegistrationDate";
            RegistrationDate.Width = 132;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(281, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 5);
            panel1.TabIndex = 2;
            // 
            // UC_CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupCustomerInfo);
            Controls.Add(groupBoxDataCustomerManagement);
            Name = "UC_CustomerManagement";
            Size = new Size(1124, 695);
            Load += UC_CustomerManagement_Load;
            groupCustomerInfo.ResumeLayout(false);
            panelCustomerInfo.ResumeLayout(false);
            panelCustomerInfo.PerformLayout();
            groupBoxDataCustomerManagement.ResumeLayout(false);
            groupBoxDataCustomerManagement.PerformLayout();
            panelCustomerSearch.ResumeLayout(false);
            panelCustomerSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataCustomerManagement).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupCustomerInfo;
        private Panel panelCustomerInfo;
        private Label labelCustomerID;
        private TextBox textBoxCustomerID;
        private TextBox textBoxFullName;
        private Label labelFullName;
        private DateTimePicker dateTimePickerDateOfBirth;
        private Label labelDateOfBirth;
        private TextBox textBoxNationality;
        private Label labelNationality;
        private Label labelGender;
        private ComboBox comboBoxGender;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelPhone;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private TextBox textBoxCitizenID;
        private Label labelCitizenID;
        private TextBox textBoxPhone;
        private DateTimePicker dateTimePickerRegistrationDate;
        private Label labelRegistrationDate;
        private Button buttonAddCustomer;
        private Button buttonEditCustomer;
        private Button buttonDeleteCustomer;
        private Button buttonSaveCustomer;
        private Panel panel2;
        private Panel panel3;
        private Button buttonCancelCustomer;
        private GroupBox groupBoxDataCustomerManagement;
        private Panel panelCustomerSearch;
        private Button buttonCustomerSearch;
        private TextBox textBoxCustomerSearch;
        private DataGridView dataCustomerManagement;
        private Panel panel1;
        private ComboBox comboBoxCustomerType;
        private Label labelCustomerType;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn CustomerType;
        private DataGridViewTextBoxColumn Nationality;
        private DataGridViewTextBoxColumn CitizenID;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn RegistrationDate;
        private ComboBox comboBoxCustomerFilter;
        private Label labelCustomerFilter;
    }
}
