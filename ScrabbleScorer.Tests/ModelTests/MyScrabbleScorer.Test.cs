using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Tests
{
    [TestClass]
    public class MyScrabbleScorerTests
    {
        // 1st Test: Test to create instance of Scrabble object
        [TestMethod]
        public void ScrabbleScorerConstructor_CreatesInstanceOfScrabble_Scrabble()
        {
            MyScrabbleScorer newScrabble = new MyScrabbleScorer("bola");

            Assert.AreEqual(typeof(MyScrabbleScorer), newScrabble.GetType());
        }

        // 2nd Test: Test to get string from Scrabble class
        // [TestMethod]
        // public void GetWord_GetsScrabbleWord_String()
        // {
        //     // Arrange
        //     MyScrabbleScorer newScrabble = new MyScrabbleScorer("bola");
        //     string expectedWord = "bola";

        //     // Act 
        //     string returnedWord = newScrabble.Word;

        //     // Assert
        //     Assert.AreEqual(expectedWord, returnedWord);
        // }
        
        // // 3rd Test: Test to set string from Scrabble class
        // [TestMethod]
        // public void SetWord_SetsScrabbleWord_Void()
        // {
        //     // Arrange
        //     MyScrabbleScorer newScrabble = new MyScrabbleScorer("bola");
        //     string setWord = "bola";

        //     // Act 
        //     newScrabble.Word = setWord;

        //     // Assert
        //     Assert.AreEqual(setWord, newScrabble.Word);
        // }
        
        // // 4th Test: First path of ScrabbleScoreDeterminer() method
        // [TestMethod]
        // public void ScrabbleScoreDeterminer_MethodsFirstPath_Void()
        // {
        //     // Arrange
        //     MyScrabbleScorer newScrabble = new MyScrabbleScorer("bola");
        //     int expectedNum = 6;

        //     // bola word contains: o, l, a i.e +3 from the first set of cases... And b is from a case where we added 3.. which makes it a total of 6

        //     // Act 
        //     int returnedNum = newScrabble.ScrabbleScoreDeterminer();

        //     // Assert
        //     Assert.AreEqual(expectedNum, returnedNum);
        // }
    }
}