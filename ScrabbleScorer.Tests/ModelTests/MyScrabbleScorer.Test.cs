using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Tests
{
    [TestClass]
    public class MyScrabbleScorerTests
    {
        [TestMethod]
        public void ScrabbleScorerConstructor_CreatesInstanceOfScrabble_Scrabble()
        {
            MyScrabbleScorer newScrabble = new MyScrabbleScorer();

            Assert.AreEqual(typeof(MyScrabbleScorer), newScrabble.GetType());
        }
    }
}