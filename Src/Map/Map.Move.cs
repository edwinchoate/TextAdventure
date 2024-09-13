
namespace TextAdventure
{
    public partial class Map
    {

        public Cell? CurrentCell { get; set; }


        public void GoToCell (int index)
        {
            if (Cells == null)
                throw new NullReferenceException();
            else
            {
                if (CurrentCell != null)
                    CurrentCell.Visited = true;

                CurrentCell = Cells[index];
            }
        }

        public void GoToStartingCell ()
        {
            if (Cells == null)
                throw new NullReferenceException();
            else 
                CurrentCell = Cells[0]; // TODO Set starting cell based on the actual content I come up with
        }

    }
}