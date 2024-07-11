namespace Ship_Class_System_Config_Editor
{
    public static class ListExtensions
    {
        public static List<T> Clone<T>(this List<T> source) where T : ICloneable
        {
            return source.Select(x => (T)x.Clone()).ToList();
        }
    }
}
