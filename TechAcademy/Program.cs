using System;


namespace TechAcademy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            string fname = Console.ReadLine();
            Console.WriteLine("Hello " + fname + " !");
            Console.WriteLine("what course are you on?");
            string coursename = Console.ReadLine();
            Console.WriteLine("You are in the " + coursename + " course!");
            Console.WriteLine("What page number are you on?");
            int coursenum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer " + "\"true\"" + " or " + "\"false\"");
            string answer = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics!");
            string user_response = Console.ReadLine();
            Console.WriteLine("Thank you for sharing!");
            Console.ReadLine();
            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");
            Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
