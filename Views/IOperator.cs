using ScaleApp.Models;
using ScaleApp.Presenters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleApp.Views
{
    public interface IOperator
    {
        string StrOperatorCode { get; set; }
        string StrOperatorName { get; set; }
        string StrDepartment { get; set; }
        bool checkIsActive { get; set; }

        void CreateOperator(Operator modelOperator);
        //DataSet LoadOperator();
    }
}
