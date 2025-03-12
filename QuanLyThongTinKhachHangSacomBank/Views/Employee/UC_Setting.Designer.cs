namespace QuanLyThongTinKhachHangSacomBank.Views.Employee
{
    partial class UC_Setting
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
            buttonChangePassword = new Button();
            SuspendLayout();
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.Location = new Point(457, 210);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(226, 108);
            buttonChangePassword.TabIndex = 0;
            buttonChangePassword.Text = "Đổi mật khẩu";
            buttonChangePassword.UseVisualStyleBackColor = true;
            // 
            // UC_Setting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonChangePassword);
            Name = "UC_Setting";
            Size = new Size(1124, 695);
            Load += UC_Setting_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonChangePassword;
    }
}
