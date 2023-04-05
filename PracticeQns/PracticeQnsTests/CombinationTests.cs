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
    public class CombinationTests
    {
        [TestMethod()]
        public void IsRoyalFlushTest()
        {
            Combination combination = new Combination();
            string[] input = { "Ac", "Kc", "Jc", "Qc", "10c" };
            Assert.AreEqual("Royal Flush", combination.GetCombination(input));

        }

        [TestMethod()]
        public void IsStraightFlushTest()
        {
            Combination combination = new Combination();
            string[] input = { "2c", "3c", "4c", "5c", "6c" };
            Assert.AreEqual("Straight Flush", combination.GetCombination(input));


        }

        [TestMethod()]
        public void IsFourOfAKindTest()
        {
            Combination combination1 = new Combination();
            string[] input = { "10s", "10c", "8d", "10d", "10h" };
            Assert.AreEqual("Four Of A Kind", combination1.GetCombination(input));
        }

        [TestMethod()]
        public void IsFullHouseTest()
        {
            Combination combination1 = new Combination();
            string[] input = { "10s", "8c", "8d", "10d", "10h" };
            Assert.AreEqual("Full House", combination1.GetCombination(input));
        }

        [TestMethod()]
        public void IsThreeOfAKindTest()
        {
            Combination combination1 = new Combination();
            string[] input = { "10s", "2c", "8d", "10d", "10h" };
            Assert.AreEqual("Three Of A Kind", combination1.GetCombination(input));
        }

        [TestMethod()]
        public void IsStraightTest()
        {
            Combination combination1 = new Combination();
            string[] input = { "10d", "8h", "6c", "7s", "9c" };
            Assert.AreEqual("Straight", combination1.GetCombination(input));
        }

        [TestMethod()]
        public void IsFlushTest()
        {
            Combination combination1 = new Combination();
            string[] input = { "10c", "2c", "3c", "8c", "6c" };
            Assert.AreEqual("Flush", combination1.GetCombination(input));
        }

        [TestMethod()]
        public void IsTwoPairsTest()
        {
            Combination combination1 = new Combination();
            string[] input = { "10c", "3c", "3c", "8d", "8c" };
            Assert.AreEqual("Two Pairs", combination1.GetCombination(input));
        }

        [TestMethod()]
        public void IsPairsTest()
        {
            Combination combination1 = new Combination();
            string[] input = { "10c", "10c", "4c", "2d", "8c" };
            Assert.AreEqual("Pairs", combination1.GetCombination(input));
        }
    }
}


