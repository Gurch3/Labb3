using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ClassLibrary1
{
    public class WordList
    {
        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }

        public string Name { get; }
        public string[] Languages { get; }

        private List<Word>? wordList = new List<Word>();
        public static string[] GetLists()
        {
            
            string[] lists = Directory.GetFiles(GetFolderPath(), "*dat");

            for (int i = 0; i < lists.Length; i++)
            {
                lists[i] = Path.GetFileNameWithoutExtension(lists[i]);

            }

            return lists;

        }
        public static WordList LoadList(string name)
        {
            try
            {

                using StreamReader load = new(GetFilePath(name));
                var languages = load.ReadLine().Trim(';').Split(';');
                WordList loadedList = new WordList(name, languages);
                while (!load.EndOfStream)
                {
                    loadedList.Add(load.ReadLine().Trim(';').Split(';'));
                }

                return loadedList;
            }
            catch(FileNotFoundException)
            {
                return null;
            }
        }
        public void Save()
        {
            string listName = Name;
            using (StreamWriter saveList = new StreamWriter(GetFilePath(listName)))
            {
                foreach (string lang in Languages)
                {
                    saveList.Write(lang + ";");
                }
                saveList.WriteLine();
                foreach(Word word in wordList)
                {
                    foreach(string t in word.Translations)
                    {
                        saveList.Write(t + ";");
                    }
                    saveList.WriteLine();
                }
            }
             

        }

        public void Add(params string[] translations)
        {
            if (Languages.Length == translations.Length)
            {
                wordList.Add(new Word(translations));
            }
            else
            {
                throw new ArgumentException("Number of translations doesn't match the number of languages");
            }
        }

         public bool Remove(int translation, string word)
        {
            foreach(Word removeWord in wordList)
            {
                if (removeWord.Translations[translation].ToLower() == word.ToLower())
                {
                    wordList.Remove(removeWord);
                    return true;
                }
            }
            return false;
        }

         public int Count()
         {
             int count = wordList.Count;
             return count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslation)
        {
            List<Word> sortedList = wordList.OrderBy(o => o.Translations[sortByTranslation]).ToList();
            foreach(Word word in sortedList)
            {
                showTranslation(word.Translations);
            }
        }   
        public Word GetWordToPractice()
        {
            int random = new Random().Next(0, wordList.Count);
            int randomFromLanguage = new Random().Next(0, wordList[random].Translations.Length);
            int randomToLanguage = new Random().Next(0, wordList[random].Translations.Length);
            while (randomFromLanguage == randomToLanguage)
            {
                randomToLanguage = new Random().Next(0, wordList[random].Translations.Length);
            }
            Word randomWord = new(wordList[random].Translations, randomFromLanguage, randomToLanguage);
          
            return randomWord;
        }
        static string GetFolderPath()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            folderPath = Path.Combine(folderPath, "Labb3");
            return folderPath;
        }
        static string GetFilePath(string name)
        {
            string filePath = Path.Combine(GetFolderPath(), name + ".dat");
            return filePath;
        }

    }
   
}
