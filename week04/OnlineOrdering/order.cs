class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalPrice();
        }

        double shipping = _customer.IsInUSA() ? 5.00 : 20.00;
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"- {product.GetProductName()} (ID: {product.GetProductID()})";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping label:\n{_customer.GetName()} \n{_customer.GetAddress()}";
    }
}