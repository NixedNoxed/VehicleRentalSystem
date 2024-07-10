using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public class CargoVan : Vehicle
    {
        
        public CargoVan(string brand, string model, double value) 
            : base(brand, model, value)
        {
        }

        public override double CalculatingDailyRentalCost(int rentalPeriod)
        {
            double dailyRentalCost = 0.00;
            if (rentalPeriod <= 7)
            {
                dailyRentalCost = 50;
            }
            else if (rentalPeriod > 7)
            {
                dailyRentalCost = 40;
            }

            return dailyRentalCost;
        }
        public override double CalculatingDailyInsuranceCost(Customer customer)
        {
            double insuranceCost = 0.0003 * Value;
            if (customer.DriversExperience > 5)
            {
                insuranceCost *= 0.85;
            }
            return insuranceCost;
        }
    }
}
