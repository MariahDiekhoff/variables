using System;

namespace Helloworld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(" Welcome User!");

      // ask the user a questions. 
      Console.WriteLine("How many cups of coffee?");
      // store the results
      // var nameOfVariable = "some value";
      var cupsOfCoffee = Console.ReadLine();

      Console.WriteLine(cupsOfCoffee);

      //fullName
      Console.WriteLine("fullName");

      var fullName = Console.ReadLine();

      Console.WriteLine(fullName);

      //ask user for their name
      Console.WriteLine("What is your name?");
      var user = Console.ReadLine();
      Console.WriteLine(user);

      Console.WriteLine("Today Date");
      var Today = Console.ReadLine();
      Console.WriteLine(Today);

      Console.WriteLine(" Hi my name is " + fullName + " Today's date is " + Today + " I've had " + cupsOfCoffee + " cups of coffee ");


      //ask user for 2 numbers
      Console.WriteLine(" Input two numbers ");
      var numberone = Console.ReadLine();
      var numbertwo = Console.ReadLine();


      var operand1 = double.Parse(numberone);
      var operand2 = double.Parse(numbertwo);

      //creating a sum
      var sum = operand1 + operand2;
      var difference = operand1 - operand2;
      var quotient = operand1 / operand2;
      var product = operand1 * operand2;
      var remainder = operand1 / operand2;

      Console.WriteLine(sum);
      Console.WriteLine(difference);
      Console.WriteLine(quotient);
      Console.WriteLine(product);
      Console.WriteLine(remainder);















    }
  }
}
