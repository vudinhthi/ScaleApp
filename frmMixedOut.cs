using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaleApp
{
    public partial class frmMixedOut : Form
    {
        public frmMixedOut()
        {
            InitializeComponent();
        }        

        private void frmMixedOut_Load(object sender, EventArgs e)
        {
            txtWeight.Text = "0";
            rdbRunner.Checked = true;
            Start_Timer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString();
        }

        private void Start_Timer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }
    }
}
