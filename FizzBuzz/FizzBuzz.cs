using System;

namespace FizzBuzz
{
  class FizzBuzz
  {
    private int min;
    private int max;
    private int number;
    private bool isNumber;

    public FizzBuzz(int min, int max)
    {
      this.min = min;
      this.max = max;
    }
    public void init()
    {
      do
      {
        Console.WriteLine($"{min}-{max}");
        string numString = Console.ReadLine();
        isNumber = int.TryParse(numString, out number);
        if (!isNumber)
        {
          Console.WriteLine("Not a Number");
        }
      } while (!isNumber || (isNumber && !isValid(number, min, max)));
      resolve(number);
    }
    private bool isValid(int number, int min, int max)
    {
      bool result = true;
      if (number < min || number > max)
      {
        Console.WriteLine("Invalid Number");
        result = false;
      }
      return result;
    }
    private void resolve(int count)
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