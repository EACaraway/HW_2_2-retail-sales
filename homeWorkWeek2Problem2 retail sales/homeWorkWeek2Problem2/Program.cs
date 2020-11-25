using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkWeek2Problem2
{
    class Program
    {
                                                                 // Evan Caraway, Srinivas Reddy Doma, Kipack Jeong
        static void Main(string[] args)
        {
            Console.Write("Enter retail price: ");               // ask the user to enter price.
            
            string price = Console.ReadLine();                   // read user input and store to price.
            
            decimal retailPrice = Convert.ToDecimal(price);      // convert string price to decimal.
            decimal salesTaxRate = .09m;                         // Bremerton local tax .025 + WA state tax .065 = .090
            decimal salesTax = retailPrice * salesTaxRate;
            decimal totalSale = retailPrice + salesTax;
            Console.WriteLine($"Retail Price: {retailPrice:c}"); // The "C" (or currency) format specifier is used to convert a number to a string representing a currency amount.
            Console.WriteLine($"Sales Tax:    {salesTax:c}");
            Console.WriteLine($"Total Sale:   {totalSale:c}");
        }
    }
}
