using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (DataProvider.instance == null) instance = new DataProvider(); return DataProvider.instance; }
            set { DataProvider.instance = value; }
        }
        private DataProvider() { }
        private string connectionSTR = @"Data Source=.\SQLEXPRESS01;Initial Catalog=QuanLyDuLieu;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string s in listPara) {
                        if (s.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(s, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(data);
                conn.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int numdata = 0;
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string s in listPara)
                    {
                        if (s.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(s, parameter[i]);
                            i++;
                        }
                    }
                }
                numdata = sqlCommand.ExecuteNonQuery();
                conn.Close();
            }
            return numdata;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = null;
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string s in listPara)
                    {
                        if (s.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(s, parameter[i]);
                            i++;
                        }
                    }
                }
                data = sqlCommand.ExecuteScalar();
                conn.Close();
            }
            return data;
        }
    }
}
