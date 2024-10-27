namespace QuanLyNhaHang
{
    partial class AccountProfile
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
            panel1 = new Panel();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            panel2 = new Panel();
            textBoxDisplayName = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            textBoxNewPassword = new TextBox();
            label5 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            textBoxReEnter = new TextBox();
            label7 = new Label();
            buttonUpdate = new Button();
            buttonExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxUsername);
            panel1.Controls.Add(labelUsername);
            panel1.Location = new Point(17, 13);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 52);
            panel1.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(168, 14);
            textBoxUsername.Margin = new Padding(4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.ReadOnly = true;
            textBoxUsername.Size = new Size(205, 26);
            textBoxUsername.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(4, 19);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(127, 21);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxDisplayName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(17, 73);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 56);
            panel2.TabIndex = 2;
            // 
            // textBoxDisplayName
            // 
            textBoxDisplayName.BorderStyle = BorderStyle.FixedSingle;
            textBoxDisplayName.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDisplayName.Location = new Point(168, 18);
            textBoxDisplayName.Margin = new Padding(4);
            textBoxDisplayName.Name = "textBoxDisplayName";
            textBoxDisplayName.Size = new Size(205, 26);
            textBoxDisplayName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBoxPassword);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(17, 137);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 56);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu cũ:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(168, 18);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(205, 26);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBoxNewPassword);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(17, 201);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(377, 56);
            panel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 23);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 2;
            label4.Text = "Mật khẩu mới:";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxNewPassword.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.Location = new Point(168, 18);
            textBoxNewPassword.Margin = new Padding(4);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(205, 26);
            textBoxNewPassword.TabIndex = 1;
            textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 23);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Controls.Add(textBoxReEnter);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(17, 265);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(377, 56);
            panel5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(4, 23);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 2;
            label6.Text = "Nhập lại: ";
            // 
            // textBoxReEnter
            // 
            textBoxReEnter.BorderStyle = BorderStyle.FixedSingle;
            textBoxReEnter.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxReEnter.Location = new Point(168, 18);
            textBoxReEnter.Margin = new Padding(4);
            textBoxReEnter.Name = "textBoxReEnter";
            textBoxReEnter.Size = new Size(205, 26);
            textBoxReEnter.TabIndex = 1;
            textBoxReEnter.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(4, 23);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 0;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.LawnGreen;
            buttonUpdate.Location = new Point(176, 335);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 38);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Cập nhật";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.IndianRed;
            buttonExit.Location = new Point(304, 335);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 38);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = false;
            // 
            // AccountProfile
            // 
            AcceptButton = buttonUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonExit;
            ClientSize = new Size(410, 400);
            Controls.Add(buttonExit);
            Controls.Add(buttonUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            Load += AccountProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private Panel panel2;
        private TextBox textBoxDisplayName;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label2;
        private Panel panel4;
        private Label label4;
        private TextBox textBoxNewPassword;
        private Label label5;
        private Panel panel5;
        private Label label6;
        private TextBox textBoxReEnter;
        private Label label7;
        private Button buttonUpdate;
        private Button buttonExit;
    }
}