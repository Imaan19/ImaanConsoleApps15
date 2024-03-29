﻿using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Serialization;
using ConsoleAppProject.Helpers;

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
        // Conversion Constants for Distances
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        public const int METRES_IN_KILOMETRES = 1000;
        public const double FEET_IN_KILOMETRES = 3280.839895;
        public const double MILES_IN_KILOMETRES = 1.609;
        public const int CENTIMETRES_IN_METRES = 100;
        public const int CENTIMETRES_IN_KILOMETRES = 100000;
        public const int CENTIMETRES_IN_MILES = 160935;
        public const double CENTIMETRES_IN_FEET = 30.48;
        public const int METRES_IN_MILIMETRES = 1000;
        public const int MILIMETRES_IN_KILOMETRES = 1000000;
        public const int CENTIMETRES_IN_MILIMETRES = 10;
        public const int MILES_IN_MILIMETRES = 1609350;
        public const double MILIMETRES_IN_FEET = 304.8;


        // Variables for Distances
        public const string FEET = "Feet";
        public const string MILES = "Miles";
        public const string METRES = "Metres";
        public const string KILOMETRES = "Kilometres";
        public const string CENTIMETRES = "Centimetres";
        public const string MILIMETRES = "Milimetres";
        public double toDistance;
        public double fromDistance;

        public string ToUnit;
        public string fromUnit;

        public double ToDistance { get; set; }
        public int FromDistance { get; set; }

        public DistanceUnits DistanceUnits
        {
            get => default;
            set
            {
            }
        }

        public DistanceConverter()
        {
            fromUnit = MILES;
            ToUnit = FEET;
        }
        /// <summary>
        /// This method will input the users choice of 6 
        /// distances and output the users choice of 6 distances. 
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
            else if (choice.Equals("4"))
            {
                return KILOMETRES;
            }
            else if (choice.Equals("5"))
            {
                return CENTIMETRES;
            }
            else if (choice.Equals("6"))
            {
                return MILIMETRES;
            }
            else
            {
                Console.WriteLine(" Invalid Choice !");
            }
                return null;

        }
        // Display choices of distances
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1.  {FEET}");
            Console.WriteLine($" 2.  {METRES}");
            Console.WriteLine($" 3.  {MILES}");
            Console.WriteLine($" 4.  {KILOMETRES}");
            Console.WriteLine($" 5.  {CENTIMETRES}");
            Console.WriteLine($" 6.  {MILIMETRES}");
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
            
            try
            {
                double distance = Convert.ToDouble(value);
                return distance;
            }
            catch (FormatException)
            {
                throw new FormatException(" Error occured. ");
            }
        }
        // Output the Distance the user wants
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

        public void CalculateDistance()
        {
            CalculateDistance(fromUnit);
        }

        // Calculate Distances
        public void CalculateDistance(string fromUnit)
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
            else if (fromUnit == METRES && ToUnit == KILOMETRES)
            {
                toDistance = fromDistance / METRES_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && ToUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_KILOMETRES;
            }
            else if (fromUnit == FEET && ToUnit == KILOMETRES)
            {
                toDistance = fromDistance / FEET_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && ToUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_KILOMETRES;
            }
            else if (fromUnit == MILES && ToUnit == KILOMETRES)
            {
                toDistance = fromDistance * MILES_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && ToUnit == MILES)
            {
                toDistance = fromDistance / MILES_IN_KILOMETRES;
            }
            else if (fromUnit == CENTIMETRES && ToUnit == METRES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == METRES && ToUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == CENTIMETRES && ToUnit == KILOMETRES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && ToUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_KILOMETRES;
            }
            else if (fromUnit == CENTIMETRES && ToUnit == MILES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_MILES;
            }
            else if (fromUnit == MILES && ToUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_MILES;
            }
            else if (fromUnit == CENTIMETRES && ToUnit == FEET)
            {
                toDistance = fromDistance / CENTIMETRES_IN_FEET;
            }
            else if (fromUnit == FEET && ToUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_FEET;
            }
            else if (fromUnit == METRES && ToUnit == MILIMETRES)
            {
                toDistance = fromDistance * METRES_IN_MILIMETRES;
            }
            else if (fromUnit == MILIMETRES && ToUnit == METRES)
            {
                toDistance = fromDistance / METRES_IN_MILIMETRES;
            }
            else if (fromUnit == MILIMETRES && ToUnit == KILOMETRES)
            {
                toDistance = fromDistance / MILIMETRES_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && ToUnit == MILIMETRES)
            {
                toDistance = fromDistance * MILIMETRES_IN_KILOMETRES;
            }
            else if (fromUnit == CENTIMETRES && ToUnit == MILIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_MILIMETRES;
            }
            else if (fromUnit == MILIMETRES && ToUnit == CENTIMETRES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_MILIMETRES;
            }
            else if (fromUnit == MILES && ToUnit == MILIMETRES)
            {
                toDistance = fromDistance * MILES_IN_MILIMETRES;
            }
            else if (fromUnit == MILIMETRES && ToUnit == MILES)
            {
                toDistance = fromDistance / MILES_IN_MILIMETRES;
            }
            else if (fromUnit == MILIMETRES && ToUnit == FEET)
            {
                toDistance = fromDistance / MILIMETRES_IN_FEET;
            }
            else if (fromUnit == FEET && ToUnit == MILIMETRES)
            {
                toDistance = fromDistance * MILIMETRES_IN_FEET;
            }
        }
    }
}

