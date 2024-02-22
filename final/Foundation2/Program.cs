class Program
{
    static void Main(string[] args)
    {
        
        var address = new Address("1665 Mission Dr", "Solvang", "CA", "USA");
        var customer = new Customer("Joseph Donaldson", address);

        
        var order = new Order(customer);
        order.AddProduct(new Product("Angled Paint Brush", "B123", 5.00m, 2));
        order.AddProduct(new Product("Painters tape", "P650", 5.00m, 3));
        order.AddProduct(new Product("Roller Brush", "B864", 10.00m, 4));
        order.AddProduct(new Product("Coblat Blue Paint 1 gal", "P456", 30.00m, 1));

        decimal totalCost = order.CalculateTotalCost();
        string packingLabel = order.GeneratePackingLabel();
        string shippingLabel = order.GenerateShippingLabel();

       
        Console.WriteLine("Order Details:");
        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine($"Total Cost: ${totalCost}");
    }
}