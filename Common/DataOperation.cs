using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace ScaleApp.Common
{
    class DataOperation
    {
        static SqlConnection conn;
        static SqlCommand cmd = new SqlCommand();

        // open connection
        public static void connect(int db)
        {

            string conStr = ConfigurationManager.ConnectionStrings[db].ToString();

            conn = new SqlConnection(conStr);

            if (conn.State == ConnectionState.Closed)

                conn.Open();

        }

        public static void ConnectToDB()
        {
            conn = new SqlConnection();   //Khởi tạo đối tượng
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ColorMix;Persist Security Info=True;User ID=sa;Password=12345678;Connect Timeout=30;User Instance=True";
            conn.Open();                  //Mở kết nối
            //Kiểm tra kết nối
            if (conn.State == ConnectionState.Open)
                MessageBox.Show("Kết nối thành công");
            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }

        // close connection
        public static void disconnect()
        {

            if ((conn != null) && (conn.State == ConnectionState.Open))
            {
                conn.Close();    //Đóng kết nối
                conn.Dispose();  //Giải phóng tài nguyên
                conn = null;
            }
        }

        // return DataTable .
        public static DataTable getDataTable(int db, string sql)
        {
            connect(db);

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            disconnect();

            return dt;

        }

        // thực thi câu lệnh truy vấn insert,delete,update
        public static void ExecuteNonQuery(int db, string sql)
        {

            connect(db);

            cmd = new SqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            disconnect();
        }

        // return DataReader
        public static SqlDataReader getDataReader(int db, string sql)
        {
            connect(db);

            cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            disconnect();

            return dr;

        }

        public static DataSet GetDataSet(int db, string procName, string[] paramName, string[] paramValue)
        {

            connect(db);

            cmd = new SqlCommand();
            cmd.Connection = conn;
            using (conn)
            {
                try
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        //check param
                        if (paramName.Length != paramValue.Length)
                        {
                            return new DataSet();
                        }

                        // This will be your input parameter and its value
                        for (int i = 0; i <= paramName.Length - 1; i++)
                        {
                            cmd.Parameters.AddWithValue("@" + mFunction.ToString(paramName[i]), mFunction.ToString(paramValue[i]));
                        }

                        //// You can retrieve values of `output` variables
                        //var returnParam = new SqlParameter
                        //{
                        //    ParameterName = "@Error",
                        //    Direction = ParameterDirection.Output,
                        //    Size = 1000
                        //};
                        //cmd.Parameters.Add(returnParam);

                        // Name of stored procedure
                        cmd.CommandText = procName;
                        da.SelectCommand = cmd;
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        disconnect();

                        return ds;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                }
            }

            disconnect();
            return new DataSet();
        }
    }
}
