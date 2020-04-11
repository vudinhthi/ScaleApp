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
using System.Configuration;
using System.Xml;

namespace ScaleApp
{
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddUpdateAppSettings("TimeScale", spinEdit1.Value.ToString());
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try 
            { 
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

                foreach (XmlElement xElement in xmlDoc.DocumentElement)
                {
                    if (xElement.Name == "applicationSettings")
                    {
                        foreach (XmlNode xnode in xElement.ChildNodes)
                        {
                            if (xnode.Name == "ScaleApp.Properties.Settings")
                            {
                                foreach (XmlNode cNode in xnode.ChildNodes)
                                {
                                    if (cNode.ChildNodes[0].Attributes[0].Value == key)
                                    {
                                        cNode.Attributes[1].Value = value;
                                    }
                                }
                            }                            
                        }
                    }
                }
                xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            }
            catch (Exception ex) 
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            spinEdit1.Value = ScaleApp.Properties.Settings.Default.TimeScale;
        }
    }
}