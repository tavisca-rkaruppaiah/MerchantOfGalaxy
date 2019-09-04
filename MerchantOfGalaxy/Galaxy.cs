using System.Collections.Generic;

namespace MerchantOfGalaxy
{
    public class Galaxy
    {
        public static bool IsQuestion(string dialog)
        {
            return dialog.EndsWith("?");
        }

        private static Dictionary<string, char> _names = new Dictionary<string, char>()
        {
            { "glob", 'I'},
            { "prok", 'V'},
            { "pish", 'X'},
            { "tegj", 'L'}

        };

        public static string GetRomanNumberFromSentence(string sentence)
        {
            var dialogs = sentence.Split(" ");
            string roman = "";
            for (int position = 0; position < dialogs.Length - 1; position++)
            {
                roman += GetRomanNumber(dialogs[position]);
            }

            return roman.Replace("\0", "");
        }
        
        public static char GetRomanNumber(string name)
        {
            if (_names.ContainsKey(name))
                return _names[name];
            return char.MinValue;
        }

        public static string GetSentenceFromDialog(string dialog, string remove)
        {
            return dialog.Replace(remove, "").Replace("?", "");
        }

        public static string GetRomanNumberFromDialog(string dialog, string remove)
        {
            return GetRomanNumberFromSentence(GetSentenceFromDialog(dialog, remove));
        }
    }

   
}
