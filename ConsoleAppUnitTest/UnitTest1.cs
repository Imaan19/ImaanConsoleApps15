using ConsoleAppProject.App01;
namespace ConsoleAppUnitTest
{
    [TestClass]
    public class App1Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = "feet";
            converter.ToUnit = "miles";
            converter.FromDistance = 10560;

            converter.ConvertDistance();

            double expectedOutput = 2.0;

            Assert.AreEqual(expectedOutput, converter.ToDistance);


        }
    }
}