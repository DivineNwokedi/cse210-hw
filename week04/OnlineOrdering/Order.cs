using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _productList;
    private Customer _customer;
    private int? _totalCost;

    public Order(List<Product> productList, Customer customer)
    {
        _productList = productList;
        _customer = customer;
    }

    public int CalculateOrderTotal()
    {
        if (_totalCost.HasValue)
            return _totalCost.Value;

        int total = 0;
        foreach (var product in _productList)
        {
            total += product.CalculateTotalCost();
        }
        total += GetOneTimeShippingCost();
        _totalCost = total;
        return total;
    }

    public string GetPackingLabelString()
    {
        var labels = new StringBuilder();
        foreach (var product in _productList)
        {
            labels.AppendLine(product.ToString());
        }
        return labels.ToString();
    }

    public string GetShippingLabelString() => _customer.ToString();

    private int GetOneTimeShippingCost() => _customer.IsInUSA() ? 5 : 35;

    public override string ToString() => $"Order Total: {CalculateOrderTotal()}\nPacking Label:\n{GetPackingLabelString()}\nShipping Label:\n{GetShippingLabelString()}";
}

