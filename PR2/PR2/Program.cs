using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to cute little calculator!");
            Console.WriteLine("What is your name?:)");
            string MyName = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + MyName
                + "! I'll try to help you!");
            Console.ReadKey();

            char again = 'y'; //переменная
            while (again == 'y')//цикл "пока" пользователь не закончит работу с программой
            {
                double a; //Объявленные переменные
                double b;
                double total;
                char oper;
                Console.WriteLine("Enter the First number");
                a = Convert.ToDouble(Console.ReadLine()); //Ввод переменной пользователем
                Console.WriteLine("Choose one operation: + - Addition ; \n - -Subtraction; \n * -Multiplication; \n / -Division.");


                oper = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter the Second number");
                b = Convert.ToDouble(Console.ReadLine());
                if (oper == '+') //оператор выбирает, какое условие будет выполняться. Имеет значение "если, то"
                {
                    total = a + b;
                    Console.WriteLine("Summ of" + a + " and " + b + " = " + total + ".");
                }
                else if (oper == '-') //"Или если, то"
                {
                    total = a - b;

                    Console.WriteLine(" Subtraction " + a + " and " + b + " = " + total + ".");
                }
                else if (oper == '*')
                {
                    total = a * b;

                    Console.WriteLine(" Multiplication " + a + " and " + b + " = " + total + ".");
                }
                else if (oper == '/')
                {
                    total = a / b;

                    Console.WriteLine(" Division " + a + " and " + b + " = " + total + ".");
                }

                else //"Если нет, то..."
                {
                    Console.WriteLine("Sorry, friend, I don't understand you:( Try again,please!");
                }
                {
                    Console.WriteLine("Do you want to continue working with the calculator? y/no ");
                    again = Convert.ToChar(Console.ReadLine());
                    Console.ReadLine();
                }

            }
        }
    }
}