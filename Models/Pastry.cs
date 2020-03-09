using System;
using System.Collections.Generic;

namespace Pastry.Models
{
  public class PastryOrder
  {
    public int NumberOfPastries { get; set; }
    public int Price { get; set; }

    public PastryOrder(int numberOfPastries ,int price)
    {
      NumberOfPastries = numberOfPastries;
      Price = price;
    }
    public int AddPastry(int number)
    {
      NumberOfPastries = number;
      return number*2;
    }
    public void AddPastryPrice(int pastryNumber)
    {
      if(pastryNumber >=3)
      {
        Price += (pastryNumber - 1);
      }
      else
      {
        Price += pastryNumber;
      }
    }
  }
}