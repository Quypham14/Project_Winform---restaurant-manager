using System;
using System.Data;

namespace QuanLyNhaHang.DTO
{
    public class Food
    {
        public Food(int id, string name, int categoryID, float price)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["idcategory"];
            // Kiểm tra và chuyển đổi giá trị Price sang float
            this.Price = row["price"] != DBNull.Value ? Convert.ToSingle(row["price"]) : 0.0f;
        }

        private float price;
        private int categoryID;
        private string name;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public float Price { get => price; set => price = value; }
    }
}
