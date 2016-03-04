using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStat
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("would you like to win prize 1, 2 or 3?");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "you won a car";
            else if (userValue == "2")
                message = "you won a cow";
            else if (userValue == "3")
                message="you won a pizza";
            else
                message="sorry you won a toilet paper";

            Console.WriteLine(message);
            Console.ReadLine();


            for (int i = 0; i < length; i++)
            {

            }




            

        }
    }
}
