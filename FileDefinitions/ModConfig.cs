using Ship_Class_System_Config_Editor.FileDefinitions;
using System.Xml.Serialization;

namespace Ship_Class_System_Config_Editor.Definitions
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
    }
}
