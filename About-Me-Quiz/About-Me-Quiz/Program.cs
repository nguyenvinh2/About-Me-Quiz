using System;

namespace About_Me_Quiz
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("Time for a Quiz!");
      Country();
      Console.ReadKey();
    }

    static int Counter(int age)
    {
      return 2;
    }

    static void Country()
    {
      while (true)
        try
        {
          Console.WriteLine("What Country was I born in?");
          string answer = Console.ReadLine();
          CheckAnswer(answer);
          break;
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }

    }
    static string CheckAnswer(string answer)
    {
      if (answer.Length < 1)
      {
        throw (new Exception("You Didn't Answer the Question!"));
      }
      else
      {
        if (answer.ToLower() == "vietnam")
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
