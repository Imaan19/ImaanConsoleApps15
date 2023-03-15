using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private IEnumerable<KeyValuePair<string, int>> studentMarks;

        // Properties
        public string[] Students { get; set; }

        public string[] GetAllStudents { get; set; }

        public int[] Marks { get; set; }

        public string[] Grade { get; set; }

        public int[] Stats { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        // Attributes

        /// <summary>
        ///  Student names 
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
                    {
                "Alisha", "Eric", "Haroon",
                "Hasan", "Hamza", "Jack",
                "Lilly", "Liam", "Shaun", "Shannice"
                    };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

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
                    case 3: CalculateStats();
                            OutputStats(); break;

                    case 4: CalculateGradeProfile();
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
        private void InputMarks()
        {
            Console.Write(" Enter the name of the student: ");
            string name = Console.ReadLine();

            Console.Write(" Enter the mark for " + name + ": ");
            int mark = int.Parse(Console.ReadLine());

            Console.WriteLine(" Mark " + mark + " added for " + name);
        }

        /// <summary>
        /// Output all the students name alongside
        /// their marks and grades
        /// </summary>
        
        public void OutputMarks()
        {
            Console.WriteLine("  Marks:");
            Console.WriteLine("  Alisha Mark = 42,  Grade = D");

            foreach (KeyValuePair<string, int> studentMark in studentMarks)
            {
                Console.WriteLine(studentMark.Key + ": " + studentMark.Value);
            }
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
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark < HighestMark)
            {
                return Grades.A;
            }
            return Grades.F;
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

            foreach(int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
                total += mark;
            }

            Mean = total / Marks.Length;
        }

        public void OutputStats()
        {

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
            Grades grade = Grade.X;
            Console.WriteLine();

            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }

            Console.WriteLine();
        }
    }
}
