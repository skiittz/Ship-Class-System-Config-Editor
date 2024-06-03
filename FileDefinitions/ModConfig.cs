using Ship_Class_System_Config_Editor.FileDefinitions;
using System.Xml.Serialization;

namespace Ship_Class_System_Config_Editor.Definitions
{
    [XmlRoot(ElementName = "ModConfig")]
    public class ModConfig
    {
        public List<string> IgnoreFactionTags { get; set; }
        public bool IncludeAiFactions { get; set; }
        public GridClass DefaultGridClass { get; set; }
        public List<GridClass> GridClasses { get; set; }
        public List<BlockLimit> BlockLimits { get; set; }
    }
}
