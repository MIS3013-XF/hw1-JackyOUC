// HW1a Sales Total

// Your Name:Jacky Chen
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1;
            double num2;
            double sum;
            double salesSum;
            double total;
            const double salesTax = 8.5;
            string item;
            string num1AsString;
            string num2AsString;

            Console.WriteLine("What Item are you Purchasing");
            item = Console.ReadLine();
            Console.WriteLine("How many " + item +"'s would you like to purchase: ");
            num1AsString = Console.ReadLine();
            Console.WriteLine("What is the Cost");
            num2AsString = Console.ReadLine();

           
            num1 = Convert.ToDouble(num1AsString);
            num2 = Convert.ToDouble(num2AsString);
            sum = num1 * num2;
            salesSum = sum * salesTax;
            Console.WriteLine("Subtotal: " + sum.ToString("N2"));
            Console.WriteLine("Sales Tax: " + salesSum.ToString("N2"));
            total = sum + salesSum;
            Console.WriteLine("Total: " + total.ToString("N2"));
            Console.ReadLine();
        }
    }
}
