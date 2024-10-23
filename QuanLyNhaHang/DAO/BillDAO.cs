using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
     public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        // Thành công: bill ID
        // Thất bại: -1
        public int GetUncheckBillIDByTableID(int id)
        {
            // Chỉ lấy hóa đơn chưa thanh toán của bàn có ID = id
            string query = "SELECT * FROM dbo.Bill WHERE idTable = " + id + " AND status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                Console.WriteLine("Unpaid Bill ID for table " + id + ": " + bill.ID);
                return bill.ID; // Trả về ID của hóa đơn chưa thanh toán
            }

            Console.WriteLine("No unpaid bill found for table " + id);
            return -1; // Không có hóa đơn chưa thanh toán
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }
        public int GetMaxIDBill()
        {
            try
            {
               return (int)DataProvider.Instance.ExecuteScalar("select MAX(id) from dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
    }
}
