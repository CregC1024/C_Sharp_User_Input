using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // typpe your name and press enter
            Console.WriteLine("Enter user name:");

            // create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            //print the value of the variable (userName), which will display the input value
            Console.WriteLine("User name is: " + userName);
            Console.Read();
        }
    }
}

