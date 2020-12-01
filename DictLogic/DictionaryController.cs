using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryData;

namespace DictLogic
{
    public class DictionaryController
    {
        Dictionary<string, string> gerToEng;
        Dictionary<string, string> gerToDia;

        private string _currentLanguage;
        public string CurrentLanguage { get { return _currentLanguage; } set => _currentLanguage = value; }

        public DictionaryController()
        {
            gerToEng = new Dictionary<string, string>();
            gerToDia = new Dictionary<string, string>();

            _currentLanguage = "eng";

            DictionaryEntities entity = new DictionaryEntities();

            var english = entity.GerToEng;

            foreach (var id in english)
            {
                gerToEng.Add(id.german, id.english);
            }

            var dialect = entity.GerToDia;

            foreach (var id in dialect)
            {
                gerToDia.Add(id.german, id.dialect);
            }
        }


        public List<string> UpdateTranslation()
        {
            List<string> output = new List<string>();
            if (CurrentLanguage.Equals("eng"))
            {
                output = SortDictionary(gerToEng).Keys.ToList();
            }
            else if (CurrentLanguage.Equals("dia"))
            {
                output = SortDictionary(gerToDia).Keys.ToList();
            }

            return output;
        }

        private Dictionary<string, string> SortDictionary(Dictionary<string, string> dictionary)
        {
            List<string> words = new List<string>(dictionary.Keys);
            words.Sort();
            Dictionary<string, string> orderedDictionary = new Dictionary<string, string>();

            foreach (var key in words)
            {
                orderedDictionary.Add(key, dictionary[key]);
            }
            return orderedDictionary;
        }

        public string GetTranslation(string word)
        {
            string translation = string.Empty;

            if (CurrentLanguage.Equals("eng") && gerToEng.ContainsKey(word))
            {
                translation = gerToEng[word];
            }
            else if (CurrentLanguage.Equals("dia") && gerToDia.ContainsKey(word))
            {
                translation = gerToDia[word];
            }
            return translation;
        }
        public string ShowTranslation(string key)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            if (CurrentLanguage.Equals("eng"))
            {
                dict = gerToEng;
            }
            else if (CurrentLanguage.Equals("dia"))
            {
                dict = gerToDia;
            }
            return dict[key];

        }
        private void TranslateWord(string original, string translated, Dictionary<string, string> dictionary)
        {
            var word = original;
            var translation = translated;

            dictionary.Add(word, translation);
        }

        public void NewGermanWord(string german, string english)
        {
            bool newWord = true;

            foreach (var item in gerToEng.Keys)
            {
                if (item.ToLower().Equals(german.ToLower()))
                {
                    newWord = false;
                }
            }


            if (newWord)
            {
                DictionaryEntities entity = new DictionaryEntities();
                GerToEng word = new GerToEng() { german = german, english = english };
                entity.GerToEng.Add(word);
                entity.SaveChanges();


                TranslateWord(german, english, gerToEng);
            }
        }

        public void NewDialectWord(string german, string dialect)
        {
            bool newWord = true;

            foreach (var item in gerToDia.Keys)
            {
                if (item.ToLower().Equals(german.ToLower()))
                {
                    newWord = false;
                }
            }

            if (newWord)
            {
                DictionaryEntities entity = new DictionaryEntities();
                GerToDia word = new GerToDia() { german = german, dialect = dialect };
                entity.GerToDia.Add(word);
                entity.SaveChanges();

                TranslateWord(german, dialect, gerToDia);
            }
        }

        public void SetCurrentLanguage(string selection)
        {
            if (selection.Equals("eng"))
            {
                CurrentLanguage = "eng";
            }
            else if (selection.Equals("dia"))
            {
                CurrentLanguage = "dia";
            }
        }
        public string GetCurrentLanguage()
        {
            string output = string.Empty;
            if (CurrentLanguage.Equals("eng"))
            {
                output = "eng";
            }
            else if (CurrentLanguage.Equals("dia"))
            {
                output = "dia";
            }
            return output;
        }

        public List<string> SelectByLetter(string selection)
        {
            char[] selectedLetter = selection.ToCharArray();

            Dictionary<string, string> dict = new Dictionary<string, string>();
            if (CurrentLanguage.Equals("eng"))
            {
                dict = gerToEng;
            }
            else if (CurrentLanguage.Equals("dia"))
            {
                dict = gerToDia;
            }

            List<string> words = new List<string>();


            foreach (var item in dict.Keys)
            {
                char[] letters = item.ToCharArray();
                if (letters[0].Equals(selectedLetter[0]))
                {
                    words.Add(item);
                }
            }
            return words;
        }

        public List<string> ImportAlphabet()
        {
            string[] alphabetArray = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
                                        "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            List<string> alphabetList = new List<string>();

            foreach (var letter in alphabetArray)
            {
                alphabetList.Add(letter);
            }
            return alphabetList;
        }

        public List<string> GetSearchResults(string searchText)
        {
            List<string> results = new List<string>();

            var text = searchText;
            Dictionary<string, string> selection = new Dictionary<string, string>();
            if (CurrentLanguage.Equals("eng"))
            {
                foreach (var word in gerToEng)
                {
                    if (word.Key.ToLower().Contains(text))
                    {
                        selection.Add(word.Key, gerToEng[word.Key]);
                    }
                }
                results = SortDictionary(selection).Keys.ToList();
            }
            else if (CurrentLanguage.Equals("dia"))
            {
                foreach (var word in gerToDia)
                {
                    if (word.Key.ToLower().Contains(text))
                    {
                        selection.Add(word.Key, gerToDia[word.Key]);
                    }
                }
                results = SortDictionary(selection).Keys.ToList();
            }
            return results;
        }
    }
}
