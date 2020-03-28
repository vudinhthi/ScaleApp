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
using System.Deployment.Application;

namespace ScaleApp
{
    public partial class frmAbout : DevExpress.XtraEditors.XtraForm
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            textEdit1.Text = AssemblyVersion.Major.ToString() + "."
                        + AssemblyVersion.Minor.ToString() + "."
                        + AssemblyVersion.Build.ToString() + "."
                        + AssemblyVersion.Revision.ToString();
        }

        public Version AssemblyVersion
        {
            get
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}