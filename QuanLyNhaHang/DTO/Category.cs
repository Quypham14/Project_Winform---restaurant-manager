using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Category
    {
        public Category(int id, string nametable)
        {
            this.ID = id;
            this.Name = nametable;
        }
        public Category(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name =row["nametable"].ToString();

        }
        private string nametable;
        private int iD;
        public int ID
        { get { return iD; } set { iD = value; } }

        public string Name { get => nametable; set => nametable = value; }
    }
}
