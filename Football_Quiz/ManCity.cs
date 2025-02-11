using System.Formats.Asn1;

class ManchesterCityQuiz
{
     public void ManchesterCity()
  {
    Console.WriteLine("Did Mancity win the treble?");
    string answer5 = Console.ReadLine();
    if (answer5== "Yes")
    {
        Console.WriteLine("That is correct!");
    }
    else if (answer5 == "No")
    {
        Console.WriteLine("That is incorrect!");
    }
    else
     {
        Console.WriteLine("Invalid input. Please answer with a number.");
     }
    
        
    
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Haland");
  }
    }
