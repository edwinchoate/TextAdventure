
namespace TextAdventure
{
    public static partial class Text
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

    }
}
