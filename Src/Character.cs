
namespace TextAdventure
{

    public abstract class Character
    {
        private string _name;

        public string Name 
        { 
            get => _name; 
            set => _name = value[0].ToString().ToUpper() + value.Substring(1); 
        }
        
        public Character (string name)
        {
            Name = name;
        }

    }
}
