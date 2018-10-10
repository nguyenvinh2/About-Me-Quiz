using System;

namespace About_Me_Quiz
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("My Name is Vinh");
      //Asks if user wants to play. Exits out of reply is no.
      if (PlayGame())
      {
        Console.WriteLine("Great! Let's get started");
        //Calls up overall method to run game. Also keeps track of number of right answers.
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

      //keeps track of number of right answers by summing up return from Questions() method. Integer input is to assign id to each question. It's not necessarily needed but easier to deal with using an integer.
      int count = Questions(1, questionOne) + Questions(2, questionTwo) + Questions(3, questionThree) + Questions(4, questionFour) +Questions(5, questionFive);

      Console.WriteLine($"You got {count} questions correct out of 5.");
    }

    //method asks if user wants to play game and returns true or false based on yes or no input
    static bool PlayGame()
    {
      string answer;
      //the loop with the catch exception prevents user from submitting empty input and will continue to ask until user inputs something. Same algorithm is used in Questions() method
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
      //samething in PlayGame() method
      while (true)
        try
        {
          Console.WriteLine(questionContent);
          //compares user's reply to stored answer
          string answer = Console.ReadLine();
          output = CheckAnswer(answer, questionNumber);
          break;
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }
      Console.WriteLine(output);
      //returns 1 point if input is correct for summing.
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
      //if user has no input, throws exception to parent methods
      if (answer.Length < 1)
      {
        throw (new Exception("You Didn't Answer the Question!"));
      }
      //matches user input to correct answer and returns either "Correct" or "Incorrect"
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
