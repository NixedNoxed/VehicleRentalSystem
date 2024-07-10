using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string brand, string model, double value) 
            : base(brand, model, value)
        {
        }

        public override double CalculatingDailyRentalCost(int rentalPeriod)
        {
            double dailyRentalCost = 0.00;
            if (rentalPeriod <= 7)
            {
                dailyRentalCost = 15;
            }
            else if (rentalPeriod > 7)
            {
                dailyRentalCost = 10;
            }

            return dailyRentalCost;
        }
        public override double CalculatingDailyInsuranceCost(Customer customer)
        {
            double insuranceCost = 0.0002 * Value;
            if (customer.RidersAge < 25)
            {
                insuranceCost *= 1.2;
            }
            return insuranceCost;
        }
    }
}
