using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountRepeats_DoesNotAppearInSentence_0()
    {
      RepeatCounter newCount = new RepeatCounter("hello", "hi");
      int expected = 0;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_DoesNotAppearInMultiWordSentence_0()
    {
      RepeatCounter newCount = new RepeatCounter("hello there", "hi");
      int expected = 0;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_MatchesOneWordSentence_1()
    {
      RepeatCounter newCount = new RepeatCounter("Hello", "Hello");
      int expected = 1;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountRepeats_MatchesOneWordLowerCase_1()
    {
      RepeatCounter newCount = new RepeatCounter("Hello", "hello");
      int expected = 1;
      int actual = newCount.CountRepeats();
      Assert.AreEqual(expected, actual);
    }
  }
}