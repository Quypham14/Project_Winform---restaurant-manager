using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckout, int status, int discount=0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckout;
            this.status = status;
            this.Discount=discount; 
        }
        public Bill(DataRow row)
        {
           this.ID = (int)row["id"];
           this.DateCheckIn = (DateTime?)row["dateCheckin"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;

            this.status = (int)row["status"];
            this.Discount = (int)row["discount"];
        }
        private int discount;
        private int status;
        private DateTime? DateCheckIn;
        public DateTime? DateCheckOut
        {
            get { return DateCheckIn; }
            set { DateCheckIn = value; }
        }

        public int Discount { get => discount; set => discount = value; }

        public int ID;

    }
}