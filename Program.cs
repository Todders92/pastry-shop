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
      Console.WriteLine("hello and welcome to Pierre's Bakery!");
      Console.WriteLine("Below are some of the food items availible");
      Console.WriteLine("---------------------------------------------");
      Console.WriteLine("Bread ------ $5.00 ea or buy 2 or more get one free!");
      Console.WriteLine("Pastry ----- $2.00 ea or 3 for $5.00");
      Console.WriteLine("---------------------------------------------");
      ////////////////////////////////////////////////////////////////////////////
      ////////////////////// ORDERING LOGIC //////////////////////////////////////
      ////////////////////////////////////////////////////////////////////////////
    
      /////////////////////bread logic //////////////////////////
      Console.WriteLine("how many orders of bread would you like?");
      string breadResponse = Console.ReadLine();
      int breadNumber = int.Parse(breadResponse);
      BreadOrder bread = new BreadOrder(breadNumber);
      int cost = bread.AddBreadPrice(breadNumber);
      Console.WriteLine("this is the total price for the bread order: $" + cost);
     
      ///////////////////////pastry logic ///////////////////////////
      // Console.WriteLine("how many orders of pastry would you like?");
      // string pastryResponse = Console.ReadLine();
      // int pastryNumber = int.Parse(pastryResponse);
      // int numberResponse2 = pastry.AddPastry(pastryNumber);
      // pastry.AddPastryPrice(numberResponse2);
      // Console.WriteLine("this is the total price for the pastry order: $" + pastry.Price);
      // Console.WriteLine("your order total is $" + (pastry.Price + bread.NumberOfBread) + ".00");

    }
  }
}