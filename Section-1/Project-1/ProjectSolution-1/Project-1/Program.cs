using System;


namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();                                // Console input & value assignment (string)       
            Console.Write("What is your middle initial? ");
            string middleInitial = Console.ReadLine();
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + middleInitial + " " + lastName;


            Console.Write("What is your height in feet? ");
            int heightFeet = int.Parse(Console.ReadLine());
            Console.Write("What is your remaining height in inches? ");
            double heightInches = double.Parse(Console.ReadLine());
            double totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Are you a citizen? (y/n) ");
            bool isCitizen = Console.ReadLine().ToLower().StartsWith("y");
            bool canVote = isCitizen && age >= 18;


            Console.WriteLine(" ");
            Console.WriteLine("Your name is: " + fullName);
            Console.WriteLine("Your height in centimeters is: " + totalHeightCM);
            Console.WriteLine("You can vote if True: " + canVote);
            Console.WriteLine("**Please press enter to exit**");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ReadLine();


        }
        }
    }