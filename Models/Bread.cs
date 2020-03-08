using System;
using System.Collections.Generic;

namespace Bakery.Models 
{

  public class Bread
  {
    public int LoafNum { get; set; }
    public int LoafPrice { get; set; }
    
    public void BreadOrder(int loafNum)
      {
        LoafNum = loafNum;
        LoafPrice = loafNum * 5;
      }

    public void BreadPrice(int loafNum)
    { 
      if(loafNum % 3 == 0)
      {
        LoafPrice = (loafNum * 5)/3;
      }
      else
      {
        LoafPrice = loafNum * 5;
      }
    }
    
  }
}




