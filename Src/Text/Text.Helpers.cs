
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

        public static string CommaSeparatedList(string[] words, string conjunction)
        {
            string oxfordComma = words.Length > 2 ? "," : "";

            return String.Concat(
                String.Join(", ", words, 0, words.Length - 1),
                String.Format("{0} {1} ", oxfordComma, conjunction),
                words[words.Length - 1]
            );
        }

    }
}