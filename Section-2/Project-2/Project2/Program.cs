namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Spouse = new Person();

            Person p2 = new Person();
            p2.Spouse = new Person();

            System.Console.WriteLine("[ Enter Information for p1 ]");
            System.Console.WriteLine("");

            p1.PersonInfo();
            p1.SpouseInfo();

            System.Console.WriteLine("");
            System.Console.WriteLine("[ Enter Information for p2 ]");
            System.Console.WriteLine("");

            p2.PersonInfo();
            p2.SpouseInfo();

            System.Console.WriteLine("");
            System.Console.WriteLine("[ Printing Results ]");
            System.Console.WriteLine("");

            p1.PrintNameAndAge();
            p2.PrintNameAndAge();

            System.Console.WriteLine("");
            System.Console.WriteLine("Average Age = " + Person.AverageAge());
            System.Console.Read();
        }
    }
}
