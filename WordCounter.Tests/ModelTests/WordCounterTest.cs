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
      Word.ClearAll();
    }
    [TestMethod]
    public void ReturnWord_ReturnsWord_Word()
    {
      string testWord1 = "abc";
      Word test = new Word(testWord1, "ignore me");
      string testWord2 = "abc";
      Assert.AreEqual(testWord2, test.ReturnWord(test));
    }
    [TestMethod]
    public void RepeatCounterClassAndGetWord_ComparesWordAndSentence_WordAndSentence()
    {
      string testWord1 = "abc";
      string testSentence1 = "this is a sentence";
      Word test = new Word(testWord1, testSentence1);
      test.Save();
      List<Word> testList = Word.GetAll();
      string testWord2 = "abc";
      string testSentence2 = "this is a sentence";
      Assert.AreEqual(testWord2, testList[0].GetWord());
      Assert.AreEqual(testSentence2, testList[0].GetSentence());
      Assert.AreEqual(1, testList.Count);
    }
    [TestMethod]
    public void StringContains_ComparesLetterWithLetter_A()
    {
      string testLetter1 = "A";
      string testLetter2 = "A";
      Word testLetter3 = new Word(testLetter1, testLetter2);

      Assert.AreEqual(true, testLetter3.StringContains(testLetter3));
    }
    [TestMethod]
    public void StringContains_ComparesLetterWithSentence_A()
    {
      string testLetter1 = "A";
      string testLetter2 = "BRACKET";
      Word testLetter3 = new Word(testLetter1, testLetter2);

      Assert.AreEqual(true, testLetter3.StringContains(testLetter3));
    }
  }
}
