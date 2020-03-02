using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using ScaleApp.Common;

namespace ScaleApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mixingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            frmMixing mixing = new frmMixing();
            mixing.TopLevel = false;
            mixing.Parent = this;
            mixing.Show();
        }

        private void recycledStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            frmCrushing crushing = new frmCrushing();
            crushing.TopLevel = false;
            crushing.Parent = this;
            crushing.Show();
        }

        private void mixedOutStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            frmMixedOut mixing = new frmMixedOut();
            mixing.TopLevel = false;
            mixing.Parent = this;
            mixing.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ScaleApp.Common.DataOperation.ConnectToDB();
        }
    }
}
