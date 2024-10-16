namespace QuanLyNhaHang
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            textBoxUserName = new TextBox();
            labelUsername = new Label();
            panel2 = new Panel();
            textBoxPassWord = new TextBox();
            label1 = new Label();
            buttonLogin = new Button();
            buttonExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(labelUsername);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 89);
            panel1.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            textBoxUserName.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserName.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserName.Location = new Point(170, 40);
            textBoxUserName.Margin = new Padding(4);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(205, 26);
            textBoxUserName.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(12, 45);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(150, 21);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "TÊN ĐĂNG NHẬP: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxPassWord);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 97);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 58);
            panel2.TabIndex = 1;
            // 
            // textBoxPassWord
            // 
            textBoxPassWord.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassWord.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassWord.Location = new Point(170, 4);
            textBoxPassWord.Margin = new Padding(4);
            textBoxPassWord.Name = "textBoxPassWord";
            textBoxPassWord.Size = new Size(205, 26);
            textBoxPassWord.TabIndex = 1;
            textBoxPassWord.UseSystemPasswordChar = true;
            textBoxPassWord.TextChanged += textBoxPassWord_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 0;
            label1.Text = "MẬT KHẨU:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.LawnGreen;
            buttonLogin.Location = new Point(46, 162);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(111, 36);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Đăng nhập";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Red;
            buttonExit.Location = new Point(241, 162);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(111, 36);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // Login
            // 
            AcceptButton = buttonLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            CancelButton = buttonExit;
            ClientSize = new Size(461, 210);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += Login_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxUserName;
        private Label labelUsername;
        private Panel panel2;
        private TextBox textBoxPassWord;
        private Label label1;
        private Button buttonLogin;
        private Button buttonExit;
    }
}
