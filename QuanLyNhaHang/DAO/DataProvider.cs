using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLyNhaHang.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get {if (instance == null) instance = new DataProvider();  return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() {}
        private string connectionSTR = "Data Source =.\\sqlexpress; Initial Catalog = QUANLYNHAHANG; Integrated Security = True; Trust Server Certificate = True";
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null) {
                    string[] listPara= query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara) { 
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        // Lấy tất cả các tham số từ truy vấn
                        string[] listParams = query.Split(new[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                                    .Where(p => p.StartsWith("@")).ToArray();

                        // Kiểm tra xem số lượng tham số có khớp không
                        if (listParams.Length != parameters.Length)
                        {
                            throw new ArgumentException("Số lượng tham số không khớp với truy vấn.");
                        }

                        for (int i = 0; i < listParams.Length; i++)
                        {
                            // Thêm tham số vào SqlCommand
                            command.Parameters.AddWithValue(listParams[i], parameters[i]);
                        }
                    }

                    // Thực thi truy vấn
                    data = command.ExecuteNonQuery(); // Số dòng bị ảnh hưởng
                }
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
