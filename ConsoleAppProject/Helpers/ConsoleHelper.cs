using System;

namespace ConsoleAppProject.Helpers
{

    /// <summary>
    /// This is a general purpose class containing methods
    /// that can be used by other console based classes.
    /// Methods to input numbers from the user, and ask the
    /// user to select a choice from a list of choices.
    /// There are methods for outputting a main heading
    /// and a title.
    /// <author>
    /// Imaan Majid 2023
    /// </author>
    /// </summary>
    public static class ConsoleHelper
    {

        /// <summary>
        /// This method displays a list of numbered choices to the
        /// user, they can then select a choice and and the choice 
        /// number is returned.  Choices start at 1.
        /// </summary>
        public static int SelectChoice(string[] choices)
        {
            // Display all the choices

            DisplayChoices(choices);

            // Get the user's choice

            int choiceNo = (int)InputNumber("\n Please enter your choice > ", 
                                            1, choices.Length);
            return choiceNo;
        }

        /// <summary>
        /// This displays all the available choices in a numbered
        /// list, starting at 1
        /// </summary>
        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"    {choiceNo}.  {choice}");
            }
        }


        /// <summary>
        /// This method will display a prompt to the user and
        /// will return any number as a double.  Any exception
        /// will generate an error message.
        /// </summary>
        public static double InputNumber(string prompt)
        {
            double number = 0;
            bool isValid = false; // Initialise isValid to false 
            do
            {
                if (number <= 0)
                {
                    Console.Write(prompt);
                    string value = Console.ReadLine();
                    try
                    {
                        //Check for negative values
                        if (value.StartsWith("-"))
                        {
                            Console.WriteLine(" Negative values are not allowed! ");
                            isValid = false;
                        }
                        else
                        {
                            // Convert input string to double 
                            number = Convert.ToDouble(value);
                            isValid = true;
                        }
                    }
                    catch (Exception)
                    {
                        // Handle other exceptions
                        isValid = false;
                        Console.WriteLine(" INAVLID NUMBER! ");
                    }
                }
            } while (!isValid);
            return number;
        }


        /// <summary>
        /// This method will prompt the user to enter a number
        /// between the min and max values includice.
        /// 
        /// Error messages will be displayed for an invalid number
        /// or a number outside the min or max values.
        /// The number returned can be cast as an (int/decimal)
        /// </summary>
        public static double InputNumber(string prompt, double min, double max)
        {
            bool isValid;
            double number;

            do
            {
                number = InputNumber(prompt);

                if (number < min || number > max)
                {
                    isValid = false;
                    Console.WriteLine($"Number must be between {min} and {max}");
                }
                else isValid = true;

            } while (!isValid);

            return number;

        }

        /// <summary>
        /// Output a short heading in green for the application
        /// and the name of the author and a prompt to
        /// inform the use which units are being converted
        /// Please change the authors name.
        /// </summary>
        public static void OutputHeading(string heading)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n ---------------------------------");
            Console.WriteLine($"    {heading}          ");
            Console.WriteLine("         by Imaan Majid           ");
            Console.WriteLine(" ---------------------------------" +
                "\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        /// <summary>
        /// This method will display a green title underlined
        /// by dashes.
        /// </summary>
        public static void OutputTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"\n {title}");
            Console.Write(" ");

            for(int count = 0; count <= title.Length; count++)
            {
                Console.Write("-");
            }

            Console.WriteLine("\n");
            Console.ResetColor();
        }

        public static int DisplayMenu(string[] choices)
        {
            DisplayMenu(choices);
            
            int choiceNo = (int)InputNumber(" Please enter your choice > ",
                                            1, choices.Length);
            return choiceNo;
        }
    }
}
