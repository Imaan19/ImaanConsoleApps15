using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Welcome to my BMI Calculator. 
    /// This Application will tell you whether or not your Body mass index is good for your height and weight or not
    /// once you type your height in metres and weight in kg.
    /// </summary>
    /// <author>
    /// Imaan Majid version 0.1
    /// </author>
    public class BMI
    {
        static void Main(string[] args)
    }

    {
        Console.Write (" Enter your weight in (kg): ");
        double kg = Convert.ToDouble(Console.ReadLine());
        Console.Write (" Enter your height in (m): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double BMI = kg / (height * height);
        Console.WriteLine (" Your BMI is: " + Math.Round(BMI, 2));
        Console.ReadKey();

        if bmi< 18.50:
        Console.WriteLine (" You are Underweight ");
        else
        if bmi >= 18.5 and bmi< 24.9:
        Console.WriteLine (" You are Normal ");
        else
        if bmi >= 25.0 and bmi< 29.9:
        Console.WriteLine (" You are Overweight ");
        else
        if bmi >= 30.0 and bmi< 34.9:
        Console.WriteLine (" You are Obese class I ");
        else
        if bmi >= 35.0 and bmi< 39.9:
        Console.WriteLine (" You are Obese class II ");
        else
        if bmi >= 40.0:
        Console.WriteLine (" You are Obese class III ");

        /// <summary>
        /// If BMI is < 18.50, You are Underweight
        /// If BMI is >= 18.5 and < 24.9, You are Normal
        /// If BMI is >= 25.0 and < 29.9, You are Overweight
        /// If BMI is >= 30.0 and < 34.9, You are Obese class I
        /// If BMI is >= 35.0 and < 39.9, You are Obese class II
        /// If BMI is >= 40.0, You are Obese class III
        /// </summary>

}
