using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class StringMathCalculator : Calculator
    {
        public virtual string StringInputHandler(string input)
        {
            try
            {
                double number_1 = Convert.ToDouble(input.Substring(0, input.IndexOf('+')));
                double number_2 = Convert.ToDouble(input.Substring(input.IndexOf('+') + 1));

                double result = number_1 + number_2;

                Console.WriteLine($"\"{number_1}+{number_2}\"->\"{result}\"");
                return result.ToString();
            } catch (System.FormatException)
            {
                Console.WriteLine("Разработанный StringMathCalculator на данный момент умеет работать лишь с числами формата double!");
                return "error";
            }
        }
    }
}
