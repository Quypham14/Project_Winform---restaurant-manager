using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }
        #region Method
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            comboBoxCategory.DataSource = listCategory;
            comboBoxCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            comboBoxFood.DataSource = listFood;
            comboBoxFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flowLayoutPanelTable.Controls.Add(btn);

            }
        }
        void ShowBill(int id)
        {
            listViewBill.Items.Clear(); // Xóa danh sách hiện có trước khi thêm mới
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString()); // Tạo ListViewItem
                listViewItem.SubItems.Add(item.Count.ToString()); // Thêm SubItem
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                listViewBill.Items.Add(listViewItem); // Thêm vào ListView (thay vì ListViewItem.Items)
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            textBoxTotalPrice.Text = totalPrice.ToString("c");
        }
        #endregion
        #region Events
        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || btn.Tag == null)
            {
                MessageBox.Show("Không thể lấy thông tin bàn.");
                return;
            }

            Table table = btn.Tag as Table;
            listViewBill.Tag = table; // Gán thông tin bàn vào Tag của listViewBill
            ShowBill(table.ID); // Hiển thị hóa đơn của bàn này
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void boxCategory_Click(object sender, EventArgs e) 
            {
                int id = 0;
                ComboBox cb = sender as ComboBox;
                if (cb.SelectedItem == null)
                    return;
                Category selected = cb.SelectedItem as Category;
                id = selected.ID;
                LoadFoodListByCategoryID(id);
            }

        private void thôngTinCaNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile f = new AccountProfile();
            f.ShowDialog();
        }

        private void admInToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.ShowDialog();
        }
        #endregion

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            Table table =listViewBill.Tag as Table;
            int idBill=BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (comboBoxFood.SelectedItem as Food).ID;
            int count=(int)numericUpDownFoodCount.Value;
            if(idBill== -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);
        }
    }
}
