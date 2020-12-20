using System;
using PierreBakery.Models;

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
      Console.WriteLine("Press [Enter] to see Todays Specials!");
      Console.ReadLine();
      Console.WriteLine("Todays Specials Include:");
      Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*");
      Console.WriteLine("Bread: Buy 2, get 1 free.");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5");
      Console.WriteLine("What would you like to order? Please enter [Bread] or [Pastry]");
      string order = Console.ReadLine().ToLower();
      Console.WriteLine("Thank you for letting us know you would like to purchase" + " " + order + " How many would you like to purchase?");
      int quantity = int.Parse(Console.ReadLine());
      if (quantity == 1 && order == "bread") {
        Bread newBread = new Bread(5, 1);
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + newBread.GetPrice());
      } 
      else if (quantity == 2 && order == "bread") 
      {
        Console.WriteLine("Thank you for purchasing with us today, your total is $5");
      } 
      else if(quantity >= 3 && order == "bread") 
      {
        Bread newBread = new Bread(5, quantity);
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + newBread.GetDiscount());
      }
      else if (quantity == 1 && order == "pastry")
      { 
        Pastry newPastry = new Pastry(2, 1);
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + newPastry.GetPrice());
      }
      else if (quantity == 2 && order == "pastry") 
      {
        Pastry newPastry = new Pastry(2, 2);
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + newPastry.GetPrice());
      }
      else if (quantity == 3 && order == "pastry")
      {
        Console.WriteLine("Thank you for purchasing with us today, your total is $5");
      }
      else if (quantity > 3 && order == "pastry")
      {
        Pastry newPastry = new Pastry(2, quantity);
        Console.WriteLine("Thank you for purchasing with us today, your total is" + " $" + newPastry.GetDiscount());
      } 
      else 
      {
        Console.WriteLine("Please enter a specific quantity and try again");
      }
      Console.ReadLine();
    }
  }
}
