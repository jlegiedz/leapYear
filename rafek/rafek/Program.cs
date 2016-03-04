using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rafek
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, decimal>();

            StreamReader myReader = new StreamReader("projektRafek.txt");
            string line = "";
            string category = "";
            decimal value = 0;

            while (line != null)
            {
                line = myReader.ReadLine();

                if (line != null)
                {
                    value = decimal.Parse(line.Split('|')[1]);
                    category = line.Split('|')[0].Trim();

                    
                    if (dict.ContainsKey(category))
                    {
                        dict[category] = dict[category] + value;
                    }
                    else
                    {
                        dict.Add(category, value);
                    }

                    

                }
            }

            myReader.Close();

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }







            Console.Write("Expense category: ");

            string expenseCategory = Console.ReadLine();
        
            Console.Write("Expense amount: ");

            string expenseAmount = Console.ReadLine();

            //var Decimal = decimal.Parse(expenseAmount);

            decimal expenseAmountDec;

            while (!decimal.TryParse(expenseAmount, out expenseAmountDec))
            {
                Console.WriteLine(expenseAmount + " is not a number. Try again.");
                Console.Write("Expense amount: ");
                expenseAmount = Console.ReadLine();
            }
           
   
            using (StreamWriter writer = new StreamWriter("projektRafek.txt", true))
            {
                writer.WriteLine(expenseCategory + "|" + expenseAmount + "|" + DateTime.Now.ToShortDateString());

            }

          

            

            

            
            

        
        }
    }
}
