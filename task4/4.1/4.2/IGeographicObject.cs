namespace GeoInterfaceApp
{
    public interface IGeographicObject
    {
        double X { get; set; }
        double Y { get; set; }
        string Name { get; set; }
        string Description { get; set; }

        string GetInfo();
    }
}
