using Ship_Class_System_Config_Editor.Definitions;
using System.Xml.Serialization;
using System.Xml;
using System.Text;
using System.IO;

namespace Ship_Class_System_Config_Editor
{
    internal static class Program
    {
        //private static ModConfig currentFile;
        //static Encoding encoding => Encoding.GetEncoding("UTF-16");
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

            //var defaultFileName = "C:\\Users\\wspei\\source\\repos\\Ship Class System Config Editor\\DefaultConfigs.xml";
            //var filename = "C:\\Users\\wspei\\source\\repos\\Ship Class System Config Editor\\DBG_CfgFile.xml";
            //LoadConfig(defaultFileName);
            //SaveConfig(filename);
        }

        //public static void LoadConfig(string filePath)
        //{
        //    var serializer = new XmlSerializer(typeof(ModConfig));
        //    using (var reader = new StreamReader(filePath))
        //        currentFile = (ModConfig)serializer.Deserialize(reader);
        //}

        //public static void SaveConfig(string filename)
        //{
        //    var fs = new FileStream(filename, FileMode.Create);

        //    var w = new XmlSerializer(typeof(ModConfig));
        //    //<< -------------- "OptionsSettings" put here your class

        //    var sw = new StreamWriter(fs, encoding);
        //    w.Serialize(sw, currentFile);
        //    sw.Close();
        //    fs.Close();
        //}
    }
}