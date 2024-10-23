using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckout, int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckout;
            this.status = status;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckin"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if(dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;

            this.status = (int)row["status"];
        }
        private int status;
        private DateTime? DateCheckIn;
        public DateTime? DateCheckOut
        {
            get { return DateCheckIn; }
            set { DateCheckIn = value; }
        }
        public int ID;

    }
}