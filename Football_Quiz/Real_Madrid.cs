class Real 
{
    public void Madrid()
    {
        Console.WriteLine("Hala Madrid");
        Console.WriteLine("Welcome to the Real Madrid Quiz!");

        Console.WriteLine("Question 1: Who is the all-time top scorer for Real Madrid?");
        Console.WriteLine("a) Cristiano Ronaldo");
        Console.WriteLine("b) Raul");
        Console.WriteLine("c) Karim Benzema");
        Console.WriteLine("d) Alfredo Di Stefano");
        Console.Write("Your answer: ");
        string answer1 = Console.ReadLine();

        if (answer1.ToLower() == "a")
        {
            Console.WriteLine("Correct! Cristiano Ronaldo is the all-time top scorer for Real Madrid.");
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is a) Cristiano Ronaldo.");
        }

        Console.WriteLine();

        Console.WriteLine("Question 2: How many UEFA Champions League titles has Real Madrid won?");
        Console.WriteLine("a) 10");
        Console.WriteLine("b) 12");
        Console.WriteLine("c) 13");
        Console.WriteLine("d) 15");
        Console.Write("Your answer: ");
        string answer2 = Console.ReadLine();

        if (answer2.ToLower() == "c")
        {
            Console.WriteLine("Correct! Real Madrid has won 13 UEFA Champions League titles.");
        }
        else
        {
            Console.WriteLine("Incorrect. The correct answer is c) 13.");
        }

        // Add more questions as needed

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Thank you for taking the Real Madrid Quiz!");
    }
}

    
