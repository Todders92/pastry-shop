using System;
using System.Collections.Generic;

namespace Bread.Models
{
  public class BreadOrder
  {
    public int BreadPrice { get; set; }

    public BreadOrder(int breadPrice)
    {
      BreadPrice = breadPrice;
    }
    public int AddBreadPrice(int breadNumber)
    {
      BreadPrice = (breadNumber - (breadNumber / 3)) * 5;
      return BreadPrice;
    }
  }
}