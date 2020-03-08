using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
 public class Program
 {
    public static void Main()
    {
      Bread bread = new Bread();
      Pastry pastry = new Pastry();
      Console.ForegroundColor = ConsoleColor.Magenta;
      TypeLine("Please Enter Your Name to Start Your Order");
      string userName = Console.ReadLine().ToUpper();
      TypeLine("Hello " + userName + "," + " welcome to 'La Boulangerie' bakery!");
      TypeLine("----------------------------------------------------");
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      TypeLine("Please select from our Menu: ");
      TypeLine("Bread: $5each or Buy 2 and get 1 FREE");
      TypeLine("Pastry: $2each or Buy 3 for $5");
      TypeLine("----------------------------------------------------");
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      TypeLine("Would you like to order Bread or Pastry?");
      string userOrder = Console.ReadLine().ToLower();
      if(userOrder == "bread")
      {
        TypeLine("How many loafs of bread would you like?");
        string loafQuont = Console.ReadLine();
        int loafNum = int.Parse(loafQuont);
        TypeLine($"Bread order summary: Total number of bread(s): {loafNum} Price: $");
      }else if(userOrder == "pastry")
      {
        TypeLine("How many of the pasties would you like?");
        string pastryQuont = Console.ReadLine();
        int pastryNum = int.Parse(pastryQuont);
        TypeLine($"Pastry order summary: Total number of pastr(y/ies): {pastryNum} Price: $");
      }
      else
      {
        TypeLine("Please select an item that is on the menu!");
      }
    }

    public static void TypeLine(string input)
    {
      for (int i = 0; i < input.Length; i++)
      {
          Console.Write(input[i]);
          System.Threading.Thread.Sleep(25);
      }
      Console.Write(Environment.NewLine);
      Console.Write(Environment.NewLine);
    }
 }
}