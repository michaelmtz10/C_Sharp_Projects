using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Project
{
    class Program
    {
        static void Main()
        {
            int age; // creating parameters
            bool dui;
            int tickets;
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());  // converting age to int if format incorrect
            Console.WriteLine("Have you ever had a DUI? Please enter, true or false.");
            dui = Convert.ToBoolean(Console.ReadLine()); // converting status to bool
            Console.WriteLine("How many speeding tickets do you have?"); 
            tickets = Convert.ToInt32(Console.ReadLine());
            bool respone = (age > 15 && dui == false && tickets < 3); // creating conditon to determine qualification status
            Console.WriteLine("Qualification Status: {0}.", respone);
            Console.Read();

        }
    }
}
