using System;

namespace FizzBuzz
{
  class Program
  {
    static void Main(string[] args)
    {
      FizzBuzz prog = new FizzBuzz(1, 30);
      prog.init();
    }
  }
}