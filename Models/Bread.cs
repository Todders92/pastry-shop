using System;
using System.Collections.Generic;

namespace Bread.Models
{
  public class BreadOrder
  {
    public int NumberOfBread { get; set; }
    public int Price { get; set; }

    public BreadOrder(int numberOfBread)
    {
      NumberOfBread = numberOfBread;
    }
    public int AddBreadPrice(int breadNumber)
    {
      NumberOfBread = (NumberOfBread - (NumberOfBread / 3)) * 5;
      return NumberOfBread;
    }
  }
}