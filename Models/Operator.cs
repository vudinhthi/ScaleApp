using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using ScaleApp.Common;

namespace ScaleApp.Models
{
    public class Operator
    {
        public string OperatorCode { get; set; }
        public string OperatorName { get; set; }
        public string Department { get; set; }
        public bool IsActive { get; set; }        
    }
}
