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
    Console.WriteLine("Please Enter Your Name to Start Your Order");
    string userName = Console.ReadLine();
    Console.WriteLine("Hello " + userName + "," + " welcome to 'La Boulangerie' bakery!");
    Console.WriteLine("____________________________________________________");
    Console.WriteLine("");
    Console.WriteLine("Please select from our Menu: ");
    Console.WriteLine("Bread: $5each Options: White, Wheat, Multigrain");
    Console.WriteLine("Pastry: $2each Options: Croissant, Eclair, Canele");
    Console.WriteLine("____________________________________________________");
    Console.WriteLine("");
    Console.WriteLine("Current Specials: Bread - Buy 2");

  }
 }
}