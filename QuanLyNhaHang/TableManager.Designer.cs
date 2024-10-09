namespace QuanLyNhaHang
{
    partial class TableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTaiKhoanToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            thôngTinCaNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuâtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTaiKhoanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1099, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // thôngTinTaiKhoanToolStripMenuItem
            // 
            thôngTinTaiKhoanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCaNhânToolStripMenuItem, đăngXuâtToolStripMenuItem });
            thôngTinTaiKhoanToolStripMenuItem.Name = "thôngTinTaiKhoanToolStripMenuItem";
            thôngTinTaiKhoanToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTaiKhoanToolStripMenuItem.Click += thôngTinTaiKhoanToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 607);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // thôngTinCaNhânToolStripMenuItem
            // 
            thôngTinCaNhânToolStripMenuItem.Name = "thôngTinCaNhânToolStripMenuItem";
            thôngTinCaNhânToolStripMenuItem.Size = new Size(224, 26);
            thôngTinCaNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // đăngXuâtToolStripMenuItem
            // 
            đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            đăngXuâtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuâtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // panel2
            // 
            panel2.Location = new Point(595, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 607);
            panel2.TabIndex = 0;
            // 
            // TableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 642);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableManager";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTaiKhoanToolStripMenuItem;
        private ToolStripMenuItem thôngTinCaNhânToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private Panel panel2;
    }
}