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
        height = float (input(" Enter your height in metres: "))
        weight = float (input(" Enter your weight in kg : "))
        bmi = weight / (height**2)
        if bmi< 18.50:
        print(f", you are Underweight. Your BMI is {bmi} ")
        if bmi >= 18.5 and bmi< 24.9:
        print(f", you are Normal. Your BMI is {bmi} ")
        if bmi >= 25.0 and bmi< 29.9:
        print(f", you are Overweight. Your BMI is {bmi} ")
        if bmi >= 30.0 and bmi< 34.9:
        print(f", you are Obese class I. Your BMI is {bmi} ")
        if bmi >= 35.0 and bmi< 39.9:
        print(f", you are Obese class II. Your BMI is {bmi} ")
        if bmi >= 40.0:
        print(f", you are Obese class III. Your BMI is {bmi} ")
    }
}
