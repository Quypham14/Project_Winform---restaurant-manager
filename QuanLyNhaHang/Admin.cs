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

        public Admin()
        {
            InitializeComponent();
            Load();
            // Thiết lập giá trị tối thiểu và tối đa cho numericFoodPrice
            numericFoodPrice.Minimum = 0; // Giá trị tối thiểu
            numericFoodPrice.Maximum = 10000000; // Giá trị tối đa, thay đổi theo nhu cầu
        }


        #region methods
        void Load()
        {
            dataGridViewFood.DataSource = foodList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
            LoadListFood();
            LoadCategoryIntoCombobox(comboBoxFoodCatagory);
            AddFoodBinding();
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
            textBoxFoodName.DataBindings.Add(new Binding("Text", dataGridViewFood.DataSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            textBoxFoodID.DataBindings.Add(new Binding("Text", dataGridViewFood.DataSource, "ID", true, DataSourceUpdateMode.OnPropertyChanged));
            numericFoodPrice.DataBindings.Add(new Binding("Value", dataGridViewFood.DataSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
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

        #endregion

        private void numericFoodPrice_ValueChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện nếu cần
        }
    }
}
