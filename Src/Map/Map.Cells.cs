

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

                Cells[i] = cell;
            }

        }

    }
}
