using System;
using System.Collections.Generic;

namespace Bakery.Models 
{

  public class Pastry
  {
    public int PastryNum { get; set; }
    public int PastryPrice { get; set; }
    
    public void PastryOrder(int pastryNum)
      {
        PastryNum = pastryNum;
      }

    public void PastryTotal(int pastryNum)
    { 
      if(pastryNum % 3 == 0)
      {
        PastryPrice = (pastryNum / 3) * 5 + (pastryNum % 3) * 2;
      }
      else
      {
        PastryPrice = pastryNum * 2;
      }
    } 
  }
}




