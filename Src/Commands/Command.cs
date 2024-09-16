
namespace TextAdventure
{
    public abstract class Command
    {

        public virtual string Name => "";

        public virtual void Execute(string[] args)
        {
            throw new NotImplementedException();
        }

    }
}