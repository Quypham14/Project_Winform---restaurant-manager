﻿using Microsoft.Identity.Client;
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
            string query = "USP_Login @userName , @passWord";

            DataTable result =DataProvider.Instance.ExecuteQuery(query, new object[] {userName , passWord});
            return result.Rows.Count > 0;
        }

    }
}