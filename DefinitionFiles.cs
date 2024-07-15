using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace Ship_Class_System_Config_Editor
{
    public class DefinitionFiles
    {
        [XmlIgnore]
        public List<CubeBlock> LoadedDefinitions = new List<CubeBlock>();
        public List<string> Files = new List<string>();

        public void LoadAllDefinitions()
        {
            LoadedDefinitions.Clear();
            foreach (var file in Files)
            {
                if (File.Exists(file))
                {
                    var fileDefinitions = CubeBlockLoader.LoadCubeBlockDefinitions(file);
                    LoadedDefinitions.AddRange(fileDefinitions);
                }
            }
        }

        private const string fileName = "DefinitionFiles.xml";
        public void LoadConfig()
        {
            var currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var fullPath = Path.Combine(currentDirectory, fileName);
            if (!File.Exists(fullPath))
                return;
            
            var serializer = new XmlSerializer(typeof(DefinitionFiles));
            using (var reader = new StreamReader(fullPath)) 
            {
                var data = (DefinitionFiles)serializer.Deserialize(reader);
                Files = data.Files;
            }

            LoadAllDefinitions();
        }

        public void SaveConfig()
        {
            var fs = new FileStream(fileName, FileMode.Create);
            var w = new XmlSerializer(typeof(DefinitionFiles));
            var sw = new StreamWriter(fs, Encoding.GetEncoding("UTF-8"));
            w.Serialize(sw, this);
            sw.Close();
            fs.Close();
        }

        public void AddFile(string filePath)
        {
            if (!Files.Contains(filePath))
            {
                Files.Add(filePath);
            }
            LoadAllDefinitions();
            this.SaveConfig();
        }

        public void RemoveFile(string filePath) {
            if (Files.Contains(filePath))
            {
                Files.Remove(filePath);
            }
            LoadAllDefinitions();
            this.SaveConfig();
        }
    }
}
