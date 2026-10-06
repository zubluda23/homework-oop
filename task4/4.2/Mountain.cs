namespace GeoInterfaceApp
{
    public class Mountain : IGeographicObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double HighestPoint { get; set; }

        public Mountain(double x, double y, string name, string description, double highestPoint)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
            HighestPoint = highestPoint;
        }

        public string GetInfo()
        {
            return $"Name: {Name}\n" +
                   $"Coordinates: ({X}, {Y})\n" +
                   $"Description: {Description}\n" +
                   $"Highest Point: {HighestPoint} m";
        }
    }
}