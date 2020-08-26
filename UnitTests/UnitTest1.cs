using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CandidateTest;

namespace CandidateUnitTests
{
    [TestClass]
    public class CandidateUnitTests
    {
        [TestMethod]
        public void AverageIsCorrect()
        {
            var calculatedValue = TestFunctions.Average(2, 1);
            var expectedValue = 1.5;
            Assert.AreEqual(expectedValue,calculatedValue,"Value is incorrect");
        }

        [TestMethod]
        public void NamesAreUnique()
        {
            string[] names1 = { "Ava", "Emma", "Olivia" };
            string[] names2 = { "Olivia", "Sophia", "Emma" };
            string[] expectedValue = { "Ava", "Emma", "Olivia", "Sophia"};
            var calculatedValue = string.Join(", ", TestFunctions.UniqueNames(names1, names2));

            Assert.AreEqual(expectedValue,calculatedValue,"Value is incorrect");
        }
        [TestMethod]
        public void PhraseWasReversed()
        {
            var calculatedValue = TestFunctions.ReversePhrase("I want to work for Cox Automotive");
            var expectedValue = "Automotive cox for work to want i";

            Assert.AreEqual(expectedValue, calculatedValue, "Value is incorrect");
        }
    }
}
