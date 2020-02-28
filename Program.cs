using System;
using System.Collections.Generic;
using Pastry.Models;

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
      Console.WriteLine("Bread ------ $5.00 ea or buy 2 get on free!");
      Console.WriteLine("Pastry ----- $2.00 ea or 3 for $5.00");
      Console.WriteLine("---------------------------------------------");
      Console.WriteLine("how many orders of bread would you like?");
      string breadResponse = Console.ReadLine();
      Console.WriteLine(breadResponse);
      Console.WriteLine("how many orders of pastry would you like?");
      string pastryResponse = Console.ReadLine();
      int pastryNumber = int.Parse(pastryResponse);
      Console.WriteLine(pastryResponse);
      pastry.AddPastry(pastryNumber);
      Console.WriteLine("number of pastries in pastry object: " + pastry.NumberOfPastries);
    }
  }
}