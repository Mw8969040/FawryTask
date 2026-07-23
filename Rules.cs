using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask
{
    public interface Rules
    {
        public Violation Check(CarsData cars);
    }

    public class TruckSpeed : Rules
    {
        public Violation? Check(CarsData car)
        {
            if (car == null)
            {
                throw new ArgumentNullException("Not found any data for car .");
            }

            if (car.vehicleType == Vehicletype.Truck && car.speed > 60)
            {
                return new Violation(descryption: $"Speed is {car.speed} , exceeded speed limit (60 km/h) .", price: 300);
            }

            return null;
        }
    }

    public class PrivateCarSpeed : Rules
    {
        public Violation? Check(CarsData car)
        {
            if (car == null)
            {
                throw new ArgumentNullException("Not found any data for car .");
            }

            if (car.vehicleType == Vehicletype.PrivateCar && car.speed > 80)
            {
                return new Violation(descryption: $"Speed is {car.speed} , exceeded speed limit (80 km/h) .", price: 300);
            }

            return null;
        }
    }
     public class BusSpeed : Rules
    {
        public Violation? Check(CarsData car)
        {
            if (car == null)
            {
                throw new ArgumentNullException("Not found any data for car .");
            }

            if (car.vehicleType == Vehicletype.Bus && car.speed > 50)
            {
                return new Violation(descryption: $"Speed is {car.speed} , exceeded speed limit (50 km/h) .", price: 300);
            }

            return null;
        }
    }

    public class Seatbelt : Rules
    {
        public Violation? Check(CarsData car)
        {
            if (car == null)
            {
                throw new ArgumentNullException("Not found any data for car .");
            }

            if ((car.vehicleType == Vehicletype.Truck || car.vehicleType == Vehicletype.PrivateCar || car.vehicleType == Vehicletype.Bus)  && car.seatbelt)
            {
                return new Violation(descryption: "the seatbelt is not used .", price: 100);
            }

            return null;
        }
    }
}
