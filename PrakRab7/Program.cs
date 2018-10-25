using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakRab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, What's your name");
            Console.WriteLine("Как я могу к Вам обращаться?");
            string MyName = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + MyName
            + "! Добро пожаловать в систему!");
            // Задать с клавиатуры число элементов массива
            int n;
            Console.WriteLine("Введите число элементов массива");
            n = Convert.ToInt16(Console.ReadLine());
            // Объявим одномерный массив Data с n-элементами 
            double[] Data = new double[n];
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("Введите элемент массива");
                /* Вводим элементы массива с клавиатуры 
                 * и заполняем ими массив */
                Data[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            // Вывод содержимого массива
            for (i = 0; i < n; i = i + 1)
                Console.WriteLine("Элемент[" + i + "]: " + Data[i]);
            Console.ReadKey();
        }
    }
}
