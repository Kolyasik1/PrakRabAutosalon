using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma privetstvuet vas!");
            Console.WriteLine("Kak Vas zovut?");
            string MyName = Console.ReadLine();
            Console.WriteLine("Zdravstvuite, " + MyName
            + "! Welcome to system!");
            Console.WriteLine("Vvedite kolichestvo elementov massiva");
            int Num = int.Parse(Console.ReadLine());//Num=2 
            Console.WriteLine("Vvedite elementi massiva:");
            int[] Array = new int[Num];
            for (
            int i = 0; i < Array.Length; i++) //Array.lenght=Num=2 
            {
                Array[i] = int.Parse(Console.ReadLine()); // Массив Array[0]=3 Array[1]=2/ 

            }// foreach(int i in Array);{Console.WriteLine(i); 
             //Console.ReadKey 
            BubbleSort(Array);
            Console.WriteLine("Izmenenniy massiv:");
            foreach (int i in Array)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }
        }
        static int[] BubbleSort(int[] Array)

        {
            int kol = 0; //kol-количество шагов программы

            int Sort;
            for (int i = 0; i < Array.Length; i++) //Принимает первое значение 
            {
                for (int j = i + 1; j < Array.Length; j++) //Принимает второе значение 
                {


                    if (Array[i] > Array[j])
                    {
                        Sort = Array[i];
                        Array[i] = Array[j];
                        Array[j] = Sort;
                        kol++;


                    }

                }

            }
            Console.WriteLine("kolichestvo deistviy: " + kol);//вывод кол-ва действий
            Console.ReadKey();
            return Array;


        }
    }
}
