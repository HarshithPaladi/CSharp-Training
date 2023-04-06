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
    public class NicoCipherEncoderTests
    {
        [TestMethod()]
        public void NicoCipherTest_mubashirhassan()
        {
            var NicoCipherEncoder = new NicoCipherEncoder();
            string actual = NicoCipherEncoder.NicoCipher("mubashirhassan", "crazy");
            string expected = "bmusarhiahass n";
            Console.WriteLine($"Expected result: {expected}\nActual Result: {actual}");
            Assert.AreEqual(expected,actual);
        }
        [TestMethod()]
        public void NicoCipherTest_edabitisamazing()
        {
            var NicoCipherEncoder = new NicoCipherEncoder();
            string actual = NicoCipherEncoder.NicoCipher("edabitisamazing", "matt");
            string expected = "deabtiismaaznig ";
            Console.WriteLine($"Expected result: {expected}\nActual Result: {actual}");
            Assert.AreEqual(expected,actual);
        }
        [TestMethod()]
        public void NicoCipherTest_iloveher()
        {
            var NicoCipherEncoder = new NicoCipherEncoder();
            string actual = NicoCipherEncoder.NicoCipher("iloveher", "612345");
            string expected = "lovehir    e";
            Console.WriteLine($"Expected result: {expected}\nActual Result: {actual}");
            Assert.AreEqual(expected,actual);
        }

    }
}