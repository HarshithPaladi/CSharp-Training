using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Testing.Tests
{
    [TestFixture()]
    public class ProgramTests
    {
        // [TestMethod()]
        // public void MainTest(){
        //     int subjectCount = int.Parse(Console.ReadLine());
        //     Program.Main();

        // }
        public static FileStream file = new FileStream("D:\\source\\repos\\C# - Training\\Day 8\\Testcases.txt", FileMode.Open, FileAccess.Read);
        public static StreamReader sr = new StreamReader(file);
        [Test()]
        public void FactorialTest()
        {

            string outp = Program.Factorial(Convert.ToInt32(sr.ReadLine())).ToString();
            Assert.AreEqual(sr.ReadLine(), outp);

        }
        [Test()]
        public void FactorialTest1()
        {

            string outp = Program.Factorial(Convert.ToInt32(sr.ReadLine())).ToString();
            Assert.AreEqual(sr.ReadLine(), outp);

        }
        [Test()]
        public void FactorialTest2()
        {

            string outp = Program.Factorial(Convert.ToInt32(sr.ReadLine())).ToString();
            Assert.AreEqual(sr.ReadLine(), outp);
            sr.Close();
            file.Close();
        }
        [Test()]
        public void CalculateCGPATest()
        {
            int subjectCount = 3;
            List<float> marks = new List<float>() { 90f, 80f, 85f };
            string grade = Program.CalculateCGPA(subjectCount, marks);
            if (grade == "AP")
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}