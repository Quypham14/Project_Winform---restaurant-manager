using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QuanLyNhaHang.DAO;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace QuanLyNhaHang
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadAccountList();
        }
        void LoadAccountList()
        {
           string query = "EXEC dbo.USP_GetAccountByUserName @userName";
           dataGridViewAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"Pham Sy Quy"});
        }
    }
}
