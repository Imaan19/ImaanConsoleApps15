using System;
using System.Reflection.Metadata.Ecma335;

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
        public string FromUnit;

        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }



        /// <summary>
        /// This method will input the distance measured in miles
        /// calcululate the same distance in feet, and output the
        /// distance in feet.
        /// </summary>


      private void OutputHeading(String prompt)
           {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("       Distance Converter        ");
            Console.WriteLine("         by Imaan Majid             ");
            Console.WriteLine("-------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
           }
      private void InputMiles()
           {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
           }
           

            private void CalculateFeet()
            {
                feet = miles * FEET_IN_MILES;
            }

            private void CalculateMiles()
            {
                miles = feet / FEET_IN_MILES;
            }

            private void CalculateMetres()
            {
                metres = miles * METRES_IN_MILES;
            }

            private void OutputDistance(
                double fromDistance, string fromUnit,
                double toDistance, string toUnit)
            {
                Console.WriteLine($" {fromDistance}  {fromUnit}" +
                    $" is {toDistance} {toUnit}!");
            }
        
        
            public void ConvertDistance()
             {
                OutputHeading($"Converting {FromUnit} to {ToUnit}");

                fromDistance = InputDistance($" Please enter the number of {FromUnit} > ");
                
                //CalculateFeet();

                OutputDistance(fromDistance, FromUnit, toDistance, ToUnit);
             }
            
            /// <summary>
            /// Prompt the user to enter the distance in miles 
            /// Input the miles as a double number
            /// </summary>
            /// 

            private double InputDistance(string prompt)
            {
                   Console.Write(prompt);
                   string value = Console.ReadLine();
                   return Convert.ToDouble(value);
            }
            

            /// <summary>
            /// 
            /// </summary>
            ///
           
            public void ConvertDistance()
            {
                  throw new NotImplementedException();
            }
    }
}
