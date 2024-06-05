namespace Ship_Class_System_Config_Editor.FileDefinitions
{
    public class UtilModifiers
    {
        public float AssemblerSpeed { get; set; }
        public float DrillHarvestMultipler { get; set; }
        public float GyroEfficiency { get; set; }
        public float GyroForce { get; set; }
        public float PowerProducersOutput { get; set; }
        public float RefineEfficiency { get; set; }
        public float RefineSpeed { get; set; }
        public float ThrusterEfficiency { get; set; }
        public float ThrusterForce { get; set; }

        public static UtilModifiers Default => new UtilModifiers
        {
            AssemblerSpeed = 1,
            DrillHarvestMultipler = 1,
            GyroEfficiency = 1,
            GyroForce = 1,
            PowerProducersOutput = 1,
            RefineEfficiency = 1,
            RefineSpeed = 1,
            ThrusterEfficiency = 1,
            ThrusterForce = 1
        };
    }
}
