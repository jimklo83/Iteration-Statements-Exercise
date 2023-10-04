using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void CountDown()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void MultiplesThree()
        {
            for (int i = 3; i <= 999; i += 3) 
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualParameters(int num1, int num2) 
        {
            if (num1 == num2) 
            {
                Console.WriteLine($"{num1} and {num2} are equal.");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal.");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num) 
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number.");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number.");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int num) 
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is a positive number.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is a negative number.");
            }
            else 
            {
                Console.WriteLine($"The number is {0}.");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanYouVote() 
        {
            Console.Write("What is your age (in number form)? ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18) 
            {
                Console.WriteLine("Congratulations!!! You are old enough to vote.");
            }
            else
            {
                Console.WriteLine("So sorry... You are not old enough to vote yet...");
            }           
        }

        public static void CanYouVoteTwo() 
        {
            Console.Write("What is your age (in number form)? ");
            string userInput = Console.ReadLine();
            int age;

            if (int.TryParse(userInput, out age) && age >= 18) 
            {
                Console.WriteLine("Congratulations!!! You are old enough to vote.");
            }
            else if (int.TryParse(userInput,out age) && age < 18)
            {
                Console.WriteLine("So sorry... You are not old enough to vote yet...");
            }
            else
            {
                Console.WriteLine("I do not understand your answer.");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InTheRange() 
        {
            Console.Write("Pick a number, any number: ");
            int userNum = int.Parse(Console.ReadLine());

            if(userNum >= -10 && userNum <= 10) 
            {
                Console.WriteLine($"{userNum} is between -10 and 10.");
            }
            else
            {
                Console.WriteLine($"{userNum} is not between -10 and 10.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplyTable() 
        {
            Console.WriteLine("Give me a number to see it's multiplication table: ");
            int multiple = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++) 
            {
                int product = multiple * i;
                Console.WriteLine($"{multiple} x {i} is {product}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            CountDown();
            MultiplesThree();
            EqualParameters(20, 20);
            EvenOrOdd(7);
            PositiveOrNegative(-4);
            CanYouVote();
            CanYouVoteTwo();
            InTheRange();
            MultiplyTable();
        }
    }
}
