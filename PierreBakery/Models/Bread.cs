using System;
using PierreBakeryUI;

namespace PierreBakery.Models
{
  public class Bread
  {
    public int Price { get; set;}
    public int Quantity { get; set;}

    public string Order { get; set; }

    public Bread(int price, int quantity, string order)
    {
      Price = price;
      Quantity = quantity;
      Order = order; 
    }
    // public void CalculatePrice() {
    //         if (quantity == 1 && order == "bread") {
    //     Console.WriteLine("Thank you for purchasing with us today, your total is $5");
    //   } 
    //   else if (quantity == 2 && order == "bread") 
    //   {
    //     Console.WriteLine("Thank you for purchasing with us today, your total is $5");
    //   } 
    //   else if(quantity > 2 && order == "bread") 
    //   {
    //     Console.WriteLine("Thank you for purchasing with us today, your total is" + quantity/2 * 5);
    //   }
    //   else if (quantity == 1 && order == "pastry")
    //   { 
    //     Console.WriteLine("Thank you for purchasing with us today, your total is $2");
    //   }
    //   else if (quantity == 2 && order == "pastry") 
    //   {
    //     Console.WriteLine("Thank you for purchasing with us today, your total is $4");
    //   }
    //   else if (quantity == 3 && order == "pastry")
    //   {
    //     Console.WriteLine("Thank you for purchasing with us today, your total is $5");
    //   }
    //   else if (quantity > 3 && order == "pastry")
    //   {
    //     Console.WriteLine("Thank you for purchasing with us ")
    //   }
    // }
  }
}

