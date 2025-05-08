using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("what is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {firstName}, {firstName} {lastName}.");

        Console.Write("Enter Nummber: ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        int y = 8 ;
        int z = 10;

        if (x > y)
        {
            if (x > y)
            {
                Console.WriteLine("greater than both");
            }
            else if (x > z)
            {
                Console.WriteLine("greater than z");
            }

            else 
            {
                Console.WriteLine("less than both");
            }
        }

        Console.WriteLine("Hey User, Can I Help Determine Yur Grade...");

        Console.Write("Enter your grade: ");
        string gradeFromUser = Console.ReadLine();
        int grade = int.Parse(gradeFromUser);
        string letterGrade;

        if (grade >= 90 && grade <= 100)
        {
            letterGrade = "A";
            Console.WriteLine($"Your  grade is {letterGrade}.");
        }
        else if (grade >= 80 && grade < 90)
        {
            letterGrade = "B";
            Console.WriteLine($"Your  grade is {letterGrade}.");
        }
        else if (grade >= 70 && grade < 80)
        {
            letterGrade = "C";
            Console.WriteLine($"Your  grade is {letterGrade}.");
        }
        else if (grade >= 60 && grade < 70)
        {
            letterGrade = "D";
            Console.WriteLine($"Your  grade is {letterGrade}.");
        }
        else if (grade < 60)
        {
            letterGrade = "F";
            Console.WriteLine($"Your  grade is {letterGrade}.");
        }
        else
        {
            Console.WriteLine("Invalid grade entered.");
        }

        Console.WriteLine("Hello I am Code to Guess the magic number...");

        Random random = new Random();
        int magicNumber = random.Next(1, 10); // Random number between 1 and 10
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("what is the magic number between 1 and 10:");
        while (guess != magicNumber)
        {
            Console.Write("Enter your guess: ");
            string guessFromUser = Console.ReadLine();
            guess = int.Parse(guessFromUser);
            attempts++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
        }
        Console.WriteLine($"Congratulations! You guessed the magic number {magicNumber} in {attempts} attempts.");
        
        List<int> numbers = new List<int>();

            Console.WriteLine("Enter a number (0 to stop):");
            string input = Console.ReadLine();

            while (input != "0")
            {
                int number = Convert.ToInt32(input);
                numbers.Add(number);

                Console.WriteLine("Enter a number (0 to stop):");
                input = Console.ReadLine();
            }

            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            double average = (double)total / numbers.Count;
            int maximum = numbers.Max();
            int smallestPositive = numbers.Where(x => x > 0).Min();

            List<int> sortedNumbers = numbers.OrderBy(x => x).ToList();
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Maximum: {maximum}");
            Console.WriteLine($"Smallest Positive: {smallestPositive}");
            Console.WriteLine("Sorted Numbers: " + string.Join(", ", sortedNumbers));
         static void Main(string[] args)
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);
            DisplayResult(userName, squaredNumber);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"Hello {userName}, the squared number is: {squaredNumber}");
        }

    }
}