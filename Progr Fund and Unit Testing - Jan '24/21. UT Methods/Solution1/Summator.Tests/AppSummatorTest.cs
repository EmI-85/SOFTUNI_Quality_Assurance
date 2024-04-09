using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ConsoleAppSummator.Tests
{
    public class AppSummatorTest
    {
        [SetUp]
        public void SetUp()
            {
               ;
            }

        [Test]
        public void ProgramSumShouldReturnSummedNumbers()
        {
            // Arrange:
            int[] arrayOfNums = new int[] { 1, 2, 3 };

            //Act:
            int sumOfArray = Program.Sum(arrayOfNums);

            //Assert:

            // Assert.AreEqual(7, sumOfArray);
            // Assert.That(6, Is.EqualTo(sumOfArray));

            Assert.That(sumOfArray == 6);
        }

        [Test]
        public void ProgramSumShouldReturn0IfNothingIsPassed()
        {
            int sumOfArray = Program.Sum(new int[] {});

            Assert.That(sumOfArray == 0);
        }
    }
} 