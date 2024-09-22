
namespace TextAdventure
{
    public class Key : Item
    {

        private readonly Map _map;

        public Key (Map map)
        {
            _map = map;

            Takeable = true;
            Reusable = false;
        }

        public override string Name => Text.StringResources.Key;

        public override void Use (string user)
        {
            if (_map.CurrentCell != null)
                _map.CurrentCell.UseItem(Text.StringResources.Chest, Name);
            else
                throw new NullReferenceException();
        }

    }
}