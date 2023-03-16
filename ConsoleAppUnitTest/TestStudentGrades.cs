using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleAppUnitTest
{
    public class StudentGradesTest
    {
        private readonly StudentGrades studentGrades = new StudentGrades();

        private readonly int[] StatsMarks = new int[]
        {
            10, 20, 30, 40, 50, 60, 70, 80, 90, 100
        };
 
        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            // Arrange

            Grades expectedGrade = Grades.F;

            // Act

            Grades actualGrade = studentGrades.ConvertToGrade(0);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            // Arrange

            Grades expectedGrade = Grades.F;

            // Act

            Grades actualGrade = studentGrades.ConvertToGrade(39);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);

            /*
            // Arrange
            Grades expectedGrade = Grades.F;
            int score = 39;

            // Act
            Grades actualGrade;

            if (score >= 90)
            {
                actualGrade = Grades.A;
            }
            else if (score >= 80)
            {
                actualGrade = Grades.B;
            }
            else if (score >= 70)
            {
                actualGrade = Grades.C;
            }
            else if (score >= 60)
            {
                actualGrade = Grades.D;
            }
            else 
            {
                actualGrade = Grades.F
            }

            Assert.AreEqual(expectedGrade, actualGrade);
            */
        }

        [TestMethod]

        public void TestCalculateMean()
        {
            studentGrades.Marks = StatsMarks;
            double expectedMean = 55.0;
            studentGrades.CalculateStats();

            Assert.AreEqual(expectedMean, studentGrades.Mean);
        }

        [TestMethod]

        public void TestCalculateMin()
        {
            studentGrades.Marks = StatsMarks;
            int expectedMin = 10;

            studentGrades.CalculateStats();

            Assert.AreEqual(expectedMin, studentGrades.Minimum);
        }

        [TestMethod]

        public void TestCalculateMax()
        {
            studentGrades.Marks = StatsMarks;
            int expectedMax = 100;

            studentGrades.CalculateStats();

            Assert.AreEqual(expectedMax, studentGrades.Maximum);
        }

        [TestMethod]

        public void TestGradeProfile()
        {
            // Arrange
            studentGrades.Marks = StatsMarks;
            // Act
            studentGrades.CalculateGradeProfile();

            bool expectedProfile;
            expectedProfile = ((studentGrades.GradeProfile[0] == 3) &&
                               (studentGrades.GradeProfile[1] == 1) &&
                               (studentGrades.GradeProfile[2] == 1) &&
                               (studentGrades.GradeProfile[3] == 1) &&
                               (studentGrades.GradeProfile[4] == 4));

            // Assert
            Assert.IsTrue(expectedProfile);
        }
    }
}
