using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

namespace VehicleRentalSystem
{
    public class Car : Vehicle
    {
        public int SafetyRating { get; set; }
        public Car (string brand, string model, double value, int safetyRating) 
            : base(brand, model, value)
        {
            SafetyRating = safetyRating;
        }

        public override double CalculatingDailyRentalCost(int rentalPeriod)
        {
            double dailyRentalCost = 0.00;
            if (rentalPeriod <= 7)
            {
                dailyRentalCost = 20;
            }
            else if (rentalPeriod > 7)
            {
                dailyRentalCost = 15;
            }

            return dailyRentalCost;
        }

        public override double CalculatingDailyInsuranceCost(Customer customer)
        {
            double insuranceCost = 0.0001 * Value;
            if(SafetyRating  >= 4)
            {
                insuranceCost *= 0.9;
            }
            return insuranceCost;
        }
    }
}
