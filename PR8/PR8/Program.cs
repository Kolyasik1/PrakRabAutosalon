using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma privetstvuet vas!");
            Console.WriteLine("Kak Vas zovut?");
            string MyName = Console.ReadLine();
            Console.WriteLine("Zdravstvuite, " + MyName
            + "! Dobro Pozhalovat'!");
            Console.ReadKey();
            int countRows = GetCountRows();
            int countColumns = GetCountColumns();

            int[,] array = new int[countRows, countColumns];

            array = InputArray(countRows, countColumns);
            ShowArray(array);

            Console.ReadKey();
        }

        static int GetCountRows()
        {
            Console.Write("Vvedite kolichestvo strok = ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int GetCountColumns()
        {
            Console.Write("\nVvedite kolichestvo stolbtsov = ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[,] InputArray(int countRows, int countColumns)
        {
            int[,] array = new int[countRows, countColumns];



            Console.WriteLine();
            for (int i = 0; i < countRows; i++)


            {
                for (int j = 0; j < countColumns; j++)
                {
                    Console.Write("Vvedite elementi massiva =>  ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());


                }


                Console.ReadKey();
            }

            return array;
        }

        static void ShowArray(int[,] array)
        {


            Console.WriteLine("Poluchenniy massiv");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }


                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
