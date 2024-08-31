
namespace TextAdventure
{

    public abstract class Character
    {
        private string _name;

        public string Name 
        { 
            get => TextUtils.Capitalize(_name);
            set => _name = value; 
        }
        
        public Character (string name)
        {
            Name = name;
        }

    }
}
