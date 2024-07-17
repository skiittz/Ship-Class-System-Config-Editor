using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace ShipConfigurator_Definitions
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

        public static List<CubeBlock> LoadCubeBlockDefinitionsFromLocalFolder()
        {
            var directory = Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Definitions"));
            var cubeBlocks = new List<CubeBlock>();

            var files = System.IO.Directory.GetFiles(directory.ToString(), "*.sbc");
            foreach (var file in files)
            {
                cubeBlocks.AddRange(LoadCubeBlockDefinitions(file));
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