using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ScaleApp.Views;
using ScaleApp.Presenters;
using ScaleApp.Models;
using DevExpress.XtraEditors.DXErrorProvider;

namespace ScaleApp
{
    public partial class frmOperator : DevExpress.XtraEditors.XtraForm, IOperator
    {
        public frmOperator()
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            InitializeComponent();
        }

        public string StrOperatorCode 
        {
            get { return this.TedOperatorCode.EditValue.ToString(); }
            set { TedOperatorCode.EditValue = value; }
        }
        public string StrOperatorName 
        {
            get { return this.TedOperatorName.EditValue.ToString(); }
            set { TedOperatorName.EditValue=value; }
        }
        public string StrDepartment 
        {
            get { return this.CbeDepartment.SelectedItem.ToString(); }
            set { CbeDepartment.SelectedItem = value; }
        }
        public bool checkIsActive 
        {
            get { return this.CkeActive.Checked; }
            set { CkeActive.Checked=value; }
        }

        public void CreateOperator(Operator modelOperator)
        {
            modelOperator.OperatorCode = TedOperatorCode.EditValue.ToString();
            modelOperator.OperatorName = TedOperatorName.EditValue.ToString();
            modelOperator.Department = CbeDepartment.SelectedItem.ToString();
            modelOperator.IsActive = CkeActive.Checked;
        }

        //public DataSet LoadOperator()
        //{
            
        //}

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void SpbSave_Click(object sender, EventArgs e)
        {
            ValidateForm();
            OperatorPresenter operatorPresenter = new OperatorPresenter(this);
            operatorPresenter.CreateOperator();
        }

        private void ValidateForm()
        {
            //Validate Machine
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "Nhập dữ liệu";
            notEmptyValidationRule.ErrorType = ErrorType.Critical;

            dxValidationProvider1.SetValidationRule(TedOperatorCode, notEmptyValidationRule);
            dxValidationProvider1.SetIconAlignment(TedOperatorCode, ErrorIconAlignment.MiddleRight);

            dxValidationProvider1.SetValidationRule(TedOperatorName, notEmptyValidationRule);
            dxValidationProvider1.SetIconAlignment(TedOperatorName, ErrorIconAlignment.MiddleRight);

            dxValidationProvider1.SetValidationRule(CbeDepartment, notEmptyValidationRule);
            dxValidationProvider1.SetIconAlignment(CbeDepartment, ErrorIconAlignment.MiddleRight);

            dxValidationProvider1.Validate();
        }
    }
}