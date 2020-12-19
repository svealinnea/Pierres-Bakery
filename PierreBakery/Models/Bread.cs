// using System;
using PierreBakeryUI;

namespace PierreBakery.Models
{
  public class Bread
  {
    public int Price { get; set;}
    public int Quantity { get; set; }

    public Bread(int price, int quantity)
    {
      Price = price;
      Quantity = quantity;
    }
    public int GetPrice() 
    {
      return Price * Quantity;
    }
    public int GetDiscount()
    {
      return Price * Quantity / 2;
    }
  }
}

