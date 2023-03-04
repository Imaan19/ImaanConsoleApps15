using System;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.Helpers;

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

        public static BMI BMI
        {
            get => default;
            set
            {
            }
        }

        public static DistanceConverter DistanceConverter
        {
            get => default;
            set
            {
            }
        }

        public static void Main(string[] args)
        {
            BMI calculator = new BMI();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            string[] menu = new string[2];
            menu[0] = " Distance Converter";
            menu[1] = " BMI Calculator";
            int choice = ConsoleHelper.SelectChoice(menu);
            Console.WriteLine();

            if (choice == 1)
            {
                converter.ConvertDistance();
            }
            else if (choice == 2)
            {
                calculator.CalculateIndex();
            }
            else
            {
                Console.WriteLine(" Invalid Choice !");
            }

        }
    }
}
