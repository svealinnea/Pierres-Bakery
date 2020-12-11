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
      Console.WriteLine("The price for a loaf of Bread is $5 and the Price for Pastries is $2");
      Console.WriteLine("Todays Specials Include:");
      Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*");
      Console.WriteLine("Bread: Buy 2, get 1 free.");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5");
      Console.WriteLine("TODAY ONLY --- Multiple Order Type Special!");
      Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
      Console.WriteLine("If you purchase both a pastry and a loaf of bread you will get the pastry for $1 and the loaf for $3, NO matter how many you buy!");
      Console.WriteLine("What would you like to purchase today? [Bread] or [Pastry] or [Both]");
      string order = Console.ReadLine().ToLower();
      if (order == "both") 
      {
        new Bread(3);
        new Pastry(1);
        Console.WriteLine("How many loafs of bread would you like?");
        int breadQuantity = int.Parse(Console.ReadLine());
        Console.WriteLine("How many pastries would you like?");
        int pastryQuantity = int.Parse(Console.ReadLine());
        Console.WriteLine("Thank you for purchasing with us today, your total is");
      } 
      else if (order == "pastry") 
      {
        new Pastry(2);
      } 
      else if (order == "bread")
      {
        new Bread(5);
      }
      else if (order != "bread" && order != "pastry" && order != "both")
      {
        Console.WriteLine("Please check that you entered Bread or Pastry or Both and try again");
        Environment.Exit(0);
      }
      else 
      {
        Environment.Exit(0);
      }
      Console.WriteLine("Thank you for letting us know you would like to purchase" + " " + order + "How many would you like to purchase?");
      int quantityBread = int.Parse(Console.ReadLine());
      Bread yum = new Bread(5);
      Pastry alsoYum = new Pastry(2);
      int quantity = int.Parse(Console.ReadLine());
      if (quantity == 1 && order == "bread") {
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + yum.GetPrice());
      } 
      else if (quantityBread == 2 && order == "bread") 
      {
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + yum.GetPrice());
      } 
      else if(quantity > 2 && order == "bread") 
      {
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + quantity/2 * yum.GetPrice());
      }
      else if (quantity == 1 && order == "pastry")
      { 
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + alsoYum.GetPrice());
      }
      else if (quantity == 2 && order == "pastry") 
      {
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + alsoYum.GetPrice() * 2);
      }
      else if (quantity == 3 && order == "pastry")
      {
        Console.WriteLine("Thank you for purchasing with us today, your total is $5");
      }
      else if (quantity > 3 && order == "pastry")
      {
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + quantity/3 * 5);
      } 
      else 
      {
        Console.WriteLine("Please enter a specific quantity and try again");
      }
      Console.ReadLine();
    }
  }
}
