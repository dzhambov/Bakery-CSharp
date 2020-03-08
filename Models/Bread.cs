using System;
using System.Collections.Generic;

namespace Bakery.Models 
{

  public class Bread
  {
    public int LoafNum { get; set; }
    public int LoafPrice { get; set; }
    
    public void BreadOrder(int loafNum, int loafPrice)
      {
        LoafNum = loafNum;
        LoafPrice = loafPrice;
      }
    // public void AddBread(int loafNum)
    // {
    //   return loafNum * 5;
    // }

    // public void BreadPrice(int loafNum)
    // { 

    // }
    
  }
}




