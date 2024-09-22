
namespace TextAdventure
{
    public class Gold : Item
    {

        public Gold (int value)
        {
            Value = value;

            Takeable = true;
        }

        public override string Name
        {
            get
            {
                return String.Format(
                    Text.StringResources.Gold, Value.ToString(), Text.SingularOrPlural(Text.StringResources.Coin, Value)
                );
            }
        }

        public int Value { get; private set; }

    }
}