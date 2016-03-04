using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 3, 6, 9, 2, 5, 1, 8 };

            int max = list[0];

            for (int index = 1; index < list.Length; index++)
            {
                if (list[index] > max)
                {
                    max = list[index];
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();

        }
    }
}
