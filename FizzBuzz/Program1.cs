using System;

namespace FizzBuzz
{
  class Program1
  {
    static void Main(string[] args)
    {
      int min = 1;
      int max = 20;
      int number;
      bool isNumber;
      do
      {
        Console.WriteLine($"{min}-{max}");
        string numString = Console.ReadLine();
        try
        {
          number = Convert.ToInt32(numString);
          isNumber = true;
        }
        catch (System.FormatException)
        {
          Console.WriteLine("Not a Number");
          number = min - 1;
          isNumber = false;
        }

      } while (!isNumber || (isNumber && !isValid(number, min, max)));

      resolve(number);
    }

    static private bool isValid(int number, int min, int max)
    {
      bool result = true;
      if (number < min || number > max)
      {
        Console.WriteLine("Invalid Number");
        result = false;
      }
      return result;
    }

    static private void resolve(int count)
    {
      for (int i = 1; i <= count; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine($"{i} - FizzBuzz");
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine($"{i} - Fizz");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine($"{i} - Buzz");
        }
        else
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}