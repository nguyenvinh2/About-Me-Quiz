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
        Counter();
        Console.ReadKey();
      }
      else
      {
        Console.WriteLine("Sorry to have bothered your time :(. Press any key to exit.");
        Console.ReadKey();
      }
    }
    static void Counter()
    {
      string questionOne = "What Country was I born in?";
      string questionTwo = "What city did I grow up in?";
      string questionThree = "How many siblings do I have?";
      string questionFour = "What branch of the military did I serve in?";
      string questionFive = "How much money have I lost in Vegas?";

      int count = Questions(1, questionOne) + Questions(2, questionTwo) + Questions(3, questionThree) + Questions(4, questionFour) +Questions(5, questionFive);

      Console.WriteLine($"You got {count} questions correct out of 5.");
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

    static int Questions(int questionNumber, string questionContent)
    {
      string output;
      while (true)
        try
        {
          Console.WriteLine(questionContent);
          string answer = Console.ReadLine();
          output = CheckAnswer(answer, questionNumber);
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
        else if ((answer == "0" || answer.ToLower() == "zero") && questionNumber == 3)
        {
          return "Correct";
        }
        else if (answer.ToLower() == "navy" && questionNumber == 4)
        {
          return "Correct";
        }
        else if ((answer.ToLower() == "2000" || answer == "2,000" || answer == "$2,000" || answer == "$2000") && questionNumber == 5)
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
