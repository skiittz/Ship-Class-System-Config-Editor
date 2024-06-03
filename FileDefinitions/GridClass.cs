namespace Ship_Class_System_Config_Editor.FileDefinitions
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
    }
}
