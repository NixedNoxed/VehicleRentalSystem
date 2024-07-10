using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public class Rental
    {
        public string Date { get; set; }
        
        public Vehicle Vehicle { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int ReservedDays { get; set; }
        public string ActualReturnDate { get; set; }
        public int ActualDays { get; set; }

        public Rental(string date, Vehicle vehicle, 
            string startDate, string endDate, int daysReserved, 
            string actualReturnDate, int actualDays)
        {
            Date = date;
            Vehicle = vehicle;
            StartDate = startDate;
            EndDate = endDate;
            ReservedDays = daysReserved;
            ActualReturnDate = actualReturnDate;
            ActualDays = actualDays;
        }

        public double CalculatingTotalRentalCost()
        {

            if (ActualDays == ReservedDays)
            {
                return ActualDays * Vehicle.CalculatingDailyRentalCost(ActualDays);
            }
            else
            {
                int remainingDays = ReservedDays - ActualDays;
                double fullPriceDaysCost = ActualDays 
                    * Vehicle.CalculatingDailyRentalCost(ReservedDays);
                double halfPriceDaysCost = remainingDays 
                    * (Vehicle.CalculatingDailyRentalCost(ReservedDays) / 2);
                return fullPriceDaysCost + halfPriceDaysCost;
            }
        }

        public double CalculatingTotalInsuranceCost(Customer customer)
        {
            return ActualDays * Vehicle.CalculatingDailyInsuranceCost(customer);
        }
    }
}
