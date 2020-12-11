using System;
using PierreBakery.Models;
//using System.Collections.Generic; -- use for lists

namespace PierreBakeryUI
{
  public class Program
  {
    public static void Main() 
    { 
      Console.WriteLine("Welcome to Pierre's Delicious Bakery!");
      Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
      Console.WriteLine("Please press [Enter] to see todays Bread & Pastry prices!");
      Console.ReadLine();
      Console.WriteLine("The price for Bread is $5 and the Price for Pastries is $2");
      Console.WriteLine("Todays Specials Include:");
      Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*");
      Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5");
      Console.WriteLine("What would you like to purchase today? [Bread] or [Pastry]");
      string order = Console.ReadLine().ToLower();
      if (order == "bread") 
      {
        new Bread(5);
      } 
      else if (order == "pastry") 
      {
        new Pastry(2);
      } else 
      {
        Console.WriteLine("Please check that you entered Bread or Pastry and try again");
      }
    }
  }
}
