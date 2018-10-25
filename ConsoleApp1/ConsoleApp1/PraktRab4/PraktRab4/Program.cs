using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktRab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Programm!");
            Console.WriteLine("Please,tell me your name");
            string MyName = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + MyName
                + "! I'll try to do my best!");
            int FirstNumber, SecondNumber;
            Console.WriteLine("Enter the FirstNumber,please");
            FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the SecondNumber,please");
            SecondNumber = int.Parse(Console.ReadLine());

            do
            {
                FirstNumber++;

            }
            while (FirstNumber <= 1000);
            do
            {
                SecondNumber++;
            }
            while (SecondNumber <= 1000);
            int Step = Convert.ToInt32(FirstNumber + SecondNumber);
            do
            {
                Step++;

            } while (Step <= 1000);
            Console.WriteLine(Step);
            Console.ReadLine();

        }
    }
}
