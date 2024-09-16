
namespace TextAdventure
{
    public abstract class Item
    {

        public virtual string Name { get; set; } = "";

        public bool CanReuse { get; set; }

        public bool CanTake { get; set; } = true;

        public virtual void Use (string user)
        {
            throw new NotImplementedException();
        }

    }
}