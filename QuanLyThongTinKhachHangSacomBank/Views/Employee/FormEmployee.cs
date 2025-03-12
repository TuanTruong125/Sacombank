using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyThongTinKhachHangSacomBank.UIHelpers;


namespace QuanLyThongTinKhachHangSacomBank.Views.Employee
{
    public partial class FormEmployee : Form
    {
        private List<Button> menuButtons; // Danh sách nút menu
        private UserControl activeUC = null;  // UserControl đang hiển thị

        public FormEmployee()
        {
            InitializeComponent();
            InitializeMenuButtons(); // Khởi tạo danh sách button menu
        }

        // Hàm khởi tạo danh sách menu
        private void InitializeMenuButtons()
        {
            // Khởi tạo danh sách menu bằng UIHelper
            menuButtons = new List<Button>
            {
                buttonHome, buttonCustomerManagement, buttonAccountManagement,
                buttonServiceManagement, buttonTransactionManagement, buttonCustomerCare, buttonSetting
            };

            // Set mặc định nút Home được chọn
            EmployeeMenu.ActivateButton(menuButtons, buttonHome, panelNavigationBar);
        }

        // Hàm load UserControl vào panelMainContent
        private void LoadUserControl(UserControl uc)
        {
            if (activeUC != null && activeUC.GetType() == uc.GetType())
            {
                return; // Đã load rồi thì không load lại
            }

            panelMainContentEmployee.Controls.Clear(); // Xóa hết control cũ
            activeUC = uc;
            activeUC.Dock = DockStyle.Fill;
            activeUC.AutoSize = false; // Không cho UC tự co dãn theo nội dung
            activeUC.Width = panelMainContentEmployee.Width; // Đặt kích thước theo Panel
            activeUC.Height = panelMainContentEmployee.Height;
            panelMainContentEmployee.Controls.Add(activeUC);
            panelMainContentEmployee.Refresh(); // Cập nhật lại UI
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Home()); // Load UC_Home vào panelMainContentEmployee khi mới Load
        }


        // --- Label ---
        private void LabelBank_Click(object sender, EventArgs e)
        {

        }

        private void LabelAccountName_Click(object sender, EventArgs e)
        {

        }

        private void LabelEmployee_Click(object sender, EventArgs e)
        {

        }

        private void LabelDate_Click(object sender, EventArgs e)
        {

        }

        // --- Menu Button ---
        private void ButtonHome_Click(object sender, EventArgs e)
        {
            EmployeeMenu.ActivateButton(menuButtons, buttonHome, panelNavigationBar);
            LoadUserControl(new UC_Home()); // Load UC vào panelMainContentEmployee
        }

        private void ButtonCustomerManagement_Click(object sender, EventArgs e)
        {
            EmployeeMenu.ActivateButton(menuButtons, buttonCustomerManagement, panelNavigationBar);
            LoadUserControl(new UC_CustomerManagement()); // Load UC vào panelMainContentEmployee
        }

        private void ButtonAccountManagement_Click(object sender, EventArgs e)
        {
            EmployeeMenu.ActivateButton(menuButtons, buttonAccountManagement, panelNavigationBar);
            LoadUserControl(new UC_AccountManagement()); // Load UC vào panelMainContentEmployee
        }

        private void ButtonServiceManagement_Click(object sender, EventArgs e)
        {
            EmployeeMenu.ActivateButton(menuButtons, buttonServiceManagement, panelNavigationBar);
            LoadUserControl(new UC_ServiceManagement()); // Load UC vào panelMainContentEmployee
        }

        private void ButtonTransactionManagement_Click(object sender, EventArgs e)
        {
            EmployeeMenu.ActivateButton(menuButtons, buttonTransactionManagement, panelNavigationBar);
            LoadUserControl(new UC_TransactionManagement()); // Load UC vào panelMainContentEmployee
        }

        private void ButtonCustomerCare_Click(object sender, EventArgs e)
        {
            EmployeeMenu.ActivateButton(menuButtons, buttonCustomerCare, panelNavigationBar);
            LoadUserControl(new UC_CustomerCare()); // Load UC vào panelMainContentEmployee
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            EmployeeMenu.ActivateButton(menuButtons, buttonSetting, panelNavigationBar);
            LoadUserControl(new UC_Setting()); // Load UC vào panelMainContentEmployee
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form nhân viên
        }

    }
}
