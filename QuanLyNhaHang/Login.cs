namespace QuanLyNhaHang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            TableManager f = new TableManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
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
