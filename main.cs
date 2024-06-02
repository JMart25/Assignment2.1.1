using System;

class InchestoCentimeters {
  static void Main(string[] args)
  {
    Console.WriteLine("Enter the length in inches:");
    string input =  Console.ReadLine();

    if(double.TryParse(input, out double inches))
    {
      double centimeters = inches * 2.54;
      Console.WriteLine($"{inches} inches is equal to {centimeters} centimeters.");
    }
  }

  }  