using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class StringLingvoCalculator : StringMathCalculator
    {
        public override string StringInputHandler(string input)
        {
            try
            {
                string number_1 = input.Substring(0, input.IndexOf('+'));
                string number_2 = input.Substring(input.IndexOf('+') + 1);

                string result = String.Concat(number_1, number_2);

                Console.WriteLine($"\"{number_1}+{number_2}\"->\"{result}\"");
                return result;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Разработанный StringMathCalculator на данный момент умеет работать лишь с числами формата Integer!");
                return "error";
            }
        }
    }
}
