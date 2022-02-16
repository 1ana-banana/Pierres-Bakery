using System;

namespace PierreBakery.Models
{
  public class Pastry
  {
    public int Price {get; set;}
    public int Quantity{get; set;}
    public Pastry(int price, int quantity)
    {
      Price = price;
      Quantity = quantity;
    }
    public int GetPrice()
    {
      return Price * Quantity;
    }
    public int GetDiscount()
    {
      int freeQuiche = Quantity/3;
      return (Quantity * 2) - freeQuiche;
    }
  }
}
