using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");
             Console.Write("What's your name? ");

             string name = Console.ReadLine();
             name = name.ToLower();

             if (name == "alice" || name == "bob") 
             {
                 // 1. wyciagnac pierwsza litere i zrobic ToUpper: firstLetter
                 // 2. wyciagnac do innej zmiennej resztę strina: tail (substring)

                 var firstLetter = name[0].ToString().ToUpper();
                 var tail = name.Substring(1);

                 Console.WriteLine("Hello " + firstLetter + tail);
             }
             else
             {
                 Console.WriteLine("it is not for you!");
             }

             Console.ReadLine(); 
             */




            /* Console.Write("Give me your number: ");

             string number = Console.ReadLine();
             int num = int.Parse(number);
             int sum = 0;


                 for (int i = 3; i <= num ; i++) 
                 {
                     if ((i % 3 == 0) || (i % 5 == 0))
                     {
                         sum = sum + i;
                     }
                 }

                 Console.WriteLine("the sum is: " + sum);
                 Console.ReadLine();
                */



            Console.Write("What is your number? :");
            string number = Console.ReadLine();
            int num = int.Parse(number);

            Console.Write("choose sum or a product of 1 to your number?");
            string a = Console.ReadLine();
            int sum = 0;
            int product = 0;

            if (a == "sum")
            {
                for (int i = 1; i <= num; i++) 
                {
                    sum = sum + i;
                }
                Console.WriteLine(sum);
            }
        
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    product = num * i;
                }
                Console.WriteLine(product);
            }
            
            Console.ReadLine();
      

            

            }
          
    }
}
