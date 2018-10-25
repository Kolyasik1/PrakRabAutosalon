using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to cute little programm! \nLet me know more about you,dear User.Give me some information,please:");
            Console.WriteLine("Name");
            string Name = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("Surname");
            string Surname = Console.ReadLine();
            Console.WriteLine("Middle name");
            string MName = Console.ReadLine();
            Console.WriteLine("Hello, " + Surname + " " + Name + " " + MName + ". Welcome to my world!");
            Console.WriteLine("So,How old are you?");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Are you a Woman or a Man? Choose W or M,please!");
            string Gender = Console.ReadLine();
            switch (Gender)
            {
                case "M":
                    break;
                case "W":
                    break;
                default:
                    do
                    {
                        Console.WriteLine("No no no, you shoul choose m or w!"); Gender = Console.ReadLine();
                    } while (Gender != "M" && Gender != "W");
                    break;
            }
            Console.WriteLine("Where do you study?");
            string PlaceOfStudy = Console.ReadLine();
            Console.WriteLine("What's the name of your group?");
            string Group = Console.ReadLine();
            Console.WriteLine("Ok,what have we here? Let's have a look");
            Console.ReadKey();

            Console.WriteLine(" \n**********************************\n-- USER PROFILE----------*" + "\n**********************************\nFull name: " + Surname + " " + Name + " " + MName + "\nAge: " + Age +
"\nGender: " + Gender + "\nPlace Of Study: " + PlaceOfStudy + "\nGroup: " + Group + "\n**\n**********************************");







            Console.ReadKey();
        }
    }
}