using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaleApp
{
    static class Program
    {
        //public static SerialPort _serialPort;         //<-- declares a SerialPort Variable to be used throughout the form
        //public const int BaudRate = 9600;      //<-- BaudRate Constant. 9600 seems to be the scale-units default value

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());            
        }
    }
}
