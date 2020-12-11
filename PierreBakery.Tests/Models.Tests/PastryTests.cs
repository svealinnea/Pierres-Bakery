using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateAnInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPastryPrice_ReturnPrice_Int()
    {
      int price = 2;
      Pastry newPastry = new Pastry(price);
      int result = newPastry.Price;
      Assert.AreEqual(price, result);
    }
  }
}