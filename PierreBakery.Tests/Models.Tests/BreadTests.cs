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
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnPrice_Int()
    {
      int price = 5;
      Bread newBread = new Bread(price);
      int result = newBread.Price();
      Assert.AreEqual(price, result);
    }
    // [TestMethod]

    // public void GetBreadType_ReturnBreadType_String()
    // {
    //   string type = "ciabatta";
    //   int price = 5;
    //   Bread newBread = new Bread(price, type);
    //   string result = newBread.Price.BreadType;
    //   Assert.AreEqual(type, result);
    // }
  }
}