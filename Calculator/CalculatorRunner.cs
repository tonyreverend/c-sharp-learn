using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorRunner
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Добро пожаловать в Calculator Simulator!\n ");
            Console.WriteLine($"Запуск Calculator: ");

            Calculator calc = new Calculator();
            var div_result = calc.Div(10.0, 0);
            calc.Save(div_result);
            div_result = calc.Div(50.0, 17.6);

            Console.WriteLine($"Результат вычислений: {div_result}");
            Console.WriteLine($"Сохранено в памяти: {calc.ReturnResult()}\n");


            Console.WriteLine($"Запуск StringMathCalculator: ");

            StringMathCalculator mathCalc = new StringMathCalculator();
            Console.WriteLine("Введите строку для вычисления в формате 2,0+2,0: ");
            string math_user_input = Console.ReadLine();
            var stringMathHandledSumResult = Convert.ToDouble(mathCalc.StringInputHandler(math_user_input));
            mathCalc.Save(stringMathHandledSumResult);

            Console.WriteLine($"\nРезультат вычислений: {stringMathHandledSumResult}");
            Console.WriteLine($"Сохранено в памяти: {mathCalc.ReturnResult()}\n");

            Console.WriteLine($"Запуск StringLingvoCalculator: ");

            StringLingvoCalculator lingvoCalc = new StringLingvoCalculator();
            Console.WriteLine("Введите строку для вычисления в формате 2+2: ");
            string lingvo_user_input = Console.ReadLine();
            var stringLingvoHandledSumResult = Convert.ToDouble(lingvoCalc.StringInputHandler(lingvo_user_input));
            lingvoCalc.Save(stringLingvoHandledSumResult);

            Console.WriteLine($"\nРезультат вычислений: {stringLingvoHandledSumResult}");
            Console.WriteLine($"Сохранено в памяти: {lingvoCalc.ReturnResult()}\n");
        }
    }
}
