using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchedulerStorageRangeControl {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            //DevExpress.UserSkins.BonusSkins.Register();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}