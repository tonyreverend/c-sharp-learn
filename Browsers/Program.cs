using System;
using System.Collections.Generic;
using System.Linq;

namespace Browsers
{
    public enum BrowserType
    {
        InternetExplorer,
        Chrome,
        Firefox
    }

    class Program
    {
        /*static void Main(string[] args)
        {
            Browser browser = new Firefox();

            switch(browser.CheckBrowser(browser.GetBrowser()))
            {
                case(true):
                    PrintBrowser(browser.GetBrowser());
                    break;
                default:
                    Console.WriteLine("Don't know on which browser you're!");
                    break;
            }
        }

        public static void PrintBrowser(BrowserType type)
        {
            Console.WriteLine($"You're using the {type} browser!");
        }

        public static void MultipleHelloWorld()
        {
            string hello = "Hello World!";

            int counter = 0;

            do
            {
                Console.WriteLine(hello);
                counter++;
            } while (counter < 3);

            counter = 0;

            while (counter < 3)
            {
                Console.WriteLine(hello);
                counter++;
            }

            counter = 0;

            for (counter = 0; counter < 3; counter++)
            {
                Console.WriteLine(hello);
            }

            string[] hello_array = new string[3];

            for (int i = 0; i < 3; i++)
            {
                hello_array[i] = hello;
            }

            foreach (string hi in hello_array)
            {
                Console.WriteLine(hi);
            }
        }*/
    }
}
