using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace VehicleRentalSystem
{
    internal class Invoice
    {
        public Vehicle Vehicle { get; set; }
        public Rental Rental { get; set; }
        public Customer Customer { get; set; }

        public Invoice(Vehicle vehicle, Rental rental, Customer customer)
        {
            Vehicle = vehicle;
            Rental = rental;
            Customer = customer;
        }   

        public void Print()
        {
            double totalRentalCost = Rental.CalculatingTotalRentalCost();
            double totalInsuranceCost = Rental.CalculatingTotalInsuranceCost(Customer);
            double totalCost = totalRentalCost + totalInsuranceCost;

            Console.WriteLine("XXXXXXXXXX");
            Console.WriteLine($"Date: {Rental.Date}");
            Console.WriteLine($"Customer Name: {Customer.CustomerName}");
            Console.WriteLine($"Rented Vehicle: {Vehicle.Brand} {Vehicle.Model}");
            Console.WriteLine($"Reservation start date: {Rental.StartDate}");
            Console.WriteLine($"Reservation end date: {Rental.EndDate}");
            Console.WriteLine($"Reserved rental days: {Rental.ReservedDays} days");
            Console.WriteLine($"Actual return date: {Rental.ActualReturnDate}");
            Console.WriteLine($"Actual rental days: {Rental.ActualDays} days");
            Console.WriteLine($"Rental cost per day: " +
                $"${Vehicle.CalculatingDailyRentalCost(Rental.ReservedDays):F2}");
            Console.WriteLine($"Insurance per day: ${Vehicle.CalculatingDailyInsuranceCost(Customer):F2}");
            Console.WriteLine($"Total rent: ${totalRentalCost:F2}");
            Console.WriteLine($"Total insurance: ${totalInsuranceCost:F2}");
            Console.WriteLine($"Total: ${totalCost:F2}");
            Console.WriteLine("XXXXXXXXXX\n");
        }
    }
}
