using System;
using System.Collections.Generic;

namespace Bread.Models
{
  public class BreadOrder
  {
    public int NumberOfBread { get; set; }
    public int Price { get; set; }

    public BreadOrder(int numberOfBread, int price)
    {
      NumberOfBread = numberOfBread;
      Price = price;
    }
    public int AddBread(int number)
    {
      NumberOfBread = number;
      return number*5;
    }
    public void AddBreadPrice(int breadNumber)
    {
      Price += breadNumber;
    }
    // public int BreadModifier(int bread)
    // {
    //   List<int> breadModifier = new List <int> {};
    //   for (int i = 0; i <=bread; i++)
    //   {
    //     if(bread % 2 == 0)
    //     {
    //      breadModifier.Add(2);
    //       return bread;
    //     }
    //     else 
    //     {
    //       breadModifier.Add(1);
    //       return bread;
    //     }
    //   }
    //   return breadModifier.Count;
    // }
  }
}