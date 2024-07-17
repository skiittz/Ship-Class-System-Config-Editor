using System;
using System.Diagnostics;
using System.Windows.Forms;
using Mayerch1.GithubUpdateCheck;

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

            var update = new GithubUpdateCheck("skiittz", "Ship-Class-System-Config-Editor");
            if (update.IsUpdateAvailable(Application.ProductVersion, VersionChange.Minor))
            {
                var result = MessageBox.Show($"Version {update.Version()} is available!  Visit release page?", $"Current Version:{Application.ProductVersion}", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Process.Start("https://github.com/skiittz/Ship-Class-System-Config-Editor/releases");
                }
            }

            Application.Run(new MainForm());

            
        }
    }
}
