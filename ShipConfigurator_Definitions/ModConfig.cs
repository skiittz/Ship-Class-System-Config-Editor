using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ShipConfigurator_Definitions
{
    [XmlRoot(ElementName = "ModConfig")]
    public class ModConfig
    {
        public bool DebugMode { get; set; }
        public List<string> IgnoreFactionTags { get; set; }
        public float MaxPossibleSpeedMetersPerSecond { get; set; }
        public bool IncludeAiFactions { get; set; }
        public GridClass DefaultGridClass { get; set; }
        public List<GridClass> GridClasses { get; set; }
        public List<Zones> NoFlyZones { get; set; }

        public ModConfig()
        {
            GridClasses = new List<GridClass>();
        }

        public static ModConfig LoadConfig(string filePath)
        {
            ModConfig newConfig;
            var serializer = new XmlSerializer(typeof(ModConfig));
            using (var reader = new StreamReader(filePath))
            {
                newConfig = (ModConfig)serializer.Deserialize(reader);
            }

            newConfig.GridClasses.Add(newConfig.DefaultGridClass);

            return newConfig;
        }

        public void SaveConfig(string filename)
        {
            var defaultClass = this.GridClasses.SingleOrDefault(x => x.Id == 0);
            this.DefaultGridClass = defaultClass;
            this.GridClasses.Remove(defaultClass);
            var fs = new FileStream(filename, FileMode.Create);

            var w = new XmlSerializer(typeof(ModConfig));

            var sw = new StreamWriter(fs, Encoding.GetEncoding("UTF-16"));
            w.Serialize(sw, this);
            sw.Close();
            fs.Close();
            this.GridClasses.Add(defaultClass);
        }
    }
}
