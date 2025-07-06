class Product
{
    private string _productName;
    private string _productID;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string productName, string productID, double pricePerUnit, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public double GetTotalPrice()
    {
        return _pricePerUnit * _quantity;
    }
}