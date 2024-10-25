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
            LoadDateTimePickerBill();
            LoadListBillByDate(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
        }
        #region methods
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dateTimePickerFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePickerToDate.Value = dateTimePickerToDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
           dataGridViewBill.DataSource= BillDAO.Instance.GetBillListByDate(checkIn, checkOut);

        }
        #endregion
        #region events
        private void buttonViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePickerFromDate.Value, dateTimePickerToDate.Value);
        }
        #endregion
    }
}
