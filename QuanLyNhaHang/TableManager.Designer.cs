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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableManager));
            menuStrip1 = new MenuStrip();
            admInToolStripMenuItem2 = new ToolStripMenuItem();
            thôngTinTaiKhoanToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCaNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuâtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            listViewBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            panel4 = new Panel();
            comboBoxSwitchTable = new ComboBox();
            textBoxTotalPrice = new TextBox();
            buttonSwitchTable = new Button();
            numericUpDownDiscount = new NumericUpDown();
            buttonDiscount = new Button();
            buttonCheckout = new Button();
            panel5 = new Panel();
            numericUpDownFoodCount = new NumericUpDown();
            buttonAddFood = new Button();
            comboBoxFood = new ComboBox();
            comboBoxCategory = new ComboBox();
            flowLayoutPanelTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
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
            listViewBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewBill.GridLines = true;
            listViewBill.Location = new Point(0, 3);
            listViewBill.Name = "listViewBill";
            listViewBill.Size = new Size(435, 324);
            listViewBill.TabIndex = 1;
            listViewBill.UseCompatibleStateImageBehavior = false;
            listViewBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 100;
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
            panel4.Controls.Add(comboBoxSwitchTable);
            panel4.Controls.Add(textBoxTotalPrice);
            panel4.Controls.Add(buttonSwitchTable);
            panel4.Controls.Add(numericUpDownDiscount);
            panel4.Controls.Add(buttonDiscount);
            panel4.Controls.Add(buttonCheckout);
            panel4.Location = new Point(521, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 73);
            panel4.TabIndex = 2;
            // 
            // comboBoxSwitchTable
            // 
            comboBoxSwitchTable.FormattingEnabled = true;
            comboBoxSwitchTable.Location = new Point(2, 38);
            comboBoxSwitchTable.Name = "comboBoxSwitchTable";
            comboBoxSwitchTable.Size = new Size(83, 23);
            comboBoxSwitchTable.TabIndex = 9;
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxTotalPrice.ForeColor = Color.OrangeRed;
            textBoxTotalPrice.Location = new Point(210, 24);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.ReadOnly = true;
            textBoxTotalPrice.Size = new Size(119, 24);
            textBoxTotalPrice.TabIndex = 8;
            textBoxTotalPrice.Text = "0";
            textBoxTotalPrice.TextAlign = HorizontalAlignment.Right;
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
            buttonSwitchTable.Click += buttonSwitchTable_Click;
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.Location = new Point(103, 38);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(86, 23);
            numericUpDownDiscount.TabIndex = 5;
            numericUpDownDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonDiscount
            // 
            buttonDiscount.BackColor = Color.Orange;
            buttonDiscount.Location = new Point(103, 3);
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
            buttonCheckout.Click += buttonCheckout_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(numericUpDownFoodCount);
            panel5.Controls.Add(buttonAddFood);
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
            // buttonAddFood
            // 
            buttonAddFood.BackColor = Color.IndianRed;
            buttonAddFood.Location = new Point(229, 0);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new Size(75, 52);
            buttonAddFood.TabIndex = 2;
            buttonAddFood.Text = "Thêm món";
            buttonAddFood.UseVisualStyleBackColor = false;
            buttonAddFood.Click += buttonAddFood_Click;
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
            comboBoxCategory.Location = new Point(2, 2);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(205, 23);
            comboBoxCategory.TabIndex = 0;
            comboBoxCategory.SelectedIndexChanged += boxCategory_Click;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhà hàng PTIT";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Button buttonAddFood;
        private ComboBox comboBoxFood;
        private Button buttonCheckout;
        private FlowLayoutPanel flowLayoutPanelTable;
        private Button buttonDiscount;
        private NumericUpDown numericUpDownDiscount;
        private ToolStripMenuItem admInToolStripMenuItem2;
        private Button buttonSwitchTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox textBoxTotalPrice;
        private ComboBox comboBoxSwitchTable;
    }
}