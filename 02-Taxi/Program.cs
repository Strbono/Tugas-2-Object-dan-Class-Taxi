using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Taxi
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // membuat object taxi
            Taxi taxi = new Taxi();

            // pengesetan nilai  propertis
            taxi.DriverName = "Wibisono";
            taxi.OnDuty = true;
            taxi.NumPassengers = 5;

            // Pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassengers();
            taxi.DropOffPassengers();


            Console.ReadKey();

        }
    }
}
