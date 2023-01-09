using System.Diagnostics;

namespace ClassLibrary1
{
    [DebuggerDisplay("{Translations[0]}")]
    public class Word
    {
     
        public string[] Translations { get; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }

        public Word(string[] translations)
        {
            Translations = translations;
        }

        public Word(string[] translations, int fromLanguage, int toLanguage)
        {
            Translations = translations;
            FromLanguage = fromLanguage;
            ToLanguage = toLanguage;
        }
       


    }
}