
namespace TextAdventure
{
    public static class Text
    {

        private static StringResources? _stringResources;

        public static StringResources StringResources
        {
            get
            {
                if (_stringResources == null)
                    throw new Exception("StringResources was not loaded.");

                return _stringResources;
            }
        }

        public static void LoadStringResources (StringResources stringResources)
        {
            _stringResources = stringResources;
        }

        public static string Capitalize (string s)
        {
            return s[0].ToString().ToUpper() + s.Substring(1);
        }

        public static string AOrAn(string nextWord)
        {
            return "aeiouAEIOU".IndexOf(nextWord[0]) == -1 ? "a" : "an";
        }

        public static string CommaSeparatedList(string[] words)
        {
            return String.Concat(
                String.Join(", ", words, 0, words.Length - 1),
                $" {Text.StringResources.And} ",
                words[words.Length - 1]
            );
        }

    }

}
