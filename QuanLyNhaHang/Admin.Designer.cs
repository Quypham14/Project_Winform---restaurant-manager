namespace QuanLyNhaHang
{
    partial class Admin
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
            tabPageAccount = new TabPage();
            buttonReversePassword = new Button();
            panel17 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            dataGridViewAccount = new DataGridView();
            panel18 = new Panel();
            buttonDisplayAccount = new Button();
            buttonEditAccount = new Button();
            buttonDeleteAccount = new Button();
            buttonAddAccount = new Button();
            panel19 = new Panel();
            textBoxUserAccount = new TextBox();
            label10 = new Label();
            panel20 = new Panel();
            textBoxNameAccount = new TextBox();
            label11 = new Label();
            tabPageFood = new TabPage();
            panel6 = new Panel();
            textBoxSearchFoodName = new TextBox();
            buttonSearchFood = new Button();
            panel5 = new Panel();
            panel9 = new Panel();
            numericFoodPrice = new NumericUpDown();
            label3 = new Label();
            panel8 = new Panel();
            textBoxFoodName = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            comboBoxFoodCatagory = new ComboBox();
            label1 = new Label();
            panel4 = new Panel();
            textBoxFoodID = new TextBox();
            labelUsername = new Label();
            v = new Panel();
            buttonShowFood = new Button();
            buttonEditFood = new Button();
            buttonDeleteFood = new Button();
            buttonAddFood = new Button();
            panel3 = new Panel();
            dataGridViewFood = new DataGridView();
            tabPageBill = new TabPage();
            panel2 = new Panel();
            buttonViewBill = new Button();
            dateTimePickerToDate = new DateTimePicker();
            dateTimePickerFromDate = new DateTimePicker();
            panel1 = new Panel();
            textBoxCurrentPage = new TextBox();
            buttonNextBillPage = new Button();
            buttonLastBillPage = new Button();
            buttonPrevioursBillPage = new Button();
            buttonFirstBillPage = new Button();
            dataGridViewBill = new DataGridView();
            tabControlFood = new TabControl();
            tabPageAccount.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).BeginInit();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            tabPageFood.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericFoodPrice).BeginInit();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            v.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFood).BeginInit();
            tabPageBill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBill).BeginInit();
            tabControlFood.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageAccount
            // 
            tabPageAccount.Controls.Add(buttonReversePassword);
            tabPageAccount.Controls.Add(panel17);
            tabPageAccount.Controls.Add(dataGridViewAccount);
            tabPageAccount.Controls.Add(panel18);
            tabPageAccount.Controls.Add(panel19);
            tabPageAccount.Controls.Add(panel20);
            tabPageAccount.Location = new Point(4, 24);
            tabPageAccount.Name = "tabPageAccount";
            tabPageAccount.Padding = new Padding(3);
            tabPageAccount.Size = new Size(774, 411);
            tabPageAccount.TabIndex = 4;
            tabPageAccount.Text = "Tài khoản";
            tabPageAccount.UseVisualStyleBackColor = true;
            // 
            // buttonReversePassword
            // 
            buttonReversePassword.BackColor = Color.LawnGreen;
            buttonReversePassword.Location = new Point(680, 264);
            buttonReversePassword.Name = "buttonReversePassword";
            buttonReversePassword.Size = new Size(88, 52);
            buttonReversePassword.TabIndex = 19;
            buttonReversePassword.Text = "Đặt lại mật khẩu";
            buttonReversePassword.UseVisualStyleBackColor = false;
            buttonReversePassword.Click += buttonReversePassword_Click;
            // 
            // panel17
            // 
            panel17.Controls.Add(numericUpDown1);
            panel17.Controls.Add(label9);
            panel17.Location = new Point(402, 197);
            panel17.Margin = new Padding(4);
            panel17.Name = "panel17";
            panel17.Size = new Size(366, 56);
            panel17.TabIndex = 18;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(147, 21);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(193, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 21);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(122, 21);
            label9.TabIndex = 0;
            label9.Text = "Loại tài khoản:";
            // 
            // dataGridViewAccount
            // 
            dataGridViewAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccount.Location = new Point(6, 69);
            dataGridViewAccount.Name = "dataGridViewAccount";
            dataGridViewAccount.RowHeadersWidth = 51;
            dataGridViewAccount.Size = new Size(386, 334);
            dataGridViewAccount.TabIndex = 14;
            // 
            // panel18
            // 
            panel18.Controls.Add(buttonDisplayAccount);
            panel18.Controls.Add(buttonEditAccount);
            panel18.Controls.Add(buttonDeleteAccount);
            panel18.Controls.Add(buttonAddAccount);
            panel18.Location = new Point(6, 8);
            panel18.Name = "panel18";
            panel18.Size = new Size(386, 58);
            panel18.TabIndex = 15;
            // 
            // buttonDisplayAccount
            // 
            buttonDisplayAccount.BackColor = Color.MediumTurquoise;
            buttonDisplayAccount.Location = new Point(261, 3);
            buttonDisplayAccount.Name = "buttonDisplayAccount";
            buttonDisplayAccount.Size = new Size(81, 52);
            buttonDisplayAccount.TabIndex = 3;
            buttonDisplayAccount.Text = "Xem";
            buttonDisplayAccount.UseVisualStyleBackColor = false;
            buttonDisplayAccount.Click += buttonDisplayAccount_Click;
            // 
            // buttonEditAccount
            // 
            buttonEditAccount.BackColor = Color.Gainsboro;
            buttonEditAccount.Location = new Point(174, 3);
            buttonEditAccount.Name = "buttonEditAccount";
            buttonEditAccount.Size = new Size(81, 52);
            buttonEditAccount.TabIndex = 2;
            buttonEditAccount.Text = "Sửa";
            buttonEditAccount.UseVisualStyleBackColor = false;
            buttonEditAccount.Click += buttonEditAccount_Click;
            // 
            // buttonDeleteAccount
            // 
            buttonDeleteAccount.BackColor = Color.IndianRed;
            buttonDeleteAccount.Location = new Point(87, 3);
            buttonDeleteAccount.Name = "buttonDeleteAccount";
            buttonDeleteAccount.Size = new Size(81, 52);
            buttonDeleteAccount.TabIndex = 1;
            buttonDeleteAccount.Text = "Xóa";
            buttonDeleteAccount.UseVisualStyleBackColor = false;
            buttonDeleteAccount.Click += buttonDeleteAccount_Click;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.BackColor = Color.LawnGreen;
            buttonAddAccount.Location = new Point(0, 3);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(81, 52);
            buttonAddAccount.TabIndex = 0;
            buttonAddAccount.Text = "Thêm";
            buttonAddAccount.UseVisualStyleBackColor = false;
            buttonAddAccount.Click += buttonAddAccount_Click;
            // 
            // panel19
            // 
            panel19.Controls.Add(textBoxUserAccount);
            panel19.Controls.Add(label10);
            panel19.Location = new Point(402, 133);
            panel19.Margin = new Padding(4);
            panel19.Name = "panel19";
            panel19.Size = new Size(366, 56);
            panel19.TabIndex = 17;
            // 
            // textBoxUserAccount
            // 
            textBoxUserAccount.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserAccount.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserAccount.Location = new Point(147, 16);
            textBoxUserAccount.Margin = new Padding(4);
            textBoxUserAccount.Name = "textBoxUserAccount";
            textBoxUserAccount.Size = new Size(193, 26);
            textBoxUserAccount.TabIndex = 1;
            textBoxUserAccount.Text = " ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 21);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(104, 21);
            label10.TabIndex = 0;
            label10.Text = "Tên hiển thị:";
            // 
            // panel20
            // 
            panel20.Controls.Add(textBoxNameAccount);
            panel20.Controls.Add(label11);
            panel20.Location = new Point(402, 69);
            panel20.Margin = new Padding(4);
            panel20.Name = "panel20";
            panel20.Size = new Size(366, 56);
            panel20.TabIndex = 16;
            // 
            // textBoxNameAccount
            // 
            textBoxNameAccount.BorderStyle = BorderStyle.FixedSingle;
            textBoxNameAccount.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNameAccount.Location = new Point(147, 16);
            textBoxNameAccount.Margin = new Padding(4);
            textBoxNameAccount.Name = "textBoxNameAccount";
            textBoxNameAccount.Size = new Size(193, 26);
            textBoxNameAccount.TabIndex = 1;
            textBoxNameAccount.Text = " ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 21);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(117, 21);
            label11.TabIndex = 0;
            label11.Text = "Tên tài khoản:";
            // 
            // tabPageFood
            // 
            tabPageFood.Controls.Add(panel6);
            tabPageFood.Controls.Add(panel5);
            tabPageFood.Controls.Add(v);
            tabPageFood.Controls.Add(panel3);
            tabPageFood.Location = new Point(4, 24);
            tabPageFood.Name = "tabPageFood";
            tabPageFood.Padding = new Padding(3);
            tabPageFood.Size = new Size(774, 411);
            tabPageFood.TabIndex = 1;
            tabPageFood.Text = "Thức ăn";
            tabPageFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(textBoxSearchFoodName);
            panel6.Controls.Add(buttonSearchFood);
            panel6.Location = new Point(401, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(370, 58);
            panel6.TabIndex = 3;
            // 
            // textBoxSearchFoodName
            // 
            textBoxSearchFoodName.Location = new Point(16, 22);
            textBoxSearchFoodName.Name = "textBoxSearchFoodName";
            textBoxSearchFoodName.Size = new Size(264, 23);
            textBoxSearchFoodName.TabIndex = 5;
            // 
            // buttonSearchFood
            // 
            buttonSearchFood.Location = new Point(286, 3);
            buttonSearchFood.Name = "buttonSearchFood";
            buttonSearchFood.Size = new Size(81, 52);
            buttonSearchFood.TabIndex = 4;
            buttonSearchFood.Text = "Tìm kiếm";
            buttonSearchFood.UseVisualStyleBackColor = true;
            buttonSearchFood.Click += buttonSearchFood_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel4);
            panel5.Location = new Point(401, 70);
            panel5.Name = "panel5";
            panel5.Size = new Size(370, 341);
            panel5.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(numericFoodPrice);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(1, 193);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(366, 56);
            panel9.TabIndex = 4;
            // 
            // numericFoodPrice
            // 
            numericFoodPrice.Location = new Point(147, 19);
            numericFoodPrice.Name = "numericFoodPrice";
            numericFoodPrice.Size = new Size(193, 23);
            numericFoodPrice.TabIndex = 2;
            numericFoodPrice.TextAlign = HorizontalAlignment.Center;
            numericFoodPrice.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 21);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 21);
            label3.TabIndex = 0;
            label3.Text = "Giá:";
            // 
            // panel8
            // 
            panel8.Controls.Add(textBoxFoodName);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(1, 65);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(366, 56);
            panel8.TabIndex = 3;
            // 
            // textBoxFoodName
            // 
            textBoxFoodName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFoodName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFoodName.Location = new Point(147, 16);
            textBoxFoodName.Margin = new Padding(4);
            textBoxFoodName.Name = "textBoxFoodName";
            textBoxFoodName.Size = new Size(193, 23);
            textBoxFoodName.TabIndex = 1;
            textBoxFoodName.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 21);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên món:";
            // 
            // panel7
            // 
            panel7.Controls.Add(comboBoxFoodCatagory);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(1, 129);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(366, 56);
            panel7.TabIndex = 2;
            // 
            // comboBoxFoodCatagory
            // 
            comboBoxFoodCatagory.FormattingEnabled = true;
            comboBoxFoodCatagory.Location = new Point(146, 21);
            comboBoxFoodCatagory.Name = "comboBoxFoodCatagory";
            comboBoxFoodCatagory.Size = new Size(193, 23);
            comboBoxFoodCatagory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 0;
            label1.Text = "Danh mục:";
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxFoodID);
            panel4.Controls.Add(labelUsername);
            panel4.Location = new Point(1, 1);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(366, 56);
            panel4.TabIndex = 1;
            // 
            // textBoxFoodID
            // 
            textBoxFoodID.BorderStyle = BorderStyle.FixedSingle;
            textBoxFoodID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFoodID.Location = new Point(147, 16);
            textBoxFoodID.Margin = new Padding(4);
            textBoxFoodID.Name = "textBoxFoodID";
            textBoxFoodID.Size = new Size(193, 23);
            textBoxFoodID.TabIndex = 1;
            textBoxFoodID.Text = " ";
            textBoxFoodID.TextChanged += textBoxFoodID_TextChanged;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(15, 21);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(31, 21);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "ID:";
            // 
            // v
            // 
            v.Controls.Add(buttonShowFood);
            v.Controls.Add(buttonEditFood);
            v.Controls.Add(buttonDeleteFood);
            v.Controls.Add(buttonAddFood);
            v.Location = new Point(6, 6);
            v.Name = "v";
            v.Size = new Size(389, 58);
            v.TabIndex = 1;
            // 
            // buttonShowFood
            // 
            buttonShowFood.BackColor = Color.MediumTurquoise;
            buttonShowFood.Location = new Point(261, 6);
            buttonShowFood.Name = "buttonShowFood";
            buttonShowFood.Size = new Size(81, 52);
            buttonShowFood.TabIndex = 3;
            buttonShowFood.Text = "Xem";
            buttonShowFood.UseVisualStyleBackColor = false;
            buttonShowFood.Click += buttonShowFood_Click;
            // 
            // buttonEditFood
            // 
            buttonEditFood.BackColor = Color.Gainsboro;
            buttonEditFood.Location = new Point(174, 3);
            buttonEditFood.Name = "buttonEditFood";
            buttonEditFood.Size = new Size(81, 52);
            buttonEditFood.TabIndex = 2;
            buttonEditFood.Text = "Sửa";
            buttonEditFood.UseVisualStyleBackColor = false;
            buttonEditFood.Click += buttonEditFood_Click;
            // 
            // buttonDeleteFood
            // 
            buttonDeleteFood.BackColor = Color.IndianRed;
            buttonDeleteFood.Location = new Point(87, 3);
            buttonDeleteFood.Name = "buttonDeleteFood";
            buttonDeleteFood.Size = new Size(81, 52);
            buttonDeleteFood.TabIndex = 1;
            buttonDeleteFood.Text = "Xóa";
            buttonDeleteFood.UseVisualStyleBackColor = false;
            buttonDeleteFood.Click += buttonDeleteFood_Click;
            // 
            // buttonAddFood
            // 
            buttonAddFood.BackColor = Color.LawnGreen;
            buttonAddFood.Location = new Point(0, 3);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new Size(81, 52);
            buttonAddFood.TabIndex = 0;
            buttonAddFood.Text = "Thêm";
            buttonAddFood.UseVisualStyleBackColor = false;
            buttonAddFood.Click += buttonAddFood_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewFood);
            panel3.Location = new Point(6, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 338);
            panel3.TabIndex = 0;
            // 
            // dataGridViewFood
            // 
            dataGridViewFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFood.Location = new Point(0, 1);
            dataGridViewFood.Name = "dataGridViewFood";
            dataGridViewFood.RowHeadersWidth = 51;
            dataGridViewFood.Size = new Size(386, 334);
            dataGridViewFood.TabIndex = 0;
            // 
            // tabPageBill
            // 
            tabPageBill.Controls.Add(panel2);
            tabPageBill.Controls.Add(panel1);
            tabPageBill.Location = new Point(4, 24);
            tabPageBill.Name = "tabPageBill";
            tabPageBill.Padding = new Padding(3);
            tabPageBill.Size = new Size(774, 411);
            tabPageBill.TabIndex = 0;
            tabPageBill.Text = " Doanh thu";
            tabPageBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonViewBill);
            panel2.Controls.Add(dateTimePickerToDate);
            panel2.Controls.Add(dateTimePickerFromDate);
            panel2.Location = new Point(6, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 41);
            panel2.TabIndex = 1;
            // 
            // buttonViewBill
            // 
            buttonViewBill.Location = new Point(321, 6);
            buttonViewBill.Name = "buttonViewBill";
            buttonViewBill.Size = new Size(107, 23);
            buttonViewBill.TabIndex = 2;
            buttonViewBill.Text = "Thống kê";
            buttonViewBill.UseVisualStyleBackColor = true;
            buttonViewBill.Click += buttonViewBill_Click;
            // 
            // dateTimePickerToDate
            // 
            dateTimePickerToDate.Location = new Point(565, 4);
            dateTimePickerToDate.Name = "dateTimePickerToDate";
            dateTimePickerToDate.Size = new Size(200, 23);
            dateTimePickerToDate.TabIndex = 1;
            // 
            // dateTimePickerFromDate
            // 
            dateTimePickerFromDate.Location = new Point(0, 4);
            dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            dateTimePickerFromDate.Size = new Size(200, 23);
            dateTimePickerFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxCurrentPage);
            panel1.Controls.Add(buttonNextBillPage);
            panel1.Controls.Add(buttonLastBillPage);
            panel1.Controls.Add(buttonPrevioursBillPage);
            panel1.Controls.Add(buttonFirstBillPage);
            panel1.Controls.Add(dataGridViewBill);
            panel1.Location = new Point(6, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 367);
            panel1.TabIndex = 0;
            // 
            // textBoxCurrentPage
            // 
            textBoxCurrentPage.Location = new Point(321, 331);
            textBoxCurrentPage.Name = "textBoxCurrentPage";
            textBoxCurrentPage.ReadOnly = true;
            textBoxCurrentPage.Size = new Size(107, 23);
            textBoxCurrentPage.TabIndex = 5;
            textBoxCurrentPage.Text = "1";
            textBoxCurrentPage.TextAlign = HorizontalAlignment.Center;
            textBoxCurrentPage.TextChanged += textBoxCurrentPage_TextChanged;
            // 
            // buttonNextBillPage
            // 
            buttonNextBillPage.Location = new Point(574, 323);
            buttonNextBillPage.Name = "buttonNextBillPage";
            buttonNextBillPage.Size = new Size(91, 36);
            buttonNextBillPage.TabIndex = 4;
            buttonNextBillPage.Text = "Next";
            buttonNextBillPage.UseVisualStyleBackColor = true;
            buttonNextBillPage.Click += buttonNextBillPage_Click;
            // 
            // buttonLastBillPage
            // 
            buttonLastBillPage.Location = new Point(671, 323);
            buttonLastBillPage.Name = "buttonLastBillPage";
            buttonLastBillPage.Size = new Size(91, 36);
            buttonLastBillPage.TabIndex = 3;
            buttonLastBillPage.Text = "Last";
            buttonLastBillPage.UseVisualStyleBackColor = true;
            buttonLastBillPage.Click += buttonLastBillPage_Click;
            // 
            // buttonPrevioursBillPage
            // 
            buttonPrevioursBillPage.Location = new Point(100, 323);
            buttonPrevioursBillPage.Name = "buttonPrevioursBillPage";
            buttonPrevioursBillPage.Size = new Size(91, 36);
            buttonPrevioursBillPage.TabIndex = 2;
            buttonPrevioursBillPage.Text = "Previours";
            buttonPrevioursBillPage.UseVisualStyleBackColor = true;
            buttonPrevioursBillPage.Click += buttonPrevioursBillPage_Click;
            // 
            // buttonFirstBillPage
            // 
            buttonFirstBillPage.Location = new Point(3, 323);
            buttonFirstBillPage.Name = "buttonFirstBillPage";
            buttonFirstBillPage.Size = new Size(91, 36);
            buttonFirstBillPage.TabIndex = 1;
            buttonFirstBillPage.Text = "First";
            buttonFirstBillPage.UseVisualStyleBackColor = true;
            buttonFirstBillPage.Click += buttonFirstBillPage_Click;
            // 
            // dataGridViewBill
            // 
            dataGridViewBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBill.Location = new Point(3, 3);
            dataGridViewBill.Name = "dataGridViewBill";
            dataGridViewBill.RowHeadersWidth = 51;
            dataGridViewBill.Size = new Size(759, 317);
            dataGridViewBill.TabIndex = 0;
            // 
            // tabControlFood
            // 
            tabControlFood.Controls.Add(tabPageBill);
            tabControlFood.Controls.Add(tabPageFood);
            tabControlFood.Controls.Add(tabPageAccount);
            tabControlFood.Location = new Point(16, 7);
            tabControlFood.Name = "tabControlFood";
            tabControlFood.SelectedIndex = 0;
            tabControlFood.Size = new Size(782, 439);
            tabControlFood.TabIndex = 0;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 458);
            Controls.Add(tabControlFood);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tabPageAccount.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).EndInit();
            panel18.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            tabPageFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericFoodPrice).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            v.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFood).EndInit();
            tabPageBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBill).EndInit();
            tabControlFood.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageAccount;
        private Button buttonReversePassword;
        private Panel panel17;
        private Label label9;
        private DataGridView dataGridViewAccount;
        private Panel panel18;
        private Button buttonDisplayAccount;
        private Button buttonEditAccount;
        private Button buttonDeleteAccount;
        private Button buttonAddAccount;
        private Panel panel19;
        private TextBox textBoxUserAccount;
        private Label label10;
        private Panel panel20;
        private TextBox textBoxNameAccount;
        private Label label11;
        private TabPage tabPageFood;
        private Panel panel6;
        private TextBox textBoxSearchFoodName;
        private Button buttonSearchFood;
        private Panel panel5;
        private Panel panel9;
        private NumericUpDown numericFoodPrice;
        private Label label3;
        private Panel panel8;
        private TextBox textBoxFoodName;
        private Label label2;
        private Panel panel7;
        private ComboBox comboBoxFoodCatagory;
        private Label label1;
        private Panel panel4;
        private TextBox textBoxFoodID;
        private Label labelUsername;
        private Panel v;
        private Button buttonShowFood;
        private Button buttonEditFood;
        private Button buttonDeleteFood;
        private Button buttonAddFood;
        private Panel panel3;
        private DataGridView dataGridViewFood;
        private TabPage tabPageBill;
        private Panel panel2;
        private Button buttonViewBill;
        private DateTimePicker dateTimePickerToDate;
        private DateTimePicker dateTimePickerFromDate;
        private Panel panel1;
        private DataGridView dataGridViewBill;
        private TabControl tabControlFood;
        private NumericUpDown numericUpDown1;
        private Button buttonFirstBillPage;
        private Button buttonNextBillPage;
        private Button buttonLastBillPage;
        private Button buttonPrevioursBillPage;
        private TextBox textBoxCurrentPage;
    }
}