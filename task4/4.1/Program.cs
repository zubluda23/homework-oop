using System;
using System.Collections.Generic;

namespace GeoAbstractApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(" Project 1: Abstract Class \n");

            List<GeographicObject> geoObjects = new List<GeographicObject>
            {
                new River(48.45, 35.05, "Dnipro", "One of the major rivers of Europe", 75.5, 2201.0),
                new Mountain(48.16, 24.50, "Hoverla", "The highest mountain in Ukraine", 2061.0)
            };

            foreach (GeographicObject obj in geoObjects)
            {
                Console.WriteLine(obj.GetInfo());
                
            }

           
            Console.ReadKey();
        }
    }
}
