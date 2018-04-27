using System.Collections.Generic;
using System.IO;
using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _word;
        private string _sentence;
        private static List<RepeatCounter> _strings = new List<RepeatCounter> {};
        public RepeatCounter(string word, string sentence)
        {
          _word = word;
          _sentence = sentence;
        }
        public string GetWord()
        {
          return _word;
        }
        public void SetWord(string newWord)
        {
          _word = newWord;
        }
        public string GetSentence()
        {
          return _sentence;
        }
        public void SetSentence(string newSentence)
        {
          _sentence = newSentence;
        }
        public string ReturnWord(RepeatCounter word)
        {
          return word.GetWord();
        }
        public void Save()
        {
          _strings.Add(this);
        }
        public static List<RepeatCounter> GetAll()
        {
          return _strings;
        }
        public static void ClearAll()
        {
          _strings.Clear();
        }
    }
}
