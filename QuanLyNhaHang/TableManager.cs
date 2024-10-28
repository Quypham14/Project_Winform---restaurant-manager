using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyNhaHang.AccountProfile;

namespace QuanLyNhaHang
{
    public partial class TableManager : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public TableManager(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadComboboxTable(comboBoxSwitchTable);
        }
        #region Method
        public void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTaiKhoanToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }
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
            flowLayoutPanelTable.Controls.Clear();
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
            List<QuanLyNhaHang.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (QuanLyNhaHang.DTO.Menu item in listBillInfo)
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
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        #endregion
        #region Events
        private void Btn_Click(object? sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            listViewBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
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
            AccountProfile f = new AccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }
        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }
        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            if (listViewBill.Tag is not Table table)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món.");
                return;
            }

            if (comboBoxFood.SelectedItem is not Food food)
            {
                MessageBox.Show("Vui lòng chọn món ăn.");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = food.ID;
            int count = (int)numericUpDownFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);
            LoadTable();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            Table table = listViewBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)numericUpDownDiscount.Value;
            double totalPrice = Convert.ToDouble(textBoxTotalPrice.Text.Split(' ')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    // Thanh toán hóa đơn
                    BillDAO.Instance.Checkout(idBill, discount, (float)finalTotalPrice);

                    // Xóa các mục trong listViewBill
                    listViewBill.Items.Clear();

                    // Hiển thị hóa đơn mới cho bàn hiện tại
                    ShowBill(table.ID);

                    // Đặt tổng tiền về 0
                    textBoxTotalPrice.Text = "0";

                    // Làm mới danh sách bàn
                    LoadTable();
                }
            }
        }
        private void buttonSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (listViewBill.Tag as Table).ID;

            int id2 = (comboBoxSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua {1}", (listViewBill.Tag as Table).Name, (comboBoxSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);

                LoadTable();
            }
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.loginAccount =LoginAccount;
            f.InsertFood += f_InsertFood;
            f.DeleteFood += f_DeleteFood;
            f.UpdateFood += f_UpdateFood;
            f.ShowDialog();
        }
        void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((comboBoxCategory.SelectedItem as Category).ID);
            if (listViewBill.Tag != null)
                ShowBill((listViewBill.Tag as Table).ID);
        }

        void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((comboBoxCategory.SelectedItem as Category).ID);
            if (listViewBill.Tag != null)
                ShowBill((listViewBill.Tag as Table).ID);
            LoadTable();
        }

        void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((comboBoxCategory.SelectedItem as Category).ID);
            if (listViewBill.Tag != null)
                ShowBill((listViewBill.Tag as Table).ID);
        }
        #endregion
    }
}
