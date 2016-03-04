using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapYears_sumK
{
    class Program
    {

        static void Main(string[] args)
        {

           DateTime year = DateTime.Now;
            int yearNow = year.Year - 2 ;

            for (int i = 0; i < 4; i++)
            {
                if (przestepny(yearNow + i))
                {
                    yearNow = yearNow + i;
                    break;
                }
            }
      


             for (int i = 0; i < 20; i++)
             {
                int year1 = yearNow + (i * 4);
                Console.WriteLine(year1);
             }

             Console.ReadLine();
        }

        private static bool przestepny(int yearNow)
        {
            return ((yearNow % 4 == 0) && (yearNow % 100 != 0)) || (yearNow % 400 == 0);
        }
   
        
    }
}

