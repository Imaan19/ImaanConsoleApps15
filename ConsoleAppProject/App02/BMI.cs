using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Welcome to my BMI Calculator. 
    /// This Application will tell you whether or not your Body mass index is good for
    /// your height and weight or not once you type your height in metres and weight in kg.
    /// </summary>
    /// <author>
    /// Imaan Majid version 0.1
    /// </author>
    public class BMI
    {
        private void Run()
        {

            Console.Write(" Enter your weight in (kg): ");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter your height in (m): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = kg / (height * height);
            Console.WriteLine(" Your BMI is: " + Math.Round(BMI, 2));
            Console.ReadKey();

            if (BMI < 18.50)
            {
                Console.WriteLine(" You are Underweight ");
            }
            else if (BMI >= 18.5 && BMI < 24.9)
            {
                Console.WriteLine(" You are Normal ");
            }
            else if (BMI >= 25.0 && BMI < 29.9)
            {
                Console.WriteLine(" You are Overweight ");
            }
            else if (BMI >= 30.0 && BMI < 34.9)
            {
                Console.WriteLine(" You are Obese class I ");
            }
            else if (BMI >= 35.0 && BMI < 39.9)
            {
                Console.WriteLine(" You are Obese class II ");
            }
            else if (BMI >= 40.0)
            {
                Console.WriteLine(" You are Obese class III ");
            }
            /// <summary>
            /// If BMI is < 18.50, You are Underweight
            /// If BMI is >= 18.5 and < 24.9, You are Normal
            /// If BMI is >= 25.0 and < 29.9, You are Overweight
            /// If BMI is >= 30.0 and < 34.9, You are Obese class I
            /// If BMI is >= 35.0 and < 39.9, You are Obese class II
            /// If BMI is >= 40.0, You are Obese class III
            /// </summary>
            {
                OutputBameMessage();
            }


            /// <summary>
            /// Output a message for BAME users who are
            /// at higher risk
            /// </summary>

            private void OutputBameMessage()
            {
                Console.WriteLine();
                Console.WriteLine(" If you are Black, Asian or other minority");
                Console.WriteLine(" ethnic groups, you have a higher risk");
                Console.WriteLine();
                Console.WriteLine("\t Adults 23.0 or more are at increased risk");
                Console.WriteLine("\t Adults 27.5 or more are at high risk");
                Console.WriteLine();

                public double InputNumber(string prompt)
                {
                    Console.Write(prompt);
                    string value = Console.ReadLine();
                    double number = Convert.ToDouble(value);

                    return number;
                }
            }
        }
    }
}
