using System.Collections.Generic;
using System.IO;
using System;

namespace WordCounter.Models
{
    public class Word
    {
        private string _word;
        private string _sentence;
        private static List<Word> _strings = new List<Word> {};
        public Word(string word, string sentence)
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
        public void Save()
        {
          _strings.Add(this);
        }
        public bool StringContains(Word word)
        {
          return word.GetSentence().Contains(word.GetWord());
        }
        public static List<Word> GetAll()
        {
          return _strings;
        }
        public static void ClearAll()
        {
          _strings.Clear();
        }
        public string ReturnWord(Word word)
        {
          return word.GetWord();
        }
    }

    // public class RepeatCounter  //I am currently unable to call methods from the Word class and use them in the RepeatCounter class
    // {
    // }
}
