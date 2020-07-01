using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void OnlyBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void EmptyString()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void BracketsAreNested()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }
        [TestMethod]

        public void DoublePairofBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
        }
        [TestMethod]
        public void InversedBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }
        [TestMethod]
        public void BracketsMissingClosing()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
        [TestMethod]
        public void BracketsMissingOpening()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        [TestMethod]
        public void InversedNestedBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][]["));
        }
        [TestMethod]
        public void DoublePairBracketsMissingClosing()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[["));
        }
        [TestMethod]
        public void DoublePairMissingOpening()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]"));
        }
        [TestMethod]

        public void SingleOpeningWithDoubleClosing()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]"));
        }
        [TestMethod]
        public void DoubleOpeningWithSingleClosing()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"));
        }
            
    }
}
