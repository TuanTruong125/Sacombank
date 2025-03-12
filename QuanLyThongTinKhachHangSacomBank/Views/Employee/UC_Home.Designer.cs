namespace QuanLyThongTinKhachHangSacomBank.Views.Employee
{
    partial class UC_Home
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
            labelNewRequests = new Label();
            SuspendLayout();
            // 
            // labelNewRequests
            // 
            labelNewRequests.AutoSize = true;
            labelNewRequests.Location = new Point(455, 198);
            labelNewRequests.Name = "labelNewRequests";
            labelNewRequests.Size = new Size(154, 20);
            labelNewRequests.TabIndex = 0;
            labelNewRequests.Text = "Số yêu cầu hỗ trợ mới";
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelNewRequests);
            Name = "UC_Home";
            Size = new Size(1124, 695);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNewRequests;
    }
}
