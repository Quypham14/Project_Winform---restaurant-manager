using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool login(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.Account WHERE UserName = N'"
                           + userName.Replace("'", "''")
                           + "' AND PassWord = N'"
                           + passWord.Replace("'", "''") + "'";

            DataTable result =DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

    }
}