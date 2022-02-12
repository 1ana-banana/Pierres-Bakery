using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstuctor_CreateAnInstanceofPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2,2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPastryPrice_ReturnPrice_Int()
    {
      Pastry newPastry = new Pastry(2, 1);
      int result = 2;
      int price = newPastry.GetPrice();
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetPastryDiscount_ReturnPrice_Int()
    {
      Pastry newPastry = new Pastry(2,10);
      int discount = newPastry.GetDiscount();
      int result = 17;
      Assert.AreEqual(result, discount);
    }
  }
}