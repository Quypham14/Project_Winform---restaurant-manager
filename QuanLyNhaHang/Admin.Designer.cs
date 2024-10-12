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
            tabControlFood = new TabControl();
            tabPageBill = new TabPage();
            panel2 = new Panel();
            buttonViewBill = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePickerFromDate = new DateTimePicker();
            panel1 = new Panel();
            dataGridViewBill = new DataGridView();
            tabPageFood = new TabPage();
            panel3 = new Panel();
            tabPage2 = new TabPage();
            tabPageTable = new TabPage();
            tabPageAccount = new TabPage();
            v = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            dataGridViewFood = new DataGridView();
            buttonAddFood = new Button();
            buttonDeleteFood = new Button();
            buttonEditFood = new Button();
            buttonShowFood = new Button();
            buttonSearchFood = new Button();
            textBoxSearchFoodName = new TextBox();
            panel4 = new Panel();
            textBoxFoodID = new TextBox();
            labelUsername = new Label();
            panel7 = new Panel();
            label1 = new Label();
            comboBoxFoodCatagory = new ComboBox();
            panel8 = new Panel();
            textBoxFoodName = new TextBox();
            label2 = new Label();
            panel9 = new Panel();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            tabControlFood.SuspendLayout();
            tabPageBill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBill).BeginInit();
            tabPageFood.SuspendLayout();
            panel3.SuspendLayout();
            v.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFood).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControlFood
            // 
            tabControlFood.Controls.Add(tabPageBill);
            tabControlFood.Controls.Add(tabPageFood);
            tabControlFood.Controls.Add(tabPage2);
            tabControlFood.Controls.Add(tabPageTable);
            tabControlFood.Controls.Add(tabPageAccount);
            tabControlFood.Location = new Point(16, 7);
            tabControlFood.Name = "tabControlFood";
            tabControlFood.SelectedIndex = 0;
            tabControlFood.Size = new Size(782, 439);
            tabControlFood.TabIndex = 0;
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
            panel2.Controls.Add(dateTimePicker2);
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
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(565, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 1;
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
            panel1.Controls.Add(dataGridViewBill);
            panel1.Location = new Point(6, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 367);
            panel1.TabIndex = 0;
            // 
            // dataGridViewBill
            // 
            dataGridViewBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBill.Location = new Point(3, 3);
            dataGridViewBill.Name = "dataGridViewBill";
            dataGridViewBill.Size = new Size(759, 363);
            dataGridViewBill.TabIndex = 0;
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
            // panel3
            // 
            panel3.Controls.Add(dataGridViewFood);
            panel3.Location = new Point(6, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 338);
            panel3.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(774, 411);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "Danh mục";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPageTable
            // 
            tabPageTable.Location = new Point(4, 24);
            tabPageTable.Name = "tabPageTable";
            tabPageTable.Padding = new Padding(3);
            tabPageTable.Size = new Size(774, 411);
            tabPageTable.TabIndex = 3;
            tabPageTable.Text = "Bàn ăn";
            tabPageTable.UseVisualStyleBackColor = true;
            // 
            // tabPageAccount
            // 
            tabPageAccount.Location = new Point(4, 24);
            tabPageAccount.Name = "tabPageAccount";
            tabPageAccount.Padding = new Padding(3);
            tabPageAccount.Size = new Size(774, 411);
            tabPageAccount.TabIndex = 4;
            tabPageAccount.Text = "Tài khoản";
            tabPageAccount.UseVisualStyleBackColor = true;
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
            // panel6
            // 
            panel6.Controls.Add(textBoxSearchFoodName);
            panel6.Controls.Add(buttonSearchFood);
            panel6.Location = new Point(401, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(370, 58);
            panel6.TabIndex = 3;
            // 
            // dataGridViewFood
            // 
            dataGridViewFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFood.Location = new Point(0, 1);
            dataGridViewFood.Name = "dataGridViewFood";
            dataGridViewFood.Size = new Size(386, 334);
            dataGridViewFood.TabIndex = 0;
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
            // 
            // buttonDeleteFood
            // 
            buttonDeleteFood.Location = new Point(87, 3);
            buttonDeleteFood.Name = "buttonDeleteFood";
            buttonDeleteFood.Size = new Size(81, 52);
            buttonDeleteFood.TabIndex = 1;
            buttonDeleteFood.Text = "Xóa";
            buttonDeleteFood.UseVisualStyleBackColor = true;
            // 
            // buttonEditFood
            // 
            buttonEditFood.Location = new Point(174, 3);
            buttonEditFood.Name = "buttonEditFood";
            buttonEditFood.Size = new Size(81, 52);
            buttonEditFood.TabIndex = 2;
            buttonEditFood.Text = "Sửa";
            buttonEditFood.UseVisualStyleBackColor = true;
            // 
            // buttonShowFood
            // 
            buttonShowFood.Location = new Point(261, 6);
            buttonShowFood.Name = "buttonShowFood";
            buttonShowFood.Size = new Size(81, 52);
            buttonShowFood.TabIndex = 3;
            buttonShowFood.Text = "Xem";
            buttonShowFood.UseVisualStyleBackColor = true;
            // 
            // buttonSearchFood
            // 
            buttonSearchFood.Location = new Point(286, 3);
            buttonSearchFood.Name = "buttonSearchFood";
            buttonSearchFood.Size = new Size(81, 52);
            buttonSearchFood.TabIndex = 4;
            buttonSearchFood.Text = "Tìm kiếm";
            buttonSearchFood.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchFoodName
            // 
            textBoxSearchFoodName.Location = new Point(16, 22);
            textBoxSearchFoodName.Name = "textBoxSearchFoodName";
            textBoxSearchFoodName.Size = new Size(264, 23);
            textBoxSearchFoodName.TabIndex = 5;
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
            textBoxFoodID.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFoodID.Location = new Point(147, 16);
            textBoxFoodID.Margin = new Padding(4);
            textBoxFoodID.Name = "textBoxFoodID";
            textBoxFoodID.ReadOnly = true;
            textBoxFoodID.Size = new Size(193, 26);
            textBoxFoodID.TabIndex = 1;
            textBoxFoodID.Text = " ";
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
            // comboBoxFoodCatagory
            // 
            comboBoxFoodCatagory.FormattingEnabled = true;
            comboBoxFoodCatagory.Location = new Point(147, 21);
            comboBoxFoodCatagory.Name = "comboBoxFoodCatagory";
            comboBoxFoodCatagory.Size = new Size(193, 23);
            comboBoxFoodCatagory.TabIndex = 1;
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
            textBoxFoodName.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFoodName.Location = new Point(147, 16);
            textBoxFoodName.Margin = new Padding(4);
            textBoxFoodName.Name = "textBoxFoodName";
            textBoxFoodName.ReadOnly = true;
            textBoxFoodName.Size = new Size(193, 26);
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
            // panel9
            // 
            panel9.Controls.Add(numericUpDown1);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(1, 193);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(366, 56);
            panel9.TabIndex = 4;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(147, 19);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(193, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
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
            tabControlFood.ResumeLayout(false);
            tabPageBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBill).EndInit();
            tabPageFood.ResumeLayout(false);
            panel3.ResumeLayout(false);
            v.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFood).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlFood;
        private TabPage tabPageBill;
        private TabPage tabPageFood;
        private TabPage tabPage2;
        private TabPage tabPageTable;
        private TabPage tabPageAccount;
        private Panel panel2;
        private DateTimePicker dateTimePickerFromDate;
        private Panel panel1;
        private DataGridView dataGridViewBill;
        private Button buttonViewBill;
        private DateTimePicker dateTimePicker2;
        private Panel panel3;
        private Panel v;
        private Panel panel6;
        private Panel panel5;
        private Button buttonAddFood;
        private DataGridView dataGridViewFood;
        private Button buttonEditFood;
        private Button buttonDeleteFood;
        private Button buttonShowFood;
        private TextBox textBoxSearchFoodName;
        private Button buttonSearchFood;
        private Panel panel4;
        private TextBox textBoxFoodID;
        private Label labelUsername;
        private Panel panel7;
        private Label label1;
        private Panel panel9;
        private Label label3;
        private Panel panel8;
        private TextBox textBoxFoodName;
        private Label label2;
        private ComboBox comboBoxFoodCatagory;
        private NumericUpDown numericUpDown1;
    }
}