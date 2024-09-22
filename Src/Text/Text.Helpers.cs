
namespace TextAdventure
{
    public static partial class Text
    {

        public static string Capitalize(string s)
        {
            return s[0].ToString().ToUpper() + s.Substring(1);
        }

        public static string AOrAn(string nextWord)
        {
            return "aeiouAEIOU".IndexOf(nextWord[0]) == -1 ? "a" : "an";
        }

        public static string SingularOrPlural (string original, int n)
        {
            if (n >= 2)
                return original + "s";
            else
                return original;
        }

        public static string CommaSeparatedList(string[] words, string conjunction)
        {
            string oxfordComma = words.Length > 2 ? "," : "";

            if (words.Length == 0)
                return "";
            else if (words.Length == 1)
                return words[0];
            else
            {
                return String.Concat(
                    String.Join(", ", words, 0, words.Length - 1),
                    String.Format("{0} {1} ", oxfordComma, conjunction),
                    words[words.Length - 1]
                );
            }
        }

    }
}