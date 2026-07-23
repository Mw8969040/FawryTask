using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask
{
    public class CarsData
    {
        public string? plateNumber { get; set; }
        public  DateTime date { get; set; }
        public Vehicletype vehicleType { get; set; }
        public double speed { get; set; }
        public bool seatbelt { get; set; }

        public CarsData(string? plateNumber , DateTime date , Vehicletype vehicleType ,double speed , bool seatbelt)
        {
            this.plateNumber = plateNumber;
            this.date = date;
            this.vehicleType = vehicleType;
            this.speed = speed;
            this.seatbelt = seatbelt;
        }

    }
}
