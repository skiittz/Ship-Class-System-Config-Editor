using System.Xml.Linq;

namespace Ship_Class_System_Config_Editor
{
    public static class CubeBlockLoader
    {
        public static List<CubeBlock> LoadCubeBlockDefinitions(string filePath)
        {
            XDocument xdoc = XDocument.Load(filePath);
            var cubeBlocks = new List<CubeBlock>();
            foreach (var element in xdoc.Descendants("Definition"))
            {
                var typeId = element.Element("Id")?.Element("TypeId")?.Value;
                var subTypeId = element.Element("Id")?.Element("SubtypeId")?.Value;
                cubeBlocks.Add(new CubeBlock
                {
                    TypeId = typeId,
                    SubtypeId = subTypeId,
                    DisplayName = $"{element.Element("DisplayName")?.Value.Replace("DisplayName_Block_","")}({typeId}|{subTypeId})"
                });
            }

            return cubeBlocks;
        }
    }

    public class CubeBlock
    {
        public string TypeId { get; set; }
        public string SubtypeId { get; set; }
        public string DisplayName { get; set; }
    }
}