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
  }
}