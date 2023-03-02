using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will prompt the user to input a distance 
    /// from one unit and it will calculate and output the 
    /// equivalent distance in another unit. 
    /// </summary>
    /// <author>
    /// Imaan Majid version 0.1
    /// </author>
    public class DistanceConverter
    {

        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;



        public const string FEET = "Feet";
        public const string MILES = "Miles";
        public const string METRES = "Metres";
        public double toDistance;
        public double fromDistance;

        public string ToUnit;
        public string fromUnit;

        public double ToDistance { get; set; }
        public int FromDistance { get; set; }

        public DistanceConverter()
        {
            fromUnit = MILES;
            ToUnit = FEET;
        }
        /// <summary>
        /// This method will input the distance measured in either feet,
        /// metres or miles and output the distance in feet, metres or miles.
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("       Distance Converter        ");
            Console.WriteLine("         by Imaan Majid             ");
            Console.WriteLine("-------------------------------\n");
        }
        // Select which unit the user wants to choose
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        // Execute the choice the user would like
        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }
            else
            {
                Console.WriteLine(" Invalid Choice !");
            }
                return null;

        } 

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1.  {FEET}");
            Console.WriteLine($" 2.  {METRES}");
            Console.WriteLine($" 3.  {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Prompt the user to enter the distance they want
        /// Input the distance as a double number
        /// </summary>
 

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }
        private void OutputDistance()
        {
            try
            {
                //doThings
                Console.WriteLine($"\n {fromDistance}  {fromUnit}" +
                $" is {toDistance} {ToUnit}!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Issue with runtime");
                throw ex;
            }
        }
        // Convert Distance from a distance unit to a distance unit
        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please select a from distance unit > ");
            ToUnit = SelectUnit(" Please select a to distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {ToUnit}");

            fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }
        // Calculate Distance
        public void CalculateDistance()
        {
            if (fromUnit == MILES && ToUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && ToUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && ToUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && ToUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == METRES && ToUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == FEET && ToUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
        }
    }
}

