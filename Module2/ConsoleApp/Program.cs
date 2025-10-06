/* 
Author: Lauren Holmgren
Date: 10/05/2025
Assignment: PA2
*/
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            #region Task2 Part 1
            int myInt = int.MaxValue;
            Console.WriteLine("Task2 Part 1");
            Console.WriteLine($"Max int: {myInt}");
            Console.WriteLine($"in hex: {myInt:X}\n");

            //outputs what is stored after max int is increased by 1
            myInt++;
            Console.WriteLine($"After increment: {myInt}");
            Console.WriteLine($"in hex: {myInt:X}\n");

            myInt = 0;
            Console.WriteLine($"Set to 0: {myInt}");
            Console.WriteLine($"in hex: {myInt:X}\n");

            //ouputs what is stored after 0 is decremented by 1
            myInt--;
            Console.WriteLine($"After decrement: {myInt}");
            Console.WriteLine($"in hex: {myInt:X}\n");
            #endregion

            #region Casting
            myInt = int.MaxValue;
            //casting an int to a short retains least significant bits
            short myShort = (short)myInt;
            Console.WriteLine("Casting");
            Console.WriteLine($"myInt: {myInt}");
            Console.WriteLine($"in hex: {myInt:X}\n");
            Console.WriteLine($"myShort: {myShort}");
            Console.WriteLine($"in hex: {myShort:X}\n");
            #endregion

            #region Loops
            //outputs the numbers 0-4 in an array

            Console.WriteLine("Loops");

            int[] myArray = new int[5];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }
            
            foreach (int i in myArray)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            #endregion

            #region Loop bonus
            //outputs the multiplication table up to 5x5

            Console.WriteLine("\nMultiplication table");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"\t{i}");
            }
            Console.WriteLine("\n--------------------------------------------");
            for (int row = 1; row <= 5; row++)
            {
                Console.Write($"{row} |");
                for (int column = 1; column <= 5; column++)
                {
                    Console.Write($"\t{row*column}");
                }
                Console.WriteLine();
            }
            #endregion

            #region Printer troubleshooter
            //suggests troubleshooting options based on the printer conditions the user inputs

            Console.WriteLine("\nPrinter troubleshooter");

            String condition = "";
            Console.Write("Does the printer print (Y/N)?: ");
            condition += Console.ReadLine().Trim().ToUpper();
            Console.Write("Is there a flashing red light (Y/N)?: ");
            condition += Console.ReadLine().Trim().ToUpper();
            Console.Write("Is the printer recognized by the computer (Y/N)?: ");
            condition += Console.ReadLine().Trim().ToUpper();
            Console.WriteLine();

            switch (condition)
            {
                case "NYN":
                    Console.WriteLine("Check the printer-computer cable");
                    Console.WriteLine("Ensure printer software is installed");
                    Console.WriteLine("Check/replace ink");
                    break;
                case "NYY":
                    Console.WriteLine("Check/replace ink");
                    Console.WriteLine("Check for paper jam");
                    break;
                case "NNN":
                    Console.WriteLine("Check the power cable");
                    Console.WriteLine("Check the printer-computer cable");
                    Console.WriteLine("Ensure printer software is installed");
                    break;
                case "NNY":
                    Console.WriteLine("Check for paper jam");
                    break;
                case "YYN":
                    Console.WriteLine("Ensure printer software is installed");
                    break;
                case "YYY":
                    Console.WriteLine("Check/replace ink");
                    break;
                case "YNN":
                    Console.WriteLine("Ensure printer software is installed");
                    break;
                case "YNY":
                    Console.WriteLine("No troubleshooting options available");
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again");
                    break;
            }
            #endregion

            Console.WriteLine();
        }
    }
}
