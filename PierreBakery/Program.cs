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
      Console.WriteLine("House-Secret TangZhong Milk Bread Loaf: $12 / Chives and Cheese Quiche: $5");
      Console.WriteLine("Press Enter to see today's Baker Special!");
      Console.ReadLine();
      Console.WriteLine("Specials:");
      Console.WriteLine(".:*~*:._.:*~*:._.:*~*:._.:*~*");
      Console.WriteLine("Milk Bread: Buy 2 Loaves, get one FREE");
      Console.WriteLine("Buy 3 Quiche for $13");
      Console.WriteLine("Enter your order, Type [Bread] or [Quiche]");
      string order = Console.ReadLine().ToLower();
      Console.WriteLine("We have your order: " + " " + order + "Please enter the quantity you would like to purchase.");
      int quantity = int.Parse(Console.ReadLine());
      if (quantity == 1 && order == "bread") {
        Bread newBread = new Bread(12, 1);
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
        Quiche newQuiche = new Quiche(5, 1);
        Console.WriteLine("Thank you for ordering!, the total today comes out to" + " $" + newPastry.GetPrice());
      }
      else if (quantity == 2 && order == "quiche") 
      {
        Quiche newQuiche = new Quiche(5, 2);
        Console.WriteLine("Thank you for ordering!, the total today comes out to" + " $" + newPastry.GetPrice());
      }
      else if (quantity == 3 && order == "quiche")
      {
        Console.WriteLine("Thank you for ordering!, the total today comes out to $5.");
      }
      else if (quantity > 3 && order == "quiche")
      {
        Quiche newQuiche = new Quiche(2, quantity);
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