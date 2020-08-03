using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RegularExpressionsExample
{
    [TestClass]
    public class RegularExpressionMatchExample
    {
        /// <summary>
        /// Simple example matching words in text. In this case, only considering low ascii characters (a-z).
        /// </summary>
        [TestMethod]
        public void MatchWordsInSentence()
        {
            string pattern = @"[a-zA-Z]+";
            string input = "this this thing.";
            // matches the first work only
            Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
            Assert.IsTrue(match.Success);
            // matches all the words.
            var matches = Regex.Matches(input, pattern, RegexOptions.IgnoreCase);
            Assert.AreNotEqual(matches.Count, 3);
        }

        /// <summary>
        /// 
        /// </summary>
        //https://stackoverflow.com/questions/1454913/regular-expression-to-find-a-string-included-between-two-characters-while-exclud
        [TestMethod]
        public void GetStringBetween2Characters()         {
            string pattern = @"(?<=\[)(.*?)(?=\])";
            string input = " test[jorge perez] this is a test driver[lucre enriquez]";
            // matches the first work only
            Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
            Assert.IsTrue(match.Success);
            // matches all the words.
            var matches = Regex.Matches(input, pattern, RegexOptions.IgnoreCase);
            Assert.AreEqual(matches.Count, 2);

            string pattern2 = @"(?<=\ )(.*?)(?=\[)";
            string input2 = " test[jorge perez] this is a test driver[lucre enriquez]";
            // matches the first work only
            Match match2 = Regex.Match(input2, pattern2, RegexOptions.IgnoreCase);
            Assert.IsTrue(match2.Success);
            // matches all the words.
            var matches2 = Regex.Matches(input2, pattern2, RegexOptions.IgnoreCase);
            Assert.AreEqual(matches2.Count, 2);
        }
    }
}
