namespace GeoAbstractApp
{
    public class River : GeographicObject
    {
       
        public double FlowSpeed { get; set; }
        public double TotalLength { get; set; }

        public River(double x, double y, string name, string description, double flowSpeed, double totalLength)
            : base(x, y, name, description)
        {
            FlowSpeed = flowSpeed;
            TotalLength = totalLength;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "\n" +
                   $"Flow Speed: {FlowSpeed} cm/s\n" +
                   $"Total Length: {TotalLength} km";
        }
    }
}