using System;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Imaan Majid version 0.1
    /// </author>
    public class DistanceConverter
    {

        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet; 

        private double metres;


        /// <summary>
        /// This method will input the distance measured in miles
        /// calcululate the same distance in feet, and output the
        /// distance in feet.
        /// </summary>

        public void Run()
            (
                 OutputHeading();
                 InputMiles();
                 CalculateFeet();
                 OutputFeet();
#            )

        private void OutputHeading()
            (
                 Console.WriteLine("\n-------------------------------");
                 Console.WriteLine("      Convert miles to feet         ");
                 Console.WriteLine("         by Imaan Majid             ");
                 Console.WriteLine("-------------------------------\n");

                 Console.WriteLine(prompt);
                 Console.WriteLine();
            )


        /// <summary>
        /// Prompt the user to enter the distance in miles 
        /// Input the miles as a double number
        /// </summary>

            private void InputMiles()
            (
                Console.Write("Please enter the number of miles > ");
                string value = Console.Readline();
                miles = Convert.ToDouble(value); 
            )

            private void CalculateFeet()
            (
                feet = miles * 5280;
            )

            private void OutputDistance()
            (
                Console.WriteLine(miles + " miles is " + feet + " feet!");
            )


            public void MilesToFeet()
            (
                 OutputHeading(" Converting Miles to Feet");

                 miles = InputDistance(" Please enter the number of miles > ");
                 CalculateFeet();
                 OutputFeet();
            )
            
            public void FeetToMiles()
            (
                   OutputHeading("Converting Feet to Miles");
                   
                   feet = InputDistance(" Please enter the number of feet > ");
                   CalculateMiles();
                   OutputMiles();
            )
            
            public void MilesToMetres()
            (
                   OutputHeading("Converting Miles to Metres");
                   
                   miles = InputDistance(" Please enter the number of miles > ");
                   CalculateMetres();
                   OutputMetres();
            )

            /// <summary>
            /// Prompt the user to enter the distance in miles 
            /// Input the miles as a double number
            /// </summary>
            /// 

            private double InputDistance(string prompt)
            (
                   Console.Write(prompt);
                   string value = Console.ReadLine();
                   return Convert.ToDouble(value);
            )

            /// <summary>
            /// 
            /// </summary>
            
            private void  CalculateFeet()
            (
                  feet = miles * FEET_IN_MILES; 
            )
            
            /// <summary>
            /// 
            /// </summary>
            
                  private void OutputHeading(String prompt)
            (
                 Console.WriteLine("\n-------------------------------");
                 Console.WriteLine("       Distance Converter        ");
                 Console.WriteLine("         by Imaan Majid             ");
                 Console.WriteLine("-------------------------------\n");

                 Console.WriteLine(prompt);
                 Console.WriteLine();
            )
    }
}
