using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        // Thuộc tính Singleton
        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return TableDAO.instance;
            }
            private set
            {
                TableDAO.instance = value;
            }
        }
        public static int TableWidth = 90;
        public static int TableHeight = 90;
        // Constructor private để đảm bảo chỉ có một instance
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        }
        private TableDAO() { }

        // Phương thức LoadTableList không phải là static
        public List<Table> LoadTableList()
        {
            List<Table> tablelist = new List<Table>();

            // Gọi phương thức ExecuteQuery từ DataProvider.Instance
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            // Duyệt qua từng dòng dữ liệu và thêm vào danh sách Table
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }

            return tablelist;
        }
    }
}
