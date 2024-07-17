using System;
using System.Collections.Generic;

namespace ShipConfigurator_Definitions
{
    public class BlockLimit : ICloneable
    {
        public string Name { get; set; }
        public int MaxCount { get; set; }
        public List<BlockType> BlockTypes { get; set; }
        public bool TurnedOffByNoFlyZone { get; set; }

        public static BlockLimit Default => new BlockLimit
        {
            Name = "New Limit",
            MaxCount = 0,
            BlockTypes = new List<BlockType>()
        };

        public object Clone()
        {
            var copy = (BlockLimit)this.MemberwiseClone();
            copy.BlockTypes = this.BlockTypes.Clone();
            copy.Name = $"{this.Name} (Copy)";
            return copy;
        }
    }

    public class BlockType : ICloneable
    {
        public string TypeId { get; set; }
        public string SubtypeId { get; set; }
        public float CountWeight { get; set; }
        public string CombinedName => $"{TypeId}/{SubtypeId}";

        public static BlockType Default => new BlockType
        {
            TypeId = "NewTypeId",
            SubtypeId = "NewSubTypeId",
            CountWeight = 1
        };

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
