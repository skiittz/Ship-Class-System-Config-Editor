using Ship_Class_System_Config_Editor.Definitions;
using System.Xml.Serialization;
using System.Xml;
using System.Text;
using System.IO;

namespace Ship_Class_System_Config_Editor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

        }
    }
}