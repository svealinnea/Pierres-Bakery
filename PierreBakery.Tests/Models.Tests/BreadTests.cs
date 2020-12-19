using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{ 
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateAnInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5,5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnPrice_Int()
    {
      int price = 5;
      int quantity = 6;
      int total = 30;
      Bread newBread = new Bread(price, quantity);
      int result = newBread.GetPrice();
      Assert.AreEqual(total, result);
    }
    [TestMethod]
    public void GetDiscount_ReturnsTotalCost_Int()
    {
      int price = 5;
      int quantity = 10;
      int total = 25;
      Bread newBread = new Bread(price, quantity);
      int result = newBread.GetDiscount();
      Assert.AreEqual(total, result);
    }
  }
}