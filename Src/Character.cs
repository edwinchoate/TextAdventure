
namespace TextAdventure
{

    public abstract class Character
    {
        private string _name;
        
        public Character (string name)
        {
            Name = name;
        }

        public string Name
        {
            get => Text.Capitalize(_name);
            set => _name = value;
        }

    }
}
