using System;
using PierreBakery.Models;

namespace PierreBakeryUI
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the World Famous Pierre's Bakery! 10 Year ZAGAT / 3 Star Michelin");
      Console.WriteLine(".:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:.:*~*:._.:*~*:.");
      Console.WriteLine("Press Enter to see what we have for you today! Prepare to wipe down your drool!");
      Console.ReadLine();
      Console.WriteLine("House-Secret TangZhong Milk Bread Loaf: $5 / Chives and Cheese Quiche: $2");
      Console.WriteLine("Press Enter to see today's Baker Special!");
      Console.ReadLine();
      Console.WriteLine("Specials:");
      Console.WriteLine(".:*~*:._.:*~*:._.:*~*:._.:*~*");
      Console.WriteLine("Milk Bread: Buy 2 Loaves, get one FREE");
      Console.WriteLine("Buy 3 Quiche for $5");
      Console.WriteLine("Enter your order, Type [Bread] or [Quiche]");
      string order = Console.ReadLine().ToLower();
      Console.WriteLine("Thank you! We have the following order: " + " " + order + " How many would you like to purchase?");
      int quantity = int.Parse(Console.ReadLine());
      if (quantity == 1 && order == "bread") {
        Bread newBread = new Bread(5, 1);
        Console.WriteLine("Thank you for ordering!, the total today comes out to" + " $" + newBread.GetPrice());
      } 
      else if (quantity == 2 && order == "bread") 
      {
        Console.WriteLine("Thank you for ordering!, the total today comes out to $5.");
      } 
      else if(quantity >= 3 && order == "bread") 
      {
        Bread newBread = new Bread(5, quantity);
        Console.WriteLine("Thank you for ordering!, the total today comes out to" + " $" + newBread.GetDiscount());
      }
      else if (quantity == 1 && order == "quiche")
      { 
        Pastry newPastry = new Pastry(2, 1);
        Console.WriteLine("Thank you for ordering!, the total today comes out to" + " $" + newPastry.GetPrice());
      }
      else if (quantity == 2 && order == "quiche") 
      {
        Pastry newPastry = new Pastry(2, 2);
        Console.WriteLine("Thank you for ordering!, the total today comes out to" + " $" + newPastry.GetPrice());
      }
      else if (quantity == 3 && order == "quiche")
      {
        Console.WriteLine("Thank you for ordering!, the total today comes out to $5.");
      }
      else if (quantity > 3 && order == "quiche")
      {
        Pastry newPastry = new Pastry(2, quantity);
        Console.WriteLine("Thank you for ordering!, the total today comes out to" + " $" + newPastry.GetDiscount());
      } 
      else 
      {
        Console.WriteLine("It looks like there was a problem. Please try again!");
      }
      Console.ReadLine();
    }
  }
}