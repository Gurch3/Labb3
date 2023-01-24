// See https://aka.ms/new-console-template for more information

using ClassLibrary1;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Windows.Markup;
using System.Xml.Linq;
using System.Text;
using System.Runtime.InteropServices;

string[] commands = {"-lists", "-new", "-add", "-remove", "-words", "-count", "-practice"};

try
{
    if (commands.Contains(args[0].ToLower()))
    {

        if (args[0].ToLower() == "-lists") PrintLists();
        if (args[0].ToLower() == "-new") CreateNewList();
        if (args[0].ToLower() == "-add") AddWordsLoop(GetList());
        if (args[0].ToLower() == "-remove") RemoveWord();
        if (args[0].ToLower() == "-words") PrintSorted();
        if (args[0].ToLower() == "-count") PrintCount();
        if (args[0].ToLower() == "-practice") PracticeWords();
    }
    else Help();
}
catch (System.IndexOutOfRangeException)
{
    Help();
} 

  
void PrintLists()
{
    Console.WriteLine("All list in the folder: ");
    foreach (string list in WordList.GetLists())
    {
        Console.WriteLine(list);
    }
}

void CreateNewList()
{
    if (args.Length > 1)
    {
        string name = args[1];
        WordList.LoadList(name);
        List<string> addedLanguages = new List<string>();
        if (args.Length > 3)
        {
            if (WordList.LoadList(name) == null)
            {
                for (int languages = 2; languages < args.Length; languages++)
                {
                    addedLanguages.Add(args[languages]);
                }

                new WordList(name, addedLanguages.ToArray()).Save();
                WordList newListAddWords = WordList.LoadList(name);
                AddWordsLoop(newListAddWords);
                newListAddWords.Save();
            }
            else
            {
                Console.WriteLine("List already exists");
            }
        }
        else
        {
            Console.WriteLine("You need at least 2 languages to create a list");
        }
    }
    else Console.WriteLine("Trying to create list without  a name");
}

void RemoveWord()
{
    if (args.Length > 3)
    {
        WordList remove = GetList();
        int foundLanguage = FindLanguage(remove);
        if (foundLanguage >= 0)
        {
            for (int removeWords = 3; removeWords < args.Length; removeWords++)
            {
                remove.Remove(foundLanguage, args[removeWords]);
            }

            remove.Save();
        }
        else
        {
            Console.WriteLine("Language not found in list");
        }
    }
    else
    {
        Console.WriteLine("Trying to remove word without enough input parameters");
    }

}

void PrintCount()
{
    WordList count = GetList();
    Console.WriteLine(count.Count());
}

void PrintSorted()
{
    WordList sortList = GetList();
    int sortByLanguage = FindLanguage(sortList);
    sortList.List(sortByLanguage, PrintTranslations);
}

void PrintTranslations(string[] translations)
{
    foreach (string word in translations)
    {
        Console.Write(word + " ");
    }
    Console.WriteLine();
}

void AddWordsLoop(WordList list)
{
    Console.WriteLine($"Add words to {list.Name}");
    List<string> addWordList = new List<string>();
    string addWord = "1";

    do
    {
        for (int l = 0; l < list.Languages.Length; l++)
        {
            Console.Write($"Add your word with language {list.Languages[l]}:");
            addWord = Console.ReadLine();
            if (addWord.Trim(' ') != "")
            {
                addWordList.Add(addWord);
            }
            else break;

        }

        if (addWordList.Count == list.Languages.Length)
        {
            list.Add(addWordList.ToArray());
        }

        addWordList.Clear();
    } while (addWord.Trim(' ') != "");

    list.Save();
}

void PracticeWords()
{
    WordList practiceList = GetList();
    
    int totalCount = 0;
    int correctCount = 0;
    string result = "0";
    while (result != "")
    {
        Word practiceWord = practiceList.GetWordToPractice();
        int from = practiceWord.FromLanguage;
        int to = practiceWord.ToLanguage;
        Console.WriteLine($"Translate {practiceWord.Translations[from]} to language {practiceList.Languages[to]}");
        result = Console.ReadLine();

        if (result == practiceWord.Translations[to])
        {
            Console.WriteLine("Answer was correct");
            correctCount++;
            totalCount++;
        }
        else
        {
            Console.WriteLine("Answer was wrong");
            totalCount++;
        }
        practiceWord = practiceList.GetWordToPractice();
    }
    Console.WriteLine($"You have practiced {totalCount} words and answered {correctCount} of them correctly");
}

int FindLanguage(WordList findLang)
{
    int foundLanguage = -1;
    int testLanguage = int.Parse(args[2]);
    for (int findLanguage = 0; findLanguage < findLang.Languages.Length; findLanguage++)
    {
        if (testLanguage == findLanguage)
        {
            foundLanguage = findLanguage;
            
        }
    }
    return foundLanguage;


}
WordList GetList()
{
    string listName = args[1];
    if (WordList.LoadList(listName) != null)
    {
        return WordList.LoadList(listName);
    }
    throw new FileNotFoundException("File not found");
}

void Help()
{
    Console.WriteLine("Use any of the following parameters:");
    Console.WriteLine("-lists");
    Console.WriteLine("-new <list name> <language1> <language2> .. <language n>");
    Console.WriteLine("-add <list name>");
    Console.WriteLine("-remove <list name> <language> <word 1> <word 2> .. <word n>");
    Console.WriteLine("-words <list name> <sortByLanguage>");
    Console.WriteLine("-count <list name>");
    Console.WriteLine("-practice <list name>");
}
