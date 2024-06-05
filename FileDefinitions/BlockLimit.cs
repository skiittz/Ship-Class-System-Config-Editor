﻿using System.Xml.Serialization;

namespace Ship_Class_System_Config_Editor.FileDefinitions
{
    public class BlockLimit
    {
        public string Name { get; set; }
        public List<BlockType> BlockTypes { get; set; }

        public static BlockLimit Default => new BlockLimit
        {
            Name = "New Limit",
            BlockTypes = new List<BlockType>()
        };
    }

    public class BlockType
    {
        public string TypeId { get; set; }
        public string SubtypeId { get; set; }
        public float CountWeight { get; set; }

        public static BlockType Default => new BlockType
        {
            TypeId = "NewTypeId",
            SubtypeId = "NewSubTypeId",
            CountWeight = 1
        };
    }
}
