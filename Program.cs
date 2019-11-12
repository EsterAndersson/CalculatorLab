using System;

namespace Lab1Calculator
{
    class Program
    {

        public static bool isPlaying = true;
        public static Calculator calculator = new Calculator();

        //runs 2 methods until isPlaying isnt true anymore
        static void Main(string[] args)
        {
            do
            {
                PrintAlternatives();
                UserInput();
            } while (isPlaying);
        }

    

        // gets input from user
    private static void UserInput()
    {


        var userInput = Console.ReadLine();


        switch (userInput)
        {
            case "1":
                calculator.FirstNumber = UsersNumber();
                calculator.SecondNumber = UsersNumber();
                Console.WriteLine(calculator.SumNumbers());
                break;
            case "2":
                calculator.FirstNumber = UsersNumber();
                calculator.SecondNumber = UsersNumber();
                Console.WriteLine(calculator.MultiplyNumbers());
                break;
            case "3":
                calculator.FirstNumber = UsersNumber();
                calculator.SecondNumber = UsersNumber();
                Console.WriteLine(calculator.SumInBetween());
                break;
            case "4":
                calculator.NumberInMemory = UsersNumber();
                Console.WriteLine("Number successfully added to memory");
                break;
            case "5":
                calculator = new Calculator();
                Console.WriteLine("Number in memory cleared");
                break;
            case "6":
                Console.WriteLine(calculator.ToString());
                break;
            case "7":
                Console.WriteLine("Goodbye!");
                isPlaying = false;
                break;
            default:
                break;
        }


    }
        //prints out alternatives menu
    private static void PrintAlternatives()
    {
        Console.WriteLine("1.Add two numbers");
        Console.WriteLine("2.Multiply two numbers");
        Console.WriteLine("3.Sum the numbers between two numbers");
        Console.WriteLine("4.Add number to memory");
        Console.WriteLine("5.Clear memory");
        Console.WriteLine("6.Print calculator contents.");
        Console.WriteLine("7.Quit");
        Console.WriteLine("\nChoose an alternative.");
    }

        //asks for a number and converts it to an int, if its a string.
    private static int UsersNumber()
    {
        Console.WriteLine("Write a number:");
        var input = Convert.ToInt32(Console.ReadLine());
        return input;
    }

}

}



  
