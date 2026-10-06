namespace GeoAbstractApp
{
    public abstract class GeographicObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public GeographicObject(double x, double y, string name, string description)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
        }

      
        public virtual string GetInfo()
        {
            return $"Name: {Name}\n" +
                   $"Coordinates: ({X}, {Y})\n" +
                   $"Description: {Description}";
        }
    }
}