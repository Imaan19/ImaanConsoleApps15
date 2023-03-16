using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        // Grade Boundary Constants

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;
        Dictionary<string, int> studentMarks = new Dictionary<string, int>();
        private bool validInput;
        private bool boolvalidInput;

        // Properties
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public Grades Grades
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Student names 
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
                    {
                "Alisha", "Eric", "Haroon",
                "Hasan", "Hamza", "Jack",
                "Lilly", "Liam", "Shaun", "Sara"
                    };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[10]
                {10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        }

        /// <summary>
        /// Choices option depending on
        /// what the user wants to do
        /// </summary>

        public void DisplayChoices()
        {
            string[] choices =
            {
                "Input Marks",
                "Output Marks",
                "Output Stats",
                "Output Grade Profile"};

            int choiceNo;

            do
            {
                ConsoleHelper.OutputHeading("  Student's Grades App");

                choiceNo = ConsoleHelper.SelectChoice(choices);

                switch (choiceNo)
                {
                    case 1: InputMarks(); break;
                    case 2: OutputMarks(); break;
                    case 3:
                        CalculateStats();
                        OutputStats(); break;

                    case 4:
                        CalculateGradeProfile();
                        OutputGradeProfile(); break;

                    default:
                        break;
                }
            } while (choiceNo != 4);
        }


        /// <summary>
        /// Enter the students name alongside
        /// the students mark to Input it
        /// </summary>
        public void InputMarks()
        {
            for (int i = 0; i < Students.Length; i++)

            {
                bool validInput = false;
                int mark = 0;
                while (!validInput)
                {
                    Console.Write($" Enter mark for {Students[i]}: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out mark))
                    {
                        Console.WriteLine("as");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                Marks[i] = mark;

            }
            Console.WriteLine();
            Console.ReadKey();
        }

        /// <summary>
        /// Output all the students name alongside
        /// their marks and grades
        /// </summary>
        /// 
        public void OutputMarks()
        {
            ConsoleHelper.OutputHeading(" Each students marks ");

            for (int i = 0; i < Students.Length; i++)
            {
                int mark = Marks[i];
                Grades grades = ConvertToGrade(mark);
                Console.WriteLine($"Student Name: {Students[i]} \tStudent Mark: {mark}\t" +
                    $"Student Grade: {grades}\t");
            }
            Console.WriteLine();
            ConsoleHelper.OutputHeading("      Student Marks");
            DisplayChoices();
        }
        /// <summary>
        /// Converting the students marks into grades
        /// </summary>

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark < LowestGradeA)
            {
                return Grades.B;
            }
            else
            {
                return Grades.A;
            }

        }

        /// <summary>
        /// Calculating the minimum and 
        /// maximum stats for each mark
        /// </summary>

        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach (int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
                total += mark;
            }

            Mean = total / Marks.Length;
        }

        public void OutputStats()
        {
            CalculateStats();

            double overallMean = Mean;
            Console.WriteLine($" Mean: {overallMean.ToString("F")}");

            int minimumMark = Minimum;
            Console.WriteLine($" Minimum mark: {minimumMark}");

            int maximumMark = Maximum;
            Console.WriteLine($" Maximum mark: {maximumMark}");
        }

        /// <summary>
        /// 
        /// </summary>

        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

            OutputGradeProfile();
        }

        public void OutputGradeProfile()
        {
            Grades grades = Grades.X;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grades} {percentage}% Count {count}");
                grades++;
            }
        }
    }
}
