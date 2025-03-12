using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinKhachHangSacomBank.UIHelpers
{
    // Hiệu ứng khi chuyển tab giữa các chức năng trong menu FormEmployee
    class EmployeeMenu
    {
        public static void ActivateButton(List<Button> menuButtons, Button activeButton, Panel panelNavigationBar)
        {
            foreach (Button btn in menuButtons)
            {
                btn.BackColor = Color.FromArgb(54, 116, 181);
                btn.ForeColor = Color.White;
            }

            activeButton.BackColor = Color.FromArgb(109, 232, 157);
            activeButton.ForeColor = Color.Black;

            panelNavigationBar.BringToFront();
            panelNavigationBar.Height = activeButton.Height;
            panelNavigationBar.Top = activeButton.Top;
        }
    }
}
