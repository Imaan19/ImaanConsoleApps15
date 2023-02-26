using System;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class will convert distance units.
    /// </summary>
    /// <author>
    /// Imaan Majid version 0.1
    /// </author>
    public class DistanceConverter
    {

        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public double miles;

        public double feet; 

        public double metres;

        public double ToDistance;
        public double FromDistance;
        

        public string ToUnit;
        public string FromUnit;
       


        /// <summary>
        /// This method will input the distance measured in miles
        /// calcululate the same distance in feet, and output the
        /// distance in feet.
        /// </summary>

        {
            OutputHeading("");
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }


        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("       Distance Converter        ");
            Console.WriteLine("         by Imaan Majid             ");
            Console.WriteLine("-------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }


        /// <summary>
        /// Prompt the user to enter the distance in miles 
        /// Input the miles as a double number
        /// </summary>

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

            private void CalculateMetres()
            {
                
            }


        private void OutputFeet()
            {
                Console.WriteLine(miles + " miles is " + feet + " feet!");
            }

            private void OutputMiles()
            {
                Console.WriteLine(feet + " feet is " + miles + " miles!");
            }

            private void OutputMetres()
            {
                Console.WriteLine(miles + " miles is " + metres + " metres!");
            }
            public void MilesToFeet()
            {
                 OutputHeading(" Converting Miles to Feet");

                 miles = InputDistance(" Please enter the number of miles > ");
                 CalculateFeet();
                 OutputFeet();
            }
            
            public void FeetToMiles()
            {
                   OutputHeading("Converting Feet to Miles");
  
                   feet = InputDistance(" Please enter the number of feet > ");
                   CalculateMiles();
                   OutputMiles();
            }
             
            public void MilesToMetres()
            {
                  OutputHeading("Converting Miles to Metres");

                  miles = InputDistance(" Please enter the number of miles > ");
                  CalculateMetres();
                  OutputMetres();
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
            
            private void CalculateMiles()
            {
                  feet = miles * FEET_IN_MILES;
            }

        public void ConvertDistance()
        {
            throw new NotImplementedException();
        }
    }
}
