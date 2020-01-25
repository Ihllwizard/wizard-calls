using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           
           RandomGenerator generator = new RandomGenerator();    
        int rand = generator.RandomNumber(5, 100);    
        Console.WriteLine($"Random number between 5 and 100 is {rand}");    
    
        string str = generator.RandomString(10, false);    
        Console.WriteLine($"Random string of 10 chars is {str}");    
    
        string pass = generator.RandomPassword();    
        Console.WriteLine($"Random string of 6 chars is {pass}");    
    
        Console.ReadKey();
        }
    }
}
