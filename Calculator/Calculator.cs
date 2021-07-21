using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        double number_1 { get; set; }
        double number_2 { get; set; }
        double result { get; set; }

        public virtual double Sum(double number_1, double number_2)
        {
            return number_1 + number_2;
        }

        public virtual double Sub(double number_1, double number_2)
        {
            return number_1 - number_2;
        }

        public virtual double Multi(double number_1, double number_2)
        {
            return number_1 * number_2;
        }

        public virtual double Div(double number_1, double number_2)
        {
            double result = default;
            try
            {
                result = number_1 / number_2;
                return result;
            } catch
            {
                Console.WriteLine("Вы попытались разделить число на 0! Так нельзя!");
                return default;
            }
        }

        public virtual void Save(double result)
        {
            this.result = result;
        }

        public virtual double ReturnResult()
        {
            return this.result;
        }
    }
}
