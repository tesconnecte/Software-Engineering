using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextParser.Lib;

namespace TextParser.Test
{
    [TestClass]
    public class ParseTest
    {
        [TestMethod]
        public void ExtractVowelsTest()
        {
            string test = "hello world one two three";
            string expectedResult = "eoooeoee";
            string actualResult = Parse.ExtractVowels(test);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ExtractConjunctionsTest()
        {
            string test = "and he is neither here nor there or anywhere else";
            string expectedResult = "noror";
            string actualResult = Parse.ExtractConjunctions(test);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ExtractUpperCaseWordsTest()
        {
            string test = "Joe Doe went to visit the National Museum in London";
            string expectedResult = "JoeDoeNationalMuseumLondoon";
            string actualResult = Parse.ExtractUpperCaseWords(test);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ExtractLowerCaseWordsTest()
        {
            string test = "the Quick brown fox Jumps over the lazy Dog";
            string expectedResult = "thebrownfoxoverthelazy";
            string actualResult = Parse.ExtractLowerCaseWords(test);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
