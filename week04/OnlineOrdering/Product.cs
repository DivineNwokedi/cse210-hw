public class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product(string name, int productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public int CalculateTotalCost() => _price * _quantity;

    public override string ToString() => $"Name: {_name}\nProduct ID: {_productId}\nPrice: {_price}\nQuantity: {_quantity}";
}

