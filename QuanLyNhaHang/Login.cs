﻿using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;

namespace QuanLyNhaHang
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string passWord = textBoxPassWord.Text;
            if (login(userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                TableManager f = new TableManager(loginAccount); // Chuyển tài khoản đã đăng nhập
                f.ChangeAccount(loginAccount.Type); // Gọi hàm để cập nhật giao diện
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
        bool login(string userName, string passWord)
        {
            return AccountDAO.Instance.login(userName, passWord);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void textBoxPassWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
