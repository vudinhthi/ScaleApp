using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScaleApp.Views;
using ScaleApp.Models;
using System.Data.SqlClient;
using System.Data;
using ScaleApp.Common;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace ScaleApp.Presenters
{
    public class OperatorPresenter
    {
        IOperator OperatorView;

        public OperatorPresenter(IOperator @operator)
        {
            OperatorView = @operator;
        }    

        public void CreateOperator()
        {
            int i;
            try
            {
                String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("sp_createOperator", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@operatorCode", OperatorView.StrOperatorCode);
                cmd.Parameters.AddWithValue("@operatorName", OperatorView.StrOperatorName);
                cmd.Parameters.AddWithValue("@department", OperatorView.StrDepartment);
                cmd.Parameters.AddWithValue("@isActive", OperatorView.checkIsActive);

                conn.Open();

                i = cmd.ExecuteNonQuery();

                DataOperation.disconnect();

                if (i != 0)
                {
                    XtraMessageBox.Show("Save operator successful !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException sqlEx)
            {
                int exNumber = sqlEx.Number;
                switch (sqlEx.Number)
                {
                    case 2601:
                        XtraMessageBox.Show("Data was existing !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2627:
                        XtraMessageBox.Show("Mã Operator đã tồn tại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        XtraMessageBox.Show("Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet LoadOperator()
        {
            DataSet ds = new DataSet();
            try 
            {
                String connStr = ScaleApp.Common.DataOperation.GetConnectionString(1);
                SqlConnection conn = new SqlConnection(connStr);

                SqlDataAdapter SqlDaOperator = new SqlDataAdapter("sp_getOperators", conn);
                SqlDaOperator.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlDaOperator.Fill(ds, "Operators");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ds;
        }
    }
}
