using System;

namespace PierreBakery.Models
{
  public class Bread
  {
    public int Price { get; set;}
    //public string BreadType { get; set; }

    public Bread(int price)
    {
      Price = price;
      //BreadType = type;
    }
  }
}