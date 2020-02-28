using System;
using System.Collections.Generic;
using Pastry.Models;
using Bread.Models;

namespace PastryShop
{
  public class Program
  {
    public static void Main()
    {
      PastryOrder pastry = new PastryOrder(0, 0);
      BreadOrder bread = new BreadOrder(0, 0);
      Console.WriteLine("hello and welcome to Pierre's Bakery!");
      Console.WriteLine("Below are some of the food items availible");
      Console.WriteLine("---------------------------------------------");
      Console.WriteLine("Bread ------ $5.00 ea or buy 2 get on free!");
      Console.WriteLine("Pastry ----- $2.00 ea or 3 for $5.00");
      Console.WriteLine("---------------------------------------------");
      ////////////////////////////////////////////////////////////////////////////
      ////////////////////// ORDERING LOGIC //////////////////////////////////////
      ////////////////////////////////////////////////////////////////////////////
      List<int> breadModifier = new List <int> {2, 2, 2, 2};
      Console.WriteLine("this counts the total of the bread list: " + breadModifier.Count);




      /////////////////////bread logic //////////////////////////
      Console.WriteLine("how many orders of bread would you like?");
      string breadResponse = Console.ReadLine();
      int breadNumber = int.Parse(breadResponse);
      // int stuff = bread.BreadModifier(breadNumber);
      // Console.WriteLine("this is the bread modifier results " + stuff);
      int numberResponse = bread.AddBread(breadNumber);
      bread.AddBreadPrice(numberResponse);
      Console.WriteLine("this is the total price for the bread order: $" + bread.Price);
      Console.WriteLine("number of breads in bread order object: " + bread.NumberOfBread);
     
      ///////////////////////pastry logic ///////////////////////////
      Console.WriteLine("how many orders of pastry would you like?");
      string pastryResponse = Console.ReadLine();
      int pastryNumber = int.Parse(pastryResponse);
      int numberResponse2 = pastry.AddPastry(pastryNumber);
      pastry.AddPastryPrice(numberResponse2);
      Console.WriteLine("this is the total price for the pastry order: $" + pastry.Price);
      // Console.WriteLine("number of pastries in pastry object: " + pastry.NumberOfPastries);
      Console.WriteLine("your order total is $" + (pastry.Price + bread.Price) + ".00");

    }
  }
}