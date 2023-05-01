using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      // User Input
      Console.WriteLine("Enter amount to convert into coins: ");
      string strTotal = Console.ReadLine();

      // Conversion
      double total = Math.Floor(Convert.ToDouble(strTotal));
      int goldVal = 10;
      int silverVal = 5;
      double goldCoins = Math.Floor(total / goldVal);
      double leftover = total % goldVal;
      double silverCoins = Math.Floor(leftover / silverVal);
      leftover = leftover % silverVal;


      // Explanation to user
      Console.WriteLine($"{strTotal} is equal to...");
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {leftover}");
    }
  }
}
