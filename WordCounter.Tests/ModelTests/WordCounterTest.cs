using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest : IDisposable
  {
    public void Dispose()
    {

    }
    [TestMethod]
    public void One_ReturnWord_ReturnsWord_Word()
    {
      string testWord1 = "abc";
      Word test = new Word(testWord1, "ignore me");
      string testWord2 = "abc";
      Assert.AreEqual(testWord2, test.ReturnWord(test));
    }
    [TestMethod]
    public void Two_RepeatCounterClassAndGetWord_ComparesWordAndSentence_WordAndSentence()
    {
      string testWord1 = "abc";
      string testSentence1 = "this is a sentence";
      Word test = new Word(testWord1, testSentence1);
      string testWord2 = "abc";
      string testSentence2 = "this is a sentence";
      Assert.AreEqual(testWord2, test.GetWord());
      Assert.AreEqual(testSentence2, test.GetSentence());
    }
    [TestMethod]
    public void Three_StringContains_ComparesLetterWithLetter_A()
    {
      string testLetter1 = "A";
      string testLetter2 = "A";
      Word testLetter3 = new Word(testLetter1, testLetter2);

      Assert.AreEqual(true, testLetter3.StringContains(testLetter3));
    }
    [TestMethod]
    public void Four_StringContains_ComparesLetterWithSentence_A()
    {
      string testLetter1 = "A";
      string testLetter2 = "A BRACKET";
      Word testLetter3 = new Word(testLetter1, testLetter2);

      Assert.AreEqual(true, testLetter3.StringContains(testLetter3));
    }
    [TestMethod]
    public void Five_StringContains_ComparesStringWithSentence_True()
    {
      string testLetter1 = "Ale";
      string testLetter2 = "BRACKET Ale is ale";
      Word testLetter3 = new Word(testLetter1, testLetter2);

      Assert.AreEqual(true, testLetter3.StringContains(testLetter3));
    }
    [TestMethod]
    public void Six_RepeatCounter_CountsStringOccurencesWithinSentence_Three()
    {
      string testLetter1 = "Ale";
      string testLetter2 = "Ale Ale Alex Ale ale";
      Word testLetter3 = new Word(testLetter1, testLetter2);

      Assert.AreEqual(3, testLetter3.RepeatCounter(testLetter3));
    }
  }
}
