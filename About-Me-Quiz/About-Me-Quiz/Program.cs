using System;

namespace About_Me_Quiz
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("My Name is Vinh");
      if (Game() == true)
      {
        Console.WriteLine("Great! Let's get started");
        int[] count = { Country(), City(), Siblings(), Military()};
        Console.ReadKey();
      }
      else
      {
        Console.WriteLine("Sorry to have bothered your time :(. Press any key to exit.");
        Console.ReadKey();
      }
    }
    static void Counter(int questionOne, int questionTwo, int questionThree, int questionFour, int questionFive)
    {
    }

    static bool Game()
    {
      string answer;
      while (true)
      {
        try
        {
          Console.WriteLine("Want answer a few questions? (Yes/No) The topic is about myself.");
          answer = Console.ReadLine();
          CheckAnswer(answer, 0);
          break;
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }
      }
      if (answer.ToLower() == "yes" || answer.ToLower() == "y")
      {
        return true;
      }
      else if (answer.ToLower() == "no" || answer.ToLower() == "n")
      {
        return false;
      }
      else
      {
        Console.WriteLine("Well, that wasn't a yes or a no, but I assume you mean no.");
        return false;
      }
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

    static int Siblings()
    {
      int questionCity = 3;
      string output;
      while (true)
      {
        try
        {
          Console.WriteLine("How many siblings do I have?");
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

    static int Military()
    {
      int questionCity = 4;
      string output;
      while (true)
      {
        try
        {
          Console.WriteLine("What branch of the military did I serve in?");
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
        else if ((answer.ToLower() == "0" || answer.ToLower() == "zero") && questionNumber == 3)
        {
          return "Correct";
        }
        else if (answer.ToLower() == "navy" && questionNumber == 4)
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
