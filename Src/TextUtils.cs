
namespace TextAdventure
{
    public static class TextUtils
    {

        public static string Capitalize (string s)
        {
            return s[0].ToString().ToUpper() + s.Substring(1);
        }

        public static string AOrAn(string nextWord)
        {
            return "aeiouAEIOU".IndexOf(nextWord[0]) == -1 ? "a" : "an";
        }

    }

}
