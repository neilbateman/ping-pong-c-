using System;
using System.Collections.Generic;

namespace PingPong
{
  public class TestNumber
  {
      static void Main()
      {
        TestNumber newTestNumber = new TestNumber();
        Console.WriteLine("Enter a number: ");
        int userInput = int.Parse(console.ReadLine());

        for(int i = 0; i <= userInput; i++)
        {
          Console.WriteLine(newTestNumber.IsTestNumber(i));
        }
      }


    public string IsTestNumber(int number)
        {
          string output;
          if (number % 3 == 0) && (number %5 == 0))
          {
            output = "PingPong";
            return output;
          }
          else  if(number % 3 == 0)
          {
            output = "Ping";
            return output;
          }
          else  if(number % 5 == 0)
          {
            output = "Pong";
            return output;
          }
          output = number.ToString();
          return output;
        }
      }
    }
