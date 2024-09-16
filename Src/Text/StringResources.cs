
namespace TextAdventure
{
    public class StringResources
    {

        public string WhatsYourName { get; protected set; } = "";
        public string WhatsYourName2 { get; protected set; } = "";
        public string AffirmName { get; protected set; } = "";

        public string SayDirectionOptions { get; protected set; } = "";
        public string CommandNotFound { get; protected set; } = ""; // TODO Implement multiple CommandNotFound flavor texts, printed at random
        public string GoCommandName { get; protected set; } = "";
        public string GoCommandError { get; protected set; } = "";
        public string Quit { get; protected set; } = "";
        public string Farewell { get; protected set; } = "";
        public string PassageDescIntro { get; protected set; } = "";
        public string PassagesDescIntro { get; protected set; } = "";
        public string And { get; protected set; } = "";

        public string[]? CellShortDescriptions { get; protected set; }

    }
}