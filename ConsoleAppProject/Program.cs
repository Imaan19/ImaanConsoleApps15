using System;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Imaan Majid 22/02/2023
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();

        private static BMI Calculator = new BMI();
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            Console.WriteLine("1. Distance Converter");
            Console.WriteLine("2. BMI Calculator");
            Console.WriteLine();

            Console.Write(" Please enter your choice of App > ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                converter.ConvertDistance();
            }
            else if (choice == "2")
            {
                Calculator.CalculateIndex();
            }
            else
            {
                Console.WriteLine(" Invalid Choice !");
            }
        }
    }
}
