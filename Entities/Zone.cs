namespace Entities
{
    public class Zone
    {
        public string _type_zone { get; set; } = "No type";
        public Position _position { get; set; } = new();
        public int _level_zone { get; set; } = 0;
        public double _radius { get; set; } = 0;

    }
}
