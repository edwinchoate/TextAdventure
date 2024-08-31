
namespace TextAdventure
{
    public static class TextUtils
    {
        public static string AOrAn(string nextWord)
        {
            return "aeiouAEIOU".IndexOf(nextWord[0]) == -1 ? "a" : "an";
        }

    }

}
