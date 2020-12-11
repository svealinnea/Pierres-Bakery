// using System;
// using PierreBakeryUI;

namespace PierreBakery.Models
{
  public class Bread
  {
    private int _price { get; set;}

    public Bread(int price)
    {
      _price = price;
    }
    public int GetPrice() 
    {
      return _price;
    }
  }
}

