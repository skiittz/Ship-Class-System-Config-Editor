﻿namespace Ship_Class_System_Config_Editor.FileDefinitions
{
    public class DamageModifiers
    {
        public float Bullet { get; set; }
        public float Rocket { get; set; }
        public float Explosion { get; set; }
        public float Environment { get; set; }
        public float Energy { get; set; }
        public float Kinetic { get; set; }

        public static DamageModifiers Default => new DamageModifiers
        {
            Bullet = 1,
            Rocket = 1,
            Explosion = 1,
            Environment = 1,
            Energy = 1,
            Kinetic = 1
        };
    }
}
