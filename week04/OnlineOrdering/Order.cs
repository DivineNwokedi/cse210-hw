using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _productList;
    private Customer _customer;

    public Order(List<Product> productList, Customer customer)
    {
        _productList = productList;
        _customer = customer;
    }

    public int CalculateOrderTotal()
    {
        int total = 0;
        foreach (Product product in _productList)
        {
            total += product.CalculateTotalCost();
        }
        total += GetOneTimeShippingCost();
        return total;
    }

    public string GetPackingLabelString()
    {
        string label = "";
        foreach (Product product in _productList)
        {
   label += product.GetDisplayString() + "\n";
        }
        return label;
    }

    public string GetShippingLabelString()
    {
        return _customer.GetDisplayString();
    }

    private int GetOneTimeShippingCost()
    {
        if (_customer.IsInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string GetDisplayString()
    {
        return $"Order Total: {CalculateOrderTotal()}\nPacking Label:\n{GetPackingLabelString()}\nShipping Label:\n{GetShippingLabelString()}";
    }
}
