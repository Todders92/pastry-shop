using System;
using System.Collections.Generic;

namespace Pastry.Models
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
    public void AddPastry(int number)
    {
      NumberOfPastries = number;
    }
  }
}