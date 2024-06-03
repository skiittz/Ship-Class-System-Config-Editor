namespace Ship_Class_System_Config_Editor.FileDefinitions
{
    public class BlockLimit
    {
        public string Name { get; set; }
        public List<BlockType> BlockTypes { get; set; }

    }

    public class BlockType
    {
        public string TypeId { get; set; }
        public string SubtypeId { get; set; }
        public float CountWeight { get; set; }
    }
}
