using System.Collections.Generic;

namespace ShipConfigurator_Definitions
{
    public class GridClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ForceBroadCast { get; set; }
        public int ForceBroadCastRange { get; set; }
        public bool LargeGridStatic { get; set; }
        public bool LargeGridMobile { get; set; }
        public bool SmallGrid { get; set; }
        public int MaxBlocks { get; set; }
        public int MaxMass { get; set; }
        public int MaxPCU { get; set; }
        public int MaxPerFaction { get; set; }
        public int MaxPerPlayer { get; set; }
        public int MinBlocks { get; set; }
        public int MinPlayers { get; set; }
        public UtilModifiers Modifiers { get; set; }
        public DamageModifiers DamageModifiers { get; set; }
        public List<BlockLimit> BlockLimits { get; set; }

        public GridClass()
        {
            BlockLimits = new List<BlockLimit>();
            Modifiers = new UtilModifiers();
            DamageModifiers = new DamageModifiers();
        }

        public static GridClass Default => new GridClass
        {
            Name = "New Class",
            ForceBroadCast = false,
            ForceBroadCastRange = 0,
            LargeGridStatic = false,
            LargeGridMobile = false,
            SmallGrid = false,
            MaxBlocks = -1,
            MaxMass = -1,
            MaxPCU = -1,
            MaxPerFaction = -1,
            MaxPerPlayer = -1,
            MinBlocks = -1,
            MinPlayers = -1,
            Modifiers = UtilModifiers.Default,
            DamageModifiers = DamageModifiers.Default,
            BlockLimits = new List<BlockLimit>()
        };

        public GridClass CloneToId(int newId)
        {
            var newObj = (GridClass)this.MemberwiseClone();
            newObj.Id = newId;
            newObj.Modifiers = (UtilModifiers)this.Modifiers.Clone();
            newObj.DamageModifiers = (DamageModifiers)this.DamageModifiers.Clone();
            newObj.BlockLimits = this.BlockLimits.Clone();
            return newObj;
        }
    }
}
