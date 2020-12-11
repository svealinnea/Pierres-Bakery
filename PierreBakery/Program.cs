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
      } 
      else if (order != "bread" && order != "pastry")
      {
        Console.WriteLine("Please check that you entered Bread or Pastry and try again");
        Environment.Exit(0);
      }
      else 
      {
        Environment.Exit(0);
      }
      Console.WriteLine("Thank you for letting us know you would like to purchase" + " $" + order + ". " + "How many would you like? [Please enter a number]");
      Bread yum = new Bread(5);
      Pastry alsoYum = new Pastry(2);
      int quantity = int.Parse(Console.ReadLine());
      if (quantity == 1 && order == "bread") {
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + yum.GetPrice());
      } 
      else if (quantity == 2 && order == "bread") 
      {
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + yum.GetPrice());
      } 
      else if(quantity > 2 && order == "bread") 
      {
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " " + quantity/2 * yum.GetPrice());
      }
      else if (quantity == 1 && order == "pastry")
      { 
        Console.WriteLine("Thank you for purchasing with us today, your total is $2");
      }
      else if (quantity == 2 && order == "pastry") 
      {
        Console.WriteLine("Thank you for purchasing with us today, your total is $4");
      }
      else if (quantity == 3 && order == "pastry")
      {
        Console.WriteLine("Thank you for purchasing with us today, your total is $5");
      }
      else if (quantity > 3 && order == "pastry")
      {
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " " + quantity/3 * 5);
      } 
      else 
      {
        Console.WriteLine("Please enter a specific quantity and try again");
      }
      Console.ReadLine();
    }
  }
}
