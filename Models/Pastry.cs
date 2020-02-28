using System;
using System.Collections.Generic;

namespace Pastry.Models
{
  public class Pastry
  {
  public class PastryOrder
    {
      public int NumberOfPastries { get; set; }
      public int Price { get; set; }

      public PastryOrder(int numberOfPastries, int price)
      {
        NumberOfPastries = numberOfPastries;
        Price = price;
      }




    }
  }
}