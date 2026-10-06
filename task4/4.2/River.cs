namespace GeoInterfaceApp
{
    public class River : IGeographicObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double FlowSpeed { get; set; }
        public double TotalLength { get; set; }

        public River(double x, double y, string name, string description, double flowSpeed, double totalLength)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
            FlowSpeed = flowSpeed;
            TotalLength = totalLength;
        }

        public string GetInfo()
        {
            return $"Name: {Name}\n" +
                   $"Coordinates: ({X}, {Y})\n" +
                   $"Description: {Description}\n" +
                   $"Flow Speed: {FlowSpeed} cm/s\n" +
                   $"Total Length: {TotalLength} km";
        }
    }
}
