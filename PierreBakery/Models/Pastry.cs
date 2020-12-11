using System;

namespace PierreBakery.Models
{
  public class Pastry
  {
    private int _price { get; set; }

    public Pastry(int price)
    {
      _price = price;
    }
    public int GetPrice()
    {
      return _price;
    }
  }
}