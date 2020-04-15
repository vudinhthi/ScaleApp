using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using ScaleApp.Models;
namespace ScaleApp.Common
{
   public class DataOperation
    {
        static SqlConnection conn;
        static SqlCommand cmd = new SqlCommand();
        static DataSet ds = new DataSet();
        // open connection
        public static void connect(int db)
        {
            string conStr = ConfigurationManager.ConnectionStrings[db].ToString();
            conn = new SqlConnection(conStr);

            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public static int ConnectToDB()
        {
            string conStr = "Data Source=server210;Initial Catalog=ColorMix;Persist Security Info=false;User ID=sa;Password=Fdw24$110";
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                try
                {
                    connection.Open();
                    return 1;
                }
                catch (SqlException)
                {
                    return 0;
                }
            }
        }

        public static string GetConnectionString(int db)
        {
            //var connection = System.Configuration.ConfigurationManager.ConnectionStrings["ScaleApp.Properties.Settings.ColorMixConnectionString"].ConnectionString;
            //connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ColorMix;Persist Security Info=True;User ID=sa;Password=12345678;Connect Timeout=30";
            var connection = "";
            //Get data from database ColorMix
            if (db == 1)
            {
                connection = "Data Source=server210;Initial Catalog=ColorMix;Persist Security Info=false;User ID=colourmixing;Password=M1x1ng@C0lou4";
            }
            //Get data from database Winline
            else if (db == 2)
            {
                connection = "Data Source=server210;Initial Catalog=ColorMix;Persist Security Info=false;User ID=sa;Password=Fdw24$110";
            }
            return connection;
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
        public static void InsertComponent(int db, string spName,int id, string name, string ItemID)
        {
            connect(db);
            using (SqlCommand cmd = new SqlCommand(spName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@componentID", SqlDbType.Int).Value =id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@ItemID", SqlDbType.NVarChar).Value = ItemID;
                cmd.ExecuteNonQuery();
                disconnect();
            }

        }
        public static void InsertScrewsize(int db, string spName, int id, int value, int ComponentID, string ItemID)
        {
            
            connect(db);
            using (SqlCommand cmd = new SqlCommand(spName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@screwsizeID", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@value", SqlDbType.Int).Value = value;
                cmd.Parameters.Add("@componentID", SqlDbType.Int).Value = ComponentID;
                cmd.Parameters.Add("@ItemID", SqlDbType.NVarChar).Value = ItemID;
                cmd.ExecuteNonQuery();
                disconnect();
            }

        }
        public static void InsertReason(int db, string spName, int id, string value)
        {

            connect(db);
            using (SqlCommand cmd = new SqlCommand(spName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ReasonID", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@Cause", SqlDbType.NVarChar).Value = value;
                cmd.ExecuteNonQuery();
                disconnect();
            }

        }
        public static void InsertorUpdate(int db, string spName,CookiesClass obj )
        {
            connect(db);
            using (SqlCommand cmd = new SqlCommand(spName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MachineNo", SqlDbType.Int).Value = obj.MachineNo;
                cmd.Parameters.Add("@Shift", SqlDbType.NVarChar).Value = obj.Shift;
                cmd.Parameters.Add("@Item", SqlDbType.NVarChar).Value = obj.Item;
                cmd.Parameters.Add("@Component", SqlDbType.NVarChar).Value = obj.Component;
                cmd.Parameters.Add("@Screwsize", SqlDbType.NVarChar).Value = obj.Screwsize;
                cmd.Parameters.Add("@PurgingMaterial", SqlDbType.NVarChar).Value = obj.PurgingMaterial;
                cmd.Parameters.Add("@PurgingInput", SqlDbType.NVarChar).Value = obj.PurgingInput;
                cmd.Parameters.Add("@PurgingCookies", SqlDbType.NVarChar).Value = obj.PurgingCookies;
                cmd.Parameters.Add("@TPUCookies", SqlDbType.NVarChar).Value = obj.TPUCookies;
                cmd.Parameters.Add("@MixedCookies", SqlDbType.NVarChar).Value = obj.MixedCookies;
                cmd.Parameters.Add("@Reason", SqlDbType.NVarChar).Value = obj.Reason;
                cmd.Parameters.Add("@ItemID", SqlDbType.NVarChar).Value = obj.ItemID;
                var a= cmd.ExecuteNonQuery();
                disconnect();
            }

        }
        public static DataSet SelectComponent(int db,string spName,string itemID)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                connect(db);
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemID", itemID);
                da.SelectCommand = cmd;
                if (ds.Tables["tbComponent"] != null)
                {
                    ds.Tables["tbComponent"].Clear();
                }
                da.Fill(ds, "tbComponent");
                cmd.Dispose();
                da.Dispose();
                disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
           
        }
        public static DataSet SelectCookies(int db, string spName, string itemID)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                connect(db);
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemID", itemID);
                da.SelectCommand = cmd;
                if (ds.Tables["tbCookies"] != null)
                {
                    ds.Tables["tbCookies"].Clear();
                }
                da.Fill(ds, "tbCookies");
                cmd.Dispose();
                da.Dispose();
                disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public  static  int UpdateTable(int db,ref DataTable dt,string query)
        {
            try
            {
                int result = 0;
                string conStr = ConfigurationManager.ConnectionStrings[db].ToString();
                conn = new SqlConnection(conStr);
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder cmdbd = new SqlCommandBuilder(da);
                result = da.Update(dt);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="spName"></param>
        /// <param name="ItemID"></param>
        /// <param name="condition">query theo so luong </param>
        /// <returns></returns>
        public static DataSet SelectSrewsize(int db,string spName,string ItemID,int ComponentID,int condition)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                connect(db);
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemID", ItemID);
                cmd.Parameters.AddWithValue("@ComponentID", ComponentID);
                cmd.Parameters.AddWithValue("@condition", condition);
                da.SelectCommand = cmd;
                if (ds.Tables["tbScrewsize"] != null)
                {
                    ds.Tables["tbScrewsize"].Clear();
                }
                da.Fill(ds, "tbScrewsize");
                cmd.Dispose();
                da.Dispose();
                disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }   
        public static DataSet SelectReason(int db,string spName)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                connect(db);
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                if (ds.Tables["tbReason"] != null)
                {
                    ds.Tables["tbReason"].Clear();
                }
                da.Fill(ds, "tbReason");
                cmd.Dispose();
                da.Dispose();
                disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// select last index Screwsize
        /// </summary>
        /// <param name="db"></param>
        /// <param name="spName"></param>
        /// <param name="itemID"></param>
        /// <returns></returns>
        public static int SelectLastIndex(int db, string spName)
        {
            try
            {
                int result = 0;
                connect(db);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(dt);
                result = Convert.ToInt32(dt.Rows[0][0]);
                cmd.Dispose();
                disconnect();
                return result;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return -1;
            }

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
