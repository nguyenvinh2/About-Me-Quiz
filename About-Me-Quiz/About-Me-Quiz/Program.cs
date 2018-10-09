using System;

namespace About_Me_Quiz
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("Time for a Quiz!");
      int[] count = { Country(), City() };
      Console.WriteLine(count[0] + count[1]);
      Console.ReadKey();
    }

    static int Counter(int age)
    {
      return 2;
    }

    static int Country()
    {
      string output;
      int questionCountry = 1;
      while (true)
        try
        {
          Console.WriteLine("What Country was I born in?");
          string answer = Console.ReadLine();
          output = CheckAnswer(answer, questionCountry);
          break;
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }
      Console.WriteLine(output);
      if (output == "Correct")
      {
        return 1;
      }
      else
      {
        return 0;
      }
    }

    static int City()
    {
      int questionCity = 2;
      string output;
      while (true)
      {
        try
        {
          Console.WriteLine("What city did I grow up in?");
          string answer = Console.ReadLine();
          output = CheckAnswer(answer, questionCity);
          break;
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }
      }
      Console.WriteLine(output);
      if (output == "Correct")
      {
        return 1;
      }
      else
      {
        return 0;
      }
    }

    static string CheckAnswer(string answer, int questionNumber)
    {
      if (answer.Length < 1)
      {
        throw (new Exception("You Didn't Answer the Question!"));
      }
      else
      {
        if (answer.ToLower() == "vietnam" && questionNumber == 1)
        {
          return "Correct";
        }
        else if (answer.ToLower() == "seattle" && questionNumber == 2)
        {
          return "Correct";
        }
        else
        {
          return "Incorrect";
        }
      }
    }


  }
}
