using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public double DriversExperience { get; set; }
        public int RidersAge { get; set; }
        public Customer(string name, double driversExperience, int ridersAge) 
        { 
            CustomerName = name;
            DriversExperience = driversExperience;
            RidersAge = ridersAge;
        }
    }
}
