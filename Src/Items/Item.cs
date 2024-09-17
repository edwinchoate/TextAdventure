
namespace TextAdventure
{
    public abstract class Item
    {

        public virtual string Name { get; set; } = "";

        public bool Takeable { get; set; } = true;

        public bool Reusable { get; set; }

        public virtual void Use (string user)
        {
            throw new NotImplementedException();
        }

    }
}