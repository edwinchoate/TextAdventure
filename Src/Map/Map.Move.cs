
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
            CurrentCell = Cells[0]; // TODO Set starting cell based on the actual content I come up with
        }

    }
}