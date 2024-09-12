
namespace TextAdventure
{
    public partial class Map
    {

        public Cell? CurrentCell { get; set; }


        public void GoToCell (int index)
        {
            if (CurrentCell != null)
                CurrentCell.Visited = true;

            CurrentCell = Cells[index];
        }

        public void GoToStartingCell ()
        {
            // TODO Figure out where on the map I want the player to start
        }

    }
}