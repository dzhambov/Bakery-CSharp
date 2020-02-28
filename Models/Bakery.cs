using System;

namespace Bakery.Models 
{

  public class Bread
  {
    public string LoafKind { get; set; }
    public int LoafNum { get; set; }
    public int LoafPrice { get; set; }
    
  public Bread ( string LoafKind, int LoafNum, int LoafPrice )
  {
    LoafKind = loafKind;
    LoafNum = loafNum;
    LoafPrice = loafPrice;

    public string AddLoaf(string loafKind)
    {
      if(loafKind == "white")
      {
        LoafKind = "white";
        return 0;
      }
      else if (loafKind == "weath")
      {
        LoafKind = "weath";
        return 1;
      }
      else if (loafKind == "multigrain")
      {
        LoafKind = "multigrain";
        return 2;
      }
    }

    // public int AddNum(int num)
    // {
      
    // }
  }
  }


  public class Pastry
  {

  }
}


