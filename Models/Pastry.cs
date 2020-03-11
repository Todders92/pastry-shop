using System;
using System.Collections.Generic;

namespace Pastry.Models
{
  public class PastryOrder
  {
    public int PastryPrice { get; set; }
    
    public PastryOrder(int pastryPrice)
    {
      PastryPrice = pastryPrice;
    }
    public int AddPastryPrice(int pastryNumber)
    {
      PastryPrice =  (pastryNumber / 3) * 5 + (pastryNumber % 3) * 2;
      return PastryPrice;
    }
  }
}