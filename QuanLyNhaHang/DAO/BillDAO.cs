using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.DTO;

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
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id + " AND status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }
        public void Checkout(int id, int discount, float totalPrice)
        {
            // Cập nhật trạng thái hóa đơn và thêm discount cùng tổng giá
            string query = "UPDATE dbo.Bill SET dateCheckOut = GETDATE(), status = 1, discount = @discount, totalPrice = @totalPrice WHERE id = @id";

            // Truyền đúng cả 3 tham số: discount, totalPrice và id
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { discount, totalPrice, id });

            // Xóa các BillInfo liên quan sau khi thanh toán
            string deleteQuery = "DELETE FROM dbo.BillInfo WHERE idBill = @id";
            DataProvider.Instance.ExecuteNonQuery(deleteQuery, new object[] { id });
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }
        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
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
