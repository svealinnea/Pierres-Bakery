using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace ProjectName.Tests
{ 
  [TestClass]
  public class BreadTests 
  {
    [TestMethod]
    public void BreadConstructor_CreateAnInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnPrice_Int()
    {
      int price = 5;
      Bread newBread = new Bread(price);
      int result = newBread.Price;
      Assert.AreEqual(price, result);
    }
  }
}