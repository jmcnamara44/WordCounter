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
      RepeatCounter.ClearAll();
    }
    [TestMethod]
    public void ReturnWord_ReturnsWord_Word()
    {
      string testWord1 = "abc";
      RepeatCounter test = new RepeatCounter(testWord1, "ignore me");
      string testWord2 = "abc";
      Assert.AreEqual(testWord2, test.ReturnWord(test));
    }
    [TestMethod]
    public void RepeatCounterClassAndGetWord_ComparesWordAndSentence_WordAndSentence()
    {
      string testWord1 = "abc";
      string testSentence1 = "this is a sentence";
      RepeatCounter test = new RepeatCounter(testWord1, testSentence1);
      test.Save();
      List<RepeatCounter> testList = RepeatCounter.GetAll();
      string testWord2 = "abc";
      string testSentence2 = "this is a sentence";
      Assert.AreEqual(testWord2, testList[0].GetWord());
      Assert.AreEqual(testSentence2, testList[0].GetSentence());
      Assert.AreEqual(1, testList.Count);
    }
  }
}
