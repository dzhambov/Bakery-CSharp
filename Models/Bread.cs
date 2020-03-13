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
      }

    public void BreadPrice(int loafNum)
    { 
      if(loafNum % 3 == 0)
      {
        LoafPrice = (loafNum - (loafNum/3))*5;
      }
      else
      {
        LoafPrice = loafNum * 5;
      }
    } 
  }
}




