using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeQns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQns.Tests
{
    [TestClass()]
    public class IEnglishToPigLatinTests
    {
        [TestMethod()]
        public void TranslateWordTest()
        {
            var runnerconverter = new RunnerConverter();
            string actual = runnerconverter.TranslateWord("shrimp?!.");
            string expected = "impshray?!.";
            Assert.AreEqual(expected, actual);
            Console.WriteLine($"Expected result: {expected}\nActual Result: {actual}");
        }
        [TestMethod()]
        public void TranslateSentenceTest()
        {
            var runnerconverter = new RunnerConverter();
            string actual = runnerconverter.TranslateSentence("Do you think it is going to rain today?");
            string expected = "Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?";
            Assert.AreEqual(expected, actual);
            Console.WriteLine($"Expected result: {expected}\nActual Result: {actual}");

        }
    }
}