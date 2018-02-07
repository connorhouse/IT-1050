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
            Console.Write("How many leftover inches tall are you? ");
            double heightInches = double.Parse(Console.ReadLine());

            double totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Are you a citizen? (y/n) ");
            bool isCitizen = Console.ReadLine().ToLower().StartsWith("y");

            bool canVote = isCitizen && age >= 18;


            Console.WriteLine(" ");
            Console.WriteLine("Your name: " + fullName);
            Console.WriteLine("Your height in CM is: " + totalHeightCM);
            Console.WriteLine("You can vote if true: " + canVote);
            Console.ReadLine();



            }
        }
    }