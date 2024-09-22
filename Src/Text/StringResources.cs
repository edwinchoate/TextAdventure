
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
        public string BagCommandName { get; protected set; } = "";
        public string BagSummary { get; protected set; } = "";
        public string TakeCommandName { get; protected set; } = "";
        public string TakeError { get; protected set; } = "";
        public string TookDesc { get; protected set; } = "";
        public string CantTake { get; protected set; } = "";
        public string UseCommandName { get; protected set; } = "";
        public string UseError { get; protected set; } = "";
        public string ItemUsed { get; protected set; } = "";
        public string Quit { get; protected set; } = "";
        public string Farewell { get; protected set; } = "";
        public string PassageDescIntro { get; protected set; } = "";
        public string PassagesDescIntro { get; protected set; } = "";
        public string And { get; protected set; } = "";
        public string Item { get; protected set; } = "";
        public string NoItemToUse { get; protected set; } = "";
        public string Chest { get; protected set; } = "";
        public string YouUnlockedChest { get; protected set; } = "";
        public string ChestIsEmpty { get; protected set; } = ""; 
        public string Key { get; protected set; } = "";
        public string Gold { get; protected set; } = "";
        public string Coin { get; protected set; } = "";
        public string YouSee { get; protected set; } = "";
        public string ItemAcquired { get; protected set; } = "";

        public string[]? CellShortDescriptions { get; protected set; }

    }
}