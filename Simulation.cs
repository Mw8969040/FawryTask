using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask
{
    public static  class Simulation
    {
        static Radar radar = new Radar();


        public static void InitializeData()
        {

            radar.AddNewRule(new TruckSpeed());
            radar.AddNewRule(new PrivateCarSpeed());
            radar.AddNewRule(new BusSpeed());
            radar.AddNewRule(new Seatbelt());

            List<CarsData> testCars = new List<CarsData>
            {
                new CarsData("MCM432", DateTime.Now, Vehicletype.PrivateCar, 100, false),
                new CarsData("TRK982", DateTime.Now.AddMinutes(-5), Vehicletype.Truck, 75, true),
                new CarsData("BUS101", DateTime.Now.AddMinutes(-12), Vehicletype.Bus, 110, false),
                new CarsData("OK1234", DateTime.Now.AddMinutes(-20), Vehicletype.PrivateCar, 70, true),
                new CarsData("DEF567", DateTime.Now.AddMinutes(-30), Vehicletype.PrivateCar, 75, false),
                new CarsData("GOO888", DateTime.Now.AddMinutes(-45), Vehicletype.Truck, 50, true)
            };

            foreach (var car in testCars)
            {
                radar.CarPreview(car);

               
            }

            radar.PrintAllFines();
        }


    }
}
