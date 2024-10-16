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
            admInToolStripMenuItem2 = new ToolStripMenuItem();
            thôngTinTaiKhoanToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCaNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuâtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            listViewBill = new ListView();
            panel3 = new Panel();
            panel4 = new Panel();
            numericUpDownSwitchTable = new NumericUpDown();
            buttonSwitchTable = new Button();
            numericUpDownDiscount = new NumericUpDown();
            buttonDiscount = new Button();
            buttonCheckout = new Button();
            panel5 = new Panel();
            numericUpDownFoodCount = new NumericUpDown();
            buttonFood = new Button();
            comboBoxFood = new ComboBox();
            comboBoxCategory = new ComboBox();
            flowLayoutPanelTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSwitchTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { admInToolStripMenuItem2, thôngTinTaiKhoanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(962, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // admInToolStripMenuItem2
            // 
            admInToolStripMenuItem2.Name = "admInToolStripMenuItem2";
            admInToolStripMenuItem2.Size = new Size(55, 20);
            admInToolStripMenuItem2.Text = "Admin";
            admInToolStripMenuItem2.Click += admInToolStripMenuItem2_Click;
            // 
            // thôngTinTaiKhoanToolStripMenuItem
            // 
            thôngTinTaiKhoanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCaNhânToolStripMenuItem, đăngXuâtToolStripMenuItem });
            thôngTinTaiKhoanToolStripMenuItem.Name = "thôngTinTaiKhoanToolStripMenuItem";
            thôngTinTaiKhoanToolStripMenuItem.Size = new Size(122, 20);
            thôngTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCaNhânToolStripMenuItem
            // 
            thôngTinCaNhânToolStripMenuItem.Name = "thôngTinCaNhânToolStripMenuItem";
            thôngTinCaNhânToolStripMenuItem.Size = new Size(170, 22);
            thôngTinCaNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCaNhânToolStripMenuItem.Click += thôngTinCaNhânToolStripMenuItem_Click;
            // 
            // đăngXuâtToolStripMenuItem
            // 
            đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            đăngXuâtToolStripMenuItem.Size = new Size(170, 22);
            đăngXuâtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuâtToolStripMenuItem.Click += đăngXuâtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(listViewBill);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(521, 82);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 324);
            panel2.TabIndex = 0;
            // 
            // listViewBill
            // 
            listViewBill.Location = new Point(3, 0);
            listViewBill.Name = "listViewBill";
            listViewBill.Size = new Size(435, 324);
            listViewBill.TabIndex = 1;
            listViewBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 379);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 76);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(numericUpDownSwitchTable);
            panel4.Controls.Add(buttonSwitchTable);
            panel4.Controls.Add(numericUpDownDiscount);
            panel4.Controls.Add(buttonDiscount);
            panel4.Controls.Add(buttonCheckout);
            panel4.Location = new Point(521, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 73);
            panel4.TabIndex = 2;
            // 
            // numericUpDownSwitchTable
            // 
            numericUpDownSwitchTable.Location = new Point(3, 39);
            numericUpDownSwitchTable.Name = "numericUpDownSwitchTable";
            numericUpDownSwitchTable.Size = new Size(83, 23);
            numericUpDownSwitchTable.TabIndex = 7;
            numericUpDownSwitchTable.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonSwitchTable
            // 
            buttonSwitchTable.BackColor = Color.DeepSkyBlue;
            buttonSwitchTable.Location = new Point(0, 3);
            buttonSwitchTable.Name = "buttonSwitchTable";
            buttonSwitchTable.Size = new Size(86, 35);
            buttonSwitchTable.TabIndex = 6;
            buttonSwitchTable.Text = "Chuyển bàn";
            buttonSwitchTable.UseVisualStyleBackColor = false;
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.Location = new Point(178, 39);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(86, 23);
            numericUpDownDiscount.TabIndex = 5;
            numericUpDownDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonDiscount
            // 
            buttonDiscount.BackColor = Color.Orange;
            buttonDiscount.Location = new Point(178, 4);
            buttonDiscount.Name = "buttonDiscount";
            buttonDiscount.Size = new Size(86, 35);
            buttonDiscount.TabIndex = 4;
            buttonDiscount.Text = "Giảm giá";
            buttonDiscount.UseVisualStyleBackColor = false;
            // 
            // buttonCheckout
            // 
            buttonCheckout.BackColor = Color.LawnGreen;
            buttonCheckout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCheckout.Location = new Point(335, 0);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(103, 67);
            buttonCheckout.TabIndex = 3;
            buttonCheckout.Text = "Thanh toán";
            buttonCheckout.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(numericUpDownFoodCount);
            panel5.Controls.Add(buttonFood);
            panel5.Controls.Add(comboBoxFood);
            panel5.Controls.Add(comboBoxCategory);
            panel5.Location = new Point(521, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(438, 52);
            panel5.TabIndex = 3;
            // 
            // numericUpDownFoodCount
            // 
            numericUpDownFoodCount.Location = new Point(310, 17);
            numericUpDownFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownFoodCount.Name = "numericUpDownFoodCount";
            numericUpDownFoodCount.Size = new Size(55, 23);
            numericUpDownFoodCount.TabIndex = 3;
            numericUpDownFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonFood
            // 
            buttonFood.BackColor = Color.IndianRed;
            buttonFood.Location = new Point(229, 0);
            buttonFood.Name = "buttonFood";
            buttonFood.Size = new Size(75, 52);
            buttonFood.TabIndex = 2;
            buttonFood.Text = "Thêm món";
            buttonFood.UseVisualStyleBackColor = false;
            // 
            // comboBoxFood
            // 
            comboBoxFood.FormattingEnabled = true;
            comboBoxFood.Location = new Point(3, 28);
            comboBoxFood.Name = "comboBoxFood";
            comboBoxFood.Size = new Size(205, 23);
            comboBoxFood.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(3, 2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(205, 23);
            comboBoxCategory.TabIndex = 0;
            // 
            // flowLayoutPanelTable
            // 
            flowLayoutPanelTable.AutoScroll = true;
            flowLayoutPanelTable.Location = new Point(4, 27);
            flowLayoutPanelTable.Name = "flowLayoutPanelTable";
            flowLayoutPanelTable.Size = new Size(511, 454);
            flowLayoutPanelTable.TabIndex = 4;
            // 
            // TableManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 482);
            Controls.Add(flowLayoutPanelTable);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableManager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownSwitchTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem thôngTinTaiKhoanToolStripMenuItem;
        private ToolStripMenuItem thôngTinCaNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ListView listViewBill;
        private Panel panel5;
        private ComboBox comboBoxCategory;
        private NumericUpDown numericUpDownFoodCount;
        private Button buttonFood;
        private ComboBox comboBoxFood;
        private Button buttonCheckout;
        private FlowLayoutPanel flowLayoutPanelTable;
        private Button buttonDiscount;
        private NumericUpDown numericUpDownDiscount;
        private ToolStripMenuItem admInToolStripMenuItem2;
        private Button buttonSwitchTable;
        private NumericUpDown numericUpDownSwitchTable;
    }
}