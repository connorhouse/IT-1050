namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Will you be attending a Matinee or Evening Showtime: ");
            string time = System.Console.ReadLine().ToLower();

            if (time != "matinee" & time != "evening")
            {
                System.Console.WriteLine("I do not understand...");
                System.Console.Read();
                return;
            }

            System.Console.WriteLine("Great. How many Adult tickets?:");
            int ticketReg = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("OK, how many Child tickets?:");
            int ticketJr = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Excellent, and how many Senior tickets?:");
            int ticketSr = int.Parse(System.Console.ReadLine());

            decimal totalPrice = 0;

            if (time == "matinee")
            {
                totalPrice += (ticketReg * 5.99m);
                totalPrice += (ticketJr * 3.99m);
                totalPrice += (ticketSr * 4.50m);
            }

            else
            {
                totalPrice += (ticketReg * 10.99m);
                totalPrice += (ticketJr * 6.99m);
                totalPrice += (ticketSr * 8.50m);
            }

            System.Console.WriteLine("Here are your tickets. How many small sodas?");
            int sodaS = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("OK, how many large sodas:");
            int sodaL = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Great, how many hotdogs would you like:");
            int hotDog = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("How many popcorns would you like:");
            int popCorn = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Excellent, and how many Candies?:");
            int candy = int.Parse(System.Console.ReadLine());

            totalPrice += (sodaS * 3.50m);
            totalPrice += (sodaL * 5.99m);
            totalPrice += (hotDog * 3.99m);
            totalPrice += (popCorn * 4.50m);
            totalPrice += (candy * 1.99m);

            int ticketCount = ticketReg + ticketJr + ticketSr;

            int lesserAmount = System.Math.Min(sodaL, popCorn);
            int ticketDiscount = System.Math.Min(lesserAmount, ticketCount);

            if (ticketDiscount >= 1)
            {
                totalPrice -= (ticketDiscount * 2.00m);
            }

            int popcornDiscount = 0;
            if (ticketCount >= 3)
            {
                if (time == "evening")
                {
                    if (popCorn >= 1)
                    {
                        totalPrice -= 4.50m;
                        popcornDiscount = 1;
                    }
                }
            }

            int candyDiscount = candy / 4;
            if (candyDiscount >= 1)
            {
                totalPrice -= (candyDiscount * 1.99m);
            }

            int numberOfDiscounts = ticketDiscount + candyDiscount + popcornDiscount;

            System.Console.WriteLine("You applied for " + numberOfDiscounts + " Discounts!!");
            System.Console.WriteLine("===========================");
            System.Console.WriteLine("Your total cost is: $" + totalPrice);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("...");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Enjoy your movie!");            
            System.Console.ReadKey();
        }
    }
}
