using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubUpdate;

namespace ShipClassConfiguratorUiV2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            var checker = new UpdateChecker("skiittz", "Ship-Class-System-Config-Editor");
            UpdateType update = checker.CheckUpdate().Result;
            if (update != UpdateType.None)
            {
                var result = new UpdateNotifyDialog(checker).ShowDialog();
                if (result == DialogResult.Yes)
                {
                    checker.DownloadAsset("ShipClassConfigurator.zip"); // opens it in the user's browser
                }
            }
        }
    }
}
