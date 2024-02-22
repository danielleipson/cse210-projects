class Order
{
    private List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    
    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.CalculateTotalCost();
        }
       
        totalCost += Customer.Address.IsInUSA() ? 5 : 35;
        return totalCost;
    }

    
    public string GeneratePackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"{product.Name} - {product.ProductId}\n";
        }
        return label;
    }

    
    public string GenerateShippingLabel()
    {
        return $"Shipping Label:\n{Customer.Name}\n{Customer.Address}";
    }
}