

namespace TextAdventure
{
    public partial class Map
    {

        private int CellIndex (int col, int row)
        {
            return Math.Clamp(col, -1, Width) + Math.Clamp(row, -1, Height) * Width; 
        }

        public void GenerateCells ()
        {

            Cells = new Cell[Width*Height];
    
            string[]? shortDescriptions = Text.StringResources.CellShortDescriptions;

            if (shortDescriptions == null)
                throw new NullReferenceException();
            if (shortDescriptions.Length != Width * Height)
                throw new Exception("StringResources does not contain the right number of cell short descriptions");

            for (int i = 0; i < Cells.Length; i++)
            {
                int col = i % Width;
                int row = i / Width;
                Cell cell = new Cell();
                
                if (row > 0) // then there's something to the North
                {
                    cell.Neighbors[Directions.North] = CellIndex(col, row - 1);
                }
                if (row < Height - 1) // then there's something to the South
                {
                    cell.Neighbors[Directions.South] = CellIndex(col, row + 1);
                }
                if (col < Width - 1) // then there's something to the East
                {
                    cell.Neighbors[Directions.East] = CellIndex(col + 1, row);
                }
                if (col > 0) // then there's something to the West
                {
                    cell.Neighbors[Directions.West] = CellIndex(col - 1 , row);
                }

                cell.ShortDescription = shortDescriptions[i];

                Cells[i] = cell;
            }

        }

    }
}
