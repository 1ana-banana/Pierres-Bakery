using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateAnInstanceofBread_Bread()
    {
      Bread newBread = new Bread(5, 5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
}