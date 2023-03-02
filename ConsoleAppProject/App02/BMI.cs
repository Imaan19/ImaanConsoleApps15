using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Welcome to my BMI Calculator. 
    /// This Application will give you the option to choose from 
    /// using Metric or Imperial units to calculate your BMI value,
    /// and output a BAME and Health message depending on your BMI.
    /// </summary>
    /// <author>
    /// Imaan Majid version 0.1
    /// </author>
    public class BMI
    {
        public const double Underweight = 18.50;
        public const double Normal = 24.9;
        public const double Overweight = 29.9;
        public const double ObeseLevelI = 34.9;
        public const double ObeseLevelII = 39.9;
        public const double ObeseLevelIII = 40.0;

        public const int InchesinFeet = 12;
        public const int PoundsinStones = 14;

        public double Index { get; set; }

        // Metric Details

        public double Kilograms { get; set; }
        public double Metres { get; set; }

        // Imperial Details

        public int Stones { get; set; }
        public int Pounds { get; set; }
        public int Feet { get; set; }
        public int Inches { get; set; }

        public enum UnitSystems
        {
            Metric, Imperial 
        }
        public bool BameMessage { get; private set; }

        private double metres;

        /// <summary>
        /// Prompt the user to select Imperial or Metric units.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception> 
        /// 

        public void CalculateIndex()
        {
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");

            UnitSystems unitSystem = SelectUnits();

            if (unitSystem == UnitSystems.Metric)
            {
                InputMetricDetails();
                CalculateMetricBMI();
            }
            else
            {
                InputImperialDetails();
                CalculateImperialBMI();
            }

            Console.WriteLine(GetHealthMessage());

        }
        // Calculate the metric BMI of the user
        public void CalculateMetricBMI()
        {
            Index = Kilograms / (Metres * Metres);
            GetHealthMessage();
        }

        // Calculate the Imperial BMI of the user
        public void CalculateImperialBMI()
        {
            Inches += Feet * InchesinFeet;
            Pounds += Stones * PoundsinStones;

            Index = (double)Pounds * 703 / (Inches * Inches);
        }

        /// <summary>
        /// Prompt the user to select Imperial or Metric
        /// units for entering their height and weight.
        /// </summary>

        private UnitSystems SelectUnits()
        {
            string[] choices = new string[]
            {
                "Metric Units",
                "Imperial Units"
            };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                return UnitSystems.Metric;
            }
            else return UnitSystems.Imperial;
        }

        /// <summary>
        /// Input the users height in feet and inches
        /// and their weight in stones and pounds.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>

        private void InputImperialDetails()
        {
            Console.WriteLine(" Enter your height to the nearest feet and inches > ");
            Console.WriteLine();

            Feet = (int)ConsoleHelper.InputNumber("\n Enter your height in feet > ");
            Inches = (int)ConsoleHelper.InputNumber(" Enter your height in inches > ");

            Console.WriteLine();
            Console.WriteLine(" Enter your weight to the nearest stones and pounds");
            Console.WriteLine();

            Stones = (int)ConsoleHelper.InputNumber(" Enter your weight in stones > ");
            Pounds = (int)ConsoleHelper.InputNumber(" Enter your weight in pounds > ");
        }

        /// <summary>
        /// Input the users height in metres
        /// and their weight in kilograms. 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>

        private void InputMetricDetails()
        {
            Console.Write(" Enter your height in metres: ");
            Metres = Convert.ToDouble(Console.ReadLine());

            Kilograms = ConsoleHelper.InputNumber(
                " Enter your weight in Kilograms > ");

        }

        /// <summary>
        /// Output the users BMI and their weight 
        /// category from underweight to obese. 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>

        public string GetHealthMessage()
        {
            StringBuilder message = new StringBuilder("\n");

            if (Index < Underweight)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $" You are Underweight! " + $"\n If you are Black, Asian or other minority ethnic groups, you have a higher risk.");

            }
            else if (Index <= Normal)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $" You are Normal! " + $"\n If you are Black, Asian or other minority ethnic groups, you have a higher risk.");
                
            }
            else if (Index <= Overweight)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $" You are Overweight! " + $"\n If you are Black, Asian or other minority ethnic groups, you have a higher risk.");

            }
            else if (Index <= ObeseLevelI)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $" You are Obese Class I! " + $"\n If you are Black, Asian or other minority ethnic groups, you have a higher risk.");

            }
            else if (Index <= ObeseLevelII)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $" You are Obese Level II! " + $"\n If you are Black, Asian or other minority ethnic groups, you have a higher risk.");

            }
            else if (Index <= ObeseLevelIII)
            {
                message.Append($" Your BMI is {Index:0.00}, " +
                    $" You are Obese Level III! " + $"\n If you are Black, Asian or other minority ethnic groups, you have a higher risk.");

            }
            return message.ToString();
        }

        /// <summary>
        /// Output a message for BAME users who 
        /// are at a higher risk.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        /// 
        public string GetBameMessage()
        {
            return "If you are Black, Asian or other minority ethnic groups, you have a higher risk.";
        }
    }

    public class UnitSystems
    {
        public UnitSystems Metric { get; internal set; }
        public UnitSystems Imperial { get; internal set; }
    }

}
