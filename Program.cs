using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean doAgain = true;
            bool repeat = true;

            while (doAgain)
            {
                Console.WriteLine(repeat);
                roomCalcs();
                doAgain = goAgain(repeat);
                Console.WriteLine(repeat);
            }
        }
        public static void roomCalcs()
        {
            float roomLength = 0;
            float roomWidth = 0;
            float roomHeight = 0;

            //Console.Clear();
            Console.WriteLine("Welcome to Grand Circus' Room detail Generator!\n\n");
            Console.Write("Enter room length: ");
            roomLength = float.Parse(Console.ReadLine());
            Console.Write("Enter room width: ");
            roomWidth = float.Parse(Console.ReadLine());
            Console.Write("Enter room height: ");
            roomHeight = float.Parse(Console.ReadLine());

            Console.WriteLine("\nArea: " + roomLength * roomWidth + " square feet");
            Console.WriteLine("Perimeter: " + (2 * (roomLength + roomWidth)) + " feet");
            Console.WriteLine("Volume: " + roomLength * roomWidth * roomHeight + " cubic feet\n");

            return;
        }
        public static Boolean goAgain(Boolean repeat)
        {
            bool cont = false;
            bool returnValue = false;
            while (!cont)
            {
                Console.Write("Continue? (y/n): ");
                string inputYN = Console.ReadLine();
                if (inputYN == "N" || inputYN == "n")
                {
                    cont = true;
                    returnValue = false;
                    Console.WriteLine(returnValue);
                }
                else if (inputYN == "Y" || inputYN == "y")
                {
                    cont = true;
                    returnValue = true;
                }
                else
                {
                    Console.WriteLine("Please answer Y/y or N/n only!");
                }
            }
            Console.WriteLine(returnValue);
            return returnValue;
        }

    }

}

