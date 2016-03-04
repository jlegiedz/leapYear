using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* zadanie2_strings */

            int[] array = new int[] { 1, 2, 3, 4, 5 };

            for (int i = array.Length-1; i >= 0; i--) 
            {
                Console.Write(array[i]+ " ");
            }
            Console.ReadLine();

        }
    }
}
