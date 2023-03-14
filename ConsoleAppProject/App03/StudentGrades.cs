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
                "Daniel", "Dylan", "Eric",
                "Georgia", "Hasan", "Hamza",
                "Jack", "Liam", "Shan", "Shamial"
                    };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

        }

        /// <summary>
        /// 
        /// </summary>

        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("      Student Marks   ");
            Console.WriteLine("1. Input marks ");
            Console.WriteLine("2. Output marks ");
            Console.WriteLine("3. Output Stats ");
            Console.WriteLine("4. Output Grade Profile ");

            Console.WriteLine("   Enter your choice: ");
            Console.WriteLine();

            string choice = Console.ReadLine();
            return;
        }
        
        /// <summary>
        /// 
        /// </summary>
        private void InputMarks()
        {
            Console.Write(" Enter the name of the student: ");
            string name = Console.ReadLine();

            Console.Write(" Enter the mark for " + name + ": ");
            int mark = int.Parse(Console.ReadLine());

            Console.WriteLine("Mark " + mark + " added for " + name);
        }

        /// <summary>
        /// 
        /// </summary>
        
        public void OutputMarks()
        {
            Console.WriteLine("Marks:");

            foreach (KeyValuePair<string, int> studentMark in studentMarks)
            {
                Console.WriteLine(studentMark.Key + ": " + studentMark.Value);
            }
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        
        public void CalculateStats()
        {
            double total = 0;

            Minimum = HighestMark;
            Maximum = 0;

            foreach(int mark in Marks)
            {
                total = total + mark;
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
            }
            Mean = total / Marks.Length;
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
        }
    }
}
