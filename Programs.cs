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
    Console.WriteLine("Hello " + userName + " welcome to 'Le Pann' bakery!");
  }
 }
}