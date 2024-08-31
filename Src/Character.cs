
namespace TextAdventure
{

    public abstract class Character
    {
        private string _name;

        public string Name 
        { 
            get => _name[0].ToString().ToUpper() + _name.Substring(1); 
            set => _name = value; 
        }
        
        public Character (string name)
        {
            Name = name;
        }

    }
}
