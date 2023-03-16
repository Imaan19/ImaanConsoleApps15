using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
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
        private static StudentGrades grade = new StudentGrades();
        private static studentMarks marks = new studentMarks();

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

        public static StudentGrades StudentGrades
        {
            get => default;
            set
            {
            }
        }

        public static StudentGrades StudentGrades1
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

            string[] menu = new string[3];
            menu[0] = " Distance Converter";
            menu[1] = " BMI Calculator";
            menu[2] = " Student Marks";
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
            else if (choice == 3)
            {
                grade.DisplayChoices();
            }
            else
            {
                Console.WriteLine(" Invalid Choice !");
            }

        }

        private class studentMarks
        {
        }
    }
}
