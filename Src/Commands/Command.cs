
namespace TextAdventure
{
    public abstract class Command
    {

        public virtual string Name { get => ""; }

        public virtual void Execute(string[] args)
        {
            throw new Exception(
                "Execute in the Command parent class was called. This method is supposed to be overridden."
            );
        }

    }
}