using System;

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
                roomCalcs();
                doAgain = goAgain(repeat);
            }
        }

        public static void roomCalcs()
        {
            const int qtyInputs = 3;
            string testString = "start";
            //be sure qty of strings in {} to match value of qtyInputs
            string[] dimension = new string[qtyInputs] {"length", "width", "height"};
            float[] valid = new float[qtyInputs]; 

            Console.Clear();
            Console.WriteLine("Welcome to Grand Circus' Room detail Generator!\n\n");

            for (int i = 0; i<=(qtyInputs-1); i++)
            {
                while (!validFloat(testString))
                {
                    Console.Write($"Please enter a valid {dimension[i]} for your room: ");
                    testString = Console.ReadLine();
                }
                valid[i] = float.Parse(testString);
                testString = "reset";
            }

            Console.WriteLine("\nArea: " + valid[0] * valid[1] + " square feet");
            Console.WriteLine("Perimeter: " + (2 * (valid[0] + valid[1])) + " feet");
            Console.WriteLine("Volume: " + valid[0] * valid[1] * valid[2] + " cubic feet\n");
        }

        public static Boolean validFloat(string x)
        {
            bool answer;
            try
            {
                float.Parse(x);
                answer = true;
            }
            catch
            {
                answer = false;
            }
            return answer;
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
            return returnValue;
        }

    }

}

