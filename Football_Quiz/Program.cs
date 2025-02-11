using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

  

class Manchester
{
  public void UnitedQuiz()
  {
    Console.ForegroundColor = ConsoleColor.DarkRed;
        
        
        Console.WriteLine("Is Man United good or bad in it's curret state?");
        string answer = Console.ReadLine();
        if (answer=="bad")
        {
          Console.WriteLine("You are correct.");
        }
        else if (answer=="good")
        {
            Console.WriteLine("WRONG!!!");
        }
        else
        {
            Console.WriteLine("Invalid input. Please answer with 'good' or 'bad'.");
        }
        
        Console.WriteLine("How many Home League trophies have they won?");
        int answer2 = Convert.ToInt32(Console.ReadLine());
        if (answer2 ==13)
        {
            Console.WriteLine("Correct");
        }
        else if (answer2 !=13)
        {
          Console.WriteLine("That is incorrect.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please answer with a number.");
        }

        Console.WriteLine("Who was the youngester that was David Beckham's replacement?");
        Console.WriteLine("Was it Rooney, Mainoo or Ronaldo?");
        string answer3 = Console.ReadLine();
        if (answer3 == "Ronaldo")
        {
           Console.WriteLine("You are correct!"); 
        }
        else if (answer3 == "Rooney")
        {
          Console.WriteLine("Are you dumb?");
          Console.WriteLine("Yes or No");
          string dumb = Console.ReadLine();
          if (dumb == "Yes")
          {
            Console.WriteLine("At least you can admit it.");
          }
          else if (dumb == "No")
          {
            Console.WriteLine("Yeah sure you aren't.");
          }
          else
          {
            Console.WriteLine("Yeah you are dumb.");
          }
        }
        else if (answer3 == "Mainoo")
        {
            Console.WriteLine("Truth be told I don't know who that is but I do know you're WRONG!");
        }
        else
        {
          Console.WriteLine("Please pick a player's name from what is provided.");  
        }

        Console.WriteLine("Who is currently older. Rooney or Ronaldo?");
        string answer4 = Console.ReadLine();
        if (answer4 == "Ronaldo")
        {
          Console.WriteLine("You are correct.");
        }
        else if (answer4 != "Ronaldo")
        {
          Console.WriteLine("Wrong!");
        }
        
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Congrats on finishing.");
    }
  }

class Program
{
    static void Main(string[] args)
    {
       while (true)
      {
        {
       Console.WriteLine("Do you wish to play? \n yes or no");
       string question = Console.ReadLine();
       if (question == "yes")
      {
        
      {
        
        Console.WriteLine("Welcome to Club Quiz. \nPick a club to get quized on:");
        Console.WriteLine("Press 1 for Liverpool Quiz \nPress 2 for Man United Quiz \nPress 3 for Man City Quiz \nPress 4 for Real Madrid Quiz");
        int number = Convert.ToInt32(Console.ReadLine());

      switch (number)
      {
        case 1: Liverpool liverpool = new Liverpool();
                liverpool.LiverpoolQuiz();
                break;

        case 2: Manchester manchester = new Manchester();
                manchester.UnitedQuiz();
                break;

        case 3: ManchesterCityQuiz mancity = new ManchesterCityQuiz();
                mancity.ManchesterCity();
                break;

       case 4: Real real = new Real();
               real.Madrid();
               break;            

        default: Console.WriteLine("Invalid number.");
                break;
      }

      }
    }
    else if (question == "no")
    {
      Console.WriteLine("You have exited the application.");
      break;
    }
    else
    {
      Console.WriteLine("Please enter a valid answer.");
    }
      }

      }
    }
}
       
  

      