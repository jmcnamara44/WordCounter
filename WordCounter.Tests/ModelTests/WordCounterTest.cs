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
      RepeatCounter test = new RepeatCounter(testWord1);
      string testWord2 = "abc";
      Assert.AreEqual(testWord2, test.ReturnWord(test));
    }
  }
}
