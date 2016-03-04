using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 5;
            numbers[2] = 8;
            numbers[3] = 9;
            numbers[4] = 14;
            
            int[] numbers = new int[] { 2, 8, 9, 4, 8, 2 };
            Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
            */


            /* string[] names = new string[] { "Asia", "Iza", "Jan", "Ola", "Maciek" };

              foreach (string name in names)
              {
                  Console.WriteLine(name);
              }
              Console.ReadLine();
              */

            string zig = "You can teake what you want out of lief" +
                "if you help enought other people get whant they want";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            Console.WriteLine(zigChar);

                Console.ReadLine();
                    }
    }
}
