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
            AddUpdateAppSettings("COMPort", cbeCOMPort.EditValue.ToString());
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
                                    if (cNode.Attributes[0].Value == key)
                                    {
                                        cNode.ChildNodes[0].InnerXml = value;
                                    }
                                }
                            }                            
                        }
                    }
                }
                xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

                ConfigurationManager.RefreshSection("appSettings");

                XtraMessageBox.Show("Lưu " + key + " thành công !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        static void UpdateAppConfig(string key, string value)
        {
            System.Xml.XmlDocument xml = new System.Xml.XmlDocument();
            xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            System.Xml.XmlNode node;
            node = xml.SelectSingleNode("configuration/applicationSettings/ScaleApp.Properties.Settings/setting[@name='key']");
            node.ChildNodes[0].InnerText = value;
            xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        static void UpdateConfigSetting(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            cbeCOMPort.EditValue = ScaleApp.Properties.Settings.Default.COMPort;
            spinEdit1.Value = ScaleApp.Properties.Settings.Default.TimeScale;
        }
    }
}