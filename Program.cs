using VehicleRentalSystem;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Mitsubishi", "Mirage", 15000.00, 3);
        Customer carCustomer = new Customer("John Doe", 10, 40);
        Rental carRental = new Rental("2024-06-13", car, 
            "2024-06-03", "2024-06-13", 10, "2024-06-13", 7);
        Invoice carInvoice = new Invoice(car, carRental, carCustomer);
        carInvoice.Print();

        Motorcycle motorcycle = new Motorcycle("Triumph", "Tiger Sport 660", 10000.00);
        Customer motorcycleCustomer = new Customer("Mary Johnson", 10, 20);
        Rental motorcycleRental = new Rental("2024-06-13", motorcycle, "2024-06-03", 
            "2024-06-13", 10, "2024-06-13", 10);
        Invoice motorcycleInvoice = new Invoice(motorcycle, motorcycleRental, motorcycleCustomer);
        motorcycleInvoice.Print();

        CargoVan cargoVan = new CargoVan("Citroen", "Jumper", 20000.00);
        Customer cargoVanCustomer = new Customer("John Markson", 8, 35);
        Rental cargoVanRental = new Rental("2024-06-13", cargoVan, "2024-06-03", 
            "2024-06-18", 15, "2024-06-13", 10);
        Invoice cargoVanInvoice = new Invoice(cargoVan, cargoVanRental, cargoVanCustomer);
        cargoVanInvoice.Print();
    }
}
