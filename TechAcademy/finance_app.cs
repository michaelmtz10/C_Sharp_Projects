using System;


namespace myConsoleProject
{
    class Program
    {
        static void Main()
        {
            double total; // create total for rate by hour
            double total2;
            double amount;
            double hours;
            int year = 52; // assigned var to amount of weeks in year
            Console.WriteLine("Welcome to the \"Anonymous Income Comaparison Program\"!"); // create interaction
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is your hourly rate?");
            amount = Convert.ToDouble(Console.ReadLine()); // convert to double in case input format differs
            Console.WriteLine("How many do you work a week?");
            hours = Convert.ToDouble(Console.ReadLine());
            total = year * amount * hours; // multiply 52 by amount by num of hours
            Console.WriteLine("Annual salary for person 1 :{0}!", total);
            Console.WriteLine("Now person 2!");
            Console.WriteLine("Person 2:");
            Console.WriteLine("What is your hourly rate?");
            amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many hours do you work a week?");
            hours = Convert.ToDouble(Console.ReadLine());
            total2 = year * amount * hours;
            Console.WriteLine("Annual salary for person 2: {0}", total2);
            Console.WriteLine("Does person 1 make more money than person 2?");
            bool result = total > total2; // check to see wether p1 made more than p2
            Console.WriteLine("The answer is.... {0}", result);
            Console.Read();

        }
    }
}
