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
    public class PayCalcTests
    {
        [TestMethod()]
        public void ingressDataTest()
        {
            var test = new PayCalc();
            double[] arr = {13.25, 15, 30, 1.5}; 
            test.ingressData(arr);
            if (test.salary == 52.5)
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