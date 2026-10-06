using System;
using System.Collections.Generic;

namespace GeoInterfaceApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(" Project 2: Interface D\n");

            List<IGeographicObject> geoObjects = new List<IGeographicObject>
            {
                new River(49.84, 24.03, "Poltva", "Subterranean river in Lviv", 30.0, 70.0),
                new Mountain(48.15, 24.63, "Pip Ivan", "One of the highest peaks in Chornohora", 2028.5)
            };

            foreach (IGeographicObject obj in geoObjects)
            {
                Console.WriteLine(obj.GetInfo());
                
            }

            
            Console.ReadKey();
        }
    }
}