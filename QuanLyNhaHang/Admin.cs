using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;

namespace QuanLyNhaHang
{
    public partial class Admin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource accountList = new BindingSource();
        public Account loginAccount;
        public Admin()
        {
            InitializeComponent();
            Load();
            // Thiết lập giá trị tối thiểu và tối đa cho numericFoodPrice
            numericFoodPrice.Minimum = 0; // Giá trị tối thiểu
            numericFoodPrice.Maximum = 10000000; // Giá trị tối đa, thay đổi theo nhu cầu
        }


        #region methods
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
        void Load()
        {
            dataGridViewFood.DataSource = foodList;
            dataGridViewAccount.DataSource = accountList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
            LoadListFood();
            LoadAccount();
            LoadCategoryIntoCombobox(comboBoxFoodCatagory);
            AddFoodBinding();
            AddAccountBinding();
        }
        void AddAccountBinding()
        {
            textBoxNameAccount.DataBindings.Add(new Binding("Text", dataGridViewAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            textBoxUserAccount.DataBindings.Add(new Binding("Text", dataGridViewAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Value", dataGridViewAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dateTimePickerFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePickerToDate.Value = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dataGridViewBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        void AddFoodBinding()
        {
            textBoxFoodName.DataBindings.Clear();
            textBoxFoodID.DataBindings.Clear();
            numericFoodPrice.DataBindings.Clear();

            textBoxFoodName.DataBindings.Add("Text", foodList, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxFoodID.DataBindings.Add("Text", foodList, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            numericFoodPrice.DataBindings.Add("Value", foodList, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
            cb.ValueMember = "ID"; // Nếu cần sử dụng ID trong việc lấy giá trị
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        private void buttonShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        #endregion

        #region events
        private void buttonViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
        }

        private void textBoxFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewFood.SelectedCells.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewFood.SelectedCells[0].OwningRow;

                    // Kiểm tra nếu CategoryID hợp lệ
                    if (selectedRow.Cells["CategoryID"].Value != null)
                    {
                        int id = (int)selectedRow.Cells["CategoryID"].Value;
                        Category category = CategoryDAO.Instance.GetCategoryByID(id);

                        if (category != null)
                        {
                            // Cập nhật ComboBox với danh mục
                            comboBoxFoodCatagory.SelectedItem = category;

                            // Tìm và chọn đúng index trong ComboBox
                            int index = comboBoxFoodCatagory.FindStringExact(category.Name);
                            if (index >= 0)
                            {
                                comboBoxFoodCatagory.SelectedIndex = index;
                            }
                        }
                    }

                    // Cập nhật giá thực phẩm
                    if (selectedRow.Cells["Price"].Value != null)
                    {
                        float price = (float)selectedRow.Cells["Price"].Value;
                        numericFoodPrice.Value = (decimal)price; // Cập nhật giá vào NumericUpDown
                    }
                }
            }
            catch { }
        }
        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            string name = textBoxFoodName.Text;
            int categoryID = (comboBoxFoodCatagory.SelectedItem as Category).ID;
            float price = (float)numericFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }
        private void buttonEditFood_Click(object sender, EventArgs e)
        {
            string name = textBoxFoodName.Text;
            int categoryID = (comboBoxFoodCatagory.SelectedItem as Category).ID;
            float price = (float)numericFoodPrice.Value;
            int id = Convert.ToInt32(textBoxFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void buttonDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }

        private void buttonSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(textBoxSearchFoodName.Text);
        }

        private void buttonDisplayAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            string userName = textBoxNameAccount.Text;
            string displayName = textBoxUserAccount.Text;
            int type = (int)numericUpDown1.Value;

            AddAccount(userName, displayName, type);
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = textBoxNameAccount.Text;

            DeleteAccount(userName);
        }

        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            string userName = textBoxNameAccount.Text;
            string displayName = textBoxUserAccount.Text;
            int type = (int)numericUpDown1.Value;

            EditAccount(userName, displayName, type);
        }

        private void buttonReversePassword_Click(object sender, EventArgs e)
        {
            string userName = textBoxNameAccount.Text;

            ResetPass(userName);

        }

        private void buttonFirstBillPage_Click(object sender, EventArgs e)
        {
            textBoxCurrentPage.Text = "1";
        }

        private void buttonLastBillPage_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
            int lastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
            {
                lastPage++;
            }
            textBoxCurrentPage.Text = lastPage.ToString();
        }

        private void textBoxCurrentPage_TextChanged(object sender, EventArgs e)
        {
            dataGridViewBill.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dateTimePickerFromDate.Value, dateTimePickerToDate.Value, Convert.ToInt32(textBoxCurrentPage.Text));
        }

        private void buttonPrevioursBillPage_Click(object sender, EventArgs e)
        {
            int page=Convert.ToInt32(textBoxCurrentPage.Text);
            if (page > 1)
            {
                page--;
            }
            textBoxCurrentPage.Text=page.ToString();
        }

        private void buttonNextBillPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(textBoxCurrentPage.Text);
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
            if(page<sumRecord)
            {
                page++;
            }
            textBoxCurrentPage.Text=page.ToString() ;
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
    }
    #endregion
}
