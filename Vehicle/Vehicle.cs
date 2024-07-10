using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Value { get; set; }
        public Vehicle(string brand, string model, double value)
        {
            Brand = brand;
            Model = model;
            Value = value;
        }

        public abstract double CalculatingDailyRentalCost(int rentalPeriod);
        public abstract double CalculatingDailyInsuranceCost(Customer customer);
    }
}
